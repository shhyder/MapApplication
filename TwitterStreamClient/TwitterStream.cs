using System;
using System.Text;
using System.IO;
using System.Net;
using System.Configuration;
using System.Threading;
using System.Diagnostics;
using System.Web;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Messaging;
using System.Security.Cryptography;


namespace TwitterStreamClient
{
    public class TwitterStream
    {
        public void Stream2Queue()
        {
            string username = ConfigurationManager.AppSettings["twitter_username"];
            string password = Common.Decrypt( ConfigurationManager.AppSettings["twitter_password_encrypted"]);
            //Twitter Streaming API
            StringBuilder stream_url = new StringBuilder();// ConfigurationManager.AppSettings["stream_url"];
            StringBuilder strResults = new StringBuilder();
            StringBuilder strMaxid= new StringBuilder();
            strResults.Append('"').Append("results").Append('"').Append(":[]");
            strMaxid.Append('"').Append("max_id").Append('"').Append(":");
            
            
            HttpWebRequest webRequest = null;
            HttpWebResponse webResponse = null;
            StreamReader responseStream = null;
            MessageQueue q = null;
            string useQueue = ConfigurationManager.AppSettings["use_queue"];

            int wait = 250;
            string jsonText = "";
            int page = 1;
            Logger logger = new Logger();
            bool is_first = true;

            int startIndex = 0;
            int endIndex = 0;
            string maxID = "";
            try
            {
                //Message Queue
                if (useQueue == "true")
                {
                    if (MessageQueue.Exists(@".\private$\Twitter"))
                    {
                        q = new MessageQueue(@".\private$\Twitter");
                    }
                    else
                    {
                        q = MessageQueue.Create(@".\private$\Twitter");
                    }
                }

                is_first = true;
                string keyword = "Beltane Fire Festival";
                while (true)
                {
                    stream_url = new StringBuilder();
                    stream_url = stream_url.Append( @"http://search.twitter.com/search.json?q=").Append('"').Append(keyword).Append('"').Append(" until:2012-03-31 since:2012-03-30&page=").Append( page.ToString() ).Append(maxID).Append("&rpp=5");
                    //stream_url = stream_url.Replace('\'','"');
                    try
                    {
                        //Connect
                        webRequest = (HttpWebRequest)WebRequest.Create(stream_url.ToString());
                        webRequest.Credentials = new NetworkCredential(username, password);
                        webRequest.Timeout = -1;
                        webResponse = (HttpWebResponse)webRequest.GetResponse();
                        Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                        responseStream = new StreamReader(webResponse.GetResponseStream(), encode);

    //                    webResponse.

    //                    MyObject deserializedObject = (MyObject)JavaScriptConvert.DeserializeObject(
    //strJson, typeof(MyObject));
                        is_first = true;
                        //Read the stream.




                        jsonText = responseStream.ReadLine();


                        if (jsonText != null)
                        {
                            if (jsonText.Contains(strResults.ToString()))
                            {
                                break;
                            }

                            if (jsonText.Contains(strResults.ToString()))
                            {
                                break;
                            }
                            startIndex = jsonText.IndexOf(strMaxid.ToString()) + 9;
                            endIndex = jsonText.IndexOf(',', startIndex);
                            maxID = "&max_id =" + jsonText.Substring(startIndex, endIndex - startIndex);
                        }

                        if (jsonText == null && is_first)
                        {
                            break;
                        }
                        else
                            is_first = false;
                        



                        
                        //while (true)
                        //{
                        //    jsonText = responseStream.ReadLine();
                        //    //Post each message to the queue.
                        //    if (useQueue == "true")
                        //    {
                        //        Message message = new Message(jsonText);
                        //        q.Send(message);
                        //    }

                        //    if (jsonText != null)
                        //    {
                        //        if (jsonText.Contains(strResults.ToString()))
                        //        {
                        //            break;
                        //        }
                        //        startIndex = jsonText.IndexOf(strMaxid.ToString()) + 9;
                        //        endIndex = jsonText.IndexOf(',', startIndex);
                        //        maxID = "&max_id =" + jsonText.Substring(startIndex, endIndex - startIndex);
                        //    }

                            

                        //    if (jsonText == null && is_first)
                        //    {
                        //        break;
                        //    }
                        //    else
                        //        is_first = false;


                        //    if (jsonText == null && !is_first)
                        //    {
                        //        jsonText = "";
                        //        break;
                        //    }

                        //    //Success
                        //    wait = 250;

                        //    //Write Status
                        //    //Console.Write(jsonText);
                        //    //Console.Write(jsonText);


                        //}

                        if (jsonText.Contains(strResults.ToString()))
                        {
                            break;
                        }

                        Console.Write(page.ToString() + " =   " + ( page * 100 ));
                        page++;
                        //Abort is needed or responseStream.Close() will hang.
                        webRequest.Abort();
                        responseStream.Close();
                        responseStream = null;
                        webResponse.Close();
                        webResponse = null;

                    }
                    catch (WebException ex)
                    {
                        Console.WriteLine(ex.Message);
                        logger.append(ex.Message, Logger.LogLevel.ERROR);
                        if (ex.Status == WebExceptionStatus.ProtocolError)
                        {
                            //-- From Twitter Docs -- 
                            //When a HTTP error (> 200) is returned, back off exponentially. 
                            //Perhaps start with a 10 second wait, double on each subsequent failure, 
                            //and finally cap the wait at 240 seconds. 
                            //Exponential Backoff
                            if (wait < 10000)
                            {
                                wait = 10000;
                            }
                            else
                            {
                                if (wait < 240000)
                                {
                                    wait = wait * 2;
                                }
                            }
                        }
                        else
                        {
                            //-- From Twitter Docs -- 
                            //When a network error (TCP/IP level) is encountered, back off linearly. 
                            //Perhaps start at 250 milliseconds and cap at 16 seconds.
                            //Linear Backoff
                            if (wait < 16000)
                            {
                                wait += 250;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        logger.append(ex.Message, Logger.LogLevel.ERROR);
                    }
                    finally
                    {
                        if (webRequest != null)
                        {
                            webRequest.Abort();
                        }
                        if (responseStream != null)
                        {
                            responseStream.Close();
                            responseStream = null;
                        }

                        if (webResponse != null)
                        {
                            webResponse.Close();
                            webResponse = null;
                        }
                        Console.WriteLine("Waiting: " + wait);
                        //Thread.Sleep(wait);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                logger.append(ex.Message, Logger.LogLevel.ERROR);
                Console.WriteLine("Waiting: " + wait);
                Thread.Sleep(wait);
            }

            Console.WriteLine(page.ToString());

        }



       
        
        public void QueueRead()
        {
            MessageQueue q;
            string multiThread = ConfigurationManager.AppSettings["multithread"];
            Logger logger = new Logger();

            try
            {
                if (MessageQueue.Exists(@".\private$\Twitter"))
                {
                    q = new MessageQueue(@".\private$\Twitter");
                }
                else
                {
                    Console.WriteLine("Queue does not exists.");
                    return;
                }

                while (true)
                {
                    Message message;
                    try
                    {
                        message = q.Receive();
                        message.Formatter =
                            new XmlMessageFormatter(new String[] { "System.String" });
                        if (multiThread == "true")
                        {
                            ThreadPool.QueueUserWorkItem(MessageProcess, message);
                        }
                        else
                        {
                            MessageProcess(message);
                        }
                    }
                    catch { continue; }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                logger.append(ex.Message, Logger.LogLevel.ERROR);
            }
        }
        
        
        public void MessageProcess(object objMessage)
        {
            status status = new status();
            Logger logger = new Logger();
            DataContractJsonSerializer json = new DataContractJsonSerializer(status.GetType());

            try
            {
                Message message = objMessage as Message;

                byte[] byteArray = Encoding.UTF8.GetBytes(message.Body.ToString());
                MemoryStream stream = new MemoryStream(byteArray);
                
                //TODO:  Check for multiple objects.
                status = json.ReadObject(stream) as status;

                Console.WriteLine(message.Body.ToString());

                //TODO: Store the status object
                DataStore.Add(status);




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                logger.append(ex.Message, Logger.LogLevel.ERROR);
            }
        }
    }
}
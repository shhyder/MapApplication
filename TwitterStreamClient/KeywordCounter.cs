using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Web;
using System.IO;
using System.Net;

namespace TwitterStreamClient
{
    public class KeywordCounter
    {
        public int GetSearchCount(string keyword, DateTime date)
        {
            string username = ConfigurationManager.AppSettings["twitter_username"];
            string password = Common.Decrypt(ConfigurationManager.AppSettings["twitter_password_encrypted"]);
            //Twitter Streaming API
            StringBuilder stream_url = new StringBuilder();// ConfigurationManager.AppSettings["stream_url"];
            StringBuilder strResults = new StringBuilder();
            StringBuilder strMaxid = new StringBuilder();
            strResults.Append('"').Append("results").Append('"').Append(":[]");
            strMaxid.Append('"').Append("max_id").Append('"').Append(":");


            HttpWebRequest webRequest = null;
            HttpWebResponse webResponse = null;
            StreamReader responseStream = null;
            string useQueue = ConfigurationManager.AppSettings["use_queue"];

            int wait = 250;
            string jsonText = "";
            int page = 1;
            Logger logger = new Logger();
            bool is_first = true;

            int startIndex = 0;
            int endIndex = 0;
            string maxID = "";


            string dateRange = "until:" + date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString() + " since:" + date.AddDays(-1).Year.ToString() + "-" + date.AddDays(-1).Month.ToString() + "-" + date.AddDays(-1).Day.ToString(); 
          
            try
            {
                

                is_first = true;
                while (true)
                {
                    stream_url = new StringBuilder();
                    stream_url = stream_url.Append(@"http://search.twitter.com/search.json?q=").Append('"').Append(keyword).Append('"').Append( dateRange ).Append("&page=").Append(page.ToString()).Append(maxID).Append("&rpp=50");
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





                        if (jsonText.Contains(strResults.ToString()))
                        {
                            break;
                        }

                        //Console.Write(page.ToString() + " =   " + (page * 100));
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
                        //Console.WriteLine(ex.Message);
                        //logger.append(ex.Message, Logger.LogLevel.ERROR);
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
                        //Console.WriteLine(ex.Message);
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
                        //Console.WriteLine("Waiting: " + wait);
                        //Thread.Sleep(wait);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.append(ex.Message, Logger.LogLevel.ERROR);
                //Console.WriteLine("Waiting: " + wait);
                //Thread.Sleep(wait);
            }

            //Console.WriteLine(page.ToString());
            return page * 50;
        }

    }
}

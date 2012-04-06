using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using System.Data;
using System.Text;

namespace Web.Controllers
{
   
    public class MarkerController : _BaseController
    {
     
        public ActionResult Index()
        {
            Init(WebConfigurationManager.AppSettings["PageSize"].ToString());
            LoadList(1, null);
            return View("Index");
        }


        #region list section
        public JsonResult GetList(int? id, FormCollection collection)
        {
            //FormCollection  collection = new FormCollection(ConvertRawUrlToQuerystring());

            Widget obj = new Widget();

            ViewDataDictionary vdd = LoadList(id, collection);
            obj.StoreList = RenderViewToStringAsHTML(this, "Grid", vdd);
            obj.Navigator = ViewData["pageLinks"].ToString();
            obj.SearchCritaria = ViewData["SearchCritaria"].ToString();
      

            int id2 = 1;
            string icon = Url.Content("~/icon/state.png");
       
            int sr_No = Convert.ToInt32(ViewData["start"]);

            string title = "";

            if (vdd[UIMarker.listMarker.ToString()] != null)
            {
                obj.Markers = new Marker[(vdd[UIMarker.listMarker.ToString()] as List<DataRow>).Count ];
                foreach (var dealer in (vdd[UIMarker.listMarker.ToString()] as List<DataRow>))
                {
                    icon = Url.Content("~/MarkerIcon.ashx?label=" + sr_No.ToString()); // 
                    {

                        obj.Markers[id2 - 1] = new Marker(id2, Convert.ToDecimal(dealer["Latitude"]),
                            Convert.ToDecimal(dealer["Longitude"]), "title", icon, "", 1,
                            "");
                        id2++;
                    }
                    
                    sr_No++;
                }
            }
         

            icon = Url.Content("~/icon/home.png");
        
             obj.totalMarker = Convert.ToInt32(ViewData["Count"]);


            return Json(obj, JsonRequestBehavior.AllowGet);
        }



        [NonAction]
        private ViewDataDictionary LoadList(int? id, FormCollection collection)
        {
            int _totalCount = 0;

            DataSet.DSParameter ds = (DataSet.DSParameter)System.Web.HttpContext.Current.Cache["data"];




            //_totalCount = ds.Tables[BusinessLogic.Base.Tables.ItemLineDetail.ToString()].Rows.Count;


            int pageSize = Convert.ToInt32(WebConfigurationManager.AppSettings["PageSize"].ToString());

            string filter = "1=1 ";
            string searchCritaria = "";
            StringBuilder orderBy = new StringBuilder();
            int orderByCount = 0;
            if (collection != null)
            {

                if (collection[UIMarker.srhMarker.ToString()].Split(',')[1].Trim().Length != 0)
                {
                    filter += " and Marker_Tag like '" + collection[UIMarker.srhMarker.ToString()].Split(',')[1].ToString().Replace("'", "") + "*'";
                    searchCritaria += " Marker : " + collection[UIMarker.srhMarker.ToString()].Split(',')[1].ToString().Replace("'", "") + "* ,";
                }

                if (collection[UIMarker.srhAddress.ToString()].Split(',')[1].Trim().Length != 0)
                {
                    filter += " and Address like '" + collection[UIMarker.srhAddress.ToString()].Split(',')[0].ToString().Replace("'", "") + "*'";
                    searchCritaria += " Store : " + collection[UIMarker.srhAddress.ToString()].Split(',')[1].ToString().Replace("'", "") + "* ,";
             
                }

                if (collection[UIMarker.srhCity.ToString()].Split(',')[1].Trim().Length != 0)
                {
                    filter += " and City like '" + collection[UIMarker.srhCity.ToString()].Split(',')[1].ToString().Replace("'", "") + "*'";
                    searchCritaria += " City : " + collection[UIMarker.srhCity.ToString()].Split(',')[1].ToString().Replace("'", "") + "* ,";
                }

                if (collection[UIMarker.srhState.ToString()].Split(',')[1].Trim().Length != 0)
                {
                    filter += " and State like '" + collection[UIMarker.srhState.ToString()].Split(',')[1].ToString() + "*'";
                    searchCritaria += " State : " + collection[UIMarker.srhState.ToString()].Split(',')[1].ToString().Replace("'", "") + "* ,";
                }

                if (collection[UIMarker.srhCountry.ToString()].Split(',')[1].Trim().Length != 0)
                {
                    filter += " and Country like '" + collection[UIMarker.srhCountry.ToString()].Split(',')[1].ToString() + "*'";
                    searchCritaria += " Country : " + collection[UIMarker.srhCountry.ToString()].Split(',')[1].ToString().Replace("'", "") + "* ,";
                }

                

               

                if (collection[UIMarker.ordMarker.ToString()].Split(',')[1].ToString() != "0")
                {
                    orderBy.Append(", Marker_Tag ").Append(collection[UIMarker.ordMarker.ToString()].Split(',')[1].ToString() == "1" ? " ASC " : " DESC ");
                    orderByCount++;
                }

                if (collection[UIMarker.ordAddress.ToString()].Split(',')[1].ToString() != "0")
                {
                    orderBy.Append(", Address ").Append(collection[UIMarker.ordAddress.ToString()].Split(',')[1].ToString() == "1" ? " ASC " : " DESC ");
                    orderByCount++;
                }

                if (collection[UIMarker.ordCity.ToString()].Split(',')[1].ToString() != "0")
                {
                    orderBy.Append(", City ").Append(collection[UIMarker.ordCity.ToString()].Split(',')[1].ToString() == "1" ? " ASC " : " DESC ");
                    orderByCount++;
                }

                if (collection[UIMarker.ordState.ToString()].Split(',')[1].ToString() != "0")
                {
                    orderBy.Append(", State ").Append(collection[UIMarker.ordState.ToString()].Split(',')[1].ToString() == "1" ? " ASC " : " DESC ");
                    orderByCount++;
                }

                if (collection[UIMarker.ordCountry.ToString()].Split(',')[1].ToString() != "0")
                {
                    orderBy.Append(", Country ").Append(collection[UIMarker.ordCountry.ToString()].Split(',')[1].ToString() == "1" ? " ASC " : " DESC ");
                    orderByCount++;
                }

            

                

                if (collection[UIAll.gridSize.ToString()].Trim().Length != 0)
                {
                    pageSize = Convert.ToInt32(collection[UIAll.gridSize.ToString()].Split(',')[1].ToString());
                }

                if( searchCritaria.Length != 0 )
                    searchCritaria = searchCritaria.Remove(searchCritaria.Length - 1);
            }

            if( orderByCount > 0 )
                orderBy = orderBy.Remove(0, 1);

            
            DataRow[] rows = ds.Marker.Select(filter, orderBy.ToString());



            _totalCount = rows.Length;

            int pageCalled = 0;
            if (id == null)
                pageCalled = 1;
            else
                pageCalled = (int)id;


            try
            {

                //---------------------------------------------- 
                //Fill Custom Data 
                //string temp = "";

                int totalItems = _totalCount;

                Web.Model.Pagination pagination = new Web.Model.Pagination(true);
                pagination.BaseUrl = Url.Content("~/Marker/GetList/");
                pagination.TrailingQueryString = "";

                pagination.TrailingQueryString = "";
                pagination.Is_UserClickFunction = true;
                pagination.ClickFunctionName = "javascript:GetList";

                Session["QSCurDL"] = "";
                ViewData["queryString"] = "";
                ViewData["product_IDs"] = "";

                pagination.TotalRows = totalItems;
                pagination.CurPage = pageCalled;
                pagination.PerPage = pageSize;

                pagination.PrevLink = "Prev";
                pagination.NextLink = "Next";
                pagination.UpdateTargetId = "dealerList";
                pagination._class = " class='navButton'";

                string pageLinks = pagination.GetPageLinks();
                int start = (pageCalled - 1) * pagination.PerPage;
                int offset = pagination.PerPage;
                ViewData["pageLinks"] = pageLinks;

                ViewData["Count"] = totalItems;

                ViewData["start"] = (start + 1).ToString();

                IQueryable<DataRow> dt = rows.Cast<DataRow>().AsQueryable();
                ViewData[ UIMarker.listMarker.ToString()] = dt.Skip(start).Take(offset).ToList();
                searchCritaria = (start + 1).ToString() + " - " + (start + dt.Skip(start).Take(offset).ToList().Count).ToString() + " from " + totalItems.ToString() + "  :   " + searchCritaria;
                ViewData["SearchCritaria"] = searchCritaria;

            }
            catch 
            {

            }
            


            return ViewData;

        }


        [NonAction]
        void Init(string selectedGridSize)
        {



            initGridSize(selectedGridSize);



        }




        public ActionResult About()
        {
            return View();
        }


        public class Widget
        {
            public string StoreList { get; set; }
            public string Navigator { get; set; }
            public string SearchCritaria { get; set; }
            public int totalMarker { get; set; }
            public Marker[] Markers { get; set; }
        }

        #endregion

        #region CRUD

         public ActionResult New()
        {


            ViewData[ UIMarker.hidID.ToString()] = "0";
            ViewData[UIMarker.hidLatitude.ToString()] = "";
            ViewData[UIMarker.hidLongitude.ToString()] = "";
            ViewData[UIMarker.txtMarker.ToString()] = "";
            ViewData[UIMarker.txtAddress.ToString()] = "";
            ViewData[UIMarker.txtCity.ToString()] = "";
            ViewData[UIMarker.txtState.ToString()] = "";
            ViewData[UIMarker.txtCountry.ToString()] = "";
            ViewData[UIMarker.hidState.ToString()] = 3;

            
            return View("Marker");
        }






        public JsonResult Save()
        {


            StoreManifest stm = new StoreManifest();

             
            if (!Validate(ref stm))
            {
                BusinessLogic.Marker.Marker sp = new BusinessLogic.Marker.Marker();
                DataSet.DSParameter ds = new DataSet.DSParameter();

                ds.Marker.Marker_IDColumn.ReadOnly = false;


                ds.Marker.AddMarkerRow(stm.Marker, stm.Address, stm.City, stm.State, stm.Country,Convert.ToDecimal( stm.Latitude ), Convert.ToDecimal(stm.Longitude), stm.Is_Recurring_Event, 0,
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                   
                ds.EnforceConstraints = false;
                ds.Marker[0]["Marker_ID"] = Convert.ToInt32(stm.ID);

                if (stm.hidState == 3)
                {
                    sp.New(ds);
                }
                else
                {
                    sp.Update(ds);
                }
                UpdateCache();
            }


            return this.Json(stm, JsonRequestBehavior.AllowGet);
        }


        public JsonResult Delete(string codeSLSP, string SalesRepCode, string Territory)
        {


            StoreManifest spm = new StoreManifest();



            //BusinessLogic.SalesPerson.SalesPerson sp = new BusinessLogic.SalesPerson.SalesPerson();
            //DataSet.DSParameter ds = new DataSet.DSParameter();
            //ds.ARSAP.AddARSAPRow(codeSLSP, "", SalesRepCode, Territory, "");
            //if (sp.Delete(ds))
            //{
            //    spm.Has_Error = false;
            //    MvcApplication.RefreshData("", null, System.Web.Caching.CacheItemRemovedReason.DependencyChanged);
            //}
            //else
            //{
            //    spm.Has_Error = true;

            //}

            return this.Json(spm, JsonRequestBehavior.AllowGet);
        }



        public ActionResult Edit(string id)
        {
            DataSet.DSParameter ds = (DataSet.DSParameter)System.Web.HttpContext.Current.Cache["data"];
            string filter = " Marker_id = " + id.ToString();
            DataRow[] rows = ds.Marker.Select(filter);

            if (rows.Length == 1)
            {
                DataSet.DSParameter.MarkerRow dispRow = (DataSet.DSParameter.MarkerRow)rows[0];
                ViewData[UIMarker.hidID.ToString()] = dispRow.Marker_ID;
                ViewData[UIMarker.hidLatitude.ToString()] = dispRow.IsLatitudeNull()?0: dispRow.Latitude;
                ViewData[UIMarker.hidLongitude.ToString()] = dispRow.IsLongitudeNull()?0: dispRow.Longitude;
                ViewData[UIMarker.txtMarker.ToString()] = dispRow.Marker_Tag;
                
                ViewData[UIMarker.txtAddress.ToString()] = dispRow.Address;
                ViewData[UIMarker.txtCity.ToString()] = dispRow.City;
                ViewData[UIMarker.txtState.ToString()] = dispRow.State;
                ViewData[UIMarker.txtCountry.ToString()] = dispRow.IsCountryNull()?"": dispRow.Country;
                
                ViewData[UIMarker.hidState.ToString()] = 3;

                
       
            }
            else
            {
                ViewData[UIMarker.hidID.ToString()] = "";
                ViewData[UIMarker.hidLatitude.ToString()] = "";
                ViewData[UIMarker.hidLongitude.ToString()] = "";
                ViewData[UIMarker.txtMarker.ToString()] = "";
                ViewData[UIMarker.txtAddress.ToString()] = "";
                ViewData[UIMarker.txtCity.ToString()] = "";
                ViewData[UIMarker.txtState.ToString()] = "";
                ViewData[UIMarker.txtCountry.ToString()] = "";
                ViewData[UIMarker.hidState.ToString()] = 3;

            }

            ViewData[UIMarker.hidState.ToString()] = 2;

            return View("Marker");

        }







        [NonAction]
        bool Validate(ref StoreManifest stm)
        {
            FormCollection collection = new FormCollection(ConvertRawUrlToQuerystring());

            stm.Marker = collection[UIMarker.txtMarker.ToString()].ToString();
            stm.Address = collection[UIMarker.txtAddress.ToString()].ToString();
            stm.City= collection[UIMarker.txtCity.ToString()].ToString();
            stm.City = collection[UIMarker.txtCity.ToString()].ToString();
            stm.State= collection[UIMarker.txtState.ToString()].ToString();
            stm.Country = collection[UIMarker.txtCountry.ToString()].ToString();
            stm.hidState = Convert.ToInt32(collection[UIMarker.hidState.ToString()]);
            stm.ID = Convert.ToInt32( collection[UIMarker.hidID.ToString()].ToString() ) ;
            stm.Latitude = collection[UIMarker.hidLatitude.ToString()].ToString(); ;
            stm.Longitude = collection[UIMarker.hidLongitude.ToString()].ToString(); ;



            if (collection[UIMarker.is_Recurring_Event.ToString()] == null)
            {
                stm.Is_Recurring_Event = false;
            }
            else
            {
                stm.Is_Recurring_Event = true;
            }



            if (stm.Marker.Length <= 2)
            {
                stm.MarkerError = "Enter Valid Marker name";
                stm.Has_Error = true;
            }



            if (stm.Address.Length <= 2)
            {
                stm.AddressError = "Enter Valid Address";
                stm.Has_Error = true;
            }


           

            if (stm.City.Length <= 3)
            {
                stm.CityError = "Enter City";
                stm.Has_Error = true;
            }


            if (stm.State.Length <= 2)
            {
                stm.StateError = "Enter state";
                stm.Has_Error = true;
            }

            if (stm.Country.Length <= 0)
            {
                stm.CountryError = "Enter sales country";
                stm.Has_Error = true;
            }

            

            if (stm.Latitude.Length == 0 || stm.Longitude.Length == 0)
            {
                stm.AddressError = "Enter valid address";
                stm.Has_Error = true;
            }


            return stm.Has_Error;
        }




        #endregion


        public class StoreManifest
        {
            public int ID { get; set; }
            public string Marker { get; set; }
            public string Address{ get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public string Latitude { get; set; }
            public string Longitude { get; set; }

            public int hidState { get; set; }
            public string MarkerError { get; set; }
            public string StoreError { get; set; }
            public string AddressError { get; set; }
            public string CityError { get; set; }
            public string StateError { get; set; }
            public string CountryError { get; set; }
            public bool Is_Recurring_Event { get; set; }
          
            public bool Has_Error { get; set; }
        }

    }

}

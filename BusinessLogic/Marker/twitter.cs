using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Security;
using Google.Api.Ads.AdWords.Lib;
using Google.Api.Ads.AdWords.v201109;

namespace BusinessLogic.Marker
{
    internal class twitter
    {
         int _marker_ID;

         public twitter(int marker_ID)
        {
            _marker_ID = marker_ID;
        }


        public void GetCount(ref DataSet.DSParameter ds)
        {

            DateTime cur_dt = DateTime.Now;
            DateTime dt = new DateTime();

            TwitterStreamClient.KeywordCounter twi = new TwitterStreamClient.KeywordCounter();
            
            // current date data
            dt = cur_dt;
            ds.Keyword.AddKeywordRow(dt.Day, dt.Month, dt.Year, 2, _marker_ID, 1, 1, dt,
                twi.GetSearchCount(ds.Marker[0].Marker_Tag, cur_dt), 0);
         

            // 1 day before
            dt = cur_dt.AddDays(-1);
            ds.Keyword.AddKeywordRow(dt.Day, dt.Month, dt.Year, 2, _marker_ID, 1, 1, dt,
            twi.GetSearchCount(ds.Marker[0].Marker_Tag, dt), 0);
         

            // 2 day before
            dt = cur_dt.AddDays(-2);
            ds.Keyword.AddKeywordRow(dt.Day, dt.Month, dt.Year, 2, _marker_ID, 1, 1, dt,
            twi.GetSearchCount(ds.Marker[0].Marker_Tag, dt), 0);

            // 3 day before
            dt = cur_dt.AddDays(-3);
            ds.Keyword.AddKeywordRow(dt.Day, dt.Month, dt.Year, 2, _marker_ID, 1, 1, dt,
            twi.GetSearchCount(ds.Marker[0].Marker_Tag, dt), 0);

            // 4 day before
            dt = cur_dt.AddDays(-4);
            ds.Keyword.AddKeywordRow(dt.Day, dt.Month, dt.Year, 2, _marker_ID, 1, 1, dt,
            twi.GetSearchCount(ds.Marker[0].Marker_Tag, dt), 0);

            // 5 day before
            dt = cur_dt.AddDays(-5);
            ds.Keyword.AddKeywordRow(dt.Day, dt.Month, dt.Year, 2, _marker_ID, 1, 1, dt,
            twi.GetSearchCount(ds.Marker[0].Marker_Tag, dt), 0);

            
        }
    }
}

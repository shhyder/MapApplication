using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataSet;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace BusinessLogic.Parameter
{
    public class Parameter
    {
        DataAccessLayer.BaseParameter _base;
        Database _db;

        public DSParameter GetParamerter()
        {
            //DataSet ds = new DataSet();

            DSParameter ds = new DSParameter();
            _base = new DataAccessLayer.Marker.Marker();
            _base.SetConnection();
            _db = _base.GetDatabase();

            ds.EnforceConstraints = false;
            ds.Load(_base.GetAllItem(), LoadOption.OverwriteChanges, ds.Marker);


          


            

            _base.Dispose();
            
            return ds;
        }


    }
}

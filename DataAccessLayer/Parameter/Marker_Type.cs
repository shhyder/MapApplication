using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataSet;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data;
namespace DataAccessLayer.Parameter
{

    //----------------------------------------------------------------
    /// Class: Marker_Type
    //----------------------------------------------------------------
    public class Marker_Type : BaseParameter
    {

        System.String _marker_type_ID;

        public Marker_Type(Database db, DbTransaction dbTrans)
        {
            _db = db;
            _transaction = dbTrans;
        }
        public Marker_Type(Database db)
        {
            _db = db;
        }
        public Marker_Type()
        {

        }
        public Marker_Type(System.String marker_type_ID)
        {
            _marker_type_ID = marker_type_ID;
        }

        //----------------------------------------------------------------
        /// Get specific records: Marker_Type
        //----------------------------------------------------------------
        public override IDataReader GetItem()
        {

            _dbCommand = _db.GetStoredProcCommand("GetMarker_Type");
            _db.AddInParameter(_dbCommand, _DSParam.Marker_Type.Marker_TypeColumn.ToString(), DbType.String, _marker_type_ID);
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Get records List: Marker_Type
        //----------------------------------------------------------------

        public override IDataReader GetAllItem()
        {

            _dbCommand = _db.GetStoredProcCommand("GetAllMarker_Type");
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Delete: Marker_Type
        //----------------------------------------------------------------
        public override IDataReader Delete()
        {

            _dbCommand = _db.GetStoredProcCommand("GetMarker_Type");
            _db.AddInParameter(_dbCommand, _DSParam.Marker_Type.Marker_TypeColumn.ToString(), DbType.String, _marker_type_ID);
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Insert record: Marker_Type
        //----------------------------------------------------------------
        public override IDataReader Insert(DSParameter ds)
        {
            _dbCommand = _db.GetStoredProcCommand("InsertMarker_Type");
            _db.AddInParameter(_dbCommand, ds.Marker_Type.Marker_TypeColumn.ToString(), DbType.String, ds.Marker_Type.Rows[0][ds.Marker_Type.Marker_TypeColumn.ToString()]);
            IDataReader dr = _db.ExecuteReader(_dbCommand, _transaction);
            dr.Close();
            return dr;
        }



        //----------------------------------------------------------------
        /// Update: Marker_Type
        //----------------------------------------------------------------
        public override IDataReader Update( DSParameter ds)
        {
            _dbCommand = _db.GetStoredProcCommand("UpdateMarker_Type");
            _db.AddInParameter(_dbCommand, ds.Marker_Type.Marker_TypeColumn.ToString(), DbType.String, ds.Marker_Type.Rows[0][ds.Marker_Type.Marker_TypeColumn.ToString()]);
            IDataReader dr = _db.ExecuteReader(_dbCommand, _transaction);
            dr.Close();
            return dr;
        }


    }


}

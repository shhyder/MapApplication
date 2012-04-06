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
    /// Class: Trend
    //----------------------------------------------------------------
    public class Trend : BaseParameter
    {

        System.Int32 _trend_ID;

        public Trend(Database db, DbTransaction dbTrans)
        {
            _db = db;
            _transaction = dbTrans;
        }
        public Trend(Database db)
        {
            _db = db;
        }
        public Trend()
        {

        }
        public Trend(System.Int32 trend_ID)
        {
            _trend_ID = trend_ID;
        }

        //----------------------------------------------------------------
        /// Get specific records: Trend
        //----------------------------------------------------------------
        public override IDataReader GetItem()
        {

            _dbCommand = _db.GetStoredProcCommand("GetTrend");
            _db.AddInParameter(_dbCommand, _DSParam.Trend.Trend_IDColumn.ToString(), DbType.Int32, _trend_ID);
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Get records List: Trend
        //----------------------------------------------------------------

        public override IDataReader GetAllItem()
        {

            _dbCommand = _db.GetStoredProcCommand("GetAllTrend");
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Delete: Trend
        //----------------------------------------------------------------
        public override IDataReader Delete()
        {

            _dbCommand = _db.GetStoredProcCommand("GetTrend");
            _db.AddInParameter(_dbCommand, _DSParam.Trend.Trend_IDColumn.ToString(), DbType.Int32, _trend_ID);
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Insert record: Trend
        //----------------------------------------------------------------
        public override IDataReader Insert(DSParameter ds)
        {
            _dbCommand = _db.GetStoredProcCommand("InsertTrend");
            _db.AddOutParameter(_dbCommand, ds.Trend.Trend_IDColumn.ToString(), DbType.Int32, 20);
            _db.AddInParameter(_dbCommand, ds.Trend.TrendColumn.ToString(), DbType.String, ds.Trend.Rows[0][ds.Trend.TrendColumn.ToString()]);
            IDataReader dr = _db.ExecuteReader(_dbCommand, _transaction);
            dr.Close();
            _ID = System.Int32.Parse(_db.GetParameterValue(_dbCommand, "@Trend_ID").ToString());
            return dr;
        }



        //----------------------------------------------------------------
        /// Update: Trend
        //----------------------------------------------------------------
        public override IDataReader Update(DSParameter ds)
        {
            _dbCommand = _db.GetStoredProcCommand("UpdateTrend");
            _db.AddInParameter(_dbCommand, ds.Trend.Trend_IDColumn.ToString(), DbType.Int32, ds.Trend.Rows[0][ds.Trend.Trend_IDColumn.ToString()]);
            _db.AddInParameter(_dbCommand, ds.Trend.TrendColumn.ToString(), DbType.String, ds.Trend.Rows[0][ds.Trend.TrendColumn.ToString()]);
            IDataReader dr = _db.ExecuteReader(_dbCommand, _transaction);
            dr.Close();
            return dr;
        }


    }




}

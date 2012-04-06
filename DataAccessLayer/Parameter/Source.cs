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
    /// Class: Source
    //----------------------------------------------------------------
    public class Source : BaseParameter
    {

        System.Int32 _source_ID;

        public Source(Database db, DbTransaction dbTrans)
        {
            _db = db;
            _transaction = dbTrans;
        }
        public Source(Database db)
        {
            _db = db;
        }
        public Source()
        {

        }
        public Source(System.Int32 source_ID)
        {
            _source_ID = source_ID;
        }

        //----------------------------------------------------------------
        /// Get specific records: Source
        //----------------------------------------------------------------
        public override IDataReader GetItem()
        {

            _dbCommand = _db.GetStoredProcCommand("GetSource");
            _db.AddInParameter(_dbCommand, _DSParam.Source.Source_IDColumn.ToString(), DbType.Int32, _source_ID);
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Get records List: Source
        //----------------------------------------------------------------

        public override IDataReader GetAllItem()
        {

            _dbCommand = _db.GetStoredProcCommand("GetAllSource");
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Delete: Source
        //----------------------------------------------------------------
        public override IDataReader Delete()
        {

            _dbCommand = _db.GetStoredProcCommand("GetSource");
            _db.AddInParameter(_dbCommand, _DSParam.Source.Source_IDColumn.ToString(), DbType.Int32, _source_ID);
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Insert record: Source
        //----------------------------------------------------------------
        public override IDataReader Insert( DSParameter ds)
        {
            _dbCommand = _db.GetStoredProcCommand("InsertSource");
            _db.AddOutParameter(_dbCommand, ds.Source.Source_IDColumn.ToString(), DbType.Int32, 20);
            _db.AddInParameter(_dbCommand, ds.Source.SourceColumn.ToString(), DbType.String, ds.Source.Rows[0][ds.Source.SourceColumn.ToString()]);
            IDataReader dr = _db.ExecuteReader(_dbCommand, _transaction);
            dr.Close();
            _ID = System.Int32.Parse(_db.GetParameterValue(_dbCommand, "@Source_ID").ToString());
            return dr;
        }



        //----------------------------------------------------------------
        /// Update: Source
        //----------------------------------------------------------------
        public override IDataReader Update( DSParameter ds)
        {
            _dbCommand = _db.GetStoredProcCommand("UpdateSource");
            _db.AddInParameter(_dbCommand, ds.Source.Source_IDColumn.ToString(), DbType.Int32, ds.Source.Rows[0][ds.Source.Source_IDColumn.ToString()]);
            _db.AddInParameter(_dbCommand, ds.Source.SourceColumn.ToString(), DbType.String, ds.Source.Rows[0][ds.Source.SourceColumn.ToString()]);
            IDataReader dr = _db.ExecuteReader(_dbCommand, _transaction);
            dr.Close();
            return dr;
        }


    }

}

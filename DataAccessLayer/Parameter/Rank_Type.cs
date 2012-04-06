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
    /// Class: Rank_Type
    //----------------------------------------------------------------
    public class Rank_Type : BaseParameter
    {

        System.Int32 _rank_type_ID;

        public Rank_Type(Database db, DbTransaction dbTrans)
        {
            _db = db;
            _transaction = dbTrans;
        }
        public Rank_Type(Database db)
        {
            _db = db;
        }
        public Rank_Type()
        {

        }
        public Rank_Type(System.Int32 rank_type_ID)
        {
            _rank_type_ID = rank_type_ID;
        }

        //----------------------------------------------------------------
        /// Get specific records: Rank_Type
        //----------------------------------------------------------------
        public override IDataReader GetItem()
        {

            _dbCommand = _db.GetStoredProcCommand("GetRank_Type");
            _db.AddInParameter(_dbCommand, _DSParam.Rank_Type.Rank_Type_IDColumn.ToString(), DbType.Int32, _rank_type_ID);
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Get records List: Rank_Type
        //----------------------------------------------------------------

        public override IDataReader GetAllItem()
        {

            _dbCommand = _db.GetStoredProcCommand("GetAllRank_Type");
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Delete: Rank_Type
        //----------------------------------------------------------------
        public override IDataReader Delete()
        {

            _dbCommand = _db.GetStoredProcCommand("GetRank_Type");
            _db.AddInParameter(_dbCommand, _DSParam.Rank_Type.Rank_Type_IDColumn.ToString(), DbType.Int32, _rank_type_ID);
            return _db.ExecuteReader(_dbCommand);
        }



        //----------------------------------------------------------------
        /// Insert record: Rank_Type
        //----------------------------------------------------------------
        public override IDataReader Insert( DSParameter ds)
        {
            _dbCommand = _db.GetStoredProcCommand("InsertRank_Type");
            _db.AddOutParameter(_dbCommand, ds.Rank_Type.Rank_Type_IDColumn.ToString(), DbType.Int32, 20);
            _db.AddInParameter(_dbCommand, ds.Rank_Type.Rank_TypeColumn.ToString(), DbType.String, ds.Rank_Type.Rows[0][ds.Rank_Type.Rank_TypeColumn.ToString()]);
            IDataReader dr = _db.ExecuteReader(_dbCommand, _transaction);
            dr.Close();
            _ID = System.Int32.Parse(_db.GetParameterValue(_dbCommand, "@Rank_Type_ID").ToString());
            return dr;
        }



        //----------------------------------------------------------------
        /// Update: Rank_Type
        //----------------------------------------------------------------
        public override IDataReader Update( DSParameter ds)
        {
            _dbCommand = _db.GetStoredProcCommand("UpdateRank_Type");
            _db.AddInParameter(_dbCommand, ds.Rank_Type.Rank_Type_IDColumn.ToString(), DbType.Int32, ds.Rank_Type.Rows[0][ds.Rank_Type.Rank_Type_IDColumn.ToString()]);
            _db.AddInParameter(_dbCommand, ds.Rank_Type.Rank_TypeColumn.ToString(), DbType.String, ds.Rank_Type.Rows[0][ds.Rank_Type.Rank_TypeColumn.ToString()]);
            IDataReader dr = _db.ExecuteReader(_dbCommand, _transaction);
            dr.Close();
            return dr;
        }


    }


}

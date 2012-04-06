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

namespace DataAccessLayer.Marker
{
    //----------------------------------------------------------------
/// Class: Keyword
//----------------------------------------------------------------
    public class Keyword : BaseParameter
{

System.Int32  _keyword_ID;
int _index;

public Keyword (Database db,DbTransaction dbTrans) 
{
	_db = db;
	_transaction = dbTrans;
}

public Keyword(Database db, DbTransaction dbTrans,int index):this(db,dbTrans)
{
    _index = index;
}
public Keyword (Database db) 
{
	_db = db;
}
public Keyword () 
{
 
}
public Keyword (System.Int32  keyword_ID) 
{
  _keyword_ID = keyword_ID;
}

//----------------------------------------------------------------
/// Get specific records: Keyword
//----------------------------------------------------------------
public override IDataReader GetItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetKeyword");
_db.AddInParameter(_dbCommand, _DSParam.Keyword.DayColumn.ToString(), DbType.Int32, _keyword_ID);
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Get records List: Keyword
//----------------------------------------------------------------

public override IDataReader GetAllItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetAllKeyword");
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Delete: Keyword
//----------------------------------------------------------------
public override IDataReader Delete( )
{

_dbCommand = _db.GetStoredProcCommand( "GetKeyword");
_db.AddInParameter(_dbCommand, _DSParam.Keyword.DayColumn.ToString(), DbType.Int32, _keyword_ID);
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Insert record: Keyword
//----------------------------------------------------------------
public override IDataReader Insert(DSParameter ds)
{
_dbCommand = _db.GetStoredProcCommand( "InsertKeyword");
_db.AddInParameter(_dbCommand, ds.Keyword.DayColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.DayColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.MonthColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.MonthColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.YearColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.YearColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.Source_IDColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.Source_IDColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.Marker_IDColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.Marker_IDColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.Count_Type_IDColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.Count_Type_IDColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.Rank_Type_IDColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.Rank_Type_IDColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.DateColumn.ToString(), DbType.DateTime, ds.Keyword.Rows[_index][ds.Keyword.DateColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.MentionColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.MentionColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.RankColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.RankColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
return dr;
}



//----------------------------------------------------------------
/// Update: Keyword
//----------------------------------------------------------------
public override IDataReader Update(DSParameter ds)
{
_dbCommand = _db.GetStoredProcCommand( "UpdateKeyword");
_db.AddInParameter(_dbCommand, ds.Keyword.DayColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.DayColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.MonthColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.MonthColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.YearColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.YearColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.Source_IDColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.Source_IDColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.Marker_IDColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.Marker_IDColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.Count_Type_IDColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.Count_Type_IDColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.Rank_Type_IDColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.Rank_Type_IDColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.DateColumn.ToString(), DbType.DateTime, ds.Keyword.Rows[_index][ds.Keyword.DateColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.MentionColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.MentionColumn.ToString()]);
_db.AddInParameter(_dbCommand, ds.Keyword.RankColumn.ToString(), DbType.Int32, ds.Keyword.Rows[_index][ds.Keyword.RankColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
return dr;
}


}

}

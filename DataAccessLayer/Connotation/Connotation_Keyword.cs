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

namespace DataAccessLayer.Connotation
{
    //----------------------------------------------------------------
/// Class: Connotation_Keyword
//----------------------------------------------------------------
public class Connotation_Keyword : BaseParameter
{

System.Int32  _connotation_keyword_ID;

public Connotation_Keyword (Database db,DbTransaction dbTrans) 
{
	_db = db;
	_transaction = dbTrans;
}
public Connotation_Keyword (Database db) 
{
	_db = db;
}
public Connotation_Keyword () 
{
 
}
public Connotation_Keyword (System.Int32  connotation_keyword_ID) 
{
  _connotation_keyword_ID = connotation_keyword_ID;
}

//----------------------------------------------------------------
/// Get specific records: Connotation_Keyword
//----------------------------------------------------------------
public override IDataReader GetItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetConnotation_Keyword");
	_db.AddInParameter(_dbCommand, _DSParam.Connotation_Keyword.DayColumn.ToString(), DbType.Int32,  _connotation_keyword_ID );
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Get records List: Connotation_Keyword
//----------------------------------------------------------------

public override IDataReader GetAllItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetAllConnotation_Keyword");
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Delete: Connotation_Keyword
//----------------------------------------------------------------
public override IDataReader Delete( )
{

_dbCommand = _db.GetStoredProcCommand( "GetConnotation_Keyword");
_db.AddInParameter(_dbCommand, _DSParam.Connotation_Keyword.DayColumn.ToString(), DbType.Int32, _connotation_keyword_ID);
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Insert record: Connotation_Keyword
//----------------------------------------------------------------
public override IDataReader Insert(DSParameter ds )
{
_dbCommand = _db.GetStoredProcCommand( "InsertConnotation_Keyword");
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.DayColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.DayColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.MonthColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.MonthColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.YearColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.YearColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.Marker_Connotation_IDColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.Marker_Connotation_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.Source_IDColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.Source_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.DateColumn.ToString(), DbType.DateTime,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.DateColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.MentionColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.MentionColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
return dr;
}



//----------------------------------------------------------------
/// Update: Connotation_Keyword
//----------------------------------------------------------------
public override IDataReader Update(DSParameter ds)
{
_dbCommand = _db.GetStoredProcCommand( "UpdateConnotation_Keyword");
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.DayColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.DayColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.MonthColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.MonthColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.YearColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.YearColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.Marker_Connotation_IDColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.Marker_Connotation_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.Source_IDColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.Source_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.DateColumn.ToString(), DbType.DateTime,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.DateColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Connotation_Keyword.MentionColumn.ToString(), DbType.Int32,ds.Connotation_Keyword.Rows[0][ds.Connotation_Keyword.MentionColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
return dr;
}


}

}

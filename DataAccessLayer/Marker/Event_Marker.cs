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
/// Class: Event_Marker
//----------------------------------------------------------------
    public class Event_Marker : BaseParameter
{

System.Int32  _event_marker_ID;

public Event_Marker (Database db,DbTransaction dbTrans) 
{
	_db = db;
	_transaction = dbTrans;
}
public Event_Marker (Database db) 
{
	_db = db;
}
public Event_Marker () 
{
 
}
public Event_Marker (System.Int32  event_marker_ID) 
{
  _event_marker_ID = event_marker_ID;
}

//----------------------------------------------------------------
/// Get specific records: Event_Marker
//----------------------------------------------------------------
public override IDataReader GetItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetEvent_Marker");
_db.AddInParameter(_dbCommand, _DSParam.Event_Marker.Event_Marker_IDColumn.ToString(), DbType.Int32, _event_marker_ID);
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Get records List: Event_Marker
//----------------------------------------------------------------

public override IDataReader GetAllItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetallEvent_Marker");
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Delete: Event_Marker
//----------------------------------------------------------------
public override IDataReader Delete( )
{

_dbCommand = _db.GetStoredProcCommand( "GetEvent_Marker");
_db.AddInParameter(_dbCommand, _DSParam.Event_Marker.Event_Marker_IDColumn.ToString(), DbType.Int32, _event_marker_ID);
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Insert record: Event_Marker
//----------------------------------------------------------------
public override IDataReader Insert(DSParameter ds)
{
_dbCommand = _db.GetStoredProcCommand( "InsertEvent_Marker");
	_db.AddOutParameter(_dbCommand, ds.Event_Marker.Event_Marker_IDColumn.ToString(), DbType.Int32,20);
	_db.AddInParameter(_dbCommand, ds.Event_Marker.Marker_IDColumn.ToString(), DbType.Int32,ds.Event_Marker.Rows[0][ds.Event_Marker.Marker_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Event_Marker.Period_In_DaysColumn.ToString(), DbType.Int32,ds.Event_Marker.Rows[0][ds.Event_Marker.Period_In_DaysColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Event_Marker.Start_DateColumn.ToString(), DbType.DateTime,ds.Event_Marker.Rows[0][ds.Event_Marker.Start_DateColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Event_Marker.Start_YearColumn.ToString(), DbType.Int32,ds.Event_Marker.Rows[0][ds.Event_Marker.Start_YearColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Event_Marker.End_YearColumn.ToString(), DbType.Int32,ds.Event_Marker.Rows[0][ds.Event_Marker.End_YearColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
_ID = System.Int32.Parse( _db.GetParameterValue(_dbCommand, "@Event_Marker_ID").ToString() );
return dr;
}



//----------------------------------------------------------------
/// Update: Event_Marker
//----------------------------------------------------------------
public override IDataReader Update(DSParameter ds)
{
_dbCommand = _db.GetStoredProcCommand( "UpdateEvent_Marker");
	_db.AddInParameter(_dbCommand, ds.Event_Marker.Event_Marker_IDColumn.ToString(), DbType.Int32,ds.Event_Marker.Rows[0][ds.Event_Marker.Event_Marker_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Event_Marker.Marker_IDColumn.ToString(), DbType.Int32,ds.Event_Marker.Rows[0][ds.Event_Marker.Marker_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Event_Marker.Period_In_DaysColumn.ToString(), DbType.Int32,ds.Event_Marker.Rows[0][ds.Event_Marker.Period_In_DaysColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Event_Marker.Start_DateColumn.ToString(), DbType.DateTime,ds.Event_Marker.Rows[0][ds.Event_Marker.Start_DateColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Event_Marker.Start_YearColumn.ToString(), DbType.Int32,ds.Event_Marker.Rows[0][ds.Event_Marker.Start_YearColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Event_Marker.End_YearColumn.ToString(), DbType.Int32,ds.Event_Marker.Rows[0][ds.Event_Marker.End_YearColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
return dr;
}


}


}

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
/// Class: Marker_Connotation
//----------------------------------------------------------------
    public class Marker_Connotation : BaseParameter
{

System.Int32  _marker_connotation_ID;

public Marker_Connotation (Database db,DbTransaction dbTrans) 
{
	_db = db;
	_transaction = dbTrans;
}
public Marker_Connotation (Database db) 
{
	_db = db;
}
public Marker_Connotation () 
{
 
}
public Marker_Connotation (System.Int32  marker_connotation_ID) 
{
  _marker_connotation_ID = marker_connotation_ID;
}

//----------------------------------------------------------------
/// Get specific records: Marker_Connotation
//----------------------------------------------------------------
public override IDataReader GetItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetMarker_Connotation");
_db.AddInParameter(_dbCommand, _DSParam.Marker_Connotation.Marker_Connotation_IDColumn.ToString(), DbType.Int32, _marker_connotation_ID);
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Get records List: Marker_Connotation
//----------------------------------------------------------------

public override IDataReader GetAllItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetAllMarker_Connotation");
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Delete: Marker_Connotation
//----------------------------------------------------------------
public override IDataReader Delete( )
{

_dbCommand = _db.GetStoredProcCommand( "GetMarker_Connotation");
_db.AddInParameter(_dbCommand, _DSParam.Marker_Connotation.Marker_Connotation_IDColumn.ToString(), DbType.Int32, _marker_connotation_ID);
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Insert record: Marker_Connotation
//----------------------------------------------------------------
public override IDataReader Insert(DSParameter ds)
{
_dbCommand = _db.GetStoredProcCommand( "InsertMarker_Connotation");
	_db.AddOutParameter(_dbCommand, ds.Marker_Connotation.Marker_Connotation_IDColumn.ToString(), DbType.Int32,20);
	_db.AddInParameter(_dbCommand, ds.Marker_Connotation.Marker_IDColumn.ToString(), DbType.Int32,ds.Marker_Connotation.Rows[0][ds.Marker_Connotation.Marker_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker_Connotation.Marker_ConnotationColumn.ToString(), DbType.String,ds.Marker_Connotation.Rows[0][ds.Marker_Connotation.Marker_ConnotationColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
_ID = System.Int32.Parse( _db.GetParameterValue(_dbCommand, "@Marker_Connotation_ID").ToString() );
return dr;
}



//----------------------------------------------------------------
/// Update: Marker_Connotation
//----------------------------------------------------------------
public override  IDataReader Update( DSParameter ds )
{
_dbCommand = _db.GetStoredProcCommand( "UpdateMarker_Connotation");
	_db.AddInParameter(_dbCommand, ds.Marker_Connotation.Marker_Connotation_IDColumn.ToString(), DbType.Int32,ds.Marker_Connotation.Rows[0][ds.Marker_Connotation.Marker_Connotation_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker_Connotation.Marker_IDColumn.ToString(), DbType.Int32,ds.Marker_Connotation.Rows[0][ds.Marker_Connotation.Marker_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker_Connotation.Marker_ConnotationColumn.ToString(), DbType.String,ds.Marker_Connotation.Rows[0][ds.Marker_Connotation.Marker_ConnotationColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
return dr;
}


}


}

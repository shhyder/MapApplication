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
/// Class: Count_Type
//----------------------------------------------------------------
public class Count_Type : BaseParameter
{

System.Int32  _count_type_ID;

public Count_Type (Database db,DbTransaction dbTrans) 
{
	_db = db;
	_transaction = dbTrans;
}
public Count_Type (Database db) 
{
	_db = db;
}
public Count_Type () 
{
 
}
public Count_Type (System.Int32  count_type_ID) 
{
  _count_type_ID = count_type_ID;
}

//----------------------------------------------------------------
/// Get specific records: Count_Type
//----------------------------------------------------------------
public override IDataReader GetItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetCount_Type");
	_db.AddInParameter(_dbCommand, _DSParam.Count_Type.Count_Type_IDColumn.ToString(), DbType.Int32,  _count_type_ID );
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Get records List: Count_Type
//----------------------------------------------------------------

public override IDataReader GetAllItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetAllCount_Type");
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Delete: Count_Type
//----------------------------------------------------------------
public override IDataReader Delete( )
{

_dbCommand = _db.GetStoredProcCommand( "GetCount_Type");
_db.AddInParameter(_dbCommand, _DSParam.Count_Type.Count_Type_IDColumn.ToString(), DbType.Int32, _count_type_ID);
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Insert record: Count_Type
//----------------------------------------------------------------
public override IDataReader Insert(DSParameter ds)
{
_dbCommand = _db.GetStoredProcCommand( "InsertCount_Type");
	_db.AddOutParameter(_dbCommand, ds.Count_Type.Count_Type_IDColumn.ToString(), DbType.Int32,20);
	_db.AddInParameter(_dbCommand, ds.Count_Type.Count_TypeColumn.ToString(), DbType.String,ds.Count_Type.Rows[0][ds.Count_Type.Count_TypeColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
_ID = System.Int32.Parse( _db.GetParameterValue(_dbCommand, "@Count_Type_ID").ToString() );
return dr;
}



//----------------------------------------------------------------
/// Update: Count_Type
//----------------------------------------------------------------
public override IDataReader Update(DSParameter ds)
{
_dbCommand = _db.GetStoredProcCommand( "UpdateCount_Type");
	_db.AddInParameter(_dbCommand, ds.Count_Type.Count_Type_IDColumn.ToString(), DbType.Int32,ds.Count_Type.Rows[0][ds.Count_Type.Count_Type_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Count_Type.Count_TypeColumn.ToString(), DbType.String,ds.Count_Type.Rows[0][ds.Count_Type.Count_TypeColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
return dr;
}


}

}

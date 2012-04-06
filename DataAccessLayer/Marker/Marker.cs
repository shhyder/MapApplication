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
/// Class: Marker
//----------------------------------------------------------------
    public class Marker : BaseParameter
{

System.Int32  _marker_ID;

public Marker (Database db,DbTransaction dbTrans) 
{
	_db = db;
	_transaction = dbTrans;
}
public Marker (Database db) 
{
	_db = db;
}
public Marker () 
{
 
}
public Marker (System.Int32  marker_ID) 
{
  _marker_ID = marker_ID;
}

//----------------------------------------------------------------
/// Get specific records: Marker
//----------------------------------------------------------------
public override IDataReader GetItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetMarker");
_db.AddInParameter(_dbCommand, _DSParam.Marker.Marker_IDColumn.ToString(), DbType.Int32, _marker_ID);
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Get records List: Marker
//----------------------------------------------------------------

public override IDataReader GetAllItem()
{

_dbCommand = _db.GetStoredProcCommand( "GetAllMarker");
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Delete: Marker
//----------------------------------------------------------------
public override IDataReader Delete( )
{

_dbCommand = _db.GetStoredProcCommand( "GetMarker");
_db.AddInParameter(_dbCommand, _DSParam.Marker.Marker_IDColumn.ToString(), DbType.Int32, _marker_ID);
	return _db.ExecuteReader( _dbCommand);
}



//----------------------------------------------------------------
/// Insert record: Marker
//----------------------------------------------------------------
public override IDataReader Insert(DSParameter ds)
{
_dbCommand = _db.GetStoredProcCommand( "InsertMarker");
	_db.AddOutParameter(_dbCommand, ds.Marker.Marker_IDColumn.ToString(), DbType.Int32,20);
	_db.AddInParameter(_dbCommand, ds.Marker.Marker_TagColumn.ToString(), DbType.String,ds.Marker.Rows[0][ds.Marker.Marker_TagColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.AddressColumn.ToString(), DbType.String,ds.Marker.Rows[0][ds.Marker.AddressColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.CityColumn.ToString(), DbType.String,ds.Marker.Rows[0][ds.Marker.CityColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.StateColumn.ToString(), DbType.String,ds.Marker.Rows[0][ds.Marker.StateColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.CountryColumn.ToString(), DbType.String,ds.Marker.Rows[0][ds.Marker.CountryColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.LatitudeColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.LatitudeColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.LongitudeColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.LongitudeColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Is_Recurring_EventColumn.ToString(), DbType.Boolean,ds.Marker.Rows[0][ds.Marker.Is_Recurring_EventColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_CountColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Daily_CountColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_CountColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Monthly_CountColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_CountColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Yearly_CountColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_Count_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Daily_Count_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_Count_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Monthly_Count_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_Count_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Yearly_Count_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_Count_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Daily_Count_PercentageColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_Count_Trend_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Yearly_Count_Trend_PercentageColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_Count_Trend_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Monthly_Count_Trend_PercentageColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_RankColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Daily_RankColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_RankColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Monthly_RankColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_RankColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Yearly_RankColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_Rank_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Daily_Rank_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_Rank_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Monthly_Rank_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_Rank_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Yearly_Rank_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_Rank_Trend_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Daily_Rank_Trend_PercentageColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_Rank_Trend_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Monthly_Rank_Trend_PercentageColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_Rank_Trend_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Yearly_Rank_Trend_PercentageColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
_ID = System.Int32.Parse( _db.GetParameterValue(_dbCommand, "@Marker_ID").ToString() );
return dr;
}



//----------------------------------------------------------------
/// Update: Marker
//----------------------------------------------------------------
public override IDataReader Update(DSParameter ds)
{
_dbCommand = _db.GetStoredProcCommand( "UpdateMarker");
	_db.AddInParameter(_dbCommand, ds.Marker.Marker_IDColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Marker_IDColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Marker_TagColumn.ToString(), DbType.String,ds.Marker.Rows[0][ds.Marker.Marker_TagColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.AddressColumn.ToString(), DbType.String,ds.Marker.Rows[0][ds.Marker.AddressColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.CityColumn.ToString(), DbType.String,ds.Marker.Rows[0][ds.Marker.CityColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.StateColumn.ToString(), DbType.String,ds.Marker.Rows[0][ds.Marker.StateColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.CountryColumn.ToString(), DbType.String,ds.Marker.Rows[0][ds.Marker.CountryColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.LatitudeColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.LatitudeColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.LongitudeColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.LongitudeColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Is_Recurring_EventColumn.ToString(), DbType.Boolean,ds.Marker.Rows[0][ds.Marker.Is_Recurring_EventColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_CountColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Daily_CountColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_CountColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Monthly_CountColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_CountColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Yearly_CountColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_Count_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Daily_Count_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_Count_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Monthly_Count_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_Count_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Yearly_Count_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_Count_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Daily_Count_PercentageColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_Count_Trend_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Yearly_Count_Trend_PercentageColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_Count_Trend_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Monthly_Count_Trend_PercentageColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_RankColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Daily_RankColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_RankColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Monthly_RankColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_RankColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Yearly_RankColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_Rank_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Daily_Rank_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_Rank_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Monthly_Rank_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_Rank_TrendColumn.ToString(), DbType.Int32,ds.Marker.Rows[0][ds.Marker.Current_Yearly_Rank_TrendColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Daily_Rank_Trend_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Daily_Rank_Trend_PercentageColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Monthly_Rank_Trend_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Monthly_Rank_Trend_PercentageColumn.ToString()]);
	_db.AddInParameter(_dbCommand, ds.Marker.Current_Yearly_Rank_Trend_PercentageColumn.ToString(), DbType.Decimal,ds.Marker.Rows[0][ds.Marker.Current_Yearly_Rank_Trend_PercentageColumn.ToString()]);
	IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
dr.Close();
return dr;
}
public void GetMarkerRankUpdate()
{
    _dbCommand = _db.GetStoredProcCommand("GetMarkerRankUpdate");
    IDataReader dr = _db.ExecuteReader( _dbCommand,_transaction);
    dr.Close();
}

}


}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BusinessLogic.Marker
{
   

    public class Marker : BaseParameter, IParameterBL//, IList
    {
        #region INonParameterBL Members

        public DataSet.DSParameter New(DataSet.DSParameter ds)
        {
            _is_Single_Transaction = false;

            GetAllSourceCountHistory(ref ds, 0);
            try
            {

                int Marker_ID = 0;
                _base = new DataAccessLayer.Marker.Marker();
                _base.BeginTransaction();
                _base.SetConnection();
                _base.Insert(ds);
                Marker_ID = (int)_base._ID;


                

                int length = ds.Keyword.Count;


                for (int i = 0; i < length; i++)
                {
                    _base = new DataAccessLayer.Marker.Keyword(_base._db, _base._transaction, i);
                    ds.Keyword[i]["Marker_ID"] = Marker_ID;
                    base.baseNew(ds, ds.Keyword.TableName);
                }


                _ID = (int)_base._ID;

                DataAccessLayer.Marker.Marker mark = new DataAccessLayer.Marker.Marker(_base._db, _base._transaction);
                mark.GetMarkerRankUpdate();
                _base.CommitTransaction();
            }
            catch
            {
                _base.RollBackTransaction();
                throw;
            }

            return this.Get();
        }


      


        public bool Update(DataSet.DSParameter ds)
        {
            _is_Single_Transaction = false;
            try
            {
                int patient_ID = ds.Distributor[0].Distributor_ID;

                _base = new DataAccessLayer.Distributor.Distributor();
                _base._ID = patient_ID;
                _base.BeginTransaction();
                _base.SetConnection();
                base.baseUpdate(ds, ds.Distributor.TableName);


                DataAccessLayer.Marker.Marker mark = new DataAccessLayer.Marker.Marker(_base._db, _base._transaction);
                mark.GetMarkerRankUpdate();
                _base.CommitTransaction();
            }
            catch
            {
                return false;
            }
            finally
            {

            }
            return true;
        }

        public bool Delete(DataSet.DSParameter ds)
        {
            _is_Single_Transaction = false;
            try
            {
                int Distributor_ID = ds.Distributor[0].Distributor_ID;
                _base = new DataAccessLayer.Distributor.Distributor();
                _base.BeginTransaction();
                _base.SetConnection();
                _base._ID = Distributor_ID;
                base.baseDelete();

                _base.CommitTransaction();
            }
            catch
            {
                return false;
            }
            finally
            {

            }
            return true;
        }

        public DataSet.DSParameter Get()
        {
            DataSet.DSParameter ds = new DataSet.DSParameter();
            //_is_Single_Transaction = false;
            try
            {
                _base = new DataAccessLayer.Distributor.Distributor();
                _base.SetConnection();
                _db = _base.GetDatabase();
                _base._ID = _ID;
                ds.Load(_base.GetItem(), LoadOption.OverwriteChanges, ds.Distributor.TableName);
            }
            catch
            {
                //_base.RollBackTransaction();
                //throw;
            }

            return ds;
        }






        //public System.Data.DataSet GetPage(int start, int count, ref int totalCount,
        //   string Distributor_No, string customer, string address, string email,
        //   string phone, string country, string state, string from_Date,
        //   string to_Date)
        //{
        //    System.Data.DataSet ds = new System.Data.DataSet();
        //    //_is_Single_Transaction = false;
        //    try
        //    {
        //        DataAccessLayer.Distributor.Distributor obj = new DataAccessLayer.Distributor.Distributor(start, count, totalCount,
        //       Distributor_No, customer, address, email, phone, country, state, from_Date, to_Date);
        //        obj.SetConnection();
        //        _db = obj.GetDatabase();
        //        ds = obj.GetPage();
        //        totalCount = obj._ID;
        //    }
        //    catch
        //    {
        //        //_base.RollBackTransaction();
        //        //throw;
        //    }

        //    return ds;
        //}

        //public System.Data.DataSet GetPage(int start, int count, ref int totalCount,
        //    string UCI, int? company, string first_Name,
        //    string middle_Name, string last_Naemm, string phone_1,
        //    string phone_2, string from_Date, string to_Date)
        //{
        //    System.Data.DataSet ds = new System.Data.DataSet();
        //    //_is_Single_Transaction = false;
        //    try
        //    {
        //        DataAccessLayer.Consumer.Consumer cons = new DataAccessLayer.Consumer.Consumer(start, count, totalCount,
        //            UCI, company, first_Name, middle_Name, last_Naemm, phone_1, phone_2, from_Date, to_Date);
        //        cons.SetConnection();
        //        _db = cons.GetDatabase();
        //        ds = cons.GetPage();
        //        totalCount = cons._ID;
        //    }
        //    catch
        //    {
        //        //_base.RollBackTransaction();
        //        //throw;
        //    }

        //    return ds;
        //}



        //public DataSet.DSParameter GetCaseByConsumer(int consumer_ID)
        //{
        //    DataSet.DSParameter ds = new DataSet.DSParameter();
        //    //_is_Single_Transaction = false;
        //    try
        //    {
        //        DataAccessLayer.Consumer.Case Cons = new DataAccessLayer.Consumer.Case();
        //        Cons.SetConnection();
        //        _db = Cons.GetDatabase();
        //        Cons._ID = consumer_ID;
        //        ds.Load(Cons.GetItemByConsumer(), LoadOption.OverwriteChanges, ds.Case.TableName);
        //    }
        //    catch
        //    {
        //        //_base.RollBackTransaction();
        //        //throw;
        //    }

        //    return ds;
        //}


        #endregion


        public System.Data.DataSet GetDistributorStateCount()
        {
            DataAccessLayer.Distributor.Distributor obj = new DataAccessLayer.Distributor.Distributor();
            System.Data.DataSet ds = new System.Data.DataSet();
            obj.SetConnection();
            ds.Load(obj.GetStateCount(), LoadOption.OverwriteChanges, "List");
            return ds;
        }


        //#region IList Members

        //public System.Data.DataSet GetList()
        //{
        //    _base = new DataAccessLayer.Distributor.Distributor();
        //    return base.base.base.baseGetList();
        //}

        //#endregion

        #region IParameterBL Members


        public System.Data.DataSet GetAll()
        {
            throw new NotImplementedException();
        }

        #endregion

        void GetAllSourceCountHistory(ref DataSet.DSParameter ds,int marker_ID)
        {
            GoogleSearchCount plac = new GoogleSearchCount(marker_ID);
            plac.GetCount(ref ds);

            BusinessLogic.Marker.twitter twi = new twitter(marker_ID);
            twi.GetCount(ref ds);
        }
    }
}

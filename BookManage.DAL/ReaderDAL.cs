﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BookManage.Model;


namespace BookManage.DAL
{
    public class ReaderDAL
    {
        
        public static int Insert(Reader reader)
        {
            int rows = 0;
            string sql = "insert into Reader(rdID,rdName,rdSex,rdType,rdPhone,rdEmail,rdDateReg,rdPhoto,rdStatus,rdBorrowQty,rdPwd,rdAdminRoles)"
                             + "value ((@rdID,@rdName,@rdSex,@rdType,@rdPhone,@rdEmail,@rdDateReg,@rdPhoto,@rdStatus,@rdBorrowQty,@rdPwd,@rdAdminRoles)";
            SqlParameter[] parameters ={
                                           new SqlParameter("@rdID",reader.rdID),
                                           new SqlParameter("@rdName",reader.rdName),
                                           new SqlParameter("@rdSex",reader.rdSex),
                                           new SqlParameter("@rdType",reader.rdType),
                                           new SqlParameter("@rdPhone",reader.rdPhone),
                                           new SqlParameter("@rdEmail",reader.rdEmail),
                                           new SqlParameter("@rdDateReg",reader.rdDateReg),
                                           new SqlParameter("@rdPhoto",reader.rdPhoto),
                                           new SqlParameter("@rdStatus",reader.rdStatus),
                                           new SqlParameter("@rdBorrowQty",reader.rdBorrowQty),
                                           new SqlParameter("@rdPwd",reader.rdPwd),
                                           new SqlParameter("@rdAdminRoles",reader.rdAdminRoles)
                                      };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }

        public static int Update(Reader reader)
        {
            int rows = 0;
            string sql = "update Reader set"
                + "rdID=@rdID,"
                + "rdName=@rdName,"
                + "rdSex=@rdSex,"
                + "rdType=@rdType,"
                + "rdPhone=@rdPhone,"
                + "rdEmail=@rdEmail,"
                + "rdDateReg=@rdDateReg,"
                + "rdPhoto=@rdPhoto,"
                + "rdStatus=@rdStatus,"
                + "rdBorrowQty=@rdBorrowQty,"
                + "rdPwd=@rdPwd,"
                + "rdAdminRoles=@rdAdminRoles"
                + "where rdID=@rdID";               
            SqlParameter[] parameters ={
                                           new SqlParameter("@rdID",reader.rdID),
                                           new SqlParameter("@rdName",reader.rdName),
                                           new SqlParameter("@rdSex",reader.rdSex),
                                           new SqlParameter("@rdType",reader.rdType),
                                           new SqlParameter("@rdPhone",reader.rdPhone),
                                           new SqlParameter("@rdEmail",reader.rdEmail),
                                           new SqlParameter("@rdDateReg",reader.rdDateReg),
                                           new SqlParameter("@rdPhoto",reader.rdPhoto),
                                           new SqlParameter("@rdStatus",reader.rdStatus),
                                           new SqlParameter("@rdBorrowQty",reader.rdBorrowQty),
                                           new SqlParameter("@rdPwd",reader.rdPwd),
                                           new SqlParameter("@rdAdminRoles",reader.rdAdminRoles)
                                      };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }

        public static int Delete(Reader reader)
        {
            int rows = 0;
            string sql = "deaete from Reader where rdID=@rdID";
            SqlParameter[] parameters = { new SqlParameter("@rdID", reader.rdID) };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }

        ///
        /// 由读者类型ID(rdType)得到该读者类型信息，返回DataRow
        ///
        public static DataRow GetDRByID(int rdID)
        {
            string sql = "select * from Reader where rdID=@rdID";
            SqlParameter[] parameters = { new SqlParameter("@rdID", rdID) };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "Reader");
            DataRow dr = null;
            if (dt == null || dt.Rows.Count == 0)
            {
                return dr;
            }
            else
            {
                dr = dt.Rows[0];
                return dr;
            }
        }

        public static Reader GetObjectByID(int rdID)
        {
            DataRow dr = GetDRByID(rdID);
            return SqlHelper.DataRowToT<Reader>(dr);
        }
    }
}

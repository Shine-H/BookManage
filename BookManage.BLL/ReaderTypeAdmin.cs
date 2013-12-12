﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookManage.Model;
using BookManage.DAL;

namespace BookManage.BLL
{
    public class ReaderTypeAdmin//读者类型管理类
    {
        public static ReaderType GetReaderType(int rdType)
        {
            return (ReaderTypeDAL.GetObjectByID(rdType));
        }

        public DataTable GetReaderType()
        {
            return (ReaderTypeDAL.GetReaderType());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookManage.Model;
using BookManage.DAL;

namespace BookManage.BLL
{
    public class ReaderAdmin
    {
        public static Reader GetReader(int rdID)
        {
            return (DAL.ReaderDAL.GetObjectByID(rdID));
        }

        public DataTable  GetAllReaderType()
        {
            return (ReaderTypeDAL.GetAll());
        }
    }
}

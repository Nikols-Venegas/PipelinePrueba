﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    

    public class clsDAO
    {
        public SqlConnection con;
        public clsDAO()
        {
            string str = "Server=DESKTOP-HP314DE\\SQLEXPRESS2017;DataBase=School;Integrated Security=true;";
            con = new SqlConnection(str);
        }
    }
}

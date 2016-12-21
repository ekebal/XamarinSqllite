﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinSqlLight.Modele;

namespace XamarinSqlLight.Database
{
    class UserDatabase : CrudDatabase
    {
        protected override void initDababase()
        {
            Connection.CreateTable<User>();
        }
    }
}

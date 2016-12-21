using System;
using System.Collections.Generic;
using System.Text;
using XamarinSqlLight.Modele;

namespace XamarinSqlLight.Database
{
    class AlertDatabase: CrudDatabase
    {

        protected override void initDababase()
        {
            Connection.CreateTable<Alert>();
        }

    }
}

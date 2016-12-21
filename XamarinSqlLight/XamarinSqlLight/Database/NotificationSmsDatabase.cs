using System;
using System.Collections.Generic;
using System.Text;
using XamarinSqlLight.Modele;

namespace XamarinSqlLight.Database
{
    class NotificationSmsDatabase : CrudDatabase
    {
        protected override void initDababase()
        {
            Connection.CreateTable<NotificationSms>();
        }
    }
}

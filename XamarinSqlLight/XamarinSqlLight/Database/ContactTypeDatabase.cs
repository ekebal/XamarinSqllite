using System;
using System.Collections.Generic;
using System.Text;
using XamarinSqlLight.Modele;

namespace XamarinSqlLight.Database
{
   public  class ContactTypeDatabase : CrudDatabase
    {
        protected override void initDababase()
        {
            Connection.CreateTable<ContactType>();
        }

    }
}

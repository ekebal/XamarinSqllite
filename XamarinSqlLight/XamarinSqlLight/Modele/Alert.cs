﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace XamarinSqlLight.Modele
{
    class Alert : ITable
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public int Idmedicament { get; set; }

        public float Hour { get; set; }

        public override string ToString()
        {
            return string.Format("[Alert: ID={0}, Idmedicament={1}, Hour={2}]", ID, Idmedicament, Hour);
        }
    }
}



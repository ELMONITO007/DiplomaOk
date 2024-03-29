﻿using System;
using System.Data;
using System.Configuration;
using System.Text.RegularExpressions;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Data
{
    public abstract class DataAccessComponent
    {
        protected const string CONNECTION_NAME = "DefaultConnection";
        protected const string CONNECTION_Restore = "Restore";
        protected const string CONNECTION_Aux = "DefaultConnectionAux";
        static DataAccessComponent()
        {
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory(), false);
        }

        protected int PageSize
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["PageSize"]);
            }
        }

        protected static T GetDataValue<T>(IDataReader dr, string columnName)
        {
            int i = dr.GetOrdinal(columnName);

            if (!dr.IsDBNull(i))
                return (T)dr.GetValue(i);
            else
                return default(T);
        }

        protected string FormatFilterStatement(string filter)
        {
            return Regex.Replace(filter, "^(AND|OR)", string.Empty);
        }


    }
}

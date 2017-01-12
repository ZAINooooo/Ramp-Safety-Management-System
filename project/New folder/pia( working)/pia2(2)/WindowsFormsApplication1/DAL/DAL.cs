using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace piac_project.DAL
{
    class DAL
    {
        public static string SQLConnection()
        {
            return ConfigurationManager.ConnectionStrings["piadb"].ConnectionString;
        }
    }
}

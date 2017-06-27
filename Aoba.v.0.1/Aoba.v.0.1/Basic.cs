using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Aoba.v._0._1
{
    static public class Basic
    {
        static public SqlConnection mylink;
        static public string connectionstring = "server=localhost;database=Aoba;integrated security=SSPI";
        public enum UserType
        {
            user = 0,
            teacher = 1,
            student = 2,
            course = 3,
            elective = 4
        };
    }
}

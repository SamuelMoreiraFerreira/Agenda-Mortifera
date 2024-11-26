using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMortifera.StructureDB
{
    static public class UserSession
    {
        static private MySqlConnection _conexao = null;

        static public MySqlConnection Conexao
        {
            
            get
            {
                return _conexao;
            }

            set
            {
                _conexao = value;
            }

        }

        static private Dictionary<string, object> _userInfo = null;

        static public Dictionary<string, object> UserInfo
        {

            get
            {
                return _userInfo;
            }

            set
            {
                _userInfo = value;
            }

        }
    }
}
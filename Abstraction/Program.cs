using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        public string UserLogin(string username, string password)
        {
            if (ValidUser(username, password))
            {
                if (ShowDashboard(username, password) > 0)
                {
                    return "login Success";
                }
            }
            return "login Failed";
        }

        private bool ValidUser(string username, string password)
        {
            return true;
        }

        private int ShowDashboard(string username, string password)
        {
            return 1;
        }
    }
    
    }

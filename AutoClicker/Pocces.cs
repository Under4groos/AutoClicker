using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    static class Pocces
    {


        public static List<string> isWindowValid()
        {
            List<string> Name = new List<string>();
            List<string> Name2 = new List<string>();


            foreach (var item in System.Diagnostics.Process.GetProcesses())
            {
                string name = item.ProcessName;

                if (name != "svchost")
                {

                    Name.Add(name);
                }
            }
            foreach (var item in Name)
            {
                if (!isValid(Name, item))
                {

                    Name2.Add(item);
                }
            }






            return Name2;
        
        }


        public static bool isValid(List<string> s, string f)
        {
            bool b = false;

            foreach (var d in s)
            {
                if (d == f)
                {
                    b = true;
                    break;
                }
                else
                {
                    b = false;
                }
                    
            }
            return b;
        }
    }

}

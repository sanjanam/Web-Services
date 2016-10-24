using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace stem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "stem" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select stem.svc or stem.svc.cs at the Solution Explorer and start debugging.
    public class stem : Istem
    {
                        
    
     public string stemming(string val)
        {
            string input = val;
            string[] format = input.Split(' ');
            StringBuilder result1 = new StringBuilder();
            string[] suffixes = { "ation", "ative","ed","ing","s"};
            for (int n = 0; n < format.Length; n++)
            {
                for (int m = 0; m < suffixes.Length; m++)
                {
                    if (format[n].EndsWith(suffixes[m]))
                    {                       
                        int length = format[n].Length - suffixes[m].Length;
                        string ints = format[n];
                        format[n] = format[n].Replace(format[n], format[n].Substring(0, length));

                    }
                }
            }
            foreach (string str in format)
            {
                result1.Append(str);
                result1.Append(" ");
            }
            return result1.ToString();
        }

       
    
    }
}

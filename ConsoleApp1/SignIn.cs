using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SignIn
    {
        public bool Sumbit(string content) {
            if (!string.IsNullOrEmpty(content))
            {
                Console.WriteLine("you put in:{0}", content);
                return true;
            }
            else return false;
        }
    }
}

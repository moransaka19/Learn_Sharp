using System;
using System.Collections.Generic;
using System.Text;

namespace SOlution.Extensions
{
    public static class ManExtension
    {
        public static void SayYourName(this Man obj)
        {
            string name = "My name is " + obj.Name;
            Console.WriteLine(name);
        }
    }
}

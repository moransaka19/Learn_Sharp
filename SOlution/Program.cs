using SOlution.Extensions;
using System;

namespace SOlution
{
    class Program
    {
        static void Main(string[] args)
        {
            var man = new Man() { Name = "Vlad" };
            man.SayYourName();
        }
    }
}

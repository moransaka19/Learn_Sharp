using System;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot();
            robot.SayDO();
        }
    }

    public partial class Robot
    {
        public void SayDO()
        {
            Do();
        }

        partial void Do();
    }

    public partial class RobotAddition
    {
        partial void Do()
        {
            Console.WriteLine("Do additional method");
        }
    }
}

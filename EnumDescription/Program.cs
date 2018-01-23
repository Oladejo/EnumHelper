using System;

namespace EnumDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pass the Enum you want to get the description
            //if not description on the Enum, it convert the enum to string.
            string result = EnumHelper.GetDescription(Status.Boy);

            Console.WriteLine(result);
        }
    }
}

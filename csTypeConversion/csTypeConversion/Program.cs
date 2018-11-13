using System;

namespace csTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "1324";
                byte b = Convert.ToByte(number);
                Console.WriteLine(number);
            }
            catch(Exception)
            {
                Console.WriteLine("The Number could not be converted to a byte");
            }
        }
    }
}

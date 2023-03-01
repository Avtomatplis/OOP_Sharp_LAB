using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UI.bannerInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.ReadLine();
        }
    }
}

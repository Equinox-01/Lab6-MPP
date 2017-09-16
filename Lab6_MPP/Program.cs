using System;

namespace Lab6_MPP
{

    class Program
    {
        static void Main(string[] args)
        {
            var list_item = new DynamicList<string>();

            try
            {

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

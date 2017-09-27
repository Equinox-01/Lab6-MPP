using System;

namespace Lab6_MPP
{

    class Program
    {
        static void Main(string[] args)
        {
            var list_item = new DynamicList<Student>();
            list_item.Add(new Student("Станислав", 19, 3, "КСиС", "ПОИТ", true));
            list_item.Add(new Student("Иван", 20, 4, "КСиС", "ПОИТ", true));
            list_item.Add(new Student("Пётр", 19, 3, "КСиС", "ПОИТ", false));
            var uasya = new Student("Уася", 17, 1, "ФРЭ", "МНЭТиС", true);
            list_item.Add(uasya);
            foreach (var tmp in list_item)
            {
                Console.WriteLine(tmp.GetInfo());
            }
            try
            {
                Console.WriteLine("Сейчас в DynamicList находится " + list_item.Count + " элементов.");
                list_item.Remove(uasya);
                Console.WriteLine("Cейчас в DynamicList находится " + list_item.Count + " элементов.");
                list_item.RemoveAt(1);
                Console.WriteLine("Cейчас в DynamicList находится " + list_item.Count + " элементов.\n");
                list_item.Clear();
                Console.WriteLine("Cейчас в DynamicList находится " + list_item.Count + " элементов.");
            }
            catch (Exception e)
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

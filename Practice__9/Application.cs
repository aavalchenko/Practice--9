using System;
using InputOutputLib;

namespace Practice__9
{
    class Application
    {
        static void Main(string[] args)
        {
            El List = El.MakeList(Get.Int32("Введите количество элементов в списке: "));
            List.Print();
            List.Remove(Get.Int32("Введите удаляемый элемент: "));
            List.Print();
            Console.ReadKey();
        }
    }
}

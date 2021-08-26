using System;

namespace Task_3
{
    class Program
    {
        
        static void ClassTaker(MyClass @class)
        {
            @class.change = "Изменено";
            Console.WriteLine(@class.change);
        }
        static void StructTaker(MyStruct @struct)
        {
            @struct.change = "Изменено";
            Console.WriteLine(@struct.change);
        }

        static void Main(string[] args)
        {
            MyStruct @struct = new MyStruct();
            @struct.change = "Не изменено";
            Console.WriteLine(@struct.change);
            StructTaker(@struct);
            MyClass @class = new MyClass();
            @class.change = "Не изменено";
            Console.WriteLine(@class.change);
            ClassTaker(@class);



        }
    }
}

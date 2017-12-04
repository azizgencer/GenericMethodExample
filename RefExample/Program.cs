using System;

namespace GenericMethodExample
{
    class Program
    {
        static void Main()
        {
            Dummy dummy = new Dummy { Name = "Aziz" };
            Dummy2 dummy2 = new Dummy2();
            SetDummy(dummy);
            SetDummy(dummy2);

            Console.WriteLine($"Senin adın ve soyadın : {dummy.Name} {dummy.Surname}");
            Console.WriteLine($"Yaşın : {dummy2.Age}");
            Console.ReadLine();
        }

        public static T SetDummy<T>(T obj) where T : class
        {
            if (obj is Dummy)
            {
                var dummyObj = obj as Dummy;
                dummyObj.Surname = "GENCER";
            }
            else if (obj is Dummy2)
            {
                var dummy2Obj = obj as Dummy2;
                dummy2Obj.Age = 23;
            }

            return obj;
        }

        public class Dummy
        {
            public string Name { get; set; }
            public string Surname { get; set; }
        }

        public class Dummy2
        {
            public int Age { get; set; }
        }
    }
}

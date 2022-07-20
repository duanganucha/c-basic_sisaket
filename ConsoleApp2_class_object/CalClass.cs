namespace ConsoleApp2_class_object
{
    internal class CalClass
    {

        public int Cal1(int x, int y)
        {

            var z = x + y;
            return z;
        }

        public void PrintPt(string name, int age)
        {
            string pt = $"name {name} ,age {age} ปี";

            Console.WriteLine(pt);

        }


    }
}

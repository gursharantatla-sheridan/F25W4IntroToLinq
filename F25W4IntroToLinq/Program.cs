namespace F25W4IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 5, 6, 2, 1, 7, 8, 9, 5, 6, 7, 4 };

            // query syntax
            var greaterThan4 = from n in array
                               where n > 4
                               orderby n
                               select n;

            // method syntax
            greaterThan4 = array.Where(n => n > 4).OrderBy(n => n);

            foreach (var i in greaterThan4)
                Console.Write(i + " ");
            Console.WriteLine("\n\n\n\n");




            List<string> colors = new List<string>();
            colors.Add("bLuE");
            colors.Add("ruSt");
            colors.Add("GreeN");
            colors.Add("ReD");

            var startsWithR = from c in colors
                              let uppercaseColors = c.ToUpper()
                              where uppercaseColors.StartsWith("R")
                              orderby uppercaseColors
                              select uppercaseColors;

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            colors.Add("rUbY");
            colors.Add("PinK");

            // deferred execution
            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");



            List<Employee> employees = new List<Employee>()
            {
                new Employee("John", "Brown", 5000),
                new Employee("Anne", "Green", 7000),
                new Employee("James", "White", 4000),
                new Employee("Mary", "Indigo", 4500),
                new Employee("Alice", "Blue", 6000),
                new Employee("Bob", "Indigo", 3000)
            };


            foreach (var emp in employees)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");
        }
    }
}

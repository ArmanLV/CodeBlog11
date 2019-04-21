using System;

namespace CodeBlog11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаю данные
            Console.WriteLine("Введите имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите силу (от 0 до 100)");
            int Power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вес");
            int Weight = Convert.ToInt32(Console.ReadLine());
            
            // Задаю значения, используя перегрузку операторов
            var Person1 = new Swimmer(Name, Power, Weight);
            var Person2 = new Swimmer("Пётр", 40, 65);
            var Person3 = Person1 + Person2;
            var Person4 = Person1 - Person2;
            var Person5 = Person1 * Person2;
            var Person6 = Person1 / Person2;
            var Person7 = Person1 % Person2;
            var Person8 = Person1 == Person2;
            var Person9 = Person1 != Person2;
            var Person10 = Person1 > Person2;
            var Person11 = Person1 < Person2;
            
            // Вывожу значения
            Console.WriteLine($"{Person1.Name} {Person1.Power} {Person1.Weight}");
            Console.WriteLine($"{Person2.Name} {Person2.Power} {Person2.Weight}");
            Console.WriteLine($"{Person3.Name} {Person3.Power} {Person3.Weight}");
            Console.WriteLine($"{Person4.Name} {Person4.Power} {Person4.Weight}");
            Console.WriteLine($"{Person5.Name} {Person5.Power} {Person5.Weight}");
            Console.WriteLine($"{Person6.Name} {Person6.Power} {Person6.Weight}");
            Console.WriteLine($"{Person7.Name} {Person7.Power} {Person7.Weight}");
            Console.WriteLine(Person8);
            Console.WriteLine(Person9);
            Console.WriteLine(Person10);
            Console.WriteLine(Person11);
            Console.ReadLine();
        }
    }
}

using System;

namespace CodeBlog11
{
    public abstract class People // Общий абстрактный класс
    {
        // Обьявляю общие свойства
        public string Name { get; set; }
        public int Power { get; set; }
        public int Weight { get; set; }

        // Базовый конструктор с проверкой на входные данные
        public People(string name, int power, int weight)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new AggregateException(nameof(name));
            }
            if (power <= 0 || weight <= 0)
            {
                throw new ArgumentException("Данный параметр не может быть меньше нуля");
            }
            Name = name;
            Power = power;
            Weight = weight;
        }
        
        // Метод возвращающий имя 
        public override string ToString()
        {
            return Name;
        }
    }
}

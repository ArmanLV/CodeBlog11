using System;

namespace CodeBlog11
{
    public abstract class People
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Weight { get; set; }

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

        public override string ToString()
        {
            return Name;
        }
    }
}

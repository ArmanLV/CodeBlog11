using System;

namespace CodeBlog11
{
    class Swimmer : People
    {
        public Swimmer(string name, int power, int weight) : base(name, power, weight)
        {

        }

        public static Swimmer operator + (Swimmer SwimmerOne, Swimmer SwimmerTwo)
        {
            var SumPower = SwimmerOne.Power + SwimmerTwo.Power;
            var SumVeight = SwimmerOne.Weight + SwimmerTwo.Weight;
            return new Swimmer("Sum", SumPower, SumVeight);
        }

        public static Swimmer operator - (Swimmer SwimmerOne, Swimmer SwimmerTwo)
        {
            var MinusPower = SwimmerOne.Power - SwimmerTwo.Power;
            var MinusWeight = SwimmerOne.Weight - SwimmerTwo.Weight;
            return new Swimmer("Minus", MinusPower, MinusWeight);
        }
        public static Swimmer operator * (Swimmer SwimmerOne, Swimmer SwimmerTwo)
        {
            var MultiplyPower = SwimmerOne.Power * SwimmerTwo.Power;
            var MultiplyWeight = SwimmerOne.Weight * SwimmerTwo.Weight;
            return new Swimmer("Multiply", MultiplyPower, MultiplyWeight);
        }
        public static Swimmer operator / (Swimmer SwimmerOne, Swimmer SwimmerTwo)
        {
            var SharePower = SwimmerOne.Power / SwimmerTwo.Power;
            var ShareWeight = SwimmerOne.Weight / SwimmerTwo.Weight;
            return new Swimmer("Share", SharePower, ShareWeight);
        }
        public static Swimmer operator % (Swimmer SwimmerOne, Swimmer SwimmerTwo)
        {
            var RemainderPower = SwimmerOne.Power % SwimmerTwo.Power;
            var RemainderWeight = SwimmerOne.Weight % SwimmerTwo.Weight;
            return new Swimmer("Remainder", RemainderPower, RemainderWeight);
        }
        public static bool operator == (Swimmer SwimmerOne, Swimmer SwimmerTwo)
        {
            return SwimmerOne.Name == SwimmerTwo.Name;
        }
        public static bool operator != (Swimmer SwimmerOne, Swimmer SwimmerTwo)
        {
            return SwimmerOne.Name != SwimmerTwo.Name;
        }
        public static bool operator > (Swimmer SwimmerOne, Swimmer SwimmerTwo)
        {
            return SwimmerOne.Power > SwimmerTwo.Power;
        }
        public static bool operator < (Swimmer SwimmerOne, Swimmer SwimmerTwo)
        {
            return SwimmerOne.Power < SwimmerTwo.Power;
        }
    }
}

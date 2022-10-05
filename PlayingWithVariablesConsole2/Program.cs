using System;

namespace PlayingWithVariablesConsole2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declared and initialized a variable.
            // camelCase for the variable name.
            // explicit typing
            string spouseName = "Shannon"; 
            int spouseAge = 30;
            char nickName = 'S';
            bool lovesFashion = true;
            double highHeels = 20;
            decimal weight = 300.5m;

            
            // string interpolation with the $ and {} around variables
            Console.WriteLine($"My spouse's name is {spouseName}, her nickname is {nickName}. She is {spouseAge} years old and has {highHeels} pairs of high heels and it is {lovesFashion} that she loves fashion, which is why she has {weight} pounds of clothes.");

        }
    }
}

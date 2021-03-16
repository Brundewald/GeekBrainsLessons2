using System;



namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string statement;
            Console.WriteLine("Hi! This program will help you to calculate you Body Mass Index.\nEnter your weight in kg:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in meters:");
            double height = double.Parse(Console.ReadLine());
            double bmi = weight / Math.Pow(height, 2);
            statement = bmiCheck(bmi);
            Console.WriteLine($"Your BMI is {bmi:F2} that's {statement}.");
            loseWeightCalculator(statement, weight, height);
            Console.WriteLine($"Stay healthy! Goodbay!");
            Console.ReadKey();


        }

        private static void loseWeightCalculator(string statement, double weight, double height)
        {
            if (statement == "low") {
                double normalWeight = 25 * Math.Pow(height, 2);
                double loseWeight =  normalWeight - weight;
                Console.WriteLine($"You should gain {loseWeight:F2} kg.");
            }
            else if (statement == "high" || statement == "very high")
            {
                double normalWeight = 25 * Math.Pow(height, 2);
                double loseWeight = weight - normalWeight;
                Console.WriteLine($"You should lose {loseWeight:F2} kg.");
            }
            else Console.WriteLine("Your weight is fine.");
        }


        private static string bmiCheck(double bmi)
        {
            string statement;
            if (bmi < 18) statement = "low";
            else if (bmi >= 18 && bmi <= 25) statement = "normal";
            else if (bmi > 25 && bmi <= 30) statement = "high";
            else statement = "very high";
            return statement;
        }
    }
}

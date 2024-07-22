using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1");

            StoryTime();

            Console.WriteLine("Exercise 2");

           int added = Add(2, 3);
            Console.WriteLine(added);
            int subtracted = Subtract(7, 4);
            Console.WriteLine(subtracted);
            int product = Multiply(6, 3);
            Console.WriteLine(product);
            int quotient = Divide(6, 2);
            Console.WriteLine(quotient);
        }

        public static void StoryTime()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("I love that color too! Can you tell me what your favorite cryptid is?");
            string favCryptid = Console.ReadLine();
            Console.WriteLine("I see, interesting choice. What is your favorite instrument?");
            string favInstrument = Console.ReadLine();
            Console.WriteLine("Good choice! What is your favorite food?");
            string favFood = Console.ReadLine();
            Console.WriteLine("I could eat that all day! What is your favorite season?");
            string favSeason = Console.ReadLine();

            Console.WriteLine($"One beautiful {favSeason} day, {userName} went for a walk in the woods to have a picnic. He found a nice spot and sat down to eat some {favFood}. Suddenly {userName} heard music and looked up from his meal to see a {favColor} {favCryptid} playing the {favInstrument}!");
        }

        public static int Add(int numOne, int numTwo)
       {
       
            return numOne + numTwo;
       }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }


    }
}

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            StoryProgram();
        }

        public static void StoryProgram()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine($"There was a time when {name} was walking in the streets of New York \n" +
                              $"while wearing a {color} t-shirt. He saw his favorite band {band} in times square. \n" +
                              $"After that he was passing by the central park zoo and saw a {animal}. ");
            
            

        }
        
    }
}

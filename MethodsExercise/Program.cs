namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            StoryProgram();

            Console.WriteLine(Add(6, 8));
            Console.WriteLine(Subtract(10,5));
            Console.WriteLine(Multiply(14,2));
            Console.WriteLine(Divide(36,12));
            
            
            
            


        }
        


        //Story Program C#
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

            Console.WriteLine($"There was a time when {name} was walking in the streets of New York while wearing a {color} t-shirt.  \n" +
                              $"He saw his favorite band {band} in times square. \n" +
                              $"After that he was passing by the central park zoo and saw a {animal}. ");
            

        }
        
        //Math Operations Methods
        public static int Add(int a, int b)
        {
            return a + b;
        }
        
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        
        
        
        
       
        
        
        
    }
}

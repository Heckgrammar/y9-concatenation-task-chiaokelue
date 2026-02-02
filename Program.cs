namespace Y9ConcatenationTaskAGS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string SurName;
            int Age;
            Console.Write("Enter first name: ");
            FirstName = Console.ReadLine();
            Console.Write("Enter age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter last name: ");
            SurName = Console.ReadLine();

            // add two more variables for the users last name and their age
            // take these inputs into the program
            // use the test data Bob, Smith, 14
            // ammend this code to output in one command
            // Hello Bob Smith you are 14 years old
            Console.WriteLine("Hello, " + FirstName + " " + SurName + " you are " + Age + " years old.");
            // save and commit your program
            // add evidence of the test input and your own input running the program 
        }
    }
}

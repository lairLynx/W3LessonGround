namespace W3LessonGround;

/*
 * The purpose of this project is to show proof of the completion of the W3Schools C# Tutorial
 * It servers as proof of the lessons being completed, not the exercises, tests or exam. Those are proven by the certificate
 * This project will be uploaded to GitHub under the account lairLynx - account owner Vladut-Constantin Lazar
 */

class Program
{
    static void Main(string[] args)
    {
        // C# Syntax
        /*
        Console.WriteLine("Hello, World!");
        */

        //C# Output
        /*
        Console.WriteLine("Hello World!");
        Console.WriteLine("I am Learning C#");
        Console.WriteLine("It is awesome!");
        Console.WriteLine(3 + 3);
        Console.Write("Hello World! ");
        Console.Write("I will print on the same line.");
        */

        //C# Variables
        string name = "John";
        Console.WriteLine(name);

        int myNum = 15;
        Console.WriteLine(myNum);

        int myNum2;
        myNum2 = 15;
        Console.WriteLine(myNum2);
        myNum2 = 20; //change value of existing variable
        Console.WriteLine(myNum2);

        int myNum = 5;
        double myDoubleNum = 5.99D;
        char myLetter = 'D';
        bool myBool = true;
        string myText = "Hello";
    }
}
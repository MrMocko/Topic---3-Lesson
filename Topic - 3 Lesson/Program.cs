using System.Xml;

namespace Topic___3_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name, eyes, teeth, hair;
            int age, height, weight;
            name = " Max Thompson Jr";  
            age = 21;  // not a lie
            height = 73; // inches
            weight = 200;  // lbs
            eyes = "White";
            teeth = "decaying";
            hair = "Black";

            Console.WriteLine("Let's talk about" + name + ".");
            Console.WriteLine("He's " + height + " Inches tall, or " + Math.Round(73 * 2.54) + " centimeters tall  ");
            Console.WriteLine("He's " + weight + " lbs, or " + Math.Round(200 * 0.45) + " kilograms heavy ");
            Console.WriteLine("Acutally he's ginimonosaurus");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " Hair");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the trial.");
            Console.WriteLine("If i add " + age + " , " + height + " , and " + weight + " i get " + (age + height + weight) + ".");
            String myName = "Billy";
            Console.WriteLine(myName);
            myName = "HillBilly ";
            Console.WriteLine(myName);
            int myNumber = 15;
            myNumber = 20;
            Console.WriteLine(myNumber);
            double myHeight = 1.62;
            Console.WriteLine(myHeight);
            Console.WriteLine(myHeight + myNumber);
            Console.WriteLine(myNumber / 6);


        }
    }
}

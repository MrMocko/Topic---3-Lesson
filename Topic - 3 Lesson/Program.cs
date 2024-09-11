using System.Xml;

namespace Topic___3_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name, eyes, teeth, hair;
            int age, height, weight;
            name = "Max Thompson Jr";  
            age = 21;  // not a lie
            height = 73; // inches
            weight = 200;  // lbs
            eyes = "White";
            teeth = "decaying";
            hair = "Black";

            Console.WriteLine("Let's talk about" + name + ".");
            Console.WriteLine("He's " + height +  " Inches tall." + (73 + 4.49) + (" or  ";
            Console.WriteLine("He's " + weight + " pounds heavy.");
            Console.WriteLine("Acutally he's ginimonosaurus");
            Console.WriteLine("He's got" + eyes + " eyes and " + hair + " Hair");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the trial.");
            Console.WriteLine("If i add " + age + " , " + height + " , and " + weight + " i get " + (age + height + weight) + ".");
            Console.WriteLine();

        }
    }
}

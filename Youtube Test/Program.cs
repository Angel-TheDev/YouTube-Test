using System;

namespace Youtube_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge = 32;
            string characterName2 = "Mike";

            Console.WriteLine(characterName + " and " + characterName2 + " loved to go biking together");
            Console.WriteLine(characterName + " and " + characterName2 + " are both " + characterAge + ", and both are from Canada");
           
            // Note* If we wanted to change the Value halfway through the story we could just modify the Value.

            characterName = "Johnny";

            Console.WriteLine("John really liked his nickname " + characterName + " though, so for now on we'll call him " + characterName);

            Console.ReadLine();


            Console.ReadLine();


        }
    }
}

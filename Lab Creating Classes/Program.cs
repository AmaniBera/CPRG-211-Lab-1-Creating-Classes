using System.Xml.Linq;
using static Lab_Creating_Classes.Program;

namespace Lab_Creating_Classes
{
    
    internal class Program
    {
        public class Person
        {
            public int personId;
            public string firstName;
            public string lastName;
            public string favoriteColor;
            public int age;
            public bool isWorking;

            public string DisplayPersonInfo()
            {
                string Name = firstName + lastName;
                Console.WriteLine(personId + ": " + Name + "'s  favorite color is " + favoriteColor);
            }
            public string ChangeFavoriteColor()
            {
                favoriteColor = "White";
                return favoriteColor;
            }

            public int GetAgeInTenYears()
            {
                return age + 10;
            }
        }


        public static double CalculateAverageAge(params Person[] amountOfPersons)
        {
            if (amountOfPersons.Length == 0)
            {
                return 0;
            }

            double totalAgeSum = 0;

            foreach (var person in amountOfPersons)
            {
                totalAgeSum += person.age;
            }

            return totalAgeSum / amountOfPersons.Length;
        }

        static void Main(string[] args)
        {
            Person ian = new Person();
            ian.personId = 1;
            ian.firstName = "Ian";
            ian.lastName = "Brooks";
            ian.favoriteColor = "Red";
            ian.age = 30;
            ian.isWorking = true;

            Person gina = new Person();
            gina.personId = 2;
            gina.firstName = "Gina";
            gina.lastName = "James";
            gina.favoriteColor = "Green";
            gina.age = 18;
            gina.isWorking = false;

            Person mike = new Person();
            mike.personId = 3;
            mike.firstName = "Mike";
            mike.lastName = "Briscoe";
            mike.favoriteColor = "Blue";
            mike.age = 45;
            mike.isWorking = true;

            Person mary = new Person();
            mary.personId = 4;
            mary.firstName = "Mary";
            mary.lastName = "Beals";
            mary.favoriteColor = "Yellow";
            mary.age = 20;
            mary.isWorking = true;

            double averageAge = CalculateAverageAge(ian,gina,mike,mary);

            Console.WriteLine(DisplayPersonInfo(gina));

            int age10Years = GetAgeInTenYears();

            Console.WriteLine(averageAge);
            Console.ReadLine();
        }
    }
}

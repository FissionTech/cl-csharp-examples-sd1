using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLExamples.Examples
{
    public struct Height {
        public int Feet { get; set; }
        
        public float Inches { get; set; }

        public Height(int feet, float inches) {
            Feet = feet;
            Inches = inches;
        }
    }

    public enum Color {
        White,
        Brown,
        Blue,
        Red,
        Green,
        Orange,
        Yellow,
        Pink,
        Purple
    }

    public class Person {
        public string Name { get; set; }

        public Color EyeColor { get; set; }

        public Color HairColor { get; set; }

        public Height Height { get; set; }
    }

    public static class UserDefinedTypesExamples {

        public static void ChangingValueTypes() {
            Height person1Height = new Height(6, 0);
            Height person2Height = person1Height;

            person1Height.Feet = 5;

            Console.WriteLine($"Person 1 is {person1Height.Feet} feet and {person1Height.Inches} tall.");
            Console.WriteLine($"Person 2 is {person2Height.Feet} feet and {person2Height.Inches} tall.");
        }

        public static void ChangingReferenceTypes() {
            Person person1 = new Person() {
                Name = "Michael Lindsay",
                EyeColor = Color.Brown,
                HairColor = Color.Brown,
                Height = new Height(6, 0)
            };

            Person person2 = person1;

            person1.Name = "Ryan Huntbach";

            Console.WriteLine($"Person 1's name is {person1.Name}.");
            Console.WriteLine($"Person 2's name is {person2.Name}.");
        }

    }
}

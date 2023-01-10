using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLExamples.Examples
{
    class NameInfo {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public NameInfo(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() => FullName;
    }

    public static class ValueAndReferenceTypeExamples
    {
        public static void ValueTypeReassignment() {
            int age1 = 21;
            int age2 = age1;

            age1 = 40;

            // What is the value of age1 and age2 now?
            Console.WriteLine($"Age 1: {age1}, Age 2: {age2}");
        }

        public static void StringTypeReassignment() {
            /**
             * Even though strings are 'reference' types, their assignment works the same way as value types.
             **/
            string person1Name = "Michael Lindsay";
            string person2Name = person1Name;

            person1Name = "Ryan Huntbach";

            Console.WriteLine($"Person 1's name is: {person1Name}");
            Console.WriteLine($"Person 2's name is: {person2Name}");
        }

        public static void ReferenceTypeReassignment() {
            /**
             * However, when we create our own reference types, we see that things begin to change.
             **/
            NameInfo person1Name = new NameInfo("Michael", "Lindsay");
            NameInfo person2Name = person1Name;

            person1Name.FirstName = "Ryan";
            person2Name.LastName = "Huntbach";

            Console.WriteLine($"Person 1's name is: {person1Name}");
            Console.WriteLine($"Person 2's name is: {person2Name}");
        }
    }
}

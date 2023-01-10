using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLExamples.Examples
{
    public class NumberTypeExamples
    {

        public static void ByteExamples() {
            /**
             * There are two types of 'byte' values: sbyte for signed values, and byte for un-signed values.
             * Each byte is composed of 8 'bits' of data (a bit is either a 1 or a 0).
             * An sbyte can store values from -128 to +127.
             * A byte can store values from 0 to 255.
             **/

            byte numberOfHamburgersEaten = 129;
            byte numberOfHamburgersThrownAway = 250;

            Console.WriteLine($"Net # of hamburgers: {numberOfHamburgersEaten - numberOfHamburgersThrownAway}");

            // You can also use hexadecimal or binary to declare bytes. Hex literals are prefixed with '0x' and
            // binary literals must be prefixed with '0b'.
            byte hexByte = 0xff;
            byte binaryByte = 0b11111111;

            Console.WriteLine($"The base 10 value of the hex value 0xff is: {hexByte}");
            Console.WriteLine($"The base 10 value of the binary value 11111111 is {binaryByte}");

            // Challenge: Find out why each of the following lines of code are not valid.
            // sbyte signedByte = 240;
            // byte regularByte = -1;
            // byte subtractionResultByte = numberOfHamburgersEaten - numberOfHamburgersThrownAway
        }

        public static void OtherIntegerExamples() {
            /**
             * Because bytes are so small, we often use other integer types to store numbers. The following is a list of
             * ever other integer type in C#:
             * ushort: unsigned 16-bit integer
             * short:  signed 16-bit integer
             * uint:   unsigned 32-bit integer
             * int:    signed 32-bit integer
             * ulong:  unsigned 64-bit integer
             * long:   signed 64-bit integer
             **/

            int numDogs = 2;
            int numCats = 3;
            int numPets = numDogs + numCats;

            Console.WriteLine($"There are {numPets} pets.");

            /** 
             * When an operation happens that will cause an integer to exceed its' maximum value, it will 'overflow', or wrap around.
             * This is similar to a car's odometer rolling from 999999 back to 0 once it reaches one million miles.
             * A signed integer will wrap around to its smallest possible negative value, while an unsigned integer will wrap around to zero.
             **/
            int maximumInt = int.MaxValue;
            int overflowInt = maximumInt + 1;

            Console.WriteLine($"Uh-oh. There's been an integer overflow. The variable {nameof(overflowInt)} is: {overflowInt}");

            // Challenge: Determine the minimum and maximum values for each of the types listed at the start of the method.
        }
    }
}

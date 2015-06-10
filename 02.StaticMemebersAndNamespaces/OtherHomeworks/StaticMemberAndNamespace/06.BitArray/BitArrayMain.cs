/*Write a class BitArray that holds a bit sequence of integer numbers. It should support bit arrays of size between 1 and 100 000 bits. The number of bits is assigned when initializing the object. The class should support bit indexation (accessing and changing any bit at any position – e.g. num[2] = 0, num[867] = 1, etc.)
•	Override ToString() to print the number in decimal format. For example, we can create a BitArray object num with 8 bits (bits are 0 by default). We change the bit at position 7 to have a value of 1 (num[7] = 1) and print it on the console. The result is 128.
Tips: Write your own algorithm for binary-to-decimal conversion. Encapsulate all fields. Throw proper exceptions in case of improper input data or indexes, with descriptive messages.*/

namespace _06.BitArray
    {
    using System;

    public class BitArrayMain
        {
        public static void Main()
            {
            BitArray bitArray = new BitArray(100000);
            bitArray[1] = 1;
            bitArray[99999] = 1;
            Console.WriteLine(bitArray);
            }
        }
    }

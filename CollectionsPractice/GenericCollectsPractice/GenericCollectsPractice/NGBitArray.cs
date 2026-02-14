using System;
using System.Collections;
using System.Text;

namespace NonGenericCollectsPractice
{
    internal class NGBitArray
    {
        static void PrintBits(BitArray bits)
        {
            foreach(bool bit in  bits)
            {
                Console.Write( bit ? " 1, " : " 0, " );
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.WriteLine("BitArray");
            Console.WriteLine();

            BitArray bits = new BitArray(8);
            Console.WriteLine("Initial BitArray");
            PrintBits(bits);

            bits[0] = true;
            bits[3] = true;
            bits[5] = true;

            Console.WriteLine("After setting bits");
            PrintBits(bits);

            //access 1 bit
            Console.WriteLine("Bit at index 3: " + bits[3]);
            Console.WriteLine();
            Console.WriteLine("Bit at index 4: " + bits[4]);
            Console.WriteLine();

            // Count
            Console.WriteLine("Length: " + bits.Length);
            Console.WriteLine();

            //cloning bitarray
            BitArray cloned = (BitArray)bits.Clone();
            Console.WriteLine("Cloned bit array");
            PrintBits(cloned);

            //logic ops
            BitArray other = new BitArray(new bool[]
            { true, false, true, false, true, false, true, false });

            Console.WriteLine("New BitArray");
            PrintBits(other);

            //and op
            BitArray andResult = (BitArray)bits.Clone();
            andResult.And(other);
            Console.WriteLine("And result");
            PrintBits(andResult);

            // or op
            BitArray orResult = (BitArray)bits.Clone();
            orResult.Or(other);
            Console.WriteLine("Or Result");
            PrintBits(orResult);

            // xor op
            BitArray xorResult = (BitArray)bits.Clone();
            xorResult.Xor(other);
            Console.WriteLine("XOR Result");
            PrintBits(xorResult);

            // not op
            BitArray notResult = (BitArray)bits.Clone();
            notResult.Not();
            Console.WriteLine(" Not result");
            PrintBits(notResult);

            // Resize array
            Console.WriteLine("Resized to 12 bits");
            bits.Length = 12;
            PrintBits(bits);

        }
    }
}

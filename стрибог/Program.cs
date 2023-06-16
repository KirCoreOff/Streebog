using System.Text;

namespace Streebog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] inputBytes;
            bool outputSize, inputType;

            Console.Write("Enter text: ");
            inputBytes = Encoding.Default.GetBytes(Console.ReadLine());
            Console.Write("Type input (1 - text, 2 - HexCode): ");
            inputType = (Console.ReadLine() == "1") ? true : false;
            Console.Write("Output size (1 - 256 bits, 2 - 512 bits): ");
            outputSize = (Console.ReadLine() == "1") ? true : false;
            
            Console.WriteLine("\n");
            byte[] output = Streebog.HashFunc(inputBytes, outputSize, inputType);
            string hexCodes = BitConverter.ToString(output);
            Console.WriteLine($"HexCodes: {hexCodes}");
        }
    }
}
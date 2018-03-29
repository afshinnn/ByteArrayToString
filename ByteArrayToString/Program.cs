using System;

namespace ByteArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message(new byte[] { 1, 2, 3, 4 });

            Console.WriteLine(message);
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = enterText("Введите текст для шифрования: ");

            int keyNumber = enterNumber("Введите ключ: ");

            text = encode(text, keyNumber);
 
            Console.WriteLine("Зашифрованное сообщение: ");
            Console.WriteLine(text);

            text = decode(text, keyNumber);
           
            Console.WriteLine("Расшифровка: ");
            Console.WriteLine(text);
            Console.ReadKey();
        }

        static int enterNumber(string text)
        {
            int num = 0;

            do   
                Console.Write(text);
            while (!int.TryParse(Console.ReadLine(), out num));

            return num;
        }

        static string enterText(string text)
        {
            string result = null;

            do
                Console.WriteLine(text);               
            while ((result = Console.ReadLine().Trim()) == string.Empty);

            return result;
        }

        static string enterText2(string text)
        {
            Console.WriteLine(text);
            do
            {
                text = Console.ReadLine();
                if (text.Trim() == string.Empty)
                    Console.Write("Вы не ввели ни одного символа, введите текст: \n");
            }
            while (text.Trim() == string.Empty);

            return text;
        }

        static string cesar(string text, int key, bool decode = false)
        {
            char[] result = new char[text.Length];
            if (decode)
                key = -key;
            for (int i = 0; i < text.Length; i++)
            {
                result[i] = (char)(text[i] + key);                
            }
            return  new string(result);
        }

        static string encode(string text, int key)
        {
            return cesar(text, key);
        }

        static string decode(string text, int key)
        {
            return cesar(text, key, true);
        }
    }
}

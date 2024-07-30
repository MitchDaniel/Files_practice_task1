using System.IO;

namespace CSharp_Practice_modul_12_part_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parth = Convert.ToString(Console.ReadLine());
            try
            {
                if (!File.Exists(parth))
                {
                    throw new Exception("File not found");
                }
                string[] strings = File.ReadAllLines(parth);
                foreach (string s in strings)
                {

                    Console.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

//Задание 1:
//Приложение позволяет пользователю просматривать содержимое файла. Пользователь вводит путь к файлу. 
//Если файл существует, его содержимое отображается на экран. 
//Если файла не существует, нужно отобразить сообщение об ошибке.
using System;
using System.Collections.Generic;
using System.IO;

namespace KasperskyTest
{ /*
 * Есть класс, который занимается обработкой файлов разного формата (Html, Text, JSON …).
 * Предполагается, что будут добавляться новые форматы файлов. Напишите реализацию,
 * позволяющую расширять форматы обрабатываемых файлов. Детали обработки конкретного
 * содержимого файла неважны. Дополнительно, покройте реализацию тестами.
 */
    public class FileProcessor
    {
        private static readonly Dictionary<string, Action> ProcessMethod = new Dictionary<string, Action>()
        {
            {"txt", ProcessTxt},
            {"json", ProcessJson},
            {"html", ProcessHtml}
        };


        public void ProcessFile(string fileName)
        {
            string fileFormat = GetFileFormat(fileName);
            if (ProcessMethod.ContainsKey(fileFormat))
            {
                ProcessMethod[fileFormat].Invoke();
            }
            else
            {
                throw new Exception(
                    $"Ошибка с файлом: '{fileName}'\nНевозможно обработать данный формат: '{fileFormat}'");
            }
        }

        private string GetFileFormat(string fileName)
        {
            string fileFormat = "";
            if (fileName.Contains('.'))
                fileFormat = fileName.Substring(fileName.LastIndexOf('.') + 1);

            return fileFormat.ToLower();
        }

        private static void ProcessJson()
        {
            Console.WriteLine("Обработка Json");
            // очень
            // интересная
            // реализация
            
        }

        private static void ProcessTxt()
        {
            Console.WriteLine("Обработка Txt");
            // очень
            // интересная
            // реализация

        }

        private static void ProcessHtml()
        {
            Console.WriteLine("Обработка Html");
            // очень
            // интересная
            // реализация

        }
    }
}
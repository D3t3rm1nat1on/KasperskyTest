using System;
using System.Collections.Generic;

/*
 * Есть класс, который занимается обработкой файлов разного формата (Html, Text, JSON …).
 * Предполагается, что будут добавляться новые форматы файлов. Напишите реализацию,
 * позволяющую расширять форматы обрабатываемых файлов. Детали обработки конкретного
 * содержимого файла неважны. Дополнительно, покройте реализацию тестами.
 */
namespace KasperskyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = new[]
            {
                "html.html",
                "txt.txt",
                "json.json",
                "php.php"
            };
            
            FileProcessor processor = new FileProcessor();
            foreach (var file in files)
            {
                processor.ProcessFile(file);
            }
        }
    }
}
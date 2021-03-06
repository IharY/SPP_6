using System;


//Задание 6
/*Создать класс на языке C#, который:
Создать класс LogBuffer, который:
-представляет собой журнал строковых сообщений;
-предоставляет метод public void Add(string item);
-буферизирует добавляемые одиночные сообщения и записывает
их пачками в конец текстового файла на диске;
-периодически выполняет запись накопленных сообщений, когда
их количество достигает заданного предела;
-периодически выполняет запись накопленных сообщений по
истечение заданного интервала времени (вне зависимости от
наполнения буфера);
-выполняет запись накопленных сообщений асинхронно с
добавлением сообщений в буфер;*/

namespace SixthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            LogBuffer buf = new LogBuffer();
            for (var i = 0; i < 152; i++)
            {
                buf.Add(i.ToString());
            }
            buf.Close();
        }
    }
}
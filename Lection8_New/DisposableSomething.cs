using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lection8_New
{
    public class DisposableSomething : IDisposable
    {
        private StreamWriter _streamWriter;

        public DisposableSomething()
        {
            _streamWriter = new StreamWriter("123.txt");
        }

        public void WriteSomething(string data)
        {
            _streamWriter.WriteLine(data);
        }

        public void Close()
        {
            _streamWriter.Close();
        }

        public void Dispose()
        {
            _streamWriter.Dispose();
            Console.WriteLine("File disposed!");
        }
    }
}

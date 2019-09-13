using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufferedConsole
{
    class BufferedConsole : IDisposable
    {
        private StreamWriter streamWriter;
        private const int MaxBufferSize = 50;
        private char[] buffer;
        private int index;

        public BufferedConsole()
        {
            buffer = new char[MaxBufferSize];
            index = 0;
            streamWriter = new StreamWriter("Result.txt");
        }

        public void Write(string text)
        {
            if(text.Length + index >= MaxBufferSize)
            {
                string bufferString = new string(buffer.Take(index).ToArray());
                string result = bufferString + text;
                streamWriter.Write(result);
                index = 0;
                return;
            }
            foreach (char letter in text)
            {
                this.buffer[index++] = letter;
            }
        }
        public void Dispose()
        {
            streamWriter.Write(new string(buffer.Take(index).ToArray()));
            streamWriter.Close();
        }
    }
}

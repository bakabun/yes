using System;
using System.IO;
using System.Text;

public class Yes {
    public static void Main(string[] args) {
        const int MAX_BUF_SIZE = 65536;
        int _buffer = MAX_BUF_SIZE;
        string _input = args.Length > 0 ? args[0] : "y";
        StringBuilder _stringBuffer = new StringBuilder(1024, MAX_BUF_SIZE);
        while (_buffer > 0) {
            _stringBuffer.Append(_input).Append('\n');
            _buffer -= (_input.Length + 1);
        }

        using (BufferedStream _stream = new BufferedStream(Console.OpenStandardOutput())) {
            byte[] _byteBuffer = Encoding.ASCII.GetBytes(_stringBuffer.ToString());
            try {
                while (true) _stream.Write(_byteBuffer, 0, MAX_BUF_SIZE);
            } catch (IOException e) {
                Environment.Exit(1);
            }
        }
    }
}

using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class Test8
{
    public static void Print()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        {
            string pipeHandle = pipeServer.GetClientHandleAsString();

            Thread writerThread = new Thread(() => WriteData(pipeServer));
            Thread readerThread = new Thread(() => ReadData(pipeHandle));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
    }

    private static void WriteData(AnonymousPipeServerStream pipeServer)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipeServer))
            {
                writer.AutoFlush = true;
                Console.WriteLine("Writer thread started.");
                writer.WriteLine("Hello from writer thread!");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Write error: " + ex.Message);
        }
    }

    private static void ReadData(string pipeHandle)
    {
        try
        {
            using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeHandle))
            {
                using (StreamReader reader = new StreamReader(pipeClient))
                {
                    Console.WriteLine("Reader thread started.");
                    string message = reader.ReadLine();
                    Console.WriteLine("Received: " + message);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Read error: " + ex.Message);
        }
    }
}




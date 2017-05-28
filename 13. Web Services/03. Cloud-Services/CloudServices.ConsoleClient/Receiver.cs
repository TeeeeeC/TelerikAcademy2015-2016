namespace CloudServices.ConsoleClient
{
    using System;
    using System.Threading;

    using IronMQ;
    using IronMQ.Data;

    public class Receiver
    {
        private static void Main()
        {
            Client client = new Client("5643068273d0cd0006000007", "GkTDl7hOYke63lBeysep");
            Queue queue = client.Queue("Today's demo");
            
            Console.WriteLine("Listening for new messages from IronMQ server:");
            while (true)
            {
                Message msg = queue.Get();
                if (msg != null)
                {
                    Console.Write(client.Host + ": ");
                    Console.WriteLine(msg.Body);
                    queue.DeleteMessage(msg); 
                }
                Thread.Sleep(100);
            }
        }
    }
}

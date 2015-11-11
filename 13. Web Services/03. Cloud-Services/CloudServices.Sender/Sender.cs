namespace CloudServices.Sender
{
    using System;

    using IronMQ;

    public class Sender
    {
        private static void Main()
        {
            Client client = new Client("5643068273d0cd0006000007",
            "GkTDl7hOYke63lBeysep");

            Queue queue = client.Queue("Today's demo");
            Console.WriteLine("Enter messages to be sent to the IronMQ server:");
            while (true)
            {
                string msg = Console.ReadLine();
                queue.Push(msg);
                Console.WriteLine("Message sent to the IronMQ server.");
            }
        }
    }
}

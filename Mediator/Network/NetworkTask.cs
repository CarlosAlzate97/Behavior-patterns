using Mediator.Mediator;

namespace Mediator.Network
{
    public class NetworkTask
    {
        private readonly IMediator _mediator;

        public NetworkTask(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Run()
        {
            string[] messages = { "Connected", "Disconnected" };

            for(int i = 0; i < 6; i++)
            {
                _mediator.Notify(this, messages[new Random().Next(0,2)]);
            }
        }

        public void ChangeConnection()
        {
            Console.WriteLine("Network.ChangeConnection()");
        }

        public void SendDataToServer(string message)
        {
            Console.WriteLine($"SendDataToServer(): {message}");
        }
    }
}
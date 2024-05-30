using Mediator.Mediator;

namespace Mediator.Display
{
    public class DisplayTask
    {
        private readonly IMediator _mediator;

        public DisplayTask(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Run()
        {
            string[] messages = { "New Connection", "Get new data" };
            for (int i = 0; i < 4; i++)
            {
                _mediator.Notify(this, messages[i%2]);
            }
        }

        public void ShowValue(string message)
        {
            Console.WriteLine($"Display.ShowValue(): {message}");
        }

        public void ShowConnection(string message)
        {
            Console.WriteLine($"Display.ShowConnection(): {message}");
        }
    }
}
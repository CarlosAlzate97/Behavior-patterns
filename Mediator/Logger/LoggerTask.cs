using Mediator.Mediator;

namespace Mediator.Logger
{
    public class LoggerTask
    {
        private readonly IMediator _mediator;

        public LoggerTask(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Run()
        {
            string message = "New Sensor Data";

            for (int i = 0; i < 3; i++)
            {
                _mediator.Notify(this, message);
            }
        }

        public void GetNewData()
        {
            Console.WriteLine("LoggerTask.GetNewData()");
        }
    }
}
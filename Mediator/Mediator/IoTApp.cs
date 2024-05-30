using Mediator.Display;
using Mediator.Logger;
using Mediator.Network;

namespace Mediator.Mediator
{
    public class IoTApp : IMediator
    {
        private DisplayTask DisplayTask { get; set; }
        private LoggerTask LoggerTask { get; set; }
        private NetworkTask NetworkTask { get; set; }

        public IoTApp()
        {
            DisplayTask = new DisplayTask(this);
            LoggerTask = new LoggerTask(this);
            NetworkTask = new NetworkTask(this);
        }

        public void Notify(object sender, string message)
        {
            if (sender == DisplayTask)
                OnDisplayEvent(message);
            else if (sender == LoggerTask)
                OnLoggerEvent(message);
            else if (sender == NetworkTask)
                OnNetworkEvent(message);
        }

        public async void Run()
        {
            DisplayTask.Run();
            LoggerTask.Run();
            NetworkTask.Run();
        }

        private void OnDisplayEvent(string message)
        {
            if (message == "New Connection")
                NetworkTask.ChangeConnection();
            else if (message == "Get new data")
                LoggerTask.GetNewData();
        }

        private void OnLoggerEvent(string message)
        {
            if (message == "New Sensor Data")
            {
                DisplayTask.ShowValue(message);
                NetworkTask.SendDataToServer(message);
            }
        }

        private void OnNetworkEvent(string message)
        {
            if (message == "Connected" || message == "Disconnected")
            {
                DisplayTask.ShowConnection(message);
            }
        }
    }
}
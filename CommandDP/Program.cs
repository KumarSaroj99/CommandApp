using CommandDP.Models;

namespace CommandDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl control = new RemoteControl(new OffCommand(new Television()));
            control.PressButon();

            control = new RemoteControl(new OnCommand(new Television()));
            control.PressButon();
        }
    }
}

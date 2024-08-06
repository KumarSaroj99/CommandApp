using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP.Models
{
    internal class RemoteControl
    {
        ICommand command;
        public RemoteControl(ICommand command)
        {
            this.command = command;
        }
        public void PressButon()
        {
            command.Execute();
        }
    }
}

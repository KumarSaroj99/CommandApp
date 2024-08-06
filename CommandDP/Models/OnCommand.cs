using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP.Models
{
    internal class OnCommand : ICommand
    {
        private Television tv;
        public OnCommand(Television obj)
        {
            tv = obj;
        }
        public void Execute()
        {
            tv.On();
        }
    }
}

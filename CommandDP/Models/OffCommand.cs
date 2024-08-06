using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP.Models
{
    internal class OffCommand : ICommand
    {
        private Television tv;
        public OffCommand(Television obj)
        {
            tv= obj;
        }
        public void Execute()
        {
            tv.Off();
        }
    }
}

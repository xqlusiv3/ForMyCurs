using NPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.ControlsApp.OtherClass
{
    internal class Connection
    {
        public static NppcreateChihradzeContext connect { get; set; } = new NppcreateChihradzeContext();
    }
}

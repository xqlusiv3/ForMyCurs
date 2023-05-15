using NPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.ControlsApp.Main
{
    public class DbConnect
    {
        public static NppcreateChihradzeContext dbContext { get; set; } = new NppcreateChihradzeContext();
    }
}

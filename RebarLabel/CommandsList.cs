using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RebarLabel.Utils;

using Bentley.Interop.MicroStationDGN;
using Bentley.Interop.TFCom;
using Bentley.MicroStation.InteropServices;

namespace RebarLabel
{
    class CommandsList
    {
        public static Bentley.Interop.MicroStationDGN.Application app = Utilities.ComApp;

        public static void drawlabel(string unparsed)
        {
            app.CommandState.StartDefaultCommand();
            app.CommandState.StartPrimitive(LabelUtil.instance());
        }
        public static void modifylabel(string unparsed)
        {
            app.CommandState.StartDefaultCommand();
            app.CommandState.StartLocate(new ModifyUtil());
        }
    }
}

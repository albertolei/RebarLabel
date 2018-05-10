using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RebarLabel
{
    [Bentley.MicroStation.AddInAttribute(KeyinTree = "RebarLabel.commands.xml", MdlTaskID = "RebarLabel")]
    internal sealed class MyAddin : Bentley.MicroStation.AddIn
    {
        private MyAddin(System.IntPtr mdlDesc) : base(mdlDesc)
        {

        }
        protected override int Run(string[] commandLine)
        {
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bentley.Interop.MicroStationDGN;
using Bentley.Interop.TFCom;
using Bentley.MicroStation.InteropServices;

namespace RebarLabel.Utils
{
    class ModifyUtil : ILocateCommandEvents
    {
        private Application app = Utilities.ComApp;

        public void Accept(Element Element, ref Point3d Point, View View)
        {
            app.ShowCommand("");
            CellElement cell = Element.AsCellElement();
            TextNodeElement ctextnode = null;
            int nest_level = 0;
            while (cell.MoveToNextElement(false, ref nest_level))
            {
                Element current = cell.CopyCurrentElement();
                if (current.IsTextNodeElement())
                {
                    ctextnode = current.AsTextNodeElement();
                    int line_count = ctextnode.TextLinesCount;
                    string text = "";
                    for (int i = 1; i <= line_count; i++)
                    {
                        text += ctextnode.get_TextLine(i);
                        text += "\r\n";
                    }
                    text = text.Substring(0, text.Length - 2);
                    LabelModifyForm lmf = new LabelModifyForm(text);
                    if (lmf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)lmf.Controls.Find("content_textBox", false)[0];
                        text = textBox.Text;

                        TextNodeElement new_text_element = app.CreateTextNodeElement1(null, ctextnode.Origin, ctextnode.Rotation);
                        string[] lines = text.Split("\r\n".ToCharArray());
                        foreach (string line in lines)
                        {
                            new_text_element.AddTextLine(line);
                        }
                        cell.ReplaceCurrentElement(new_text_element);
                    }
                    break;
                }
            }
            cell.Rewrite();
            app.ShowPrompt("修改标注");
        }

        public void Cleanup()
        {

        }

        public void Dynamics(ref Point3d Point, View View, MsdDrawingMode DrawMode)
        {

        }

        public void LocateFailed()
        {
            app.ShowPrompt("选择标注");
        }

        public void LocateFilter(Element Element, ref Point3d Point, ref bool Accepted)
        {
            Accepted = false;
            if (Element.IsCellElement())
            {
                Accepted = true;
                app.ShowPrompt("接受单元元素");
            }
            else
            {
                app.ShowStatus("无效元素");
            }
        }

        public void LocateReset()
        {
            app.CommandState.StartDefaultCommand();
        }

        public void Start()
        {
            app.CommandState.EnableAccuSnap();
            app.ShowCommand("修改标注");
            app.ShowPrompt("选择标注");
        }
    }
}

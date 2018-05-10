using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bentley.Interop.MicroStationDGN;
using Bentley.Interop.TFCom;
using Bentley.MicroStation.InteropServices;

namespace RebarLabel.Utils
{
    class LabelUtil : IPrimitiveCommandEvents
    {
        private static Bentley.Interop.MicroStationDGN.Application app = Utilities.ComApp;
        public static LabelTextForm label_text_form = null;
        private static LabelUtil labelUtil = null;
        private bool ready = false;
        public string content = null;
        public Point3d current_point;
        
        private LabelUtil() { }
        public static LabelUtil instance()
        {
            if (labelUtil == null)
            {
                labelUtil = new LabelUtil();
            }
            if (label_text_form == null)
            {
                label_text_form = new LabelTextForm();
            }
            label_text_form.Show();
            return labelUtil;
        }

        public void Cleanup()
        {
            label_text_form.Hide();
        }

        public void DataPoint(ref Point3d Point, View View)
        {
            if (!ready)
            {
                current_point = Point;
                app.ShowPrompt("选择终点");
                ready = true;

            }
            else
            {
                if (current_point.X != Point.X)
                {
                    Point.X = current_point.X;
                }
                Element guide_line = create_line(current_point, Point);
                Element label = create_rebar_label(content);
                Range3d label_range = label.Range;
                Point3d down_left = label_range.Low, up_right = label_range.High;
                double line_length = up_right.Y - down_left.Y;
                Element line = create_line(line_length);
                if (current_point.Y < Point.Y)
                {
                    Point.Y = Point.Y + line_length;
                }
                label.Move(ref Point);
                line.Move(ref Point);
                
                
                List<Element> list = new List<Element>();
                list.Add(label);
                list.Add(line);
                list.Add(guide_line);

                //NamedGroupElement groupElement = app.ActiveModelReference.AddNewNamedGroup("标签1");
                //groupElement.AddMember(label);
                //groupElement.AddMember(line);
                //groupElement.AddMember(guide_line);
                CellElement cell = app.CreateCellElement1("标签1", list.ToArray(), Point);
                app.ActiveModelReference.AddElement(cell);
                //app.ActiveModelReference.AddElement((Element)groupElement);
                ready = false;
            }

        }

        public void Dynamics(ref Point3d Point, View View, MsdDrawingMode DrawMode)
        {
            if (!ready)
            {
                Element label = create_rebar_label(content);
                Range3d label_range = label.Range;
                Point3d down_left = label_range.Low, up_right = label_range.High;
                double line_length = up_right.Y - down_left.Y;
                Element line = create_line(line_length);
                label.Move(ref Point);
                line.Move(ref Point);
                List<Element> list = new List<Element>();
                list.Add(label);
                list.Add(line);
                CellElement cell = app.CreateCellElement1("标签", list.ToArray(), Point);
                cell.Redraw(DrawMode);
            }
            else
            {
                if (current_point.X != Point.X)
                {
                    Point.X = current_point.X;
                }
                Element guide_line = create_line(current_point, Point);
                Element label = create_rebar_label(content);
                Range3d label_range = label.Range;
                Point3d down_left = label_range.Low, up_right = label_range.High;
                double line_length = up_right.Y - down_left.Y;
                Element line = create_line(line_length);

                if (current_point.Y < Point.Y)
                {
                    Point.Y = Point.Y + line_length;
                }
                label.Move(Point);
                line.Move(Point);
                List<Element> list = new List<Element>();
                list.Add(label);
                list.Add(line);
                list.Add(guide_line);
                CellElement cell = app.CreateCellElement1("标签1", list.ToArray(), Point);
                cell.Redraw(DrawMode);
            }

        }

        public void Keyin(string Keyin)
        {

        }

        public void Reset()
        {
            app.CommandState.EnableAccuSnap();
            app.CommandState.StartDynamics();
            app.ShowCommand("添加标注");
            app.ShowPrompt("选择起点");
            if (ready == false)
            {
                label_text_form.Hide();
                app.CommandState.StartDefaultCommand();
            }
            ready = false;
        }

        public void Start()
        {
            app.CommandState.EnableAccuSnap();
            app.CommandState.StartDynamics();
            app.ShowCommand("添加标注");
            app.ShowPrompt("选择起点");
            ready = false;
        }

        public Element create_rebar_label(string text)
        {
            //string[] lines = text.Split("\r\n");
            //TextElement label = app.CreateTextElement1(null, text, app.Point3dZero(), app.Matrix3dZero());
            //TextStyle ts = app.ActiveDesignFile.TextStyles["宋体"];
            //label.TextStyle = ts;
            //TextNodeElement node = app.CreateTextNodeElement1(null, app.Point3dZero(), app.Matrix3dZero());
            //node.AddTextLine();
            //return label;
            string[] lines = text.Split("\r\n".ToCharArray());
            TextNodeElement node = app.CreateTextNodeElement1(null, app.Point3dZero(), app.Matrix3dFromRotationBetweenVectors(app.Point3dFromXYZ(0, 1, 0), app.Point3dFromXYZ(0,1,0)));
            foreach (string line in lines)
            {
                node.AddTextLine(line);
            }
            return node;
        }
        public Element create_line(double length)
        {
            Element line = app.CreateLineElement2(null, app.Point3dFromXYZ(0, 0, 0), app.Point3dFromXYZ(0, -length, 0));
            return line;
        }
        public Element create_line(Point3d start, Point3d end)
        {
            Element line = app.CreateLineElement2(null, start, end);
            return line;
        }
            
        private void getContent()
        {
            System.Windows.Forms.TextBox text_box = (System.Windows.Forms.TextBox)label_text_form.Controls.Find("content", true)[0];
            content = text_box.Text;
        }
    }
}

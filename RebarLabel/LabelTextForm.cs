using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RebarLabel.Utils;

using Bentley.Interop.MicroStationDGN;
using Bentley.Interop.TFCom;
using Bentley.MicroStation.InteropServices;
namespace RebarLabel
{
    public partial class LabelTextForm : Form
    {
        public LabelTextForm()
        {
            InitializeComponent();
        }
        private void content_TextChanged(object sender, EventArgs e)
        {
            LabelUtil label_util = LabelUtil.instance();
            label_util.content = this.content.Text;
        }
        private void LabelTextForm_Load(object sender, EventArgs e)
        {
            this.code_comboBox.SelectedIndex = 0;
            this.span_comboBox.SelectedIndex = 0;
            this.cantilever_comboBox.SelectedIndex = 1;
            this.direction_comboBox.SelectedIndex = 0;
            this.stirrup_comboBox.SelectedIndex = 0;
            this.diameter_comboBox.SelectedIndex = 0;
            this.longitudinal_comboBox.SelectedIndex = 0;
            this.longitudinal_diameter_comboBox.SelectedIndex = 0;
            this.side_comboBox.SelectedIndex = 0;
            this.side_diameter_comboBox.SelectedIndex = 0;
            this.side_grade_comboBox.SelectedIndex = 0;
        }
        private void set_content(object sender, EventArgs e)
        {
            string code = this.code_comboBox.SelectedItem == null ? "" : this.code_comboBox.SelectedItem.ToString();
            string num = this.num_textBox.Text;
            string span = this.span_comboBox.SelectedItem == null ? "" : this.span_comboBox.SelectedItem.ToString();
            string cantilever = this.cantilever_comboBox.SelectedItem == null ? "" : this.cantilever_comboBox.SelectedItem.ToString();
            string b = this.b_textBox.Text;
            string h = this.h_textBox.Text;
            string direction = this.direction_comboBox.SelectedItem == null ? "" : this.direction_comboBox.SelectedItem.ToString();
            string c1 = this.c1_textBox.Text;
            string c2 = this.c2_textBox.Text;

            string content = " " + code + "" + num + "(" + span + cantilever + ")" + " " + b + "×" + h + " " + direction + c1 + "×" + c2 + "\r\n";
            
            string stirrup = this.stirrup_comboBox.SelectedItem == null ? "" : this.stirrup_comboBox.SelectedItem.ToString();
            string grade = "";
            switch (stirrup)
            {
                case "HPB300":
                    grade = "";
                    break;
                case "HRB335":
                    grade = "";
                    break;
                case "HRBF335":
                    grade = "";
                    break;
                case "HRB400":
                    grade = "";
                    break;
                case "HRBF400":
                    grade = "";
                    break;
                case "RRB400":
                    grade = "";
                    break;
                case "HRB500":
                    grade = "";
                    break;
                case "HRBF500":
                    grade = "";
                    break;
            }
            string diameter = this.diameter_comboBox.SelectedItem == null ? "" : this.diameter_comboBox.SelectedItem.ToString();
            string densification = this.densification_textBox.Text;
            string other = this.other_textBox.Text;
            string leg_num = this.leg_number_textBox3.Text;
            content += grade + diameter + "@" + densification + "/" + other + "(" + leg_num + ")";

            string longitudinal = this.longitudinal_comboBox.SelectedItem == null ? "" : this.longitudinal_comboBox.SelectedItem.ToString();
            string longitudinal_grade = "";
            switch (longitudinal)
            {
                case "HPB300":
                    longitudinal_grade = "";
                    break;
                case "HRB335":
                    longitudinal_grade = "";
                    break;
                case "HRBF335":
                    longitudinal_grade = "";
                    break;
                case "HRB400":
                    longitudinal_grade = "";
                    break;
                case "HRBF400":
                    longitudinal_grade = "";
                    break;
                case "RRB400":
                    longitudinal_grade = "";
                    break;
                case "HRB500":
                    longitudinal_grade = "";
                    break;
                case "HRBF500":
                    longitudinal_grade = "";
                    break;
            }
            diameter = this.longitudinal_diameter_comboBox.SelectedItem == null ? "" : this.longitudinal_diameter_comboBox.SelectedItem.ToString();
            string longitudinal_num = this.longitudinal_num_textBox.Text;
            content += " " + longitudinal_num + longitudinal_grade + diameter + "\r\n";

            string side_type = this.side_comboBox.SelectedItem == null ? "" : this.side_comboBox.SelectedItem.ToString();
            string side_diameter = this.side_diameter_comboBox.SelectedItem == null ? "" : this.side_diameter_comboBox.SelectedItem.ToString();
            string side_num = this.side_num_textBox.Text;
            string side = this.side_grade_comboBox.SelectedItem == null ? "" : this.side_grade_comboBox.SelectedItem.ToString();
            string side_grade = "";
            switch (side)
            {
                case "HPB300":
                    side_grade = "";
                    break;
                case "HRB335":
                    side_grade = "";
                    break;
                case "HRBF335":
                    side_grade = "";
                    break;
                case "HRB400":
                    side_grade = "";
                    break;
                case "HRBF400":
                    side_grade = "";
                    break;
                case "RRB400":
                    side_grade = "";
                    break;
                case "HRB500":
                    side_grade = "";
                    break;
                case "HRBF500":
                    side_grade = "";
                    break;
            }
            content += " " + side_type + side_num + side_grade + side_diameter + "\r\n";
            string difference = this.difference_textBox.Text;
            content += " (" + difference + ")";
            this.content.Text = content;
        }

    }
}

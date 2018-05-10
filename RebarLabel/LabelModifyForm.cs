using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RebarLabel
{
    public partial class LabelModifyForm : Form
    {
        public LabelModifyForm()
        {
            InitializeComponent();
        }
        public LabelModifyForm(string text)
        {
            InitializeComponent();
            this.content_textBox.Text = text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = content_textBox.Text;
            int start_index = content_textBox.SelectionStart;
            string insert = "";
            switch (this.grade_comboBox.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    insert = "";
                    break;
                case 2:
                case 3:
                    insert += "";
                    break;
                case 4:
                case 5:
                case 6:
                    insert += "";
                    break;
                case 7:
                    insert += "";
                    break;
            }
            str = str.Insert(start_index, insert);
            content_textBox.Text = str;
            content_textBox.SelectionStart = start_index + 1;
            content_textBox.Focus();
        }

        private void LabelModifyForm_Load(object sender, EventArgs e)
        {
            this.grade_comboBox.SelectedIndex = 0;
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

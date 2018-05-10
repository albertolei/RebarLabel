namespace RebarLabel
{
    partial class LabelTextForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.code_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.span_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cantilever_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.b_textBox = new System.Windows.Forms.TextBox();
            this.h_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.c1_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.c2_textBox = new System.Windows.Forms.TextBox();
            this.direction_comboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.stirrup_comboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.diameter_comboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.densification_textBox = new System.Windows.Forms.TextBox();
            this.other_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.leg_number_textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.longitudinal_comboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.longitudinal_diameter_comboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.longitudinal_num_textBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.side_comboBox = new System.Windows.Forms.ComboBox();
            this.side_num_textBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.side_diameter_comboBox = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.side_grade_comboBox = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.difference_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(10, 10);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.content.Size = new System.Drawing.Size(265, 100);
            this.content.TabIndex = 0;
            this.content.TextChanged += new System.EventHandler(this.content_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "代号：";
            // 
            // code_comboBox
            // 
            this.code_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.code_comboBox.FormattingEnabled = true;
            this.code_comboBox.Items.AddRange(new object[] {
            "KL",
            "KBL",
            "WKL",
            "KZL",
            "TZL",
            "L",
            "XL",
            "JZL"});
            this.code_comboBox.Location = new System.Drawing.Point(48, 119);
            this.code_comboBox.Name = "code_comboBox";
            this.code_comboBox.Size = new System.Drawing.Size(80, 20);
            this.code_comboBox.TabIndex = 1;
            this.code_comboBox.SelectedIndexChanged += new System.EventHandler(this.set_content);
            this.code_comboBox.SelectedValueChanged += new System.EventHandler(this.set_content);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "序号：";
            // 
            // num_textBox
            // 
            this.num_textBox.Location = new System.Drawing.Point(194, 119);
            this.num_textBox.Name = "num_textBox";
            this.num_textBox.Size = new System.Drawing.Size(80, 21);
            this.num_textBox.TabIndex = 2;
            this.num_textBox.Text = "1";
            this.num_textBox.TextChanged += new System.EventHandler(this.set_content);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "跨数：";
            // 
            // span_comboBox
            // 
            this.span_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.span_comboBox.FormattingEnabled = true;
            this.span_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.span_comboBox.Location = new System.Drawing.Point(48, 150);
            this.span_comboBox.Name = "span_comboBox";
            this.span_comboBox.Size = new System.Drawing.Size(80, 20);
            this.span_comboBox.TabIndex = 3;
            this.span_comboBox.SelectedIndexChanged += new System.EventHandler(this.set_content);
            this.span_comboBox.SelectedValueChanged += new System.EventHandler(this.set_content);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "悬挑：";
            // 
            // cantilever_comboBox
            // 
            this.cantilever_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cantilever_comboBox.FormattingEnabled = true;
            this.cantilever_comboBox.Items.AddRange(new object[] {
            "",
            "A",
            "B"});
            this.cantilever_comboBox.Location = new System.Drawing.Point(194, 150);
            this.cantilever_comboBox.Name = "cantilever_comboBox";
            this.cantilever_comboBox.Size = new System.Drawing.Size(80, 20);
            this.cantilever_comboBox.TabIndex = 4;
            this.cantilever_comboBox.SelectedIndexChanged += new System.EventHandler(this.set_content);
            this.cantilever_comboBox.SelectedValueChanged += new System.EventHandler(this.set_content);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "b：";
            // 
            // b_textBox
            // 
            this.b_textBox.Location = new System.Drawing.Point(48, 180);
            this.b_textBox.Name = "b_textBox";
            this.b_textBox.Size = new System.Drawing.Size(80, 21);
            this.b_textBox.TabIndex = 5;
            this.b_textBox.Text = "400";
            this.b_textBox.TextChanged += new System.EventHandler(this.set_content);
            // 
            // h_textBox
            // 
            this.h_textBox.Location = new System.Drawing.Point(194, 180);
            this.h_textBox.Name = "h_textBox";
            this.h_textBox.Size = new System.Drawing.Size(80, 21);
            this.h_textBox.TabIndex = 6;
            this.h_textBox.Text = "800";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "h：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "c1：";
            // 
            // c1_textBox
            // 
            this.c1_textBox.Location = new System.Drawing.Point(48, 242);
            this.c1_textBox.Name = "c1_textBox";
            this.c1_textBox.Size = new System.Drawing.Size(80, 21);
            this.c1_textBox.TabIndex = 8;
            this.c1_textBox.Text = "100";
            this.c1_textBox.TextChanged += new System.EventHandler(this.set_content);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "c2：";
            // 
            // c2_textBox
            // 
            this.c2_textBox.Location = new System.Drawing.Point(194, 242);
            this.c2_textBox.Name = "c2_textBox";
            this.c2_textBox.Size = new System.Drawing.Size(80, 21);
            this.c2_textBox.TabIndex = 9;
            this.c2_textBox.Text = "50";
            this.c2_textBox.TextChanged += new System.EventHandler(this.set_content);
            // 
            // direction_comboBox
            // 
            this.direction_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.direction_comboBox.FormattingEnabled = true;
            this.direction_comboBox.Items.AddRange(new object[] {
            "Y",
            "PY"});
            this.direction_comboBox.Location = new System.Drawing.Point(48, 212);
            this.direction_comboBox.Name = "direction_comboBox";
            this.direction_comboBox.Size = new System.Drawing.Size(80, 20);
            this.direction_comboBox.TabIndex = 7;
            this.direction_comboBox.SelectedIndexChanged += new System.EventHandler(this.set_content);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "方向：";
            // 
            // stirrup_comboBox
            // 
            this.stirrup_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stirrup_comboBox.FormattingEnabled = true;
            this.stirrup_comboBox.Items.AddRange(new object[] {
            "HPB300",
            "HRB335",
            "HRBF335",
            "HRB400",
            "HRBF400",
            "RRB400",
            "HRB500",
            "HRBF500"});
            this.stirrup_comboBox.Location = new System.Drawing.Point(48, 275);
            this.stirrup_comboBox.Name = "stirrup_comboBox";
            this.stirrup_comboBox.Size = new System.Drawing.Size(80, 20);
            this.stirrup_comboBox.TabIndex = 11;
            this.stirrup_comboBox.SelectedIndexChanged += new System.EventHandler(this.set_content);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "箍筋：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "直径：";
            // 
            // diameter_comboBox
            // 
            this.diameter_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diameter_comboBox.FormattingEnabled = true;
            this.diameter_comboBox.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.diameter_comboBox.Location = new System.Drawing.Point(194, 275);
            this.diameter_comboBox.Name = "diameter_comboBox";
            this.diameter_comboBox.Size = new System.Drawing.Size(80, 20);
            this.diameter_comboBox.TabIndex = 11;
            this.diameter_comboBox.SelectedIndexChanged += new System.EventHandler(this.set_content);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "加密：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(142, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "非加密：";
            // 
            // densification_textBox
            // 
            this.densification_textBox.Location = new System.Drawing.Point(48, 307);
            this.densification_textBox.Name = "densification_textBox";
            this.densification_textBox.Size = new System.Drawing.Size(80, 21);
            this.densification_textBox.TabIndex = 13;
            this.densification_textBox.Text = "100";
            this.densification_textBox.TextChanged += new System.EventHandler(this.set_content);
            // 
            // other_textBox
            // 
            this.other_textBox.Location = new System.Drawing.Point(194, 307);
            this.other_textBox.Name = "other_textBox";
            this.other_textBox.Size = new System.Drawing.Size(80, 21);
            this.other_textBox.TabIndex = 14;
            this.other_textBox.Text = "200";
            this.other_textBox.TextChanged += new System.EventHandler(this.set_content);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "肢数：";
            // 
            // leg_number_textBox3
            // 
            this.leg_number_textBox3.Location = new System.Drawing.Point(48, 340);
            this.leg_number_textBox3.Name = "leg_number_textBox3";
            this.leg_number_textBox3.Size = new System.Drawing.Size(80, 21);
            this.leg_number_textBox3.TabIndex = 13;
            this.leg_number_textBox3.Text = "4";
            this.leg_number_textBox3.TextChanged += new System.EventHandler(this.set_content);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 21);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "2";
            this.textBox1.TextChanged += new System.EventHandler(this.set_content);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(142, 345);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 15;
            this.label15.Text = "非肢数：";
            // 
            // longitudinal_comboBox
            // 
            this.longitudinal_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.longitudinal_comboBox.FormattingEnabled = true;
            this.longitudinal_comboBox.Items.AddRange(new object[] {
            "HPB300",
            "HRB335",
            "HRBF335",
            "HRB400",
            "HRBF400",
            "RRB400",
            "HRB500",
            "HRBF500"});
            this.longitudinal_comboBox.Location = new System.Drawing.Point(48, 374);
            this.longitudinal_comboBox.Name = "longitudinal_comboBox";
            this.longitudinal_comboBox.Size = new System.Drawing.Size(80, 20);
            this.longitudinal_comboBox.TabIndex = 18;
            this.longitudinal_comboBox.SelectedIndexChanged += new System.EventHandler(this.set_content);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 17;
            this.label16.Text = "纵筋：";
            // 
            // longitudinal_diameter_comboBox
            // 
            this.longitudinal_diameter_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.longitudinal_diameter_comboBox.FormattingEnabled = true;
            this.longitudinal_diameter_comboBox.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "25",
            "28",
            "32",
            "36",
            "40"});
            this.longitudinal_diameter_comboBox.Location = new System.Drawing.Point(195, 374);
            this.longitudinal_diameter_comboBox.Name = "longitudinal_diameter_comboBox";
            this.longitudinal_diameter_comboBox.Size = new System.Drawing.Size(80, 20);
            this.longitudinal_diameter_comboBox.TabIndex = 20;
            this.longitudinal_diameter_comboBox.SelectedIndexChanged += new System.EventHandler(this.set_content);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(155, 378);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 19;
            this.label17.Text = "直径：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 411);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 10;
            this.label18.Text = "个数：";
            // 
            // longitudinal_num_textBox
            // 
            this.longitudinal_num_textBox.Location = new System.Drawing.Point(48, 407);
            this.longitudinal_num_textBox.Name = "longitudinal_num_textBox";
            this.longitudinal_num_textBox.Size = new System.Drawing.Size(80, 21);
            this.longitudinal_num_textBox.TabIndex = 13;
            this.longitudinal_num_textBox.Text = "2";
            this.longitudinal_num_textBox.TextChanged += new System.EventHandler(this.set_content);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 445);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 17;
            this.label19.Text = "侧面：";
            // 
            // side_comboBox
            // 
            this.side_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.side_comboBox.FormattingEnabled = true;
            this.side_comboBox.Items.AddRange(new object[] {
            "N",
            "G"});
            this.side_comboBox.Location = new System.Drawing.Point(48, 441);
            this.side_comboBox.Name = "side_comboBox";
            this.side_comboBox.Size = new System.Drawing.Size(80, 20);
            this.side_comboBox.TabIndex = 18;
            this.side_comboBox.SelectedIndexChanged += new System.EventHandler(this.set_content);
            // 
            // side_num_textBox
            // 
            this.side_num_textBox.Location = new System.Drawing.Point(48, 474);
            this.side_num_textBox.Name = "side_num_textBox";
            this.side_num_textBox.Size = new System.Drawing.Size(80, 21);
            this.side_num_textBox.TabIndex = 22;
            this.side_num_textBox.Text = "2";
            this.side_num_textBox.TextChanged += new System.EventHandler(this.set_content);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 478);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 21;
            this.label20.Text = "个数：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(155, 445);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 19;
            this.label21.Text = "直径：";
            // 
            // side_diameter_comboBox
            // 
            this.side_diameter_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.side_diameter_comboBox.FormattingEnabled = true;
            this.side_diameter_comboBox.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "25",
            "28",
            "32",
            "36",
            "40"});
            this.side_diameter_comboBox.Location = new System.Drawing.Point(195, 441);
            this.side_diameter_comboBox.Name = "side_diameter_comboBox";
            this.side_diameter_comboBox.Size = new System.Drawing.Size(80, 20);
            this.side_diameter_comboBox.TabIndex = 20;
            this.side_diameter_comboBox.SelectedIndexChanged += new System.EventHandler(this.set_content);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(155, 479);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 19;
            this.label22.Text = "等级：";
            // 
            // side_grade_comboBox
            // 
            this.side_grade_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.side_grade_comboBox.FormattingEnabled = true;
            this.side_grade_comboBox.Items.AddRange(new object[] {
            "HPB300",
            "HRB335",
            "HRBF335",
            "HRB400",
            "HRBF400",
            "RRB400",
            "HRB500",
            "HRBF500"});
            this.side_grade_comboBox.Location = new System.Drawing.Point(194, 475);
            this.side_grade_comboBox.Name = "side_grade_comboBox";
            this.side_grade_comboBox.Size = new System.Drawing.Size(80, 20);
            this.side_grade_comboBox.TabIndex = 20;
            this.side_grade_comboBox.SelectedIndexChanged += new System.EventHandler(this.set_content);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 512);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 12);
            this.label23.TabIndex = 21;
            this.label23.Text = "高差：";
            // 
            // difference_textBox
            // 
            this.difference_textBox.Location = new System.Drawing.Point(48, 508);
            this.difference_textBox.Name = "difference_textBox";
            this.difference_textBox.Size = new System.Drawing.Size(80, 21);
            this.difference_textBox.TabIndex = 22;
            this.difference_textBox.Text = "-0.05";
            this.difference_textBox.TextChanged += new System.EventHandler(this.set_content);
            // 
            // LabelTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 542);
            this.Controls.Add(this.difference_textBox);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.side_num_textBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.side_grade_comboBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.side_diameter_comboBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.longitudinal_diameter_comboBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.side_comboBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.longitudinal_comboBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.other_textBox);
            this.Controls.Add(this.longitudinal_num_textBox);
            this.Controls.Add(this.leg_number_textBox3);
            this.Controls.Add(this.densification_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.diameter_comboBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.stirrup_comboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.direction_comboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.c2_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.h_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.c1_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_textBox);
            this.Controls.Add(this.num_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cantilever_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.span_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.code_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LabelTextForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "标签文字";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LabelTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox code_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox span_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cantilever_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox b_textBox;
        private System.Windows.Forms.TextBox h_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox c1_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox c2_textBox;
        private System.Windows.Forms.ComboBox direction_comboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox stirrup_comboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox diameter_comboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox densification_textBox;
        private System.Windows.Forms.TextBox other_textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox leg_number_textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox longitudinal_comboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox longitudinal_diameter_comboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox longitudinal_num_textBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox side_comboBox;
        private System.Windows.Forms.TextBox side_num_textBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox side_diameter_comboBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox side_grade_comboBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox difference_textBox;
    }
}
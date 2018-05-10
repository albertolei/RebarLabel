namespace RebarLabel
{
    partial class LabelModifyForm
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
            this.content_textBox = new System.Windows.Forms.TextBox();
            this.grade_comboBox = new System.Windows.Forms.ComboBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // content_textBox
            // 
            this.content_textBox.AcceptsReturn = true;
            this.content_textBox.Location = new System.Drawing.Point(10, 10);
            this.content_textBox.Multiline = true;
            this.content_textBox.Name = "content_textBox";
            this.content_textBox.Size = new System.Drawing.Size(265, 100);
            this.content_textBox.TabIndex = 0;
            // 
            // grade_comboBox
            // 
            this.grade_comboBox.FormattingEnabled = true;
            this.grade_comboBox.Items.AddRange(new object[] {
            "等级",
            "HPB300",
            "HRB335",
            "HRBF335",
            "HRB400",
            "HRBF400",
            "RRB400",
            "HRB500",
            "HRBF500"});
            this.grade_comboBox.Location = new System.Drawing.Point(10, 120);
            this.grade_comboBox.Name = "grade_comboBox";
            this.grade_comboBox.Size = new System.Drawing.Size(120, 20);
            this.grade_comboBox.TabIndex = 1;
            this.grade_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(200, 118);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(75, 23);
            this.confirm_button.TabIndex = 2;
            this.confirm_button.Text = "确定";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // LabelModifyForm
            // 
            this.AcceptButton = this.confirm_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.grade_comboBox);
            this.Controls.Add(this.content_textBox);
            this.Name = "LabelModifyForm";
            this.Text = "LabelModifyForm";
            this.Load += new System.EventHandler(this.LabelModifyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox content_textBox;
        private System.Windows.Forms.ComboBox grade_comboBox;
        private System.Windows.Forms.Button confirm_button;
    }
}
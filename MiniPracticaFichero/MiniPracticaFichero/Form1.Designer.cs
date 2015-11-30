namespace MiniPracticaFichero
{
    partial class Form1
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
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.jobComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.v2outcomboBox = new System.Windows.Forms.ComboBox();
            this.v2comboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.v3outcomboBox = new System.Windows.Forms.ComboBox();
            this.v3comboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(35, 7);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(121, 21);
            this.raceComboBox.TabIndex = 0;
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceComboBox_SelectedIndexChanged);
            // 
            // jobComboBox
            // 
            this.jobComboBox.FormattingEnabled = true;
            this.jobComboBox.Location = new System.Drawing.Point(267, 7);
            this.jobComboBox.Name = "jobComboBox";
            this.jobComboBox.Size = new System.Drawing.Size(121, 21);
            this.jobComboBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.jobComboBox);
            this.panel1.Controls.Add(this.raceComboBox);
            this.panel1.Location = new System.Drawing.Point(42, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 37);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.v2outcomboBox);
            this.panel2.Controls.Add(this.v2comboBox);
            this.panel2.Location = new System.Drawing.Point(42, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 37);
            this.panel2.TabIndex = 3;
            // 
            // v2outcomboBox
            // 
            this.v2outcomboBox.FormattingEnabled = true;
            this.v2outcomboBox.Location = new System.Drawing.Point(267, 7);
            this.v2outcomboBox.Name = "v2outcomboBox";
            this.v2outcomboBox.Size = new System.Drawing.Size(121, 21);
            this.v2outcomboBox.TabIndex = 1;
            // 
            // v2comboBox
            // 
            this.v2comboBox.FormattingEnabled = true;
            this.v2comboBox.Location = new System.Drawing.Point(35, 7);
            this.v2comboBox.Name = "v2comboBox";
            this.v2comboBox.Size = new System.Drawing.Size(121, 21);
            this.v2comboBox.TabIndex = 0;
            this.v2comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.v3outcomboBox);
            this.panel3.Controls.Add(this.v3comboBox);
            this.panel3.Location = new System.Drawing.Point(43, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 37);
            this.panel3.TabIndex = 4;
            // 
            // v3outcomboBox
            // 
            this.v3outcomboBox.FormattingEnabled = true;
            this.v3outcomboBox.Location = new System.Drawing.Point(267, 7);
            this.v3outcomboBox.Name = "v3outcomboBox";
            this.v3outcomboBox.Size = new System.Drawing.Size(121, 21);
            this.v3outcomboBox.TabIndex = 1;
            // 
            // v3comboBox
            // 
            this.v3comboBox.FormattingEnabled = true;
            this.v3comboBox.Location = new System.Drawing.Point(35, 7);
            this.v3comboBox.Name = "v3comboBox";
            this.v3comboBox.Size = new System.Drawing.Size(121, 21);
            this.v3comboBox.TabIndex = 0;
            this.v3comboBox.SelectedIndexChanged += new System.EventHandler(this.v3comboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 306);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.ComboBox jobComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox v2outcomboBox;
        private System.Windows.Forms.ComboBox v2comboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox v3outcomboBox;
        private System.Windows.Forms.ComboBox v3comboBox;
    }
}


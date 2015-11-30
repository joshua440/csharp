namespace Magic
{
    partial class Form2
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.bddListBox = new System.Windows.Forms.ListBox();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(101, 226);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Todos",
            "Rojo",
            "Blanco",
            "Azul",
            "Negro",
            "Verde"});
            this.colorComboBox.Location = new System.Drawing.Point(12, 12);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(85, 21);
            this.colorComboBox.TabIndex = 2;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // bddListBox
            // 
            this.bddListBox.AllowDrop = true;
            this.bddListBox.DisplayMember = "name";
            this.bddListBox.FormattingEnabled = true;
            this.bddListBox.Location = new System.Drawing.Point(13, 67);
            this.bddListBox.Name = "bddListBox";
            this.bddListBox.Size = new System.Drawing.Size(109, 108);
            this.bddListBox.TabIndex = 3;
            this.bddListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // userListBox
            // 
            this.userListBox.AllowDrop = true;
            this.userListBox.DisplayMember = "name";
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(154, 67);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(118, 108);
            this.userListBox.TabIndex = 4;
            this.userListBox.ValueMember = "name";
            this.userListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "En Propiedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Disponibles";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.bddListBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.logoutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ListBox bddListBox;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
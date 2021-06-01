
namespace Contact_Tracer
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
            this.LstNameBox = new System.Windows.Forms.TextBox();
            this.LstNameLabel = new System.Windows.Forms.Label();
            this.FrstNameBox = new System.Windows.Forms.TextBox();
            this.FrstNameLabel = new System.Windows.Forms.Label();
            this.MidNameBox = new System.Windows.Forms.TextBox();
            this.MidNameLabel = new System.Windows.Forms.Label();
            this.btnOky = new System.Windows.Forms.Button();
            this.Reader = new System.Windows.Forms.Button();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.BrgyBox = new System.Windows.Forms.TextBox();
            this.ProvinceBox = new System.Windows.Forms.TextBox();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.brgyLabel = new System.Windows.Forms.Label();
            this.Instructions = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ListlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstNameBox
            // 
            this.LstNameBox.Location = new System.Drawing.Point(12, 12);
            this.LstNameBox.Name = "LstNameBox";
            this.LstNameBox.Size = new System.Drawing.Size(100, 22);
            this.LstNameBox.TabIndex = 0;
            // 
            // LstNameLabel
            // 
            this.LstNameLabel.AutoSize = true;
            this.LstNameLabel.Location = new System.Drawing.Point(26, 37);
            this.LstNameLabel.Name = "LstNameLabel";
            this.LstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.LstNameLabel.TabIndex = 1;
            this.LstNameLabel.Text = "Last Name";
            // 
            // FrstNameBox
            // 
            this.FrstNameBox.Location = new System.Drawing.Point(118, 12);
            this.FrstNameBox.Name = "FrstNameBox";
            this.FrstNameBox.Size = new System.Drawing.Size(100, 22);
            this.FrstNameBox.TabIndex = 1;
            // 
            // FrstNameLabel
            // 
            this.FrstNameLabel.AutoSize = true;
            this.FrstNameLabel.Location = new System.Drawing.Point(131, 37);
            this.FrstNameLabel.Name = "FrstNameLabel";
            this.FrstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.FrstNameLabel.TabIndex = 3;
            this.FrstNameLabel.Text = "First Name";
            // 
            // MidNameBox
            // 
            this.MidNameBox.Location = new System.Drawing.Point(224, 12);
            this.MidNameBox.Name = "MidNameBox";
            this.MidNameBox.Size = new System.Drawing.Size(100, 22);
            this.MidNameBox.TabIndex = 2;
            // 
            // MidNameLabel
            // 
            this.MidNameLabel.AutoSize = true;
            this.MidNameLabel.Location = new System.Drawing.Point(231, 37);
            this.MidNameLabel.Name = "MidNameLabel";
            this.MidNameLabel.Size = new System.Drawing.Size(90, 17);
            this.MidNameLabel.TabIndex = 5;
            this.MidNameLabel.Text = "Middle Name";
            // 
            // btnOky
            // 
            this.btnOky.Location = new System.Drawing.Point(12, 415);
            this.btnOky.Name = "btnOky";
            this.btnOky.Size = new System.Drawing.Size(112, 23);
            this.btnOky.TabIndex = 8;
            this.btnOky.Text = "Ok";
            this.btnOky.UseVisualStyleBackColor = true;
            this.btnOky.Click += new System.EventHandler(this.btnOky_Click);
            // 
            // Reader
            // 
            this.Reader.Location = new System.Drawing.Point(212, 415);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(112, 23);
            this.Reader.TabIndex = 9;
            this.Reader.Text = "Read Data";
            this.Reader.UseVisualStyleBackColor = true;
            this.Reader.Click += new System.EventHandler(this.Reader_Click);
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(12, 57);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(100, 22);
            this.AgeBox.TabIndex = 4;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(118, 62);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(33, 17);
            this.AgeLabel.TabIndex = 8;
            this.AgeLabel.Text = "Age";
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(118, 85);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(100, 22);
            this.CityBox.TabIndex = 6;
            // 
            // BrgyBox
            // 
            this.BrgyBox.Location = new System.Drawing.Point(12, 85);
            this.BrgyBox.Name = "BrgyBox";
            this.BrgyBox.Size = new System.Drawing.Size(100, 22);
            this.BrgyBox.TabIndex = 5;
            // 
            // ProvinceBox
            // 
            this.ProvinceBox.Location = new System.Drawing.Point(224, 85);
            this.ProvinceBox.Name = "ProvinceBox";
            this.ProvinceBox.Size = new System.Drawing.Size(100, 22);
            this.ProvinceBox.TabIndex = 7;
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Location = new System.Drawing.Point(243, 110);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(63, 17);
            this.provinceLabel.TabIndex = 12;
            this.provinceLabel.Text = "Province";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(152, 110);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 17);
            this.cityLabel.TabIndex = 13;
            this.cityLabel.Text = "City";
            // 
            // brgyLabel
            // 
            this.brgyLabel.AutoSize = true;
            this.brgyLabel.Location = new System.Drawing.Point(29, 110);
            this.brgyLabel.Name = "brgyLabel";
            this.brgyLabel.Size = new System.Drawing.Size(69, 17);
            this.brgyLabel.TabIndex = 14;
            this.brgyLabel.Text = "Barangay";
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Location = new System.Drawing.Point(45, 217);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(246, 17);
            this.Instructions.TabIndex = 16;
            this.Instructions.Text = "Type the name of the person to track.";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ListlistBox
            // 
            this.ListlistBox.FormattingEnabled = true;
            this.ListlistBox.ItemHeight = 16;
            this.ListlistBox.Location = new System.Drawing.Point(12, 57);
            this.ListlistBox.Name = "ListlistBox";
            this.ListlistBox.Size = new System.Drawing.Size(312, 356);
            this.ListlistBox.TabIndex = 18;
            this.ListlistBox.Visible = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.Reader);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.brgyLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.provinceLabel);
            this.Controls.Add(this.ProvinceBox);
            this.Controls.Add(this.BrgyBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.btnOky);
            this.Controls.Add(this.MidNameLabel);
            this.Controls.Add(this.MidNameBox);
            this.Controls.Add(this.FrstNameLabel);
            this.Controls.Add(this.FrstNameBox);
            this.Controls.Add(this.LstNameLabel);
            this.Controls.Add(this.LstNameBox);
            this.Controls.Add(this.ListlistBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LstNameBox;
        private System.Windows.Forms.Label LstNameLabel;
        private System.Windows.Forms.TextBox FrstNameBox;
        private System.Windows.Forms.Label FrstNameLabel;
        private System.Windows.Forms.TextBox MidNameBox;
        private System.Windows.Forms.Label MidNameLabel;
        private System.Windows.Forms.Button btnOky;
        private System.Windows.Forms.Button Reader;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox BrgyBox;
        private System.Windows.Forms.TextBox ProvinceBox;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label brgyLabel;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox ListlistBox;
    }
}


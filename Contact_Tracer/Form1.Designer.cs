
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
            this.btnOky.TabIndex = 4;
            this.btnOky.Text = "Ok";
            this.btnOky.UseVisualStyleBackColor = true;
            this.btnOky.Click += new System.EventHandler(this.btnOky_Click);
            // 
            // Reader
            // 
            this.Reader.Location = new System.Drawing.Point(209, 415);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(112, 23);
            this.Reader.TabIndex = 6;
            this.Reader.Text = "Read Data";
            this.Reader.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.Reader);
            this.Controls.Add(this.btnOky);
            this.Controls.Add(this.MidNameLabel);
            this.Controls.Add(this.MidNameBox);
            this.Controls.Add(this.FrstNameLabel);
            this.Controls.Add(this.FrstNameBox);
            this.Controls.Add(this.LstNameLabel);
            this.Controls.Add(this.LstNameBox);
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
    }
}


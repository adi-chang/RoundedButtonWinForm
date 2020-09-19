namespace RoundedButtonWinForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.roundedButton1 = new RoundedButtonWinForm.RoundedButton();
            this.circleButton1 = new RoundedButtonWinForm.CircleButton();
            this.roundedButton21 = new RoundedButtonWinForm.RoundedButton2();
            this.roundedButton31 = new RoundedButtonWinForm.RoundedButton3();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Me";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.AliceBlue;
            this.roundedButton1.Location = new System.Drawing.Point(149, 104);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(166, 48);
            this.roundedButton1.TabIndex = 2;
            this.roundedButton1.Text = "Click Me";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.ForeColor = System.Drawing.Color.AliceBlue;
            this.circleButton1.Location = new System.Drawing.Point(381, 214);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(80, 80);
            this.circleButton1.TabIndex = 1;
            this.circleButton1.Text = "Click Me";
            this.circleButton1.UseVisualStyleBackColor = false;
            this.circleButton1.Click += new System.EventHandler(this.circleButton1_Click);
            // 
            // roundedButton21
            // 
            this.roundedButton21.BackColor = System.Drawing.Color.SeaGreen;
            this.roundedButton21.BorderColor = System.Drawing.Color.Black;
            this.roundedButton21.BorderDownColor = System.Drawing.Color.Red;
            this.roundedButton21.BorderDownWidth = 2F;
            this.roundedButton21.BorderOverColor = System.Drawing.Color.Blue;
            this.roundedButton21.BorderOverWidth = 2F;
            this.roundedButton21.BorderRadius = 50;
            this.roundedButton21.BorderWidth = 1.75F;
            this.roundedButton21.ForeColor = System.Drawing.Color.White;
            this.roundedButton21.Location = new System.Drawing.Point(12, 254);
            this.roundedButton21.Name = "roundedButton21";
            this.roundedButton21.Size = new System.Drawing.Size(148, 40);
            this.roundedButton21.TabIndex = 3;
            this.roundedButton21.Text = "Click On Me";
            this.roundedButton21.UseVisualStyleBackColor = false;
            this.roundedButton21.Click += new System.EventHandler(this.roundedButton21_Click);
            // 
            // roundedButton31
            // 
            this.roundedButton31.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.roundedButton31.ButtonColor = System.Drawing.Color.Red;
            this.roundedButton31.FlatAppearance.BorderSize = 0;
            this.roundedButton31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton31.Location = new System.Drawing.Point(318, 12);
            this.roundedButton31.Name = "roundedButton31";
            this.roundedButton31.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundedButton31.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundedButton31.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundedButton31.Size = new System.Drawing.Size(143, 36);
            this.roundedButton31.TabIndex = 4;
            this.roundedButton31.Text = "Click On Me";
            this.roundedButton31.TextColor = System.Drawing.Color.White;
            this.roundedButton31.UseVisualStyleBackColor = true;
            this.roundedButton31.Click += new System.EventHandler(this.roundedButton31_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(473, 306);
            this.Controls.Add(this.roundedButton31);
            this.Controls.Add(this.roundedButton21);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.circleButton1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForm Button - Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private CircleButton circleButton1;
        private RoundedButton roundedButton1;
        private RoundedButton2 roundedButton21;
        private RoundedButton3 roundedButton31;
    }
}


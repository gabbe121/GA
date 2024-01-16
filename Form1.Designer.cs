
namespace Tastify
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
            this.Middag = new System.Windows.Forms.Button();
            this.Frukost = new System.Windows.Forms.Button();
            this.Lunch = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Middag
            // 
            this.Middag.BackColor = System.Drawing.Color.SteelBlue;
            this.Middag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Middag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Middag.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Middag.ForeColor = System.Drawing.Color.Black;
            this.Middag.Location = new System.Drawing.Point(1408, 458);
            this.Middag.Name = "Middag";
            this.Middag.Size = new System.Drawing.Size(297, 328);
            this.Middag.TabIndex = 0;
            this.Middag.Text = "Middag";
            this.Middag.UseVisualStyleBackColor = false;
            this.Middag.Click += new System.EventHandler(this.Middag_Click);
            // 
            // Frukost
            // 
            this.Frukost.BackColor = System.Drawing.Color.SteelBlue;
            this.Frukost.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Frukost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Frukost.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frukost.ForeColor = System.Drawing.Color.Black;
            this.Frukost.Location = new System.Drawing.Point(614, 458);
            this.Frukost.Name = "Frukost";
            this.Frukost.Size = new System.Drawing.Size(297, 328);
            this.Frukost.TabIndex = 1;
            this.Frukost.Text = "Frukost";
            this.Frukost.UseVisualStyleBackColor = false;
            this.Frukost.Click += new System.EventHandler(this.Frukost_Click);
            // 
            // Lunch
            // 
            this.Lunch.BackColor = System.Drawing.Color.SteelBlue;
            this.Lunch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Lunch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lunch.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lunch.ForeColor = System.Drawing.Color.Black;
            this.Lunch.Location = new System.Drawing.Point(1017, 458);
            this.Lunch.Name = "Lunch";
            this.Lunch.Size = new System.Drawing.Size(297, 328);
            this.Lunch.TabIndex = 3;
            this.Lunch.Text = "Lunch";
            this.Lunch.UseVisualStyleBackColor = false;
            this.Lunch.Click += new System.EventHandler(this.Lunch_Click);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.SteelBlue;
            this.Logo.Location = new System.Drawing.Point(1557, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(346, 117);
            this.Logo.TabIndex = 4;
            this.Logo.Text = "TastiFy";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(614, 864);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 127);
            this.button1.TabIndex = 5;
            this.button1.Text = "Se alla recept";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1017, 864);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 127);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kylskåp";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Lunch);
            this.Controls.Add(this.Frukost);
            this.Controls.Add(this.Middag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Middag;
        private System.Windows.Forms.Button Frukost;
        private System.Windows.Forms.Button Lunch;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


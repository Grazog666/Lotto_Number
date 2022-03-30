
namespace Lotto_Number
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RNGSpin = new System.Windows.Forms.Button();
            this.RngExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lotto4 = new System.Windows.Forms.TextBox();
            this.Lotto3 = new System.Windows.Forms.TextBox();
            this.Lotto1 = new System.Windows.Forms.TextBox();
            this.Lotto5 = new System.Windows.Forms.TextBox();
            this.Lotto6 = new System.Windows.Forms.TextBox();
            this.Lotto2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // RNGSpin
            // 
            this.RNGSpin.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RNGSpin.Location = new System.Drawing.Point(176, 373);
            this.RNGSpin.Name = "RNGSpin";
            this.RNGSpin.Size = new System.Drawing.Size(133, 51);
            this.RNGSpin.TabIndex = 0;
            this.RNGSpin.Text = "Spin";
            this.RNGSpin.UseVisualStyleBackColor = true;
            this.RNGSpin.Click += new System.EventHandler(this.RNGSpin_Click);
            // 
            // RngExit
            // 
            this.RngExit.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RngExit.Location = new System.Drawing.Point(451, 373);
            this.RngExit.Name = "RngExit";
            this.RngExit.Size = new System.Drawing.Size(132, 51);
            this.RngExit.TabIndex = 1;
            this.RngExit.Text = "Exit";
            this.RngExit.UseVisualStyleBackColor = true;
            this.RngExit.Click += new System.EventHandler(this.RngExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "RandomNumGen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lotto4
            // 
            this.Lotto4.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lotto4.Location = new System.Drawing.Point(34, 221);
            this.Lotto4.Multiline = true;
            this.Lotto4.Name = "Lotto4";
            this.Lotto4.Size = new System.Drawing.Size(109, 109);
            this.Lotto4.TabIndex = 3;
            this.Lotto4.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lotto3
            // 
            this.Lotto3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lotto3.Location = new System.Drawing.Point(176, 146);
            this.Lotto3.Multiline = true;
            this.Lotto3.Name = "Lotto3";
            this.Lotto3.Size = new System.Drawing.Size(109, 109);
            this.Lotto3.TabIndex = 4;
            // 
            // Lotto1
            // 
            this.Lotto1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lotto1.Location = new System.Drawing.Point(324, 70);
            this.Lotto1.Multiline = true;
            this.Lotto1.Name = "Lotto1";
            this.Lotto1.Size = new System.Drawing.Size(109, 109);
            this.Lotto1.TabIndex = 5;
            // 
            // Lotto5
            // 
            this.Lotto5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lotto5.Location = new System.Drawing.Point(324, 221);
            this.Lotto5.Multiline = true;
            this.Lotto5.Name = "Lotto5";
            this.Lotto5.Size = new System.Drawing.Size(109, 109);
            this.Lotto5.TabIndex = 6;
            this.Lotto5.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Lotto6
            // 
            this.Lotto6.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lotto6.Location = new System.Drawing.Point(628, 221);
            this.Lotto6.Multiline = true;
            this.Lotto6.Name = "Lotto6";
            this.Lotto6.Size = new System.Drawing.Size(109, 109);
            this.Lotto6.TabIndex = 7;
            this.Lotto6.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Lotto2
            // 
            this.Lotto2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lotto2.Location = new System.Drawing.Point(474, 146);
            this.Lotto2.Multiline = true;
            this.Lotto2.Name = "Lotto2";
            this.Lotto2.Size = new System.Drawing.Size(109, 109);
            this.Lotto2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lotto2);
            this.Controls.Add(this.Lotto6);
            this.Controls.Add(this.Lotto5);
            this.Controls.Add(this.Lotto1);
            this.Controls.Add(this.Lotto3);
            this.Controls.Add(this.Lotto4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RngExit);
            this.Controls.Add(this.RNGSpin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RNGSpin;
        private System.Windows.Forms.Button RngExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lotto4;
        private System.Windows.Forms.TextBox Lotto3;
        private System.Windows.Forms.TextBox Lotto1;
        private System.Windows.Forms.TextBox Lotto5;
        private System.Windows.Forms.TextBox Lotto6;
        private System.Windows.Forms.TextBox Lotto2;
        private System.Windows.Forms.Timer timer1;
    }
}


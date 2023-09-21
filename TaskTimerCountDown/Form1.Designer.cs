namespace TaskTimerCountDown
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Timer1 = new System.Windows.Forms.CheckBox();
            this.l_Timer1 = new System.Windows.Forms.Label();
            this.tb_Hours = new System.Windows.Forms.TextBox();
            this.l_Hours = new System.Windows.Forms.Label();
            this.l_Minutes = new System.Windows.Forms.Label();
            this.tb_Minutes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.l_For = new System.Windows.Forms.Label();
            this.tb_For = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Timer Count Down";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Timer1);
            this.groupBox1.Controls.Add(this.l_Timer1);
            this.groupBox1.Location = new System.Drawing.Point(370, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timers";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_Timer1
            // 
            this.cb_Timer1.AutoSize = true;
            this.cb_Timer1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cb_Timer1.Location = new System.Drawing.Point(11, 66);
            this.cb_Timer1.Name = "cb_Timer1";
            this.cb_Timer1.Size = new System.Drawing.Size(110, 22);
            this.cb_Timer1.TabIndex = 9;
            this.cb_Timer1.Text = "cb_Timer1";
            this.cb_Timer1.UseVisualStyleBackColor = true;
            // 
            // l_Timer1
            // 
            this.l_Timer1.AutoSize = true;
            this.l_Timer1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Timer1.Location = new System.Drawing.Point(7, 29);
            this.l_Timer1.Name = "l_Timer1";
            this.l_Timer1.Size = new System.Drawing.Size(74, 22);
            this.l_Timer1.TabIndex = 8;
            this.l_Timer1.Text = "Timer1";
            // 
            // tb_Hours
            // 
            this.tb_Hours.Location = new System.Drawing.Point(186, 172);
            this.tb_Hours.Name = "tb_Hours";
            this.tb_Hours.Size = new System.Drawing.Size(100, 20);
            this.tb_Hours.TabIndex = 2;
            // 
            // l_Hours
            // 
            this.l_Hours.AutoSize = true;
            this.l_Hours.Location = new System.Drawing.Point(145, 175);
            this.l_Hours.Name = "l_Hours";
            this.l_Hours.Size = new System.Drawing.Size(38, 13);
            this.l_Hours.TabIndex = 3;
            this.l_Hours.Text = "Hours:";
            this.l_Hours.Click += new System.EventHandler(this.label3_Click);
            // 
            // l_Minutes
            // 
            this.l_Minutes.AutoSize = true;
            this.l_Minutes.Location = new System.Drawing.Point(136, 201);
            this.l_Minutes.Name = "l_Minutes";
            this.l_Minutes.Size = new System.Drawing.Size(47, 13);
            this.l_Minutes.TabIndex = 5;
            this.l_Minutes.Text = "Minutes:";
            // 
            // tb_Minutes
            // 
            this.tb_Minutes.Location = new System.Drawing.Point(186, 198);
            this.tb_Minutes.Name = "tb_Minutes";
            this.tb_Minutes.Size = new System.Drawing.Size(100, 20);
            this.tb_Minutes.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_For
            // 
            this.l_For.AutoSize = true;
            this.l_For.Location = new System.Drawing.Point(155, 149);
            this.l_For.Name = "l_For";
            this.l_For.Size = new System.Drawing.Size(25, 13);
            this.l_For.TabIndex = 8;
            this.l_For.Text = "For:";
            // 
            // tb_For
            // 
            this.tb_For.Location = new System.Drawing.Point(186, 146);
            this.tb_For.Name = "tb_For";
            this.tb_For.Size = new System.Drawing.Size(100, 20);
            this.tb_For.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_For);
            this.Controls.Add(this.tb_For);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_Minutes);
            this.Controls.Add(this.tb_Minutes);
            this.Controls.Add(this.l_Hours);
            this.Controls.Add(this.tb_Hours);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_Timer1;
        private System.Windows.Forms.Label l_Timer1;
        private System.Windows.Forms.TextBox tb_Hours;
        private System.Windows.Forms.Label l_Hours;
        private System.Windows.Forms.Label l_Minutes;
        private System.Windows.Forms.TextBox tb_Minutes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_For;
        private System.Windows.Forms.TextBox tb_For;
    }
}


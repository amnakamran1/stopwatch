namespace Stopwatch
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            msecslb = new Label();
            secslb = new Label();
            minslb = new Label();
            hrslb = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 114);
            label1.Name = "label1";
            label1.Size = new Size(43, 30);
            label1.TabIndex = 0;
            label1.Text = "hrs";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(266, 114);
            label2.Name = "label2";
            label2.Size = new Size(60, 30);
            label2.TabIndex = 1;
            label2.Text = "mins";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(381, 114);
            label3.Name = "label3";
            label3.Size = new Size(52, 30);
            label3.TabIndex = 2;
            label3.Text = "secs";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(489, 114);
            label4.Name = "label4";
            label4.Size = new Size(71, 30);
            label4.TabIndex = 3;
            label4.Text = "msecs";
            // 
            // msecslb
            // 
            msecslb.AutoSize = true;
            msecslb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msecslb.Location = new Point(510, 182);
            msecslb.Name = "msecslb";
            msecslb.Size = new Size(32, 25);
            msecslb.TabIndex = 4;
            msecslb.Text = "00";
            // 
            // secslb
            // 
            secslb.AutoSize = true;
            secslb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secslb.Location = new Point(395, 182);
            secslb.Name = "secslb";
            secslb.Size = new Size(32, 25);
            secslb.TabIndex = 5;
            secslb.Text = "00";
            secslb.Click += label6_Click;
            // 
            // minslb
            // 
            minslb.AutoSize = true;
            minslb.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minslb.Location = new Point(288, 182);
            minslb.Name = "minslb";
            minslb.Size = new Size(34, 25);
            minslb.TabIndex = 6;
            minslb.Text = "00";
            minslb.Click += label7_Click;
            // 
            // hrslb
            // 
            hrslb.AutoSize = true;
            hrslb.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            hrslb.Location = new Point(147, 182);
            hrslb.Name = "hrslb";
            hrslb.Size = new Size(34, 25);
            hrslb.TabIndex = 7;
            hrslb.Text = "00";
            // 
            // button1
            // 
            button1.Location = new Point(151, 258);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(266, 258);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(381, 258);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "resume";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(489, 258);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(hrslb);
            Controls.Add(minslb);
            Controls.Add(secslb);
            Controls.Add(msecslb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Stopwatch";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label msecslb;
        private Label secslb;
        private Label minslb;
        private Label hrslb;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}

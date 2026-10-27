namespace game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 890);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(263, 551);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(154, 596);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(638, 38);
            button1.Name = "button1";
            button1.Size = new Size(677, 77);
            button1.TabIndex = 1;
            button1.Text = "Eniş hazırlığı";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(638, 157);
            button2.Name = "button2";
            button2.Size = new Size(677, 77);
            button2.TabIndex = 2;
            button2.Text = "Türbulans";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(638, 281);
            button3.Name = "button3";
            button3.Size = new Size(677, 77);
            button3.TabIndex = 3;
            button3.Text = "Kəmərlər";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_2;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(638, 410);
            button4.Name = "button4";
            button4.Size = new Size(677, 77);
            button4.TabIndex = 4;
            button4.Text = "Təşəkkürlər";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_2;
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(587, 812);
            button5.Name = "button5";
            button5.Size = new Size(825, 94);
            button5.TabIndex = 5;
            button5.Text = "ON/OFF";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SeaGreen;
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(732, 651);
            button6.Name = "button6";
            button6.Size = new Size(201, 114);
            button6.TabIndex = 6;
            button6.Text = "GAS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_2;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkRed;
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(1022, 651);
            button7.Name = "button7";
            button7.Size = new Size(201, 114);
            button7.TabIndex = 7;
            button7.Text = "Break";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_2;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkOrange;
            button8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            button8.Location = new Point(638, 529);
            button8.Name = "button8";
            button8.Size = new Size(677, 77);
            button8.TabIndex = 8;
            button8.Text = "BEEP";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 890);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Plane";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

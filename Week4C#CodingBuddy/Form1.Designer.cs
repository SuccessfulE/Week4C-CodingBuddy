namespace Week4C_CodingBuddy
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
            panel1 = new Panel();
            plank1 = new PictureBox();
            Water2 = new PictureBox();
            Water1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            scoreTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)plank1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Water2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Water1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(plank1);
            panel1.Controls.Add(Water2);
            panel1.Controls.Add(Water1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 429);
            panel1.TabIndex = 0;
            // 
            // plank1
            // 
            plank1.BackColor = Color.Transparent;
            plank1.Image = Resources.Resource1.plank;
            plank1.Location = new Point(0, 379);
            plank1.Name = "plank1";
            plank1.Size = new Size(100, 50);
            plank1.SizeMode = PictureBoxSizeMode.StretchImage;
            plank1.TabIndex = 2;
            plank1.TabStop = false;
            // 
            // Water2
            // 
            Water2.Image = Resources.Resource1.Untitled_2;
            Water2.Location = new Point(0, 0);
            Water2.Name = "Water2";
            Water2.Size = new Size(891, 429);
            Water2.SizeMode = PictureBoxSizeMode.StretchImage;
            Water2.TabIndex = 1;
            Water2.TabStop = false;
            // 
            // Water1
            // 
            Water1.Image = Resources.Resource1.Untitled_2;
            Water1.Location = new Point(-900, 0);
            Water1.Name = "Water1";
            Water1.Size = new Size(891, 429);
            Water1.SizeMode = PictureBoxSizeMode.StretchImage;
            Water1.TabIndex = 0;
            Water1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(270, 476);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(466, 480);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Time: ";
            // 
            // scoreTimer
            // 
            scoreTimer.Tick += scoreTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 522);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)plank1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Water2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Water1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox Water2;
        private PictureBox Water1;
        private Button button1;
        private Label label1;
        private PictureBox plank1;
        private System.Windows.Forms.Timer scoreTimer;
    }
}
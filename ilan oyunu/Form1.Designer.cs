namespace ilan_oyunu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            yemek = new PictureBox();
            ilan = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            buttonUp = new Button();
            buttonDown = new Button();
            buttonLeft = new Button();
            buttonRight = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yemek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ilan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(yemek);
            panel1.Controls.Add(ilan);
            panel1.Location = new Point(16, 18);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 415);
            panel1.TabIndex = 0;
            // 
            // yemek
            // 
            yemek.BackColor = Color.Black;
            yemek.Location = new Point(254, 155);
            yemek.Name = "yemek";
            yemek.Size = new Size(29, 27);
            yemek.TabIndex = 1;
            yemek.TabStop = false;
            // 
            // ilan
            // 
            ilan.BackColor = Color.Black;
            ilan.BackgroundImageLayout = ImageLayout.None;
            ilan.Location = new Point(144, 90);
            ilan.Name = "ilan";
            ilan.Size = new Size(27, 25);
            ilan.TabIndex = 0;
            ilan.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 492);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 24);
            label1.TabIndex = 1;
            label1.Text = "Xal: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(100, 492);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 24);
            label2.TabIndex = 2;
            label2.Text = "0";
            // 
            // buttonUp
            // 
            buttonUp.Image = (Image)resources.GetObject("buttonUp.Image");
            buttonUp.Location = new Point(320, 446);
            buttonUp.Margin = new Padding(4, 5, 4, 5);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(75, 73);
            buttonUp.TabIndex = 3;
            buttonUp.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            buttonDown.Image = (Image)resources.GetObject("buttonDown.Image");
            buttonDown.Location = new Point(320, 591);
            buttonDown.Margin = new Padding(4, 5, 4, 5);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(75, 73);
            buttonDown.TabIndex = 4;
            buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            buttonLeft.Image = (Image)resources.GetObject("buttonLeft.Image");
            buttonLeft.Location = new Point(246, 517);
            buttonLeft.Margin = new Padding(4, 5, 4, 5);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(76, 67);
            buttonLeft.TabIndex = 5;
            buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            buttonRight.Image = (Image)resources.GetObject("buttonRight.Image");
            buttonRight.Location = new Point(393, 517);
            buttonRight.Margin = new Padding(4, 5, 4, 5);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(75, 73);
            buttonRight.TabIndex = 6;
            buttonRight.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(707, 600);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(120, 54);
            button2.TabIndex = 7;
            button2.Text = "Çıxış";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(845, 678);
            Controls.Add(button2);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "İlan Oyunu";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)yemek).EndInit();
            ((System.ComponentModel.ISupportInitialize)ilan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button button2;
        private PictureBox yemek;
        private PictureBox ilan;
        private System.Windows.Forms.Timer timer1;
    }
}
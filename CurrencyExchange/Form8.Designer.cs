namespace CurrencyExchange
{
    partial class Form8
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
            currency1 = new Label();
            currency2 = new Label();
            currency3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            currency4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // currency1
            // 
            currency1.BackColor = SystemColors.ButtonHighlight;
            currency1.Location = new Point(71, 122);
            currency1.MaximumSize = new Size(1000, 1000);
            currency1.Name = "currency1";
            currency1.Size = new Size(250, 250);
            currency1.TabIndex = 0;
            currency1.Text = "currency1";
            currency1.TextAlign = ContentAlignment.MiddleCenter;
            currency1.Click += currency1_Click;
            // 
            // currency2
            // 
            currency2.BackColor = SystemColors.Control;
            currency2.Location = new Point(523, 122);
            currency2.MaximumSize = new Size(1000, 1000);
            currency2.Name = "currency2";
            currency2.Size = new Size(250, 250);
            currency2.TabIndex = 1;
            currency2.Text = "currency2";
            currency2.TextAlign = ContentAlignment.MiddleCenter;
            currency2.Click += currency2_Click;
            // 
            // currency3
            // 
            currency3.BackColor = SystemColors.ButtonHighlight;
            currency3.Location = new Point(71, 402);
            currency3.MaximumSize = new Size(1000, 1000);
            currency3.Name = "currency3";
            currency3.Size = new Size(250, 250);
            currency3.TabIndex = 2;
            currency3.Text = "currency3";
            currency3.TextAlign = ContentAlignment.MiddleCenter;
            currency3.Click += currency3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(344, 44);
            label4.Name = "label4";
            label4.Size = new Size(193, 25);
            label4.TabIndex = 3;
            label4.Text = "Select currency acount ";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(120, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(582, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 75);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(120, 426);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 75);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(572, 435);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 75);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // currency4
            // 
            currency4.BackColor = SystemColors.ButtonHighlight;
            currency4.Location = new Point(523, 411);
            currency4.MaximumSize = new Size(1000, 1000);
            currency4.Name = "currency4";
            currency4.Size = new Size(250, 250);
            currency4.TabIndex = 7;
            currency4.Text = "currency4";
            currency4.TextAlign = ContentAlignment.MiddleCenter;
            currency4.Click += currency4_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.GreenUI;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(922, 642);
            Controls.Add(pictureBox4);
            Controls.Add(currency4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(currency3);
            Controls.Add(currency2);
            Controls.Add(currency1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currency1;
        private Label currency2;
        private Label currency3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label currency4;
    }
}
namespace CurrencyExchange
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            switchbtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ExchangeRate = new DataGridView();
            balanceTxt = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExchangeRate).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 45);
            label1.TabIndex = 0;
            label1.Text = "Balance";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(269, 92);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(631, 112);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // switchbtn
            // 
            switchbtn.Location = new Point(780, 92);
            switchbtn.Margin = new Padding(4, 5, 4, 5);
            switchbtn.Name = "switchbtn";
            switchbtn.Size = new Size(137, 78);
            switchbtn.TabIndex = 4;
            switchbtn.Text = "Switch Currency Account";
            switchbtn.UseVisualStyleBackColor = true;
            switchbtn.Click += switchbtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(780, 338);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(143, 93);
            button1.TabIndex = 5;
            button1.Text = "Add Currency";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(780, 470);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(143, 123);
            button2.TabIndex = 6;
            button2.Text = "Transfer between currency account";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(780, 637);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(143, 93);
            button3.TabIndex = 7;
            button3.Text = "Transfer to external bank account\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ExchangeRate
            // 
            ExchangeRate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExchangeRate.Location = new Point(156, 326);
            ExchangeRate.Name = "ExchangeRate";
            ExchangeRate.RowHeadersWidth = 62;
            ExchangeRate.Size = new Size(434, 404);
            ExchangeRate.TabIndex = 8;
            ExchangeRate.CellContentClick += dataGridView1_CellContentClick;
            // 
            // balanceTxt
            // 
            balanceTxt.AutoSize = true;
            balanceTxt.BackColor = Color.Transparent;
            balanceTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceTxt.Location = new Point(156, 197);
            balanceTxt.Name = "balanceTxt";
            balanceTxt.Size = new Size(91, 38);
            balanceTxt.TabIndex = 9;
            balanceTxt.Text = "label2";
            balanceTxt.Click += balanceTxt_Click;
            // 
            // button4
            // 
            button4.Location = new Point(780, 221);
            button4.Name = "button4";
            button4.Size = new Size(143, 86);
            button4.TabIndex = 10;
            button4.Text = "View Transactions";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1079, 770);
            Controls.Add(button4);
            Controls.Add(balanceTxt);
            Controls.Add(ExchangeRate);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(switchbtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExchangeRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button switchbtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView ExchangeRate;
        private Label balanceTxt;
        private Button button4;
    }
}
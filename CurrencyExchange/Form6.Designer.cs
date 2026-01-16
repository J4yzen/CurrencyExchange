namespace CurrencyExchange
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            accNo = new TextBox();
            sortCode = new TextBox();
            forename = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label8 = new Label();
            feeTxt = new Label();
            surename = new TextBox();
            label9 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(419, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 65);
            label1.TabIndex = 0;
            label1.Text = "Transfer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(191, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 1;
            label2.Text = "Account Number";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(191, 240);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Sort Code";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(191, 300);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "Forename";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(191, 439);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 4;
            label5.Text = "Bank Currency ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(643, 166);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 5;
            label6.Text = "Amount";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(643, 262);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 6;
            label7.Text = "New Amount";
            label7.Click += label7_Click;
            // 
            // accNo
            // 
            accNo.Location = new Point(370, 166);
            accNo.Margin = new Padding(4, 5, 4, 5);
            accNo.Name = "accNo";
            accNo.Size = new Size(141, 31);
            accNo.TabIndex = 7;
            // 
            // sortCode
            // 
            sortCode.Location = new Point(370, 234);
            sortCode.Margin = new Padding(4, 5, 4, 5);
            sortCode.Name = "sortCode";
            sortCode.Size = new Size(141, 31);
            sortCode.TabIndex = 8;
            // 
            // forename
            // 
            forename.Location = new Point(370, 300);
            forename.Margin = new Padding(4, 5, 4, 5);
            forename.Name = "forename";
            forename.Size = new Size(141, 31);
            forename.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(808, 160);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(141, 31);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(808, 256);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(141, 31);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(842, 375);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 12;
            button1.Text = "Confirm Transaction";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "US Dollar", "Euro", "Indian Rupee", "Swiss Franc", "Australian Dollar", "Singaporean Dollar", "Malaysian Ringgit", "Chinese Yuan", "Japanese Yen", "British Pound" });
            listBox1.Location = new Point(370, 439);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(721, 324);
            label8.Name = "label8";
            label8.Size = new Size(39, 25);
            label8.TabIndex = 14;
            label8.Text = "Fee";
            // 
            // feeTxt
            // 
            feeTxt.AutoSize = true;
            feeTxt.BackColor = Color.Transparent;
            feeTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feeTxt.ForeColor = SystemColors.ControlLightLight;
            feeTxt.Location = new Point(808, 324);
            feeTxt.Name = "feeTxt";
            feeTxt.Size = new Size(28, 32);
            feeTxt.TabIndex = 15;
            feeTxt.Text = "X";
            // 
            // surename
            // 
            surename.Location = new Point(370, 354);
            surename.Margin = new Padding(4, 5, 4, 5);
            surename.Name = "surename";
            surename.Size = new Size(141, 31);
            surename.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(191, 354);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 25);
            label9.TabIndex = 16;
            label9.Text = "Surename";
            // 
            // button2
            // 
            button2.Location = new Point(82, 46);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 18;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 750);
            Controls.Add(button2);
            Controls.Add(surename);
            Controls.Add(label9);
            Controls.Add(feeTxt);
            Controls.Add(label8);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(forename);
            Controls.Add(sortCode);
            Controls.Add(accNo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox accNo;
        private TextBox sortCode;
        private TextBox forename;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private ListBox listBox1;
        private Label label8;
        private Label feeTxt;
        private TextBox surename;
        private Label label9;
        private Button button2;
    }
}
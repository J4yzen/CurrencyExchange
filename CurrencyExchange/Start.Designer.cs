namespace CurrencyExchange
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            txt_username = new TextBox();
            Title = new Label();
            label1 = new Label();
            label2 = new Label();
            txt_password = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(371, 167);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(185, 31);
            txt_username.TabIndex = 0;
            txt_username.TextChanged += textBox1_TextChanged;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(219, 42);
            Title.Name = "Title";
            Title.Size = new Size(408, 65);
            Title.TabIndex = 1;
            Title.Text = "Currency Transfer ";
            Title.TextAlign = ContentAlignment.TopCenter;
            Title.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(256, 167);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(256, 237);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(371, 230);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(185, 31);
            txt_password.TabIndex = 4;
            txt_password.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(256, 313);
            button2.Name = "button2";
            button2.Size = new Size(149, 67);
            button2.TabIndex = 6;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(421, 313);
            button3.Name = "button3";
            button3.Size = new Size(136, 67);
            button3.TabIndex = 7;
            button3.Text = "Create New Account";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(877, 527);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            Controls.Add(txt_username);
            Name = "StartPage";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private Label Title;
        private Label label1;
        private Label label2;
        private TextBox txt_password;
        private Button button2;
        private Button button3;
    }
}

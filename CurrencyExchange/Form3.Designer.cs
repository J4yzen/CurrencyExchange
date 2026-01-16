namespace CurrencyExchange
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            forename = new TextBox();
            txtSurname = new TextBox();
            emailAdd = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            radioPersonal = new RadioButton();
            radioBusiness = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(177, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 65);
            label1.TabIndex = 0;
            label1.Text = "Enter details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(671, 252);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 45);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(671, 147);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 45);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(119, 470);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(208, 45);
            label4.TabIndex = 5;
            label4.Text = "Account type";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(297, 627);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(211, 52);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(129, 159);
            label5.Name = "label5";
            label5.Size = new Size(162, 45);
            label5.TabIndex = 12;
            label5.Text = "Forename";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15.75F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(129, 338);
            label6.Name = "label6";
            label6.Size = new Size(220, 45);
            label6.TabIndex = 13;
            label6.Text = "Email Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 15.75F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(129, 247);
            label7.Name = "label7";
            label7.Size = new Size(145, 45);
            label7.TabIndex = 14;
            label7.Text = "Surname";
            label7.Click += label7_Click;
            // 
            // forename
            // 
            forename.Location = new Point(378, 161);
            forename.Name = "forename";
            forename.Size = new Size(236, 31);
            forename.TabIndex = 15;
            forename.TextChanged += textBox6_TextChanged;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(378, 260);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(236, 31);
            txtSurname.TabIndex = 16;
            // 
            // emailAdd
            // 
            emailAdd.Location = new Point(378, 352);
            emailAdd.Name = "emailAdd";
            emailAdd.Size = new Size(236, 31);
            emailAdd.TabIndex = 17;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(861, 159);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 31);
            txtUsername.TabIndex = 18;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(864, 257);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(213, 31);
            txtPassword.TabIndex = 19;
            // 
            // radioPersonal
            // 
            radioPersonal.AutoSize = true;
            radioPersonal.BackColor = Color.Transparent;
            radioPersonal.ForeColor = SystemColors.ControlLightLight;
            radioPersonal.Location = new Point(397, 484);
            radioPersonal.Name = "radioPersonal";
            radioPersonal.Size = new Size(103, 29);
            radioPersonal.TabIndex = 20;
            radioPersonal.TabStop = true;
            radioPersonal.Text = "Personal";
            radioPersonal.UseVisualStyleBackColor = false;
            // 
            // radioBusiness
            // 
            radioBusiness.AutoSize = true;
            radioBusiness.BackColor = Color.Transparent;
            radioBusiness.ForeColor = SystemColors.ControlLightLight;
            radioBusiness.Location = new Point(394, 546);
            radioBusiness.Name = "radioBusiness";
            radioBusiness.Size = new Size(104, 29);
            radioBusiness.TabIndex = 21;
            radioBusiness.TabStop = true;
            radioBusiness.Text = "Business";
            radioBusiness.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1266, 962);
            Controls.Add(radioBusiness);
            Controls.Add(radioPersonal);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(emailAdd);
            Controls.Add(txtSurname);
            Controls.Add(forename);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox forename;
        private TextBox txtSurname;
        private TextBox emailAdd;
        private RadioButton radioPersonal;
        private RadioButton radioBusiness;
    }
}
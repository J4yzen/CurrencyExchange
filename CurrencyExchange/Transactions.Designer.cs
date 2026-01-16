namespace CurrencyExchange
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            transactionDGV = new DataGridView();
            button1 = new Button();
            btnGenerateInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)transactionDGV).BeginInit();
            SuspendLayout();
            // 
            // transactionDGV
            // 
            transactionDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDGV.Location = new Point(218, 67);
            transactionDGV.Name = "transactionDGV";
            transactionDGV.RowHeadersWidth = 62;
            transactionDGV.Size = new Size(453, 418);
            transactionDGV.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(51, 32);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGenerateInvoice
            // 
            btnGenerateInvoice.Location = new Point(726, 179);
            btnGenerateInvoice.Name = "btnGenerateInvoice";
            btnGenerateInvoice.Size = new Size(134, 70);
            btnGenerateInvoice.TabIndex = 2;
            btnGenerateInvoice.Text = "Generate Invoice";
            btnGenerateInvoice.UseVisualStyleBackColor = true;
            btnGenerateInvoice.Click += btnGenerateInvoice_Click;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(898, 525);
            Controls.Add(btnGenerateInvoice);
            Controls.Add(button1);
            Controls.Add(transactionDGV);
            Name = "Transactions";
            Text = "Transactions";
            Load += Transactions_Load;
            ((System.ComponentModel.ISupportInitialize)transactionDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView transactionDGV;
        private Button button1;
        private Button btnGenerateInvoice;
    }
}
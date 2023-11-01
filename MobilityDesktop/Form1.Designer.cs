namespace MobilityDesktop
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
            FirstNumberTxt = new RichTextBox();
            SeconNumberTxt = new RichTextBox();
            FirstNumberBtn = new Button();
            SeconNumberBtn = new Button();
            listPrimeNumbers = new ListBox();            
            SuspendLayout();
            // 
            // FirstNumberTxt
            // 
            FirstNumberTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNumberTxt.Location = new Point(12, 12);
            FirstNumberTxt.Name = "FirstNumberTxt";
            FirstNumberTxt.Size = new Size(218, 51);
            FirstNumberTxt.TabIndex = 6;
            FirstNumberTxt.Text = "";
            // 
            // SeconNumberTxt
            // 
            SeconNumberTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SeconNumberTxt.Location = new Point(12, 69);
            SeconNumberTxt.Name = "SeconNumberTxt";
            SeconNumberTxt.Size = new Size(218, 51);
            SeconNumberTxt.TabIndex = 1;
            SeconNumberTxt.Text = "";
            // 
            // FirstNumberBtn
            // 
            FirstNumberBtn.FlatStyle = FlatStyle.Popup;
            FirstNumberBtn.ForeColor = Color.FromArgb(64, 64, 64);
            FirstNumberBtn.Location = new Point(253, 12);
            FirstNumberBtn.Name = "FirstNumberBtn";
            FirstNumberBtn.Size = new Size(208, 51);
            FirstNumberBtn.TabIndex = 3;
            FirstNumberBtn.Text = "Generate Prime Numbers 1";
            FirstNumberBtn.UseVisualStyleBackColor = true;
            FirstNumberBtn.Click += FirstNumberBtn_Click;
            // 
            // SeconNumberBtn
            // 
            SeconNumberBtn.FlatStyle = FlatStyle.Popup;
            SeconNumberBtn.ForeColor = Color.FromArgb(64, 64, 64);
            SeconNumberBtn.Location = new Point(253, 69);
            SeconNumberBtn.Name = "SeconNumberBtn";
            SeconNumberBtn.Size = new Size(208, 51);
            SeconNumberBtn.TabIndex = 4;
            SeconNumberBtn.Text = "Generate Prime Numbers 2";
            SeconNumberBtn.UseVisualStyleBackColor = true;
            SeconNumberBtn.Click += SeconNumberBtn_Click;
            // 
            // listPrimeNumbers
            // 
            listPrimeNumbers.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listPrimeNumbers.FormattingEnabled = true;
            listPrimeNumbers.ItemHeight = 19;
            listPrimeNumbers.Location = new Point(11, 132);
            listPrimeNumbers.Name = "listPrimeNumbers";
            listPrimeNumbers.Size = new Size(450, 289);
            listPrimeNumbers.TabIndex = 5;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 461);
            Controls.Add(FirstNumberTxt);
            Controls.Add(listPrimeNumbers);
            Controls.Add(SeconNumberBtn);
            Controls.Add(FirstNumberBtn);
            Controls.Add(SeconNumberTxt);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mobility Desktop Application";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox SeconNumberTxt;
        private Button FirstNumberBtn;
        private Button SeconNumberBtn;
        private ListBox listPrimeNumbers;
        private RichTextBox FirstNumberTxt;
    }
}
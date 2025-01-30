namespace BankWork
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
            heading = new Label();
            buttonDeposit = new Button();
            buttonWithdraw = new Button();
            buttonTransactions = new Button();
            CloseTheApplication = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            heading.Location = new Point(202, 37);
            heading.Name = "heading";
            heading.Size = new Size(400, 46);
            heading.TabIndex = 0;
            heading.Text = "Выберите тип операции\r\n";
            // 
            // buttonDeposit
            // 
            buttonDeposit.Location = new Point(141, 186);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new Size(163, 86);
            buttonDeposit.TabIndex = 1;
            buttonDeposit.Text = "Внести Наличные";
            buttonDeposit.UseVisualStyleBackColor = true;
            buttonDeposit.Click += buttonDeposit_Click;
            // 
            // buttonWithdraw
            // 
            buttonWithdraw.Location = new Point(539, 186);
            buttonWithdraw.Name = "buttonWithdraw";
            buttonWithdraw.Size = new Size(148, 86);
            buttonWithdraw.TabIndex = 2;
            buttonWithdraw.Text = "Снять Наличные";
            buttonWithdraw.UseVisualStyleBackColor = true;
            buttonWithdraw.Click += buttonWithdraw_Click;
            // 
            // buttonTransactions
            // 
            buttonTransactions.Location = new Point(141, 320);
            buttonTransactions.Name = "buttonTransactions";
            buttonTransactions.Size = new Size(163, 81);
            buttonTransactions.TabIndex = 3;
            buttonTransactions.Text = "История \r\nОпераций";
            buttonTransactions.UseVisualStyleBackColor = true;
            buttonTransactions.Click += buttonTransactions_Click;
            // 
            // CloseTheApplication
            // 
            CloseTheApplication.Location = new Point(539, 320);
            CloseTheApplication.Name = "CloseTheApplication";
            CloseTheApplication.Size = new Size(148, 81);
            CloseTheApplication.TabIndex = 4;
            CloseTheApplication.Text = "Выйти";
            CloseTheApplication.UseVisualStyleBackColor = true;
            CloseTheApplication.Click += CloseTheApplication_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 27);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 5;
            label1.Text = "Баланс:";
            label1.Click += label1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(CloseTheApplication);
            Controls.Add(buttonTransactions);
            Controls.Add(buttonWithdraw);
            Controls.Add(buttonDeposit);
            Controls.Add(heading);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heading;
        private Button buttonDeposit;
        private Button buttonWithdraw;
        private Button buttonTransactions;
        private Button CloseTheApplication;
        private Label label1;
    }
}
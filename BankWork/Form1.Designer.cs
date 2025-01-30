namespace BankWork
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
            logotip = new Label();
            start = new Button();
            SuspendLayout();
            // 
            // logotip
            // 
            logotip.AutoSize = true;
            logotip.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logotip.ForeColor = SystemColors.ActiveCaptionText;
            logotip.Location = new Point(178, 86);
            logotip.Name = "logotip";
            logotip.Size = new Size(462, 46);
            logotip.TabIndex = 0;
            logotip.Text = "Работа банковской системы\r\n";
            logotip.TextAlign = ContentAlignment.TopCenter;
            logotip.Click += label1_Click;
            // 
            // start
            // 
            start.Location = new Point(308, 274);
            start.Name = "start";
            start.Size = new Size(139, 58);
            start.TabIndex = 1;
            start.Text = "Начать";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(start);
            Controls.Add(logotip);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logotip;
        private Button start;
    }
}

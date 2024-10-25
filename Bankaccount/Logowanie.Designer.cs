namespace Bankaccount
{
    partial class Logowanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie));
            zaloguj = new Button();
            Log = new TextBox();
            logpass = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // zaloguj
            // 
            zaloguj.Location = new Point(164, 208);
            zaloguj.Name = "zaloguj";
            zaloguj.Size = new Size(99, 43);
            zaloguj.TabIndex = 0;
            zaloguj.Text = "Zaloguj";
            zaloguj.UseVisualStyleBackColor = true;
            zaloguj.Click += zaloguj_Click;
            // 
            // Log
            // 
            Log.Location = new Point(137, 150);
            Log.Name = "Log";
            Log.PlaceholderText = "Podaj E-mail:";
            Log.Size = new Size(155, 23);
            Log.TabIndex = 1;
            // 
            // logpass
            // 
            logpass.Location = new Point(137, 179);
            logpass.Name = "logpass";
            logpass.PasswordChar = '*';
            logpass.PlaceholderText = "Podaj Hasło:";
            logpass.Size = new Size(155, 23);
            logpass.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(164, 257);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 3;
            button1.Text = "Utwórz konto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(150, 104);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 4;
            label1.Text = "Zaloguj się";
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 350);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(logpass);
            Controls.Add(Log);
            Controls.Add(zaloguj);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Logowanie";
            Text = "Logowanie";
            Load += Logowanie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button zaloguj;
        private TextBox Log;
        private TextBox logpass;
        private Button button1;
        private Label label1;
    }
}
namespace Bankaccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            nazwa = new TextBox();
            Surname = new TextBox();
            Date = new TextBox();
            dataurodzenia = new MonthCalendar();
            male = new CheckBox();
            female = new CheckBox();
            datebtn = new Button();
            label1 = new Label();
            label2 = new Label();
            Email = new TextBox();
            passmail = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(333, 330);
            button1.Name = "button1";
            button1.Size = new Size(142, 56);
            button1.TabIndex = 0;
            button1.Text = "Utwórz konto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nazwa
            // 
            nazwa.Location = new Point(35, 170);
            nazwa.Name = "nazwa";
            nazwa.PlaceholderText = "Podaj imię:";
            nazwa.Size = new Size(165, 23);
            nazwa.TabIndex = 1;
            // 
            // Surname
            // 
            Surname.Location = new Point(35, 199);
            Surname.Name = "Surname";
            Surname.PlaceholderText = "Podaj nazwisko:";
            Surname.Size = new Size(165, 23);
            Surname.TabIndex = 2;
            // 
            // Date
            // 
            Date.Location = new Point(35, 286);
            Date.Name = "Date";
            Date.PlaceholderText = "Data urodzenia:";
            Date.ReadOnly = true;
            Date.Size = new Size(165, 23);
            Date.TabIndex = 3;
            Date.TextChanged += Date_TextChanged;
            // 
            // dataurodzenia
            // 
            dataurodzenia.Location = new Point(206, 145);
            dataurodzenia.Name = "dataurodzenia";
            dataurodzenia.TabIndex = 4;
            dataurodzenia.Visible = false;
            dataurodzenia.DateChanged += dataurodzenia_DateSelected;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(38, 124);
            male.Name = "male";
            male.Size = new Size(86, 19);
            male.TabIndex = 5;
            male.Text = "Mężczyzna ";
            male.UseVisualStyleBackColor = true;
            male.CheckedChanged += male_CheckedChanged;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(38, 145);
            female.Name = "female";
            female.Size = new Size(66, 19);
            female.TabIndex = 6;
            female.Text = "Kobieta";
            female.UseVisualStyleBackColor = true;
            // 
            // datebtn
            // 
            datebtn.Location = new Point(35, 316);
            datebtn.Name = "datebtn";
            datebtn.Size = new Size(106, 28);
            datebtn.TabIndex = 7;
            datebtn.Text = "Data urodzenia";
            datebtn.UseVisualStyleBackColor = true;
            datebtn.Click += datebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(475, 416);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label2.Location = new Point(206, 9);
            label2.Name = "label2";
            label2.Size = new Size(375, 47);
            label2.TabIndex = 9;
            label2.Text = "Stwórz konto bankowe";
            // 
            // Email
            // 
            Email.Location = new Point(35, 228);
            Email.Name = "Email";
            Email.PlaceholderText = "Podaj e-mail:";
            Email.Size = new Size(165, 23);
            Email.TabIndex = 10;
            Email.TextChanged += email_TextChanged;
            // 
            // passmail
            // 
            passmail.Location = new Point(35, 257);
            passmail.Name = "passmail";
            passmail.PasswordChar = '*';
            passmail.PlaceholderText = "Podaj Hasło:";
            passmail.Size = new Size(165, 23);
            passmail.TabIndex = 11;
            passmail.TextChanged += passmail_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(366, 392);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Zaloguj sie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(passmail);
            Controls.Add(Email);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datebtn);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(dataurodzenia);
            Controls.Add(Date);
            Controls.Add(Surname);
            Controls.Add(nazwa);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Konto Bankowe";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox nazwa;
        private TextBox Surname;
        private TextBox Date;
        private MonthCalendar dataurodzenia;
        private CheckBox male;
        private CheckBox female;
        private Button datebtn;
        private Label label1;
        private Label label2;
        private TextBox Email;
        private TextBox passmail;
        private Button button2;
    }
}

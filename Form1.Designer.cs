namespace PäättötyöViimeinenCSharp
{
    partial class Luotunnus
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
            label1 = new Label();
            Nimi = new TextBox();
            Salasana = new TextBox();
            ihminen = new CheckBox();
            jatka = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(352, 94);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Luo tunnus";
            // 
            // Nimi
            // 
            Nimi.Location = new Point(293, 112);
            Nimi.Name = "Nimi";
            Nimi.Size = new Size(188, 23);
            Nimi.TabIndex = 1;
            Nimi.TextChanged += Nimi_TextChanged;
            // 
            // Salasana
            // 
            Salasana.Location = new Point(293, 158);
            Salasana.Name = "Salasana";
            Salasana.Size = new Size(188, 23);
            Salasana.TabIndex = 2;
            Salasana.UseSystemPasswordChar = true;
            Salasana.TextChanged += Salasana_TextChanged;
            // 
            // ihminen
            // 
            ihminen.AutoSize = true;
            ihminen.BackColor = SystemColors.ActiveCaption;
            ihminen.Location = new Point(293, 198);
            ihminen.Name = "ihminen";
            ihminen.Size = new Size(98, 19);
            ihminen.TabIndex = 3;
            ihminen.Text = "Olen ihminen";
            ihminen.UseVisualStyleBackColor = false;
            ihminen.CheckedChanged += ihminen_CheckedChanged;
            // 
            // jatka
            // 
            jatka.Location = new Point(406, 194);
            jatka.Name = "jatka";
            jatka.Size = new Size(75, 23);
            jatka.TabIndex = 4;
            jatka.Text = "Jatka";
            jatka.UseVisualStyleBackColor = true;
            jatka.Click += jatka_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(172, 32);
            button1.Name = "button1";
            button1.Size = new Size(425, 258);
            button1.TabIndex = 5;
            button1.Text = "  ";
            button1.UseVisualStyleBackColor = false;
            // 
            // Luotunnus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(jatka);
            Controls.Add(ihminen);
            Controls.Add(Salasana);
            Controls.Add(Nimi);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Luotunnus";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Nimi;
        private TextBox Salasana;
        private CheckBox ihminen;
        private Button jatka;
        private Button button1;
    }
}
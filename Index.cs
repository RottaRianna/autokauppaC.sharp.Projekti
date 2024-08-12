namespace PäättötyöViimeinenCSharp
{
    partial class Etusivu
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
            components = new System.ComponentModel.Container();
            Etsi = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            imageList1 = new ImageList(components);
            comboBox2 = new ComboBox();
            imageList2 = new ImageList(components);
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // Etsi
            // 
            Etsi.BackColor = SystemColors.ButtonHighlight;
            Etsi.Location = new Point(516, 116);
            Etsi.Name = "Etsi";
            Etsi.Size = new Size(75, 26);
            Etsi.TabIndex = 4;
            Etsi.Text = "Etsi";
            Etsi.UseVisualStyleBackColor = false;
            Etsi.Click += Etsi_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth4Bit;
            imageList1.ImageSize = new Size(256, 256);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(470, 74);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 25);
            comboBox2.TabIndex = 15;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(258, 74);
            label1.Name = "label1";
            label1.Size = new Size(206, 23);
            label1.TabIndex = 16;
            label1.Text = "Valitse haluamasi automerkki";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(12, 14);
            button1.Name = "button1";
            button1.Size = new Size(1066, 143);
            button1.TabIndex = 17;
            button1.Text = "  ";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(347, 24);
            label2.Name = "label2";
            label2.Size = new Size(315, 19);
            label2.TabIndex = 18;
            label2.Text = "Tervetuloa katsaisemaan eri automerkkien malleja!";
            label2.Click += label2_Click;
            // 
            // Etusivu
            // 
            AccessibleRole = AccessibleRole.DropList;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1090, 1061);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(Etsi);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Etusivu";
            Text = "Etusivu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Etsi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ImageList imageList1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ImageList imageList2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}
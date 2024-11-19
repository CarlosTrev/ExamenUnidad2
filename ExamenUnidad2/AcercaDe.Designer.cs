namespace ExamenUnidad2
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(177, 39);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "CRUD Northwind";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(20, 39);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(20, 85);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Version:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(177, 85);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 3;
            label4.Text = "1.0";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(20, 131);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Copyright:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(177, 131);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 5;
            label6.Text = "Adrian Rios y Carlos Adrian";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(20, 185);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 6;
            label7.Text = "Descripcion: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(177, 182);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 120);
            textBox1.TabIndex = 7;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // AcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._68973;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(436, 478);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AcercaDe";
            Text = "AcercaDe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
    }
}
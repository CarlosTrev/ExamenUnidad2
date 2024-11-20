namespace ExamenUnidad2
{
    partial class ETerritoriosAgregar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTIDA = new TextBox();
            txtDA = new TextBox();
            cmbRIDA = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "TerritoryID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Region ID:";
            // 
            // txtTIDA
            // 
            txtTIDA.Location = new Point(117, 21);
            txtTIDA.Name = "txtTIDA";
            txtTIDA.Size = new Size(120, 27);
            txtTIDA.TabIndex = 3;
            // 
            // txtDA
            // 
            txtDA.Location = new Point(117, 65);
            txtDA.Name = "txtDA";
            txtDA.Size = new Size(120, 27);
            txtDA.TabIndex = 4;
            // 
            // cmbRIDA
            // 
            cmbRIDA.FormattingEnabled = true;
            cmbRIDA.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmbRIDA.Location = new Point(117, 112);
            cmbRIDA.Name = "cmbRIDA";
            cmbRIDA.Size = new Size(120, 28);
            cmbRIDA.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(47, 157);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 6;
            button1.Text = "Agregar territorio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ETerritoriosAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 198);
            Controls.Add(button1);
            Controls.Add(cmbRIDA);
            Controls.Add(txtDA);
            Controls.Add(txtTIDA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ETerritoriosAgregar";
            Text = "ETerritoriosAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTIDA;
        private TextBox txtDA;
        private ComboBox cmbRIDA;
        private Button button1;
    }
}
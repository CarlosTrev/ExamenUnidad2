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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ETerritoriosAgregar));
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
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "TerritoryID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 49);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 80);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Region ID:";
            // 
            // txtTIDA
            // 
            txtTIDA.Location = new Point(102, 16);
            txtTIDA.Margin = new Padding(3, 2, 3, 2);
            txtTIDA.Name = "txtTIDA";
            txtTIDA.Size = new Size(106, 23);
            txtTIDA.TabIndex = 3;
            // 
            // txtDA
            // 
            txtDA.Location = new Point(102, 49);
            txtDA.Margin = new Padding(3, 2, 3, 2);
            txtDA.Name = "txtDA";
            txtDA.Size = new Size(106, 23);
            txtDA.TabIndex = 4;
            // 
            // cmbRIDA
            // 
            cmbRIDA.FormattingEnabled = true;
            cmbRIDA.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmbRIDA.Location = new Point(102, 84);
            cmbRIDA.Margin = new Padding(3, 2, 3, 2);
            cmbRIDA.Name = "cmbRIDA";
            cmbRIDA.Size = new Size(106, 23);
            cmbRIDA.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(58, 115);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(136, 22);
            button1.TabIndex = 6;
            button1.Text = "Agregar territorio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ETerritoriosAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(249, 148);
            Controls.Add(button1);
            Controls.Add(cmbRIDA);
            Controls.Add(txtDA);
            Controls.Add(txtTIDA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
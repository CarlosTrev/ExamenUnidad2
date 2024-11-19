namespace ExamenUnidad2
{
    partial class EproductoEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EproductoEditar));
            butEditar = new Button();
            cBoxDis = new ComboBox();
            txtBoxPReo = new TextBox();
            txtBoxPOr = new TextBox();
            txtBoxPSt = new TextBox();
            txtBoxPUn = new TextBox();
            txtBoxPQu = new TextBox();
            txtBoxPCa = new TextBox();
            txtBoxPSu = new TextBox();
            txtBoxPN = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPrID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // butEditar
            // 
            butEditar.Location = new Point(232, 336);
            butEditar.Name = "butEditar";
            butEditar.Size = new Size(177, 23);
            butEditar.TabIndex = 39;
            butEditar.Text = "Editar Producto";
            butEditar.UseVisualStyleBackColor = true;
            butEditar.Click += butEditar_Click;
            // 
            // cBoxDis
            // 
            cBoxDis.FormattingEnabled = true;
            cBoxDis.Items.AddRange(new object[] { "0", "1" });
            cBoxDis.Location = new Point(478, 101);
            cBoxDis.Name = "cBoxDis";
            cBoxDis.Size = new Size(121, 23);
            cBoxDis.TabIndex = 38;
            // 
            // txtBoxPReo
            // 
            txtBoxPReo.Location = new Point(478, 63);
            txtBoxPReo.Name = "txtBoxPReo";
            txtBoxPReo.Size = new Size(100, 23);
            txtBoxPReo.TabIndex = 37;
            // 
            // txtBoxPOr
            // 
            txtBoxPOr.Location = new Point(478, 30);
            txtBoxPOr.Name = "txtBoxPOr";
            txtBoxPOr.Size = new Size(100, 23);
            txtBoxPOr.TabIndex = 36;
            // 
            // txtBoxPSt
            // 
            txtBoxPSt.Location = new Point(165, 263);
            txtBoxPSt.Name = "txtBoxPSt";
            txtBoxPSt.Size = new Size(100, 23);
            txtBoxPSt.TabIndex = 35;
            // 
            // txtBoxPUn
            // 
            txtBoxPUn.Location = new Point(165, 226);
            txtBoxPUn.Name = "txtBoxPUn";
            txtBoxPUn.Size = new Size(100, 23);
            txtBoxPUn.TabIndex = 34;
            // 
            // txtBoxPQu
            // 
            txtBoxPQu.Location = new Point(165, 188);
            txtBoxPQu.Name = "txtBoxPQu";
            txtBoxPQu.Size = new Size(100, 23);
            txtBoxPQu.TabIndex = 33;
            // 
            // txtBoxPCa
            // 
            txtBoxPCa.Location = new Point(165, 153);
            txtBoxPCa.Name = "txtBoxPCa";
            txtBoxPCa.Size = new Size(100, 23);
            txtBoxPCa.TabIndex = 32;
            // 
            // txtBoxPSu
            // 
            txtBoxPSu.Location = new Point(165, 112);
            txtBoxPSu.Name = "txtBoxPSu";
            txtBoxPSu.Size = new Size(100, 23);
            txtBoxPSu.TabIndex = 31;
            // 
            // txtBoxPN
            // 
            txtBoxPN.Location = new Point(165, 74);
            txtBoxPN.Name = "txtBoxPN";
            txtBoxPN.Size = new Size(100, 23);
            txtBoxPN.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Black;
            label11.ForeColor = Color.White;
            label11.Location = new Point(372, 101);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 29;
            label11.Text = "Discountinued:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Black;
            label10.ForeColor = Color.White;
            label10.Location = new Point(372, 63);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 28;
            label10.Text = "ReorderLevel:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.ForeColor = Color.White;
            label9.Location = new Point(372, 30);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 27;
            label9.Text = "UnitsOnOrder:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.ForeColor = Color.White;
            label8.Location = new Point(29, 263);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 26;
            label8.Text = "UnitInStock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.ForeColor = Color.White;
            label7.Location = new Point(29, 226);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 25;
            label7.Text = "UnitPrice:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 188);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 24;
            label6.Text = "QuantityPerUnit:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 153);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 23;
            label5.Text = "CategoryID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 115);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 22;
            label4.Text = "SupplierID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 77);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 21;
            label3.Text = "ProductName:";
            // 
            // txtPrID
            // 
            txtPrID.Location = new Point(165, 30);
            txtPrID.Name = "txtPrID";
            txtPrID.Size = new Size(100, 23);
            txtPrID.TabIndex = 41;
            txtPrID.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 40;
            label1.Text = "ProductID:";
            // 
            // EproductoEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3ab5bJ1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(651, 383);
            Controls.Add(txtPrID);
            Controls.Add(label1);
            Controls.Add(butEditar);
            Controls.Add(cBoxDis);
            Controls.Add(txtBoxPReo);
            Controls.Add(txtBoxPOr);
            Controls.Add(txtBoxPSt);
            Controls.Add(txtBoxPUn);
            Controls.Add(txtBoxPQu);
            Controls.Add(txtBoxPCa);
            Controls.Add(txtBoxPSu);
            Controls.Add(txtBoxPN);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EproductoEditar";
            Text = "EproductoEditar";
            Load += EproductoEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butEditar;
        private ComboBox cBoxDis;
        private TextBox txtBoxPReo;
        private TextBox txtBoxPOr;
        private TextBox txtBoxPSt;
        private TextBox txtBoxPUn;
        private TextBox txtBoxPQu;
        private TextBox txtBoxPCa;
        private TextBox txtBoxPSu;
        private TextBox txtBoxPN;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPrID;
        private Label label1;
    }
}
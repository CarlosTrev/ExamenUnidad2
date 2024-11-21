namespace ExamenUnidad2
{
    partial class Eproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eproductos));
            tbControlP = new TabControl();
            tabPage1 = new TabPage();
            btnEditar = new Button();
            btnBorrar = new Button();
            txtBoxPr = new TextBox();
            cboxPr = new ComboBox();
            label1 = new Label();
            dgCPr = new DataGridView();
            tabPage2 = new TabPage();
            butAgregar = new Button();
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
            tbControlP.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCPr).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tbControlP
            // 
            tbControlP.Controls.Add(tabPage1);
            tbControlP.Controls.Add(tabPage2);
            tbControlP.Location = new Point(14, 16);
            tbControlP.Margin = new Padding(3, 4, 3, 4);
            tbControlP.Name = "tbControlP";
            tbControlP.SelectedIndex = 0;
            tbControlP.Size = new Size(871, 515);
            tbControlP.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(btnBorrar);
            tabPage1.Controls.Add(txtBoxPr);
            tabPage1.Controls.Add(cboxPr);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgCPr);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(863, 482);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consultar producto";
            // 
            // btnEditar
            // 
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(3, 439);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(218, 31);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar producto";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Red;
            btnBorrar.ForeColor = Color.Black;
            btnBorrar.Location = new Point(592, 439);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(263, 31);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar producto";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtBoxPr
            // 
            txtBoxPr.Enabled = false;
            txtBoxPr.Location = new Point(376, 13);
            txtBoxPr.Margin = new Padding(3, 4, 3, 4);
            txtBoxPr.Name = "txtBoxPr";
            txtBoxPr.Size = new Size(212, 27);
            txtBoxPr.TabIndex = 3;
            txtBoxPr.TextChanged += txtBoxPr_TextChanged;
            // 
            // cboxPr
            // 
            cboxPr.FormattingEnabled = true;
            cboxPr.Items.AddRange(new object[] { "ProductID", "ProductName", "CompanyName", "CategoryName", "QuantityPerUnit", "UnitPrice", "UnitsInStock", "UnitsOnOrder", "ReorderLevel", "Discontinued" });
            cboxPr.Location = new Point(120, 13);
            cboxPr.Margin = new Padding(3, 4, 3, 4);
            cboxPr.Name = "cboxPr";
            cboxPr.Size = new Size(218, 28);
            cboxPr.TabIndex = 2;
            cboxPr.SelectedIndexChanged += cboxPr_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Buscar por:";
            label1.Click += label1_Click;
            // 
            // dgCPr
            // 
            dgCPr.BackgroundColor = Color.Black;
            dgCPr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCPr.Location = new Point(7, 52);
            dgCPr.Margin = new Padding(3, 4, 3, 4);
            dgCPr.Name = "dgCPr";
            dgCPr.ReadOnly = true;
            dgCPr.RowHeadersWidth = 51;
            dgCPr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCPr.Size = new Size(848, 383);
            dgCPr.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(butAgregar);
            tabPage2.Controls.Add(cBoxDis);
            tabPage2.Controls.Add(txtBoxPReo);
            tabPage2.Controls.Add(txtBoxPOr);
            tabPage2.Controls.Add(txtBoxPSt);
            tabPage2.Controls.Add(txtBoxPUn);
            tabPage2.Controls.Add(txtBoxPQu);
            tabPage2.Controls.Add(txtBoxPCa);
            tabPage2.Controls.Add(txtBoxPSu);
            tabPage2.Controls.Add(txtBoxPN);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.ForeColor = Color.White;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(863, 482);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Agregar producto";
            // 
            // butAgregar
            // 
            butAgregar.BackColor = Color.White;
            butAgregar.ForeColor = Color.Black;
            butAgregar.Location = new Point(318, 400);
            butAgregar.Margin = new Padding(3, 4, 3, 4);
            butAgregar.Name = "butAgregar";
            butAgregar.Size = new Size(202, 31);
            butAgregar.TabIndex = 20;
            butAgregar.Text = "Agregar Producto";
            butAgregar.UseVisualStyleBackColor = false;
            butAgregar.Click += butAgregar_Click;
            // 
            // cBoxDis
            // 
            cBoxDis.FormattingEnabled = true;
            cBoxDis.Items.AddRange(new object[] { "0", "1" });
            cBoxDis.Location = new Point(546, 121);
            cBoxDis.Margin = new Padding(3, 4, 3, 4);
            cBoxDis.Name = "cBoxDis";
            cBoxDis.Size = new Size(138, 28);
            cBoxDis.TabIndex = 19;
            // 
            // txtBoxPReo
            // 
            txtBoxPReo.Location = new Point(546, 71);
            txtBoxPReo.Margin = new Padding(3, 4, 3, 4);
            txtBoxPReo.Name = "txtBoxPReo";
            txtBoxPReo.Size = new Size(114, 27);
            txtBoxPReo.TabIndex = 18;
            // 
            // txtBoxPOr
            // 
            txtBoxPOr.Location = new Point(546, 27);
            txtBoxPOr.Margin = new Padding(3, 4, 3, 4);
            txtBoxPOr.Name = "txtBoxPOr";
            txtBoxPOr.Size = new Size(114, 27);
            txtBoxPOr.TabIndex = 17;
            // 
            // txtBoxPSt
            // 
            txtBoxPSt.Location = new Point(190, 279);
            txtBoxPSt.Margin = new Padding(3, 4, 3, 4);
            txtBoxPSt.Name = "txtBoxPSt";
            txtBoxPSt.Size = new Size(114, 27);
            txtBoxPSt.TabIndex = 16;
            // 
            // txtBoxPUn
            // 
            txtBoxPUn.Location = new Point(190, 229);
            txtBoxPUn.Margin = new Padding(3, 4, 3, 4);
            txtBoxPUn.Name = "txtBoxPUn";
            txtBoxPUn.Size = new Size(114, 27);
            txtBoxPUn.TabIndex = 15;
            // 
            // txtBoxPQu
            // 
            txtBoxPQu.Location = new Point(190, 179);
            txtBoxPQu.Margin = new Padding(3, 4, 3, 4);
            txtBoxPQu.Name = "txtBoxPQu";
            txtBoxPQu.Size = new Size(114, 27);
            txtBoxPQu.TabIndex = 14;
            txtBoxPQu.TextChanged += txtBoxPQu_TextChanged;
            // 
            // txtBoxPCa
            // 
            txtBoxPCa.Location = new Point(190, 132);
            txtBoxPCa.Margin = new Padding(3, 4, 3, 4);
            txtBoxPCa.Name = "txtBoxPCa";
            txtBoxPCa.Size = new Size(114, 27);
            txtBoxPCa.TabIndex = 13;
            // 
            // txtBoxPSu
            // 
            txtBoxPSu.Location = new Point(190, 77);
            txtBoxPSu.Margin = new Padding(3, 4, 3, 4);
            txtBoxPSu.Name = "txtBoxPSu";
            txtBoxPSu.Size = new Size(114, 27);
            txtBoxPSu.TabIndex = 12;
            // 
            // txtBoxPN
            // 
            txtBoxPN.Location = new Point(190, 27);
            txtBoxPN.Margin = new Padding(3, 4, 3, 4);
            txtBoxPN.Name = "txtBoxPN";
            txtBoxPN.Size = new Size(114, 27);
            txtBoxPN.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(425, 121);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 9;
            label11.Text = "Discountinued:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(425, 71);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 8;
            label10.Text = "ReorderLevel:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(425, 27);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 7;
            label9.Text = "UnitsOnOrder:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 279);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 6;
            label8.Text = "UnitInStock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 229);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 5;
            label7.Text = "UnitPrice:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 179);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 4;
            label6.Text = "QuantityPerUnit:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 132);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 3;
            label5.Text = "CategoryID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 81);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 2;
            label4.Text = "SupplierID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 31);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 1;
            label3.Text = "ProductName:";
            // 
            // Eproductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(898, 537);
            Controls.Add(tbControlP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Eproductos";
            Text = "Eproductos";
            Load += Eproductos_Load;
            tbControlP.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCPr).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbControlP;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgCPr;
        private Label label1;
        private ComboBox cboxPr;
        private TextBox txtBoxPr;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button butAgregar;
        private ComboBox cBoxDis;
        private TextBox txtBoxPReo;
        private TextBox txtBoxPOr;
        private TextBox txtBoxPSt;
        private TextBox txtBoxPUn;
        private TextBox txtBoxPQu;
        private TextBox txtBoxPCa;
        private TextBox txtBoxPSu;
        private TextBox txtBoxPN;
        private Button btnBorrar;
        private Button btnEditar;
    }
}
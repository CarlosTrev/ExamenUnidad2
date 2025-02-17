﻿namespace ExamenUnidad2
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
            button1 = new Button();
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
            tabPage3 = new TabPage();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            tbControlP.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCPr).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tbControlP
            // 
            tbControlP.Controls.Add(tabPage1);
            tbControlP.Controls.Add(tabPage2);
            tbControlP.Controls.Add(tabPage3);
            tbControlP.Location = new Point(12, 12);
            tbControlP.Name = "tbControlP";
            tbControlP.SelectedIndex = 0;
            tbControlP.Size = new Size(762, 631);
            tbControlP.TabIndex = 0;
            tbControlP.SelectedIndexChanged += tbControlP_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(btnBorrar);
            tabPage1.Controls.Add(txtBoxPr);
            tabPage1.Controls.Add(cboxPr);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgCPr);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(754, 603);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consultar producto";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(262, 574);
            button1.Name = "button1";
            button1.Size = new Size(191, 23);
            button1.TabIndex = 6;
            button1.Text = "Exportar tabla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(6, 574);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(191, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar producto";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Red;
            btnBorrar.ForeColor = Color.Black;
            btnBorrar.Location = new Point(518, 574);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(230, 23);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar producto";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtBoxPr
            // 
            txtBoxPr.Enabled = false;
            txtBoxPr.Location = new Point(329, 10);
            txtBoxPr.Name = "txtBoxPr";
            txtBoxPr.Size = new Size(186, 23);
            txtBoxPr.TabIndex = 3;
            txtBoxPr.TextChanged += txtBoxPr_TextChanged;
            // 
            // cboxPr
            // 
            cboxPr.FormattingEnabled = true;
            cboxPr.Items.AddRange(new object[] { "ProductID", "ProductName", "CompanyName", "CategoryName", "QuantityPerUnit", "UnitPrice", "UnitsInStock", "UnitsOnOrder", "ReorderLevel", "Discontinued" });
            cboxPr.Location = new Point(105, 10);
            cboxPr.Name = "cboxPr";
            cboxPr.Size = new Size(191, 23);
            cboxPr.TabIndex = 2;
            cboxPr.SelectedIndexChanged += cboxPr_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar por:";
            label1.Click += label1_Click;
            // 
            // dgCPr
            // 
            dgCPr.BackgroundColor = Color.Black;
            dgCPr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCPr.Location = new Point(6, 39);
            dgCPr.Name = "dgCPr";
            dgCPr.ReadOnly = true;
            dgCPr.RowHeadersWidth = 51;
            dgCPr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCPr.Size = new Size(742, 520);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(754, 603);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Agregar producto";
            // 
            // butAgregar
            // 
            butAgregar.BackColor = Color.White;
            butAgregar.ForeColor = Color.Black;
            butAgregar.Location = new Point(278, 300);
            butAgregar.Name = "butAgregar";
            butAgregar.Size = new Size(177, 23);
            butAgregar.TabIndex = 20;
            butAgregar.Text = "Agregar Producto";
            butAgregar.UseVisualStyleBackColor = false;
            butAgregar.Click += butAgregar_Click;
            // 
            // cBoxDis
            // 
            cBoxDis.FormattingEnabled = true;
            cBoxDis.Items.AddRange(new object[] { "0", "1" });
            cBoxDis.Location = new Point(478, 91);
            cBoxDis.Name = "cBoxDis";
            cBoxDis.Size = new Size(121, 23);
            cBoxDis.TabIndex = 19;
            // 
            // txtBoxPReo
            // 
            txtBoxPReo.Location = new Point(478, 53);
            txtBoxPReo.Name = "txtBoxPReo";
            txtBoxPReo.Size = new Size(100, 23);
            txtBoxPReo.TabIndex = 18;
            // 
            // txtBoxPOr
            // 
            txtBoxPOr.Location = new Point(478, 20);
            txtBoxPOr.Name = "txtBoxPOr";
            txtBoxPOr.Size = new Size(100, 23);
            txtBoxPOr.TabIndex = 17;
            // 
            // txtBoxPSt
            // 
            txtBoxPSt.Location = new Point(166, 209);
            txtBoxPSt.Name = "txtBoxPSt";
            txtBoxPSt.Size = new Size(100, 23);
            txtBoxPSt.TabIndex = 16;
            // 
            // txtBoxPUn
            // 
            txtBoxPUn.Location = new Point(166, 172);
            txtBoxPUn.Name = "txtBoxPUn";
            txtBoxPUn.Size = new Size(100, 23);
            txtBoxPUn.TabIndex = 15;
            // 
            // txtBoxPQu
            // 
            txtBoxPQu.Location = new Point(166, 134);
            txtBoxPQu.Name = "txtBoxPQu";
            txtBoxPQu.Size = new Size(100, 23);
            txtBoxPQu.TabIndex = 14;
            txtBoxPQu.TextChanged += txtBoxPQu_TextChanged;
            // 
            // txtBoxPCa
            // 
            txtBoxPCa.Location = new Point(166, 99);
            txtBoxPCa.Name = "txtBoxPCa";
            txtBoxPCa.Size = new Size(100, 23);
            txtBoxPCa.TabIndex = 13;
            // 
            // txtBoxPSu
            // 
            txtBoxPSu.Location = new Point(166, 58);
            txtBoxPSu.Name = "txtBoxPSu";
            txtBoxPSu.Size = new Size(100, 23);
            txtBoxPSu.TabIndex = 12;
            // 
            // txtBoxPN
            // 
            txtBoxPN.Location = new Point(166, 20);
            txtBoxPN.Name = "txtBoxPN";
            txtBoxPN.Size = new Size(100, 23);
            txtBoxPN.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(372, 91);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 9;
            label11.Text = "Discountinued:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(372, 53);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 8;
            label10.Text = "ReorderLevel:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(372, 20);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 7;
            label9.Text = "UnitsOnOrder:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 209);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 6;
            label8.Text = "UnitInStock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 172);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 5;
            label7.Text = "UnitPrice:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 134);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 4;
            label6.Text = "QuantityPerUnit:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 99);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 3;
            label5.Text = "CategoryID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 61);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 2;
            label4.Text = "SupplierID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 23);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 1;
            label3.Text = "ProductName:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(plotView1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(754, 603);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Grafica";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // plotView1
            // 
            plotView1.Location = new Point(15, 13);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(721, 587);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Eproductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(786, 655);
            Controls.Add(tbControlP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Eproductos";
            Text = "Eproductos";
            Load += Eproductos_Load;
            tbControlP.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCPr).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
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
        private TabPage tabPage3;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Button button1;
    }
}
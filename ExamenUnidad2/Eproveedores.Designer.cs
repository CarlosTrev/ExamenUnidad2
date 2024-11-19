namespace ExamenUnidad2
{
    partial class Eproveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eproveedores));
            tbControlProvee = new TabControl();
            tabPage1 = new TabPage();
            btnEditar = new Button();
            btnBorrar = new Button();
            txtBoxProvee = new TextBox();
            cboxProvee = new ComboBox();
            label1 = new Label();
            dgCProvee = new DataGridView();
            tabPage2 = new TabPage();
            txtBoxCph = new TextBox();
            txtBoxCHP = new TextBox();
            txtBoxCFa = new TextBox();
            label12 = new Label();
            label13 = new Label();
            butAgregar = new Button();
            txtBoxCco = new TextBox();
            txtBoxCpo = new TextBox();
            txtBoxCRe = new TextBox();
            txtBoxCci = new TextBox();
            txtBoxCad = new TextBox();
            txtBoxCtT = new TextBox();
            txtBoxCtN = new TextBox();
            txtBoxCN = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbControlProvee.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCProvee).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tbControlProvee
            // 
            tbControlProvee.Controls.Add(tabPage1);
            tbControlProvee.Controls.Add(tabPage2);
            tbControlProvee.Location = new Point(12, 12);
            tbControlProvee.Name = "tbControlProvee";
            tbControlProvee.SelectedIndex = 0;
            tbControlProvee.Size = new Size(762, 386);
            tbControlProvee.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(btnBorrar);
            tabPage1.Controls.Add(txtBoxProvee);
            tabPage1.Controls.Add(cboxProvee);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgCProvee);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(754, 358);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consultar proveedor";
            // 
            // btnEditar
            // 
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(6, 329);
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
            btnBorrar.Location = new Point(518, 332);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(230, 23);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar producto";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtBoxProvee
            // 
            txtBoxProvee.Enabled = false;
            txtBoxProvee.Location = new Point(329, 10);
            txtBoxProvee.Name = "txtBoxProvee";
            txtBoxProvee.Size = new Size(186, 23);
            txtBoxProvee.TabIndex = 3;
            txtBoxProvee.TextChanged += txtBoxProvee_TextChanged;
            // 
            // cboxProvee
            // 
            cboxProvee.FormattingEnabled = true;
            cboxProvee.Items.AddRange(new object[] { "SupplierID", "CompanyName", "ContactName", "ContactTitle", "Address", "City", "Region", "PostalCode", "Country", "Phone", "Fax", "HomePage" });
            cboxProvee.Location = new Point(105, 10);
            cboxProvee.Name = "cboxProvee";
            cboxProvee.Size = new Size(191, 23);
            cboxProvee.TabIndex = 2;
            cboxProvee.SelectedIndexChanged += cboxProvee_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar por:";
            // 
            // dgCProvee
            // 
            dgCProvee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCProvee.Location = new Point(6, 39);
            dgCProvee.Name = "dgCProvee";
            dgCProvee.ReadOnly = true;
            dgCProvee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCProvee.Size = new Size(742, 287);
            dgCProvee.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(txtBoxCph);
            tabPage2.Controls.Add(txtBoxCHP);
            tabPage2.Controls.Add(txtBoxCFa);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(butAgregar);
            tabPage2.Controls.Add(txtBoxCco);
            tabPage2.Controls.Add(txtBoxCpo);
            tabPage2.Controls.Add(txtBoxCRe);
            tabPage2.Controls.Add(txtBoxCci);
            tabPage2.Controls.Add(txtBoxCad);
            tabPage2.Controls.Add(txtBoxCtT);
            tabPage2.Controls.Add(txtBoxCtN);
            tabPage2.Controls.Add(txtBoxCN);
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
            tabPage2.Size = new Size(754, 358);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Agregar proveedor";
            // 
            // txtBoxCph
            // 
            txtBoxCph.Location = new Point(478, 94);
            txtBoxCph.Name = "txtBoxCph";
            txtBoxCph.Size = new Size(100, 23);
            txtBoxCph.TabIndex = 26;
            // 
            // txtBoxCHP
            // 
            txtBoxCHP.Location = new Point(478, 167);
            txtBoxCHP.Name = "txtBoxCHP";
            txtBoxCHP.Size = new Size(100, 23);
            txtBoxCHP.TabIndex = 25;
            // 
            // txtBoxCFa
            // 
            txtBoxCFa.Location = new Point(478, 134);
            txtBoxCFa.Name = "txtBoxCFa";
            txtBoxCFa.Size = new Size(100, 23);
            txtBoxCFa.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(375, 170);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 22;
            label12.Text = "HomePage:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(375, 137);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 21;
            label13.Text = "Fax:";
            // 
            // butAgregar
            // 
            butAgregar.ForeColor = Color.Black;
            butAgregar.Location = new Point(278, 300);
            butAgregar.Name = "butAgregar";
            butAgregar.Size = new Size(177, 23);
            butAgregar.TabIndex = 20;
            butAgregar.Text = "Agregar Proveedor";
            butAgregar.UseVisualStyleBackColor = true;
            butAgregar.Click += butAgregar_Click;
            // 
            // txtBoxCco
            // 
            txtBoxCco.Location = new Point(478, 53);
            txtBoxCco.Name = "txtBoxCco";
            txtBoxCco.Size = new Size(100, 23);
            txtBoxCco.TabIndex = 18;
            // 
            // txtBoxCpo
            // 
            txtBoxCpo.Location = new Point(478, 20);
            txtBoxCpo.Name = "txtBoxCpo";
            txtBoxCpo.Size = new Size(100, 23);
            txtBoxCpo.TabIndex = 17;
            // 
            // txtBoxCRe
            // 
            txtBoxCRe.Location = new Point(166, 209);
            txtBoxCRe.Name = "txtBoxCRe";
            txtBoxCRe.Size = new Size(100, 23);
            txtBoxCRe.TabIndex = 16;
            // 
            // txtBoxCci
            // 
            txtBoxCci.Location = new Point(166, 172);
            txtBoxCci.Name = "txtBoxCci";
            txtBoxCci.Size = new Size(100, 23);
            txtBoxCci.TabIndex = 15;
            // 
            // txtBoxCad
            // 
            txtBoxCad.Location = new Point(166, 134);
            txtBoxCad.Name = "txtBoxCad";
            txtBoxCad.Size = new Size(100, 23);
            txtBoxCad.TabIndex = 14;
            // 
            // txtBoxCtT
            // 
            txtBoxCtT.Location = new Point(166, 99);
            txtBoxCtT.Name = "txtBoxCtT";
            txtBoxCtT.Size = new Size(100, 23);
            txtBoxCtT.TabIndex = 13;
            // 
            // txtBoxCtN
            // 
            txtBoxCtN.Location = new Point(166, 58);
            txtBoxCtN.Name = "txtBoxCtN";
            txtBoxCtN.Size = new Size(100, 23);
            txtBoxCtN.TabIndex = 12;
            // 
            // txtBoxCN
            // 
            txtBoxCN.Location = new Point(166, 20);
            txtBoxCN.Name = "txtBoxCN";
            txtBoxCN.Size = new Size(100, 23);
            txtBoxCN.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(375, 94);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 9;
            label11.Text = "Phone:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(375, 56);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 8;
            label10.Text = "Country:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(375, 23);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 7;
            label9.Text = "PostalCode:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 212);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 6;
            label8.Text = "Region:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 175);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 5;
            label7.Text = "City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 137);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 4;
            label6.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 102);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 3;
            label5.Text = "ContactTitle:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 64);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 2;
            label4.Text = "ContactName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 26);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 1;
            label3.Text = "CompanyName:";
            // 
            // Eproveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(783, 409);
            Controls.Add(tbControlProvee);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Eproveedores";
            Text = "Eproveedores";
            Load += Eproveedores_Load;
            tbControlProvee.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCProvee).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbControlProvee;
        private TabPage tabPage1;
        private Button btnEditar;
        private Button btnBorrar;
        private TextBox txtBoxProvee;
        private ComboBox cboxProvee;
        private Label label1;
        private DataGridView dgCProvee;
        private TabPage tabPage2;
        private Button butAgregar;
        private TextBox txtBoxCco;
        private TextBox txtBoxCpo;
        private TextBox txtBoxCRe;
        private TextBox txtBoxCci;
        private TextBox txtBoxCad;
        private TextBox txtBoxCtT;
        private TextBox txtBoxCtN;
        private ComboBox cBoxDis;
        private TextBox txtBoxPReo;
        private TextBox txtBoxPOr;
        private TextBox txtBoxPSt;
        private TextBox txtBoxPUn;
        private TextBox txtBoxPQu;
        private TextBox txtBoxPCa;
        private TextBox txtBoxPSu;
        private TextBox txtBoxCN;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtBoxCph;
        private TextBox txtBoxCHP;
        private TextBox txtBoxCFa;
        private Label label12;
        private Label label13;
    }
}
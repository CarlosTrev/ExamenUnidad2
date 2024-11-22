namespace ExamenUnidad2
{
    partial class ETerritorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ETerritorios));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtidterritorio = new TextBox();
            txtidempleado = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnETE = new Button();
            btnATE = new Button();
            dgvETerritorios = new DataGridView();
            tabPage2 = new TabPage();
            btnAT = new Button();
            dgvTerritorios = new DataGridView();
            tabPage3 = new TabPage();
            button1 = new Button();
            dgvRegion = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvETerritorios).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTerritorios).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegion).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(790, 389);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(txtidterritorio);
            tabPage1.Controls.Add(txtidempleado);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnETE);
            tabPage1.Controls.Add(btnATE);
            tabPage1.Controls.Add(dgvETerritorios);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(782, 361);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Territorios de empleado";
            tabPage1.Click += tabPage1_Click;
            // 
            // txtidterritorio
            // 
            txtidterritorio.Location = new Point(130, 316);
            txtidterritorio.Margin = new Padding(3, 2, 3, 2);
            txtidterritorio.Name = "txtidterritorio";
            txtidterritorio.Size = new Size(110, 23);
            txtidterritorio.TabIndex = 6;
            // 
            // txtidempleado
            // 
            txtidempleado.Location = new Point(130, 281);
            txtidempleado.Margin = new Padding(3, 2, 3, 2);
            txtidempleado.Name = "txtidempleado";
            txtidempleado.Size = new Size(110, 23);
            txtidempleado.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 318);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "ID territorio:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 284);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "ID empleado: ";
            // 
            // btnETE
            // 
            btnETE.BackColor = Color.Black;
            btnETE.ForeColor = Color.White;
            btnETE.Location = new Point(537, 284);
            btnETE.Margin = new Padding(3, 2, 3, 2);
            btnETE.Name = "btnETE";
            btnETE.Size = new Size(82, 22);
            btnETE.TabIndex = 2;
            btnETE.Text = "Eliminar";
            btnETE.UseVisualStyleBackColor = false;
            btnETE.Click += btnETE_Click;
            // 
            // btnATE
            // 
            btnATE.BackColor = Color.Black;
            btnATE.ForeColor = Color.White;
            btnATE.Location = new Point(470, 317);
            btnATE.Margin = new Padding(3, 2, 3, 2);
            btnATE.Name = "btnATE";
            btnATE.Size = new Size(240, 22);
            btnATE.TabIndex = 1;
            btnATE.Text = "Añadir territorio a empleado";
            btnATE.UseVisualStyleBackColor = false;
            btnATE.Click += btnATE_Click;
            // 
            // dgvETerritorios
            // 
            dgvETerritorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvETerritorios.Location = new Point(5, 13);
            dgvETerritorios.Margin = new Padding(3, 2, 3, 2);
            dgvETerritorios.Name = "dgvETerritorios";
            dgvETerritorios.RowHeadersWidth = 51;
            dgvETerritorios.Size = new Size(771, 264);
            dgvETerritorios.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(btnAT);
            tabPage2.Controls.Add(dgvTerritorios);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(782, 361);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Territorios";
            // 
            // btnAT
            // 
            btnAT.BackColor = Color.Black;
            btnAT.ForeColor = Color.White;
            btnAT.Location = new Point(592, 152);
            btnAT.Margin = new Padding(3, 2, 3, 2);
            btnAT.Name = "btnAT";
            btnAT.Size = new Size(133, 22);
            btnAT.TabIndex = 1;
            btnAT.Text = "Añadir territorio";
            btnAT.UseVisualStyleBackColor = false;
            btnAT.Click += btnAT_Click;
            // 
            // dgvTerritorios
            // 
            dgvTerritorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerritorios.Location = new Point(16, 20);
            dgvTerritorios.Margin = new Padding(3, 2, 3, 2);
            dgvTerritorios.Name = "dgvTerritorios";
            dgvTerritorios.RowHeadersWidth = 51;
            dgvTerritorios.Size = new Size(500, 260);
            dgvTerritorios.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Black;
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(dgvRegion);
            tabPage3.ForeColor = Color.White;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(782, 361);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Region";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Location = new Point(309, 323);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 1;
            button1.Text = "Exportar tabla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvRegion
            // 
            dgvRegion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegion.Location = new Point(15, 15);
            dgvRegion.Margin = new Padding(3, 2, 3, 2);
            dgvRegion.Name = "dgvRegion";
            dgvRegion.RowHeadersWidth = 51;
            dgvRegion.Size = new Size(749, 271);
            dgvRegion.TabIndex = 0;
            // 
            // ETerritorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(821, 407);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ETerritorios";
            Text = "ETerritorios";
            Load += ETerritorios_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvETerritorios).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTerritorios).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvETerritorios;
        private TabPage tabPage3;
        private DataGridView dgvTerritorios;
        private DataGridView dgvRegion;
        private Button btnETE;
        private Button btnATE;
        private Button btnAT;
        private Label label2;
        private Label label1;
        private TextBox txtidterritorio;
        private TextBox txtidempleado;
        private Button button1;
    }
}
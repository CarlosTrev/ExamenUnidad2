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
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(903, 519);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtidterritorio);
            tabPage1.Controls.Add(txtidempleado);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnETE);
            tabPage1.Controls.Add(btnATE);
            tabPage1.Controls.Add(dgvETerritorios);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(895, 486);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Territorios de empleado";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // txtidterritorio
            // 
            txtidterritorio.Location = new Point(148, 421);
            txtidterritorio.Name = "txtidterritorio";
            txtidterritorio.Size = new Size(125, 27);
            txtidterritorio.TabIndex = 6;
            // 
            // txtidempleado
            // 
            txtidempleado.Location = new Point(148, 375);
            txtidempleado.Name = "txtidempleado";
            txtidempleado.Size = new Size(125, 27);
            txtidempleado.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 424);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "ID territorio:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 378);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 3;
            label1.Text = "ID empleado: ";
            // 
            // btnETE
            // 
            btnETE.Location = new Point(537, 392);
            btnETE.Name = "btnETE";
            btnETE.Size = new Size(94, 29);
            btnETE.TabIndex = 2;
            btnETE.Text = "Eliminar";
            btnETE.UseVisualStyleBackColor = true;
            btnETE.Click += btnETE_Click;
            // 
            // btnATE
            // 
            btnATE.Location = new Point(85, 454);
            btnATE.Name = "btnATE";
            btnATE.Size = new Size(274, 29);
            btnATE.TabIndex = 1;
            btnATE.Text = "Añadir territorio a empleado";
            btnATE.UseVisualStyleBackColor = true;
            btnATE.Click += btnATE_Click;
            // 
            // dgvETerritorios
            // 
            dgvETerritorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvETerritorios.Location = new Point(6, 17);
            dgvETerritorios.Name = "dgvETerritorios";
            dgvETerritorios.RowHeadersWidth = 51;
            dgvETerritorios.Size = new Size(536, 352);
            dgvETerritorios.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAT);
            tabPage2.Controls.Add(dgvTerritorios);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(895, 486);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Territorios";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAT
            // 
            btnAT.Location = new Point(676, 203);
            btnAT.Name = "btnAT";
            btnAT.Size = new Size(152, 29);
            btnAT.TabIndex = 1;
            btnAT.Text = "Añadir territorio";
            btnAT.UseVisualStyleBackColor = true;
            btnAT.Click += btnAT_Click;
            // 
            // dgvTerritorios
            // 
            dgvTerritorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerritorios.Location = new Point(18, 27);
            dgvTerritorios.Name = "dgvTerritorios";
            dgvTerritorios.RowHeadersWidth = 51;
            dgvTerritorios.Size = new Size(572, 347);
            dgvTerritorios.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvRegion);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(895, 486);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Region";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvRegion
            // 
            dgvRegion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegion.Location = new Point(17, 20);
            dgvRegion.Name = "dgvRegion";
            dgvRegion.RowHeadersWidth = 51;
            dgvRegion.Size = new Size(382, 267);
            dgvRegion.TabIndex = 0;
            // 
            // ETerritorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 543);
            Controls.Add(tabControl1);
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
    }
}
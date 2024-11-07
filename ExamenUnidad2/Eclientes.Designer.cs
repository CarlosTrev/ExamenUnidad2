namespace ExamenUnidad2
{
    partial class Eclientes
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
            cmbEclientes = new ComboBox();
            dgvEclientes = new DataGridView();
            Editar = new DataGridViewImageColumn();
            label1 = new Label();
            txtbxEclientes = new TextBox();
            btnEliminar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEclientes).BeginInit();
            SuspendLayout();
            // 
            // cmbEclientes
            // 
            cmbEclientes.FormattingEnabled = true;
            cmbEclientes.Items.AddRange(new object[] { "Customer ID", "Company name ", "Contact name", "Contact title", "Address", "City", "Region", "Postal Code", "Country", "Phone ", "Fax" });
            cmbEclientes.Location = new Point(12, 30);
            cmbEclientes.Name = "cmbEclientes";
            cmbEclientes.Size = new Size(252, 28);
            cmbEclientes.TabIndex = 0;
            // 
            // dgvEclientes
            // 
            dgvEclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEclientes.Columns.AddRange(new DataGridViewColumn[] { Editar });
            dgvEclientes.Location = new Point(12, 78);
            dgvEclientes.Name = "dgvEclientes";
            dgvEclientes.RowHeadersWidth = 51;
            dgvEclientes.Size = new Size(837, 401);
            dgvEclientes.TabIndex = 1;
            dgvEclientes.CellContentClick += dgvEclientes_CellContentClick;
            dgvEclientes.CellContentDoubleClick += dgvEclientes_CellContentDoubleClick;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Buscar por: ";
            // 
            // txtbxEclientes
            // 
            txtbxEclientes.Location = new Point(280, 31);
            txtbxEclientes.Name = "txtbxEclientes";
            txtbxEclientes.Size = new Size(228, 27);
            txtbxEclientes.TabIndex = 3;
            txtbxEclientes.TextChanged += txtbxEclientes_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 485);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(191, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar cliente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(659, 485);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(190, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // Eclientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 526);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(txtbxEclientes);
            Controls.Add(label1);
            Controls.Add(dgvEclientes);
            Controls.Add(cmbEclientes);
            Name = "Eclientes";
            Text = "Eclientes";
            Load += Eclientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEclientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEclientes;
        private DataGridView dgvEclientes;
        private Label label1;
        private TextBox txtbxEclientes;
        private DataGridViewImageColumn Editar;
        private Button btnEliminar;
        private Button btnAgregar;
    }
}
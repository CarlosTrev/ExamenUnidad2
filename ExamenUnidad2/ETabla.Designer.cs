namespace ExamenUnidad2
{
    partial class ETabla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ETabla));
            dgvEmpleados = new DataGridView();
            Editar = new DataGridViewImageColumn();
            lbleditar = new Label();
            btnTerritorios = new Button();
            btnEliminarEmpleado = new Button();
            btnAgregarEmpleado = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { Editar });
            dgvEmpleados.Location = new Point(14, 36);
            dgvEmpleados.Margin = new Padding(3, 4, 3, 4);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(762, 321);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Width = 125;
            // 
            // lbleditar
            // 
            lbleditar.AutoSize = true;
            lbleditar.Location = new Point(14, 12);
            lbleditar.Name = "lbleditar";
            lbleditar.Size = new Size(0, 20);
            lbleditar.TabIndex = 1;
            // 
            // btnTerritorios
            // 
            btnTerritorios.Location = new Point(330, 364);
            btnTerritorios.Name = "btnTerritorios";
            btnTerritorios.Size = new Size(94, 29);
            btnTerritorios.TabIndex = 2;
            btnTerritorios.Text = "Territorios";
            btnTerritorios.UseVisualStyleBackColor = true;
            btnTerritorios.Click += btnTerritorios_Click;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(31, 364);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(191, 29);
            btnEliminarEmpleado.TabIndex = 3;
            btnEliminarEmpleado.Text = "Eliminar empleado";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(615, 364);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(161, 29);
            btnAgregarEmpleado.TabIndex = 4;
            btnAgregarEmpleado.Text = "Agregar empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // ETabla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(790, 422);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(btnTerritorios);
            Controls.Add(lbleditar);
            Controls.Add(dgvEmpleados);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ETabla";
            Text = "Empleadotabla";
            Load += Empleadotabla_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Label lbleditar;
        private DataGridViewImageColumn Editar;
        private Button btnTerritorios;
        private Button btnEliminarEmpleado;
        private Button btnAgregarEmpleado;
    }
}
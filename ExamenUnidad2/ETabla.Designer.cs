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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { Editar });
            dgvEmpleados.Location = new Point(12, 27);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(667, 241);
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
            lbleditar.Location = new Point(12, 9);
            lbleditar.Name = "lbleditar";
            lbleditar.Size = new Size(0, 15);
            lbleditar.TabIndex = 1;
            // 
            // btnTerritorios
            // 
            btnTerritorios.Location = new Point(243, 273);
            btnTerritorios.Margin = new Padding(3, 2, 3, 2);
            btnTerritorios.Name = "btnTerritorios";
            btnTerritorios.Size = new Size(82, 22);
            btnTerritorios.TabIndex = 2;
            btnTerritorios.Text = "Territorios";
            btnTerritorios.UseVisualStyleBackColor = true;
            btnTerritorios.Click += btnTerritorios_Click;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(27, 273);
            btnEliminarEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(167, 22);
            btnEliminarEmpleado.TabIndex = 3;
            btnEliminarEmpleado.Text = "Eliminar empleado";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(538, 273);
            btnAgregarEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(141, 22);
            btnAgregarEmpleado.TabIndex = 4;
            btnAgregarEmpleado.Text = "Agregar empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // button1
            // 
            button1.Location = new Point(390, 273);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 22);
            button1.TabIndex = 5;
            button1.Text = "Exportar tabla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ETabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(691, 316);
            Controls.Add(button1);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(btnTerritorios);
            Controls.Add(lbleditar);
            Controls.Add(dgvEmpleados);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
        private Button button1;
    }
}
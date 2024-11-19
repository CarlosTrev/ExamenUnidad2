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
            lbleditar = new Label();
            Editar = new DataGridViewImageColumn();
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
            // lbleditar
            // 
            lbleditar.AutoSize = true;
            lbleditar.Location = new Point(12, 9);
            lbleditar.Name = "lbleditar";
            lbleditar.Size = new Size(0, 15);
            lbleditar.TabIndex = 1;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            Editar.Name = "Editar";
            // 
            // ETabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(691, 291);
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
    }
}
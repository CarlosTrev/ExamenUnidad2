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
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvEmpleados.Location = new Point(12, 50);

            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(522, 241);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbleditar
            // 
            lbleditar.AutoSize = true;
            lbleditar.Location = new Point(12, 9);
            lbleditar.Name = "lbleditar";
            lbleditar.Size = new Size(0, 20);
            lbleditar.TabIndex = 1;
            // 
            // ETabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 398);
            Controls.Add(lbleditar);
        
            Controls.Add(dgvEmpleados);
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
    }
}
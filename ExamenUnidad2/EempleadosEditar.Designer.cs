namespace ExamenUnidad2
{
    partial class EempleadosEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EempleadosEditar));
            dgEmpleadosEditar = new DataGridView();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEmpleadosEditar).BeginInit();
            SuspendLayout();
            // 
            // dgEmpleadosEditar
            // 
            dgEmpleadosEditar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpleadosEditar.Location = new Point(12, 21);
            dgEmpleadosEditar.Name = "dgEmpleadosEditar";
            dgEmpleadosEditar.Size = new Size(776, 150);
            dgEmpleadosEditar.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.ForeColor = Color.Red;
            btnGuardar.Location = new Point(358, 188);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Aplicar cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // EempleadosEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 223);
            Controls.Add(btnGuardar);
            Controls.Add(dgEmpleadosEditar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EempleadosEditar";
            Text = "EempleadosEditar";
            ((System.ComponentModel.ISupportInitialize)dgEmpleadosEditar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgEmpleadosEditar;
        private Button btnGuardar;
    }
}
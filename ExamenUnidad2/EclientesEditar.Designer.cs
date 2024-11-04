namespace ExamenUnidad2
{
    partial class EclientesEditar
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
            dgvClientesEditar = new DataGridView();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientesEditar).BeginInit();
            SuspendLayout();
            // 
            // dgvClientesEditar
            // 
            dgvClientesEditar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientesEditar.Location = new Point(12, 12);
            dgvClientesEditar.Name = "dgvClientesEditar";
            dgvClientesEditar.RowHeadersWidth = 51;
            dgvClientesEditar.Size = new Size(860, 157);
            dgvClientesEditar.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(355, 200);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(191, 32);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Aplicar cambios";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // EclientesEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 258);
            Controls.Add(btnEditar);
            Controls.Add(dgvClientesEditar);
            Name = "EclientesEditar";
            Text = "EclientesEditar";
            Load += EclientesEditar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientesEditar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientesEditar;
        private Button btnEditar;
    }
}
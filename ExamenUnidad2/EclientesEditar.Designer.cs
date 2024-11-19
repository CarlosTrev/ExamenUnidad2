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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EclientesEditar));
            dgvClientesEditar = new DataGridView();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientesEditar).BeginInit();
            SuspendLayout();
            // 
            // dgvClientesEditar
            // 
            dgvClientesEditar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientesEditar.Location = new Point(10, 9);
            dgvClientesEditar.Margin = new Padding(3, 2, 3, 2);
            dgvClientesEditar.Name = "dgvClientesEditar";
            dgvClientesEditar.RowHeadersWidth = 51;
            dgvClientesEditar.Size = new Size(752, 118);
            dgvClientesEditar.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(311, 150);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(167, 24);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Aplicar cambios";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // EclientesEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(767, 194);
            Controls.Add(btnEditar);
            Controls.Add(dgvClientesEditar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
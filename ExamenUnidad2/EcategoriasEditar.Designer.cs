namespace ExamenUnidad2
{
    partial class EcategoriasEditar
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
            dataGridView1 = new DataGridView();
            btnCateEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(721, 118);
            dataGridView1.TabIndex = 0;
            // 
            // btnCateEditar
            // 
            btnCateEditar.BackColor = SystemColors.ActiveCaptionText;
            btnCateEditar.ForeColor = Color.White;
            btnCateEditar.Location = new Point(347, 158);
            btnCateEditar.Name = "btnCateEditar";
            btnCateEditar.Size = new Size(114, 22);
            btnCateEditar.TabIndex = 1;
            btnCateEditar.Text = "Aplicar cambios";
            btnCateEditar.UseVisualStyleBackColor = false;
            btnCateEditar.Click += btnCateEditar_Click;
            // 
            // EcategoriasEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 208);
            Controls.Add(btnCateEditar);
            Controls.Add(dataGridView1);
            Name = "EcategoriasEditar";
            Text = "EcategoriasEditar";
            Load += EcategoriasEditar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCateEditar;
    }
}
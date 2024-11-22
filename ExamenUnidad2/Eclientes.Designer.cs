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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eclientes));
            cmbEclientes = new ComboBox();
            dgvEclientes = new DataGridView();
            Editar = new DataGridViewImageColumn();
            label1 = new Label();
            txtbxEclientes = new TextBox();
            btnEliminar = new Button();
            btnAgregar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEclientes).BeginInit();
            SuspendLayout();
            // 
            // cmbEclientes
            // 
            cmbEclientes.BackColor = SystemColors.MenuText;
            cmbEclientes.ForeColor = SystemColors.Window;
            cmbEclientes.FormattingEnabled = true;
            cmbEclientes.Items.AddRange(new object[] { "Customer ID", "Company name ", "Contact name", "Contact title", "Address", "City", "Region", "Postal Code", "Country", "Phone ", "Fax" });
            cmbEclientes.Location = new Point(10, 22);
            cmbEclientes.Margin = new Padding(3, 2, 3, 2);
            cmbEclientes.Name = "cmbEclientes";
            cmbEclientes.Size = new Size(221, 23);
            cmbEclientes.TabIndex = 0;
            cmbEclientes.SelectedIndexChanged += cmbEclientes_SelectedIndexChanged;
            // 
            // dgvEclientes
            // 
            dgvEclientes.BackgroundColor = Color.LightGray;
            dgvEclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEclientes.Columns.AddRange(new DataGridViewColumn[] { Editar });
            dgvEclientes.GridColor = SystemColors.ControlText;
            dgvEclientes.Location = new Point(10, 58);
            dgvEclientes.Margin = new Padding(3, 2, 3, 2);
            dgvEclientes.Name = "dgvEclientes";
            dgvEclientes.RowHeadersWidth = 51;
            dgvEclientes.Size = new Size(732, 301);
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
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(10, 5);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "Buscar por: ";
            // 
            // txtbxEclientes
            // 
            txtbxEclientes.BackColor = SystemColors.ActiveBorder;
            txtbxEclientes.Enabled = false;
            txtbxEclientes.ForeColor = SystemColors.Window;
            txtbxEclientes.Location = new Point(245, 23);
            txtbxEclientes.Margin = new Padding(3, 2, 3, 2);
            txtbxEclientes.Name = "txtbxEclientes";
            txtbxEclientes.Size = new Size(200, 23);
            txtbxEclientes.TabIndex = 3;
            txtbxEclientes.TextChanged += txtbxEclientes_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(574, 363);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(167, 22);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar cliente";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.WhiteSmoke;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(12, 364);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(166, 22);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar cliente";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(304, 363);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(166, 22);
            button1.TabIndex = 6;
            button1.Text = "Grafica";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Eclientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MAy198i;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(753, 394);
            Controls.Add(button1);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(txtbxEclientes);
            Controls.Add(label1);
            Controls.Add(dgvEclientes);
            Controls.Add(cmbEclientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
        private Button button1;
    }
}
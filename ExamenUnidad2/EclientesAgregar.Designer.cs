namespace ExamenUnidad2
{
    partial class EclientesAgregar
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
            txtbNC = new TextBox();
            label2 = new Label();
            txtbNCon = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtbxDireccion = new TextBox();
            label5 = new Label();
            txtbxCiudad = new TextBox();
            label6 = new Label();
            txtbxRegion = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtbxPais = new TextBox();
            label9 = new Label();
            txtbxTelefono = new TextBox();
            label10 = new Label();
            txtbxFax = new TextBox();
            label11 = new Label();
            cmbbxTitulo = new ComboBox();
            chbxRegion = new CheckBox();
            chboxCP = new CheckBox();
            chbxFax = new CheckBox();
            btnAgregarC = new Button();
            txtbxCP = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtbNC
            // 
            txtbNC.Location = new Point(134, 40);
            txtbNC.Name = "txtbNC";
            txtbNC.Size = new Size(125, 27);
            txtbNC.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Company Name";
            label2.Click += label2_Click;
            // 
            // txtbNCon
            // 
            txtbNCon.Location = new Point(134, 73);
            txtbNCon.Name = "txtbNCon";
            txtbNCon.Size = new Size(125, 27);
            txtbNCon.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 4;
            label3.Text = "Contact name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 6;
            label4.Text = "Contact title";
            // 
            // txtbxDireccion
            // 
            txtbxDireccion.Location = new Point(134, 137);
            txtbxDireccion.Name = "txtbxDireccion";
            txtbxDireccion.Size = new Size(125, 27);
            txtbxDireccion.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 135);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 8;
            label5.Text = "Address";
            label5.Click += label5_Click;
            // 
            // txtbxCiudad
            // 
            txtbxCiudad.Location = new Point(134, 171);
            txtbxCiudad.Name = "txtbxCiudad";
            txtbxCiudad.Size = new Size(125, 27);
            txtbxCiudad.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 171);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 10;
            label6.Text = "City";
            // 
            // txtbxRegion
            // 
            txtbxRegion.Location = new Point(134, 204);
            txtbxRegion.Name = "txtbxRegion";
            txtbxRegion.Size = new Size(125, 27);
            txtbxRegion.TabIndex = 7;
            txtbxRegion.TextChanged += textBox7_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 201);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 12;
            label7.Text = "Region";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 237);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 14;
            label8.Text = "Postal code";
            // 
            // txtbxPais
            // 
            txtbxPais.Location = new Point(134, 270);
            txtbxPais.Name = "txtbxPais";
            txtbxPais.Size = new Size(125, 27);
            txtbxPais.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 267);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 16;
            label9.Text = "Country";
            // 
            // txtbxTelefono
            // 
            txtbxTelefono.Location = new Point(134, 303);
            txtbxTelefono.Name = "txtbxTelefono";
            txtbxTelefono.Size = new Size(125, 27);
            txtbxTelefono.TabIndex = 12;
            txtbxTelefono.TextChanged += textBox10_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 303);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 18;
            label10.Text = "Phone";
            // 
            // txtbxFax
            // 
            txtbxFax.Location = new Point(134, 336);
            txtbxFax.Name = "txtbxFax";
            txtbxFax.Size = new Size(125, 27);
            txtbxFax.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 340);
            label11.Name = "label11";
            label11.Size = new Size(30, 20);
            label11.TabIndex = 20;
            label11.Text = "Fax";
            // 
            // cmbbxTitulo
            // 
            cmbbxTitulo.FormattingEnabled = true;
            cmbbxTitulo.Items.AddRange(new object[] { "Accounting Manager", "Assistant Sales Agent", "Assistant Sales Representative", "Marketing Assistant", "Marketing Manager", "Order Administrator", "Owner", "Owner/Marketing Assistant", "Sales Agent", "Sales Associate", "Sales Manager", "Sales Representative" });
            cmbbxTitulo.Location = new Point(134, 104);
            cmbbxTitulo.Name = "cmbbxTitulo";
            cmbbxTitulo.Size = new Size(125, 28);
            cmbbxTitulo.TabIndex = 4;
            cmbbxTitulo.Text = "Seleccione uno";
            // 
            // chbxRegion
            // 
            chbxRegion.AutoSize = true;
            chbxRegion.Location = new Point(265, 207);
            chbxRegion.Name = "chbxRegion";
            chbxRegion.Size = new Size(63, 24);
            chbxRegion.TabIndex = 8;
            chbxRegion.Text = "Nulo";
            chbxRegion.UseVisualStyleBackColor = true;
            chbxRegion.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chboxCP
            // 
            chboxCP.AutoSize = true;
            chboxCP.Location = new Point(265, 237);
            chboxCP.Name = "chboxCP";
            chboxCP.Size = new Size(63, 24);
            chboxCP.TabIndex = 10;
            chboxCP.Text = "Nulo";
            chboxCP.UseVisualStyleBackColor = true;
            chboxCP.CheckedChanged += chboxCP_CheckedChanged;
            // 
            // chbxFax
            // 
            chbxFax.AutoSize = true;
            chbxFax.Location = new Point(265, 339);
            chbxFax.Name = "chbxFax";
            chbxFax.Size = new Size(63, 24);
            chbxFax.TabIndex = 14;
            chbxFax.Text = "Nulo";
            chbxFax.UseVisualStyleBackColor = true;
            chbxFax.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // btnAgregarC
            // 
            btnAgregarC.Location = new Point(86, 379);
            btnAgregarC.Name = "btnAgregarC";
            btnAgregarC.Size = new Size(134, 29);
            btnAgregarC.TabIndex = 15;
            btnAgregarC.Text = "Agregar cliente";
            btnAgregarC.UseVisualStyleBackColor = true;
            btnAgregarC.Click += btnAgregarC_Click;
            // 
            // txtbxCP
            // 
            txtbxCP.Location = new Point(134, 237);
            txtbxCP.Mask = "00000";
            txtbxCP.Name = "txtbxCP";
            txtbxCP.Size = new Size(125, 27);
            txtbxCP.TabIndex = 9;
            // 
            // EclientesAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 434);
            Controls.Add(txtbxCP);
            Controls.Add(btnAgregarC);
            Controls.Add(chbxFax);
            Controls.Add(chboxCP);
            Controls.Add(chbxRegion);
            Controls.Add(cmbbxTitulo);
            Controls.Add(txtbxFax);
            Controls.Add(label11);
            Controls.Add(txtbxTelefono);
            Controls.Add(label10);
            Controls.Add(txtbxPais);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtbxRegion);
            Controls.Add(label7);
            Controls.Add(txtbxCiudad);
            Controls.Add(label6);
            Controls.Add(txtbxDireccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtbNCon);
            Controls.Add(label3);
            Controls.Add(txtbNC);
            Controls.Add(label2);
            Name = "EclientesAgregar";
            Text = "EclientesAgregar";
            Load += EclientesAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtbNC;
        private Label label2;
        private TextBox txtbNCon;
        private Label label3;
        private Label label4;
        private TextBox txtbxDireccion;
        private Label label5;
        private TextBox txtbxCiudad;
        private Label label6;
        private TextBox txtbxRegion;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private TextBox txtbxPais;
        private Label label9;
        private TextBox txtbxTelefono;
        private Label label10;
        private TextBox txtbxFax;
        private Label label11;
        private ComboBox cmbbxTitulo;
        private CheckBox chbxRegion;
        private CheckBox chboxCP;
        private CheckBox chbxFax;
        private Button btnAgregarC;
        private MaskedTextBox txtbxCP;
    }
}
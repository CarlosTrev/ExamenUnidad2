namespace ExamenUnidad2
{
    partial class InicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            btnInicio = new Button();
            label1 = new Label();
            txtbxUsuario = new TextBox();
            txtbxContra = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Transparent;
            btnInicio.Image = Properties.Resources.Captura_de_pantalla_2024_11_17_170113;
            btnInicio.Location = new Point(70, 219);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(181, 51);
            btnInicio.TabIndex = 0;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Image = Properties.Resources.Captura_de_pantalla_2024_11_17_171235;
            label1.Location = new Point(-34, -3);
            label1.MaximumSize = new Size(0, 53);
            label1.MinimumSize = new Size(229, 80);
            label1.Name = "label1";
            label1.Size = new Size(229, 80);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // txtbxUsuario
            // 
            txtbxUsuario.Cursor = Cursors.IBeam;
            txtbxUsuario.Location = new Point(29, 80);
            txtbxUsuario.Name = "txtbxUsuario";
            txtbxUsuario.Size = new Size(250, 27);
            txtbxUsuario.TabIndex = 2;
            // 
            // txtbxContra
            // 
            txtbxContra.Cursor = Cursors.IBeam;
            txtbxContra.Location = new Point(29, 163);
            txtbxContra.Name = "txtbxContra";
            txtbxContra.PasswordChar = '•';
            txtbxContra.Size = new Size(250, 27);
            txtbxContra.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.Captura_de_pantalla_2024_11_17_225509;
            label2.Location = new Point(29, 128);
            label2.MinimumSize = new Size(126, 27);
            label2.Name = "label2";
            label2.Size = new Size(126, 27);
            label2.TabIndex = 3;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2024_11_17_172238;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(336, 284);
            Controls.Add(txtbxContra);
            Controls.Add(label2);
            Controls.Add(txtbxUsuario);
            Controls.Add(label1);
            Controls.Add(btnInicio);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InicioSesion";
            Text = "Inicio de sesion";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicio;
        private Label label1;
        private TextBox txtbxUsuario;
        private TextBox txtbxContra;
        private Label label2;
    }
}

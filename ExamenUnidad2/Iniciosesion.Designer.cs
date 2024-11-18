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
            btnInicio.Location = new Point(61, 164);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(158, 38);
            btnInicio.TabIndex = 0;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Image = Properties.Resources.Captura_de_pantalla_2024_11_17_171235;
            label1.Location = new Point(-30, -2);
            label1.MaximumSize = new Size(0, 40);
            label1.MinimumSize = new Size(200, 60);
            label1.Name = "label1";
            label1.Size = new Size(200, 60);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // txtbxUsuario
            // 
            txtbxUsuario.Cursor = Cursors.IBeam;
            txtbxUsuario.Location = new Point(25, 60);
            txtbxUsuario.Margin = new Padding(3, 2, 3, 2);
            txtbxUsuario.Name = "txtbxUsuario";
            txtbxUsuario.Size = new Size(219, 23);
            txtbxUsuario.TabIndex = 2;
            // 
            // txtbxContra
            // 
            txtbxContra.Cursor = Cursors.IBeam;
            txtbxContra.Location = new Point(25, 122);
            txtbxContra.Margin = new Padding(3, 2, 3, 2);
            txtbxContra.Name = "txtbxContra";
            txtbxContra.Size = new Size(219, 23);
            txtbxContra.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.Captura_de_pantalla_2024_11_17_225509;
            label2.Location = new Point(25, 96);
            label2.MinimumSize = new Size(110, 20);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 3;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2024_11_17_172238;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(294, 213);
            Controls.Add(txtbxContra);
            Controls.Add(label2);
            Controls.Add(txtbxUsuario);
            Controls.Add(label1);
            Controls.Add(btnInicio);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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

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
            btnInicio = new Button();
            label1 = new Label();
            txtbxUsuario = new TextBox();
            txtbxContra = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(76, 165);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(159, 29);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Iniciar sesion";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // txtbxUsuario
            // 
            txtbxUsuario.Location = new Point(31, 44);
            txtbxUsuario.Name = "txtbxUsuario";
            txtbxUsuario.Size = new Size(250, 27);
            txtbxUsuario.TabIndex = 2;
            // 
            // txtbxContra
            // 
            txtbxContra.Location = new Point(31, 110);
            txtbxContra.Name = "txtbxContra";
            txtbxContra.Size = new Size(250, 27);
            txtbxContra.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 87);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 228);
            Controls.Add(txtbxContra);
            Controls.Add(label2);
            Controls.Add(txtbxUsuario);
            Controls.Add(label1);
            Controls.Add(btnInicio);
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

namespace ExamenUnidad2
{
    partial class Eacceso
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
            button1 = new Button();
            button2 = new Button();
            btnPyV = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 33);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(224, 171);
            button1.TabIndex = 0;
            button1.Text = "Datos de empleados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(264, 33);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(224, 171);
            button2.TabIndex = 1;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnPyV
            // 
            btnPyV.Location = new Point(510, 33);
            btnPyV.Margin = new Padding(3, 2, 3, 2);
            btnPyV.Name = "btnPyV";
            btnPyV.Size = new Size(224, 171);
            btnPyV.TabIndex = 2;
            btnPyV.Text = "Pedidos y ventas";
            btnPyV.UseVisualStyleBackColor = true;
            btnPyV.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(145, 208);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(224, 171);
            button4.TabIndex = 3;
            button4.Text = "Productos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(386, 208);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(224, 171);
            button5.TabIndex = 4;
            button5.Text = "Proveedores";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Eacceso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 395);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnPyV);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Eacceso";
            Text = "AccesosEmpleado";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnPyV;
        private Button button4;
        private Button button5;
    }
}
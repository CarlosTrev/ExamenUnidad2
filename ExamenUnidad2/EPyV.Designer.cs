namespace ExamenUnidad2
{
    partial class EPyV
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
            dgvPyV = new DataGridView();
            ColumnaBuscar = new DataGridViewImageColumn();
            label1 = new Label();
            cmbbxPyV = new ComboBox();
            txtbxPyV = new TextBox();
            btnEliminarOrden = new Button();
            tbcntrl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtFreight2 = new TextBox();
            dtpSD = new DateTimePicker();
            dtpRD = new DateTimePicker();
            CHBXcp = new CheckBox();
            chbxSR = new CheckBox();
            chbxSD = new CheckBox();
            btnAgregarOrden = new Button();
            txtboxShipCP = new MaskedTextBox();
            txtbxShipCountry = new TextBox();
            txtbxShipRegion = new TextBox();
            txtbxShipCity = new TextBox();
            txtbxShipAddress = new TextBox();
            txtbxShipName = new TextBox();
            rbShipVia3 = new RadioButton();
            rbShipVia2 = new RadioButton();
            rbShipVia1 = new RadioButton();
            dtpOrderDate = new DateTimePicker();
            txtCustomerID = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage3 = new TabPage();
            txtDiscount = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductID = new TextBox();
            btnAgregarProductos = new Button();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            txtbxOrderID = new MaskedTextBox();
            dgvBuscarOrden = new DataGridView();
            lblResulConsulta = new Label();
            btnBuscarOrden = new Button();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPyV).BeginInit();
            tbcntrl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarOrden).BeginInit();
            SuspendLayout();
            // 
            // dgvPyV
            // 
            dgvPyV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPyV.Columns.AddRange(new DataGridViewColumn[] { ColumnaBuscar });
            dgvPyV.Location = new Point(0, 45);
            dgvPyV.Name = "dgvPyV";
            dgvPyV.RowHeadersWidth = 51;
            dgvPyV.Size = new Size(1038, 453);
            dgvPyV.TabIndex = 0;
            dgvPyV.CellContentDoubleClick += dgvPyV_CellContentDoubleClick;
            dgvPyV.CellDoubleClick += dgvPyV_CellDoubleClick;
            // 
            // ColumnaBuscar
            // 
            ColumnaBuscar.HeaderText = "Consultar detalles";
            ColumnaBuscar.Image = Properties.Resources.buscar;
            ColumnaBuscar.MinimumWidth = 6;
            ColumnaBuscar.Name = "ColumnaBuscar";
            ColumnaBuscar.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Buscar por: ";
            // 
            // cmbbxPyV
            // 
            cmbbxPyV.FormattingEnabled = true;
            cmbbxPyV.Items.AddRange(new object[] { "Order ID", "Customer ID", "Employee ID", "Order Date", "Required Date", "Shipped Date", "Ship Via", "Freight", "Ship Name", "Ship Address", "Ship City", "Ship Region", "Ship Postal Code", "Ship Country" });
            cmbbxPyV.Location = new Point(92, 6);
            cmbbxPyV.Name = "cmbbxPyV";
            cmbbxPyV.Size = new Size(174, 28);
            cmbbxPyV.TabIndex = 2;
            cmbbxPyV.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtbxPyV
            // 
            txtbxPyV.Enabled = false;
            txtbxPyV.Location = new Point(292, 6);
            txtbxPyV.Name = "txtbxPyV";
            txtbxPyV.Size = new Size(247, 27);
            txtbxPyV.TabIndex = 3;
            txtbxPyV.TextChanged += txtbxPyV_TextChanged;
            // 
            // btnEliminarOrden
            // 
            btnEliminarOrden.Location = new Point(6, 504);
            btnEliminarOrden.Name = "btnEliminarOrden";
            btnEliminarOrden.Size = new Size(202, 33);
            btnEliminarOrden.TabIndex = 4;
            btnEliminarOrden.Text = "Eliminar orden";
            btnEliminarOrden.UseVisualStyleBackColor = true;
            btnEliminarOrden.Click += btnEliminarOrden_Click;
            // 
            // tbcntrl
            // 
            tbcntrl.Controls.Add(tabPage1);
            tbcntrl.Controls.Add(tabPage2);
            tbcntrl.Controls.Add(tabPage3);
            tbcntrl.Location = new Point(9, 3);
            tbcntrl.Name = "tbcntrl";
            tbcntrl.SelectedIndex = 0;
            tbcntrl.Size = new Size(1061, 594);
            tbcntrl.TabIndex = 5;
            tbcntrl.SelectedIndexChanged += tbcntrl_SelectedIndexChanged;
            tbcntrl.TabIndexChanged += tbcntrl_TabIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnEliminarOrden);
            tabPage1.Controls.Add(dgvPyV);
            tabPage1.Controls.Add(txtbxPyV);
            tabPage1.Controls.Add(cmbbxPyV);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1053, 561);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consultar orden";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtFreight2);
            tabPage2.Controls.Add(dtpSD);
            tabPage2.Controls.Add(dtpRD);
            tabPage2.Controls.Add(CHBXcp);
            tabPage2.Controls.Add(chbxSR);
            tabPage2.Controls.Add(chbxSD);
            tabPage2.Controls.Add(btnAgregarOrden);
            tabPage2.Controls.Add(txtboxShipCP);
            tabPage2.Controls.Add(txtbxShipCountry);
            tabPage2.Controls.Add(txtbxShipRegion);
            tabPage2.Controls.Add(txtbxShipCity);
            tabPage2.Controls.Add(txtbxShipAddress);
            tabPage2.Controls.Add(txtbxShipName);
            tabPage2.Controls.Add(rbShipVia3);
            tabPage2.Controls.Add(rbShipVia2);
            tabPage2.Controls.Add(rbShipVia1);
            tabPage2.Controls.Add(dtpOrderDate);
            tabPage2.Controls.Add(txtCustomerID);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1053, 561);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Agregar orden";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtFreight2
            // 
            txtFreight2.Location = new Point(123, 181);
            txtFreight2.Name = "txtFreight2";
            txtFreight2.Size = new Size(125, 27);
            txtFreight2.TabIndex = 33;
            // 
            // dtpSD
            // 
            dtpSD.CustomFormat = "";
            dtpSD.Format = DateTimePickerFormat.Custom;
            dtpSD.Location = new Point(123, 109);
            dtpSD.Name = "dtpSD";
            dtpSD.Size = new Size(294, 27);
            dtpSD.TabIndex = 32;
            // 
            // dtpRD
            // 
            dtpRD.CustomFormat = "";
            dtpRD.Format = DateTimePickerFormat.Custom;
            dtpRD.Location = new Point(123, 76);
            dtpRD.Name = "dtpRD";
            dtpRD.Size = new Size(294, 27);
            dtpRD.TabIndex = 31;
            // 
            // CHBXcp
            // 
            CHBXcp.AutoSize = true;
            CHBXcp.Location = new Point(264, 353);
            CHBXcp.Name = "CHBXcp";
            CHBXcp.Size = new Size(66, 24);
            CHBXcp.TabIndex = 30;
            CHBXcp.Text = "NULL";
            CHBXcp.UseVisualStyleBackColor = true;
            CHBXcp.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chbxSR
            // 
            chbxSR.AutoSize = true;
            chbxSR.Location = new Point(264, 313);
            chbxSR.Name = "chbxSR";
            chbxSR.Size = new Size(66, 24);
            chbxSR.TabIndex = 29;
            chbxSR.Text = "NULL";
            chbxSR.UseVisualStyleBackColor = true;
            chbxSR.CheckedChanged += chbxSR_CheckedChanged;
            // 
            // chbxSD
            // 
            chbxSD.AutoSize = true;
            chbxSD.Location = new Point(425, 111);
            chbxSD.Name = "chbxSD";
            chbxSD.Size = new Size(66, 24);
            chbxSD.TabIndex = 28;
            chbxSD.Text = "NULL";
            chbxSD.UseVisualStyleBackColor = true;
            chbxSD.CheckedChanged += chbxSD_CheckedChanged;
            // 
            // btnAgregarOrden
            // 
            btnAgregarOrden.Location = new Point(75, 441);
            btnAgregarOrden.Name = "btnAgregarOrden";
            btnAgregarOrden.Size = new Size(211, 29);
            btnAgregarOrden.TabIndex = 27;
            btnAgregarOrden.Text = "Agregar orden";
            btnAgregarOrden.UseVisualStyleBackColor = true;
            btnAgregarOrden.Click += btnAgregarOrden_Click;
            // 
            // txtboxShipCP
            // 
            txtboxShipCP.Location = new Point(125, 350);
            txtboxShipCP.Mask = "00000";
            txtboxShipCP.Name = "txtboxShipCP";
            txtboxShipCP.Size = new Size(125, 27);
            txtboxShipCP.TabIndex = 26;
            // 
            // txtbxShipCountry
            // 
            txtbxShipCountry.Location = new Point(125, 383);
            txtbxShipCountry.Name = "txtbxShipCountry";
            txtbxShipCountry.Size = new Size(125, 27);
            txtbxShipCountry.TabIndex = 25;
            // 
            // txtbxShipRegion
            // 
            txtbxShipRegion.Location = new Point(125, 310);
            txtbxShipRegion.Name = "txtbxShipRegion";
            txtbxShipRegion.Size = new Size(125, 27);
            txtbxShipRegion.TabIndex = 23;
            // 
            // txtbxShipCity
            // 
            txtbxShipCity.Location = new Point(125, 277);
            txtbxShipCity.Name = "txtbxShipCity";
            txtbxShipCity.Size = new Size(125, 27);
            txtbxShipCity.TabIndex = 22;
            // 
            // txtbxShipAddress
            // 
            txtbxShipAddress.Location = new Point(125, 246);
            txtbxShipAddress.Name = "txtbxShipAddress";
            txtbxShipAddress.Size = new Size(125, 27);
            txtbxShipAddress.TabIndex = 21;
            // 
            // txtbxShipName
            // 
            txtbxShipName.Location = new Point(125, 214);
            txtbxShipName.Name = "txtbxShipName";
            txtbxShipName.Size = new Size(125, 27);
            txtbxShipName.TabIndex = 20;
            // 
            // rbShipVia3
            // 
            rbShipVia3.AutoSize = true;
            rbShipVia3.Location = new Point(371, 151);
            rbShipVia3.Name = "rbShipVia3";
            rbShipVia3.Size = new Size(38, 24);
            rbShipVia3.TabIndex = 18;
            rbShipVia3.TabStop = true;
            rbShipVia3.Text = "3";
            rbShipVia3.UseVisualStyleBackColor = true;
            // 
            // rbShipVia2
            // 
            rbShipVia2.AutoSize = true;
            rbShipVia2.Location = new Point(248, 151);
            rbShipVia2.Name = "rbShipVia2";
            rbShipVia2.Size = new Size(38, 24);
            rbShipVia2.TabIndex = 17;
            rbShipVia2.TabStop = true;
            rbShipVia2.Text = "2";
            rbShipVia2.UseVisualStyleBackColor = true;
            // 
            // rbShipVia1
            // 
            rbShipVia1.AutoSize = true;
            rbShipVia1.Location = new Point(125, 151);
            rbShipVia1.Name = "rbShipVia1";
            rbShipVia1.Size = new Size(38, 24);
            rbShipVia1.TabIndex = 16;
            rbShipVia1.TabStop = true;
            rbShipVia1.Text = "1";
            rbShipVia1.UseVisualStyleBackColor = true;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "";
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(125, 43);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(294, 27);
            dtpOrderDate.TabIndex = 13;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(125, 10);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(125, 27);
            txtCustomerID.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 383);
            label13.Name = "label13";
            label13.Size = new Size(91, 20);
            label13.TabIndex = 11;
            label13.Text = "Ship country";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 350);
            label12.Name = "label12";
            label12.Size = new Size(120, 20);
            label12.TabIndex = 10;
            label12.Text = "Ship postal code";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 312);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 9;
            label11.Text = "Ship region";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 280);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 8;
            label10.Text = "Ship city";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 249);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 7;
            label9.Text = "Ship address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 213);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 6;
            label8.Text = "Ship name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 179);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 5;
            label7.Text = "Freight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 146);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 4;
            label6.Text = "Ship via";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 108);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 3;
            label5.Text = "Shipped date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 79);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 2;
            label4.Text = "Requiered date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 46);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 1;
            label3.Text = "Order date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 13);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 0;
            label2.Text = "Customer ID";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtDiscount);
            tabPage3.Controls.Add(txtQuantity);
            tabPage3.Controls.Add(txtUnitPrice);
            tabPage3.Controls.Add(txtProductID);
            tabPage3.Controls.Add(btnAgregarProductos);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(txtbxOrderID);
            tabPage3.Controls.Add(dgvBuscarOrden);
            tabPage3.Controls.Add(lblResulConsulta);
            tabPage3.Controls.Add(btnBuscarOrden);
            tabPage3.Controls.Add(label14);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1053, 561);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Agregar productos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(96, 506);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(125, 27);
            txtDiscount.TabIndex = 19;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(96, 473);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 18;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Location = new Point(96, 444);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 17;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(96, 411);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(125, 27);
            txtProductID.TabIndex = 16;
            txtProductID.TextChanged += txtProductID_TextChanged;
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.Enabled = false;
            btnAgregarProductos.Location = new Point(270, 456);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.Size = new Size(194, 29);
            btnAgregarProductos.TabIndex = 15;
            btnAgregarProductos.Text = "Agregar productos";
            btnAgregarProductos.UseVisualStyleBackColor = true;
            btnAgregarProductos.Click += btnAgregarProductos_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 506);
            label19.Name = "label19";
            label19.Size = new Size(67, 20);
            label19.TabIndex = 10;
            label19.Text = "Discount";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(12, 474);
            label18.Name = "label18";
            label18.Size = new Size(65, 20);
            label18.TabIndex = 9;
            label18.Text = "Quantity";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 443);
            label17.Name = "label17";
            label17.Size = new Size(72, 20);
            label17.TabIndex = 8;
            label17.Text = "Unit Price";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 411);
            label16.Name = "label16";
            label16.Size = new Size(79, 20);
            label16.TabIndex = 7;
            label16.Text = "Product ID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 356);
            label15.Name = "label15";
            label15.Size = new Size(134, 20);
            label15.TabIndex = 6;
            label15.Text = "Agregar productos";
            // 
            // txtbxOrderID
            // 
            txtbxOrderID.Location = new Point(87, 18);
            txtbxOrderID.Mask = "999999";
            txtbxOrderID.Name = "txtbxOrderID";
            txtbxOrderID.Size = new Size(125, 27);
            txtbxOrderID.TabIndex = 5;
            txtbxOrderID.ValidatingType = typeof(int);
            // 
            // dgvBuscarOrden
            // 
            dgvBuscarOrden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscarOrden.Location = new Point(12, 68);
            dgvBuscarOrden.Name = "dgvBuscarOrden";
            dgvBuscarOrden.RowHeadersWidth = 51;
            dgvBuscarOrden.Size = new Size(592, 267);
            dgvBuscarOrden.TabIndex = 4;
            // 
            // lblResulConsulta
            // 
            lblResulConsulta.AutoSize = true;
            lblResulConsulta.Location = new Point(368, 25);
            lblResulConsulta.Name = "lblResulConsulta";
            lblResulConsulta.Size = new Size(0, 20);
            lblResulConsulta.TabIndex = 3;
            // 
            // btnBuscarOrden
            // 
            btnBuscarOrden.Location = new Point(218, 18);
            btnBuscarOrden.Name = "btnBuscarOrden";
            btnBuscarOrden.Size = new Size(135, 29);
            btnBuscarOrden.TabIndex = 2;
            btnBuscarOrden.Text = "Buscar";
            btnBuscarOrden.UseVisualStyleBackColor = true;
            btnBuscarOrden.Click += button1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 18);
            label14.Name = "label14";
            label14.Size = new Size(69, 20);
            label14.TabIndex = 0;
            label14.Text = "Order ID:";
            // 
            // EPyV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 583);
            Controls.Add(tbcntrl);
            Name = "EPyV";
            Text = "Productos y ventas";
            Load += EPyV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPyV).EndInit();
            tbcntrl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarOrden).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPyV;
        private Label label1;
        private ComboBox cmbbxPyV;
        private TextBox txtbxPyV;
        private DataGridViewImageColumn ColumnaBuscar;
        private Button btnEliminarOrden;
        private TabControl tbcntrl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private TabPage tabPage3;
        private Label label14;
        private RadioButton rbShipVia3;
        private RadioButton rbShipVia2;
        private RadioButton rbShipVia1;
        private TextBox txtCustomerID;
        private DataGridView dgvBuscarOrden;
        private Label lblResulConsulta;
        private Button btnBuscarOrden;
        private TextBox txtbxShipCountry;
        private TextBox txtbxShipRegion;
        private TextBox txtbxShipCity;
        private TextBox txtbxShipAddress;
        private TextBox txtbxShipName;
        private MaskedTextBox txtboxShipCP;
        private Button btnAgregarOrden;
        private CheckBox chbxSR;
        private CheckBox CHBXcp;
        private DateTimePicker dtpSD;
        private DateTimePicker dtpRD;
        private CheckBox chbxSD;
        private DateTimePicker dtpOrderDate;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtFreight2;
        private MaskedTextBox txtbxOrderID;
        private Label label15;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Button btnAgregarProductos;
        private TextBox txtDiscount;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductID;
    }
}
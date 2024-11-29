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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EPyV));
            dgvPyV = new DataGridView();
            ColumnaBuscar = new DataGridViewImageColumn();
            label1 = new Label();
            cmbbxPyV = new ComboBox();
            txtbxPyV = new TextBox();
            btnEliminarOrden = new Button();
            tbcntrl = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            tabPage2 = new TabPage();
            txtShipName = new TextBox();
            label12 = new Label();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            label11 = new Label();
            txtShipCountry = new TextBox();
            label65 = new Label();
            txtShipPostalCode = new TextBox();
            label45 = new Label();
            txtShipRegion = new TextBox();
            label9 = new Label();
            txtShipCity = new TextBox();
            label8 = new Label();
            txtShipAddress = new TextBox();
            label7 = new Label();
            label6 = new Label();
            dtpShippedDate = new DateTimePicker();
            label5 = new Label();
            dtpRequiredDate = new DateTimePicker();
            label4 = new Label();
            dtpOrderDate = new DateTimePicker();
            label3 = new Label();
            cmbCustomerID = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            dvgCarrito = new DataGridView();
            dvgProductosDis = new DataGridView();
            tabPage3 = new TabPage();
            lblproducto = new Label();
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
            tabPage4 = new TabPage();
            button2 = new Button();
            btnCateEditar = new Button();
            btnCateBorrar = new Button();
            btnAgregarCate = new Button();
            txtCateDes = new TextBox();
            label21 = new Label();
            txtCateNam = new TextBox();
            label20 = new Label();
            dgvCategorias = new DataGridView();
            tabPage5 = new TabPage();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)dgvPyV).BeginInit();
            tbcntrl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductosDis).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarOrden).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPyV
            // 
            dgvPyV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPyV.Columns.AddRange(new DataGridViewColumn[] { ColumnaBuscar });
            dgvPyV.Location = new Point(0, 34);
            dgvPyV.Margin = new Padding(3, 2, 3, 2);
            dgvPyV.Name = "dgvPyV";
            dgvPyV.ReadOnly = true;
            dgvPyV.RowHeadersWidth = 51;
            dgvPyV.Size = new Size(908, 340);
            dgvPyV.TabIndex = 0;
            dgvPyV.CellContentClick += dgvPyV_CellContentClick;
            dgvPyV.CellContentDoubleClick += dgvPyV_CellContentDoubleClick;
            dgvPyV.CellDoubleClick += dgvPyV_CellDoubleClick;
            // 
            // ColumnaBuscar
            // 
            ColumnaBuscar.HeaderText = "Consultar detalles";
            ColumnaBuscar.Image = Properties.Resources.buscar;
            ColumnaBuscar.MinimumWidth = 6;
            ColumnaBuscar.Name = "ColumnaBuscar";
            ColumnaBuscar.ReadOnly = true;
            ColumnaBuscar.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 7);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar por: ";
            // 
            // cmbbxPyV
            // 
            cmbbxPyV.FormattingEnabled = true;
            cmbbxPyV.Items.AddRange(new object[] { "Order ID", "Customer ID", "EmployeeName", "Order Date", "Required Date", "Shipped Date", "ShipperID", "Ship Via", "Freight", "Ship Name", "Ship Address", "Ship City", "Ship Region", "Ship Postal Code", "Ship Country" });
            cmbbxPyV.Location = new Point(80, 4);
            cmbbxPyV.Margin = new Padding(3, 2, 3, 2);
            cmbbxPyV.Name = "cmbbxPyV";
            cmbbxPyV.Size = new Size(153, 23);
            cmbbxPyV.TabIndex = 2;
            cmbbxPyV.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtbxPyV
            // 
            txtbxPyV.Enabled = false;
            txtbxPyV.Location = new Point(256, 4);
            txtbxPyV.Margin = new Padding(3, 2, 3, 2);
            txtbxPyV.Name = "txtbxPyV";
            txtbxPyV.Size = new Size(217, 23);
            txtbxPyV.TabIndex = 3;
            txtbxPyV.TextChanged += txtbxPyV_TextChanged;
            // 
            // btnEliminarOrden
            // 
            btnEliminarOrden.BackColor = Color.Red;
            btnEliminarOrden.Location = new Point(5, 378);
            btnEliminarOrden.Margin = new Padding(3, 2, 3, 2);
            btnEliminarOrden.Name = "btnEliminarOrden";
            btnEliminarOrden.Size = new Size(177, 25);
            btnEliminarOrden.TabIndex = 4;
            btnEliminarOrden.Text = "Eliminar orden";
            btnEliminarOrden.UseVisualStyleBackColor = false;
            btnEliminarOrden.Click += btnEliminarOrden_Click;
            // 
            // tbcntrl
            // 
            tbcntrl.Controls.Add(tabPage1);
            tbcntrl.Controls.Add(tabPage2);
            tbcntrl.Controls.Add(tabPage3);
            tbcntrl.Controls.Add(tabPage4);
            tbcntrl.Controls.Add(tabPage5);
            tbcntrl.Location = new Point(8, 2);
            tbcntrl.Margin = new Padding(3, 2, 3, 2);
            tbcntrl.Name = "tbcntrl";
            tbcntrl.SelectedIndex = 0;
            tbcntrl.Size = new Size(928, 481);
            tbcntrl.TabIndex = 5;
            tbcntrl.SelectedIndexChanged += tbcntrl_SelectedIndexChanged;
            tbcntrl.TabIndexChanged += tbcntrl_TabIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnEliminarOrden);
            tabPage1.Controls.Add(dgvPyV);
            tabPage1.Controls.Add(txtbxPyV);
            tabPage1.Controls.Add(cmbbxPyV);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(920, 453);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consultar orden";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(731, 378);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(177, 25);
            button1.TabIndex = 5;
            button1.Text = "Exportar tabla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(txtShipName);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(rb3);
            tabPage2.Controls.Add(rb2);
            tabPage2.Controls.Add(rb1);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtShipCountry);
            tabPage2.Controls.Add(label65);
            tabPage2.Controls.Add(txtShipPostalCode);
            tabPage2.Controls.Add(label45);
            tabPage2.Controls.Add(txtShipRegion);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtShipCity);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtShipAddress);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(dtpShippedDate);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(dtpRequiredDate);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dtpOrderDate);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cmbCustomerID);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(dvgCarrito);
            tabPage2.Controls.Add(dvgProductosDis);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(920, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Agregar orden";
            tabPage2.Click += tabPage2_Click;
            // 
            // txtShipName
            // 
            txtShipName.Location = new Point(631, 129);
            txtShipName.Name = "txtShipName";
            txtShipName.Size = new Size(107, 23);
            txtShipName.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(537, 132);
            label12.Name = "label12";
            label12.Size = new Size(65, 15);
            label12.TabIndex = 31;
            label12.Text = "ShipName:";
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.ForeColor = Color.Transparent;
            rb3.Location = new Point(801, 80);
            rb3.Name = "rb3";
            rb3.Size = new Size(113, 19);
            rb3.TabIndex = 30;
            rb3.TabStop = true;
            rb3.Text = "Federal Shipping";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.ForeColor = Color.Transparent;
            rb2.Location = new Point(801, 55);
            rb2.Name = "rb2";
            rb2.Size = new Size(107, 19);
            rb2.TabIndex = 29;
            rb2.TabStop = true;
            rb2.Text = "United Package";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.ForeColor = Color.Transparent;
            rb1.Location = new Point(801, 32);
            rb1.Name = "rb1";
            rb1.Size = new Size(105, 19);
            rb1.TabIndex = 28;
            rb1.TabStop = true;
            rb1.Text = "Speedy Express";
            rb1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(801, 14);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 27;
            label11.Text = "ShipVia:";
            // 
            // txtShipCountry
            // 
            txtShipCountry.Location = new Point(631, 92);
            txtShipCountry.Name = "txtShipCountry";
            txtShipCountry.Size = new Size(107, 23);
            txtShipCountry.TabIndex = 24;
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.ForeColor = Color.Transparent;
            label65.Location = new Point(537, 95);
            label65.Name = "label65";
            label65.Size = new Size(76, 15);
            label65.TabIndex = 23;
            label65.Text = "ShipCountry:";
            // 
            // txtShipPostalCode
            // 
            txtShipPostalCode.Location = new Point(405, 129);
            txtShipPostalCode.Name = "txtShipPostalCode";
            txtShipPostalCode.Size = new Size(107, 23);
            txtShipPostalCode.TabIndex = 22;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.ForeColor = Color.Transparent;
            label45.Location = new Point(300, 132);
            label45.Name = "label45";
            label45.Size = new Size(93, 15);
            label45.TabIndex = 21;
            label45.Text = "ShipPostalCode:";
            // 
            // txtShipRegion
            // 
            txtShipRegion.Location = new Point(405, 95);
            txtShipRegion.Name = "txtShipRegion";
            txtShipRegion.Size = new Size(107, 23);
            txtShipRegion.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(300, 98);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 19;
            label9.Text = "ShipRegion:";
            // 
            // txtShipCity
            // 
            txtShipCity.Location = new Point(140, 129);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(107, 23);
            txtShipCity.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(35, 132);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 17;
            label8.Text = "ShipCity:";
            // 
            // txtShipAddress
            // 
            txtShipAddress.Location = new Point(140, 95);
            txtShipAddress.Name = "txtShipAddress";
            txtShipAddress.Size = new Size(107, 23);
            txtShipAddress.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(35, 98);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 15;
            label7.Text = "ShipAdress:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(35, 390);
            label6.Name = "label6";
            label6.Size = new Size(202, 15);
            label6.TabIndex = 14;
            label6.Text = "Cantidad que se va agregar al carrito:";
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(510, 55);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(200, 23);
            dtpShippedDate.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(405, 61);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "ShipDate:";
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(510, 14);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(200, 23);
            dtpRequiredDate.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(405, 20);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 10;
            label4.Text = "RequiredDate:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(140, 57);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(200, 23);
            dtpOrderDate.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(35, 61);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 8;
            label3.Text = "OrderDate:";
            // 
            // cmbCustomerID
            // 
            cmbCustomerID.FormattingEnabled = true;
            cmbCustomerID.Location = new Point(140, 20);
            cmbCustomerID.Name = "cmbCustomerID";
            cmbCustomerID.Size = new Size(121, 23);
            cmbCustomerID.TabIndex = 7;
            cmbCustomerID.SelectedIndexChanged += cmbCustomerID_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(35, 20);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "CustomerID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 409);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 23);
            textBox1.TabIndex = 5;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(676, 408);
            button5.Name = "button5";
            button5.Size = new Size(129, 23);
            button5.TabIndex = 4;
            button5.Text = "Añadir al carrito";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.ForeColor = Color.Black;
            button4.Location = new Point(484, 408);
            button4.Name = "button4";
            button4.Size = new Size(129, 23);
            button4.TabIndex = 3;
            button4.Text = "Registrar Orden";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(275, 408);
            button3.Name = "button3";
            button3.Size = new Size(126, 23);
            button3.TabIndex = 2;
            button3.Text = "Limpiar Carrito";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dvgCarrito
            // 
            dvgCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCarrito.Location = new Point(484, 158);
            dvgCarrito.Name = "dvgCarrito";
            dvgCarrito.ReadOnly = true;
            dvgCarrito.Size = new Size(379, 214);
            dvgCarrito.TabIndex = 1;
            // 
            // dvgProductosDis
            // 
            dvgProductosDis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductosDis.Location = new Point(35, 158);
            dvgProductosDis.Name = "dvgProductosDis";
            dvgProductosDis.ReadOnly = true;
            dvgProductosDis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgProductosDis.Size = new Size(379, 214);
            dvgProductosDis.TabIndex = 0;
            dvgProductosDis.CellEndEdit += dvgProductosDis_CellEndEdit;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Black;
            tabPage3.Controls.Add(lblproducto);
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
            tabPage3.ForeColor = Color.Black;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(920, 453);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Agregar productos";
            // 
            // lblproducto
            // 
            lblproducto.AutoSize = true;
            lblproducto.ForeColor = Color.White;
            lblproducto.Location = new Point(239, 309);
            lblproducto.Name = "lblproducto";
            lblproducto.Size = new Size(122, 15);
            lblproducto.TabIndex = 20;
            lblproducto.Text = "Nombre del producto";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(84, 380);
            txtDiscount.Margin = new Padding(3, 2, 3, 2);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(110, 23);
            txtDiscount.TabIndex = 19;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(84, 355);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 23);
            txtQuantity.TabIndex = 18;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Location = new Point(84, 333);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(110, 23);
            txtUnitPrice.TabIndex = 17;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(84, 308);
            txtProductID.Margin = new Padding(3, 2, 3, 2);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(110, 23);
            txtProductID.TabIndex = 16;
            txtProductID.TextChanged += txtProductID_TextChanged;
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.Enabled = false;
            btnAgregarProductos.ForeColor = Color.Black;
            btnAgregarProductos.Location = new Point(236, 342);
            btnAgregarProductos.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.Size = new Size(170, 22);
            btnAgregarProductos.TabIndex = 15;
            btnAgregarProductos.Text = "Agregar productos";
            btnAgregarProductos.UseVisualStyleBackColor = true;
            btnAgregarProductos.Click += btnAgregarProductos_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.White;
            label19.Location = new Point(10, 380);
            label19.Name = "label19";
            label19.Size = new Size(54, 15);
            label19.TabIndex = 10;
            label19.Text = "Discount";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.White;
            label18.Location = new Point(10, 356);
            label18.Name = "label18";
            label18.Size = new Size(53, 15);
            label18.TabIndex = 9;
            label18.Text = "Quantity";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(10, 332);
            label17.Name = "label17";
            label17.Size = new Size(58, 15);
            label17.TabIndex = 8;
            label17.Text = "Unit Price";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(10, 308);
            label16.Name = "label16";
            label16.Size = new Size(63, 15);
            label16.TabIndex = 7;
            label16.Text = "Product ID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(10, 267);
            label15.Name = "label15";
            label15.Size = new Size(106, 15);
            label15.TabIndex = 6;
            label15.Text = "Agregar productos";
            // 
            // txtbxOrderID
            // 
            txtbxOrderID.Location = new Point(76, 14);
            txtbxOrderID.Margin = new Padding(3, 2, 3, 2);
            txtbxOrderID.Mask = "999999";
            txtbxOrderID.Name = "txtbxOrderID";
            txtbxOrderID.Size = new Size(110, 23);
            txtbxOrderID.TabIndex = 5;
            txtbxOrderID.ValidatingType = typeof(int);
            // 
            // dgvBuscarOrden
            // 
            dgvBuscarOrden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscarOrden.Location = new Point(10, 51);
            dgvBuscarOrden.Margin = new Padding(3, 2, 3, 2);
            dgvBuscarOrden.Name = "dgvBuscarOrden";
            dgvBuscarOrden.RowHeadersWidth = 51;
            dgvBuscarOrden.Size = new Size(518, 200);
            dgvBuscarOrden.TabIndex = 4;
            // 
            // lblResulConsulta
            // 
            lblResulConsulta.AutoSize = true;
            lblResulConsulta.Location = new Point(322, 19);
            lblResulConsulta.Name = "lblResulConsulta";
            lblResulConsulta.Size = new Size(0, 15);
            lblResulConsulta.TabIndex = 3;
            // 
            // btnBuscarOrden
            // 
            btnBuscarOrden.ForeColor = Color.Black;
            btnBuscarOrden.Location = new Point(191, 14);
            btnBuscarOrden.Margin = new Padding(3, 2, 3, 2);
            btnBuscarOrden.Name = "btnBuscarOrden";
            btnBuscarOrden.Size = new Size(118, 22);
            btnBuscarOrden.TabIndex = 2;
            btnBuscarOrden.Text = "Buscar";
            btnBuscarOrden.UseVisualStyleBackColor = true;
            btnBuscarOrden.Click += button1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(10, 14);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 0;
            label14.Text = "Order ID:";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Black;
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(btnCateEditar);
            tabPage4.Controls.Add(btnCateBorrar);
            tabPage4.Controls.Add(btnAgregarCate);
            tabPage4.Controls.Add(txtCateDes);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(txtCateNam);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(dgvCategorias);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(920, 453);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Categorias";
            tabPage4.Click += tabPage4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(687, 306);
            button2.Name = "button2";
            button2.Size = new Size(150, 23);
            button2.TabIndex = 8;
            button2.Text = "Exportar tabla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCateEditar
            // 
            btnCateEditar.Location = new Point(499, 350);
            btnCateEditar.Name = "btnCateEditar";
            btnCateEditar.Size = new Size(150, 22);
            btnCateEditar.TabIndex = 7;
            btnCateEditar.Text = "Editar Categoria";
            btnCateEditar.UseVisualStyleBackColor = true;
            btnCateEditar.Click += btnCateEditar_Click;
            // 
            // btnCateBorrar
            // 
            btnCateBorrar.Location = new Point(499, 307);
            btnCateBorrar.Name = "btnCateBorrar";
            btnCateBorrar.Size = new Size(150, 22);
            btnCateBorrar.TabIndex = 6;
            btnCateBorrar.Text = "Borrar Categoria";
            btnCateBorrar.UseVisualStyleBackColor = true;
            btnCateBorrar.Click += btnCateBorrar_Click;
            // 
            // btnAgregarCate
            // 
            btnAgregarCate.Location = new Point(499, 267);
            btnAgregarCate.Name = "btnAgregarCate";
            btnAgregarCate.Size = new Size(150, 23);
            btnAgregarCate.TabIndex = 5;
            btnAgregarCate.Text = "Agregar Categoria";
            btnAgregarCate.UseVisualStyleBackColor = true;
            btnAgregarCate.Click += btnAgregarCate_Click;
            // 
            // txtCateDes
            // 
            txtCateDes.Location = new Point(173, 322);
            txtCateDes.Name = "txtCateDes";
            txtCateDes.Size = new Size(100, 23);
            txtCateDes.TabIndex = 4;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = SystemColors.Control;
            label21.Location = new Point(27, 330);
            label21.Name = "label21";
            label21.Size = new Size(70, 15);
            label21.TabIndex = 3;
            label21.Text = "Description:";
            // 
            // txtCateNam
            // 
            txtCateNam.Location = new Point(173, 267);
            txtCateNam.Name = "txtCateNam";
            txtCateNam.Size = new Size(100, 23);
            txtCateNam.TabIndex = 2;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(27, 270);
            label20.Name = "label20";
            label20.Size = new Size(90, 15);
            label20.TabIndex = 1;
            label20.Text = "CategoryName:";
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(5, 15);
            dgvCategorias.Margin = new Padding(3, 2, 3, 2);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(544, 212);
            dgvCategorias.TabIndex = 0;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(plotView1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(920, 453);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Grafica";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // plotView1
            // 
            plotView1.Location = new Point(19, 14);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(884, 385);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // EPyV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(947, 494);
            Controls.Add(tbcntrl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "EPyV";
            Text = "Productos y ventas";
            Load += EPyV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPyV).EndInit();
            tbcntrl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductosDis).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarOrden).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tabPage5.ResumeLayout(false);
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
        private TabPage tabPage3;
        private Label label14;
        private DataGridView dgvBuscarOrden;
        private Label lblResulConsulta;
        private Button btnBuscarOrden;
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
        private TabPage tabPage4;
        private DataGridView dgvCategorias;
        private Label label20;
        private Button btnCateEditar;
        private Button btnCateBorrar;
        private Button btnAgregarCate;
        private TextBox txtCateDes;
        private Label label21;
        private TextBox txtCateNam;
        private Label lblproducto;
        private TabPage tabPage5;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridView dvgCarrito;
        private DataGridView dvgProductosDis;
        private ComboBox cmbCustomerID;
        private Label label2;
        private DateTimePicker dtpOrderDate;
        private Label label3;
        private DateTimePicker dtpShippedDate;
        private Label label5;
        private DateTimePicker dtpRequiredDate;
        private Label label4;
        private TextBox txtShipCountry;
        private Label label65;
        private TextBox txtShipPostalCode;
        private Label label45;
        private TextBox txtShipRegion;
        private Label label9;
        private TextBox txtShipCity;
        private Label label8;
        private TextBox txtShipAddress;
        private Label label7;
        private Label label6;
        private TextBox txtFreight;
        private Label label10;
        private RadioButton radioButton2;
        private RadioButton rb1;
        private RadioButton rb2;
        private Label label11;
        private RadioButton rb3;
        private TextBox txtShipName;
        private Label label12;
    }
}
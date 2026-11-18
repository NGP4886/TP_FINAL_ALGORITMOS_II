namespace TP_FINAL_ALGORITMOS_II
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabReservas = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.tabRecursos = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.clbEstado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabReservas.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.tabRecursos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.tabClientes.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabReservas
            // 
            this.tabReservas.Controls.Add(this.flowLayoutPanel2);
            this.tabReservas.Controls.Add(this.panel4);
            this.tabReservas.Location = new System.Drawing.Point(4, 25);
            this.tabReservas.Name = "tabReservas";
            this.tabReservas.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservas.Size = new System.Drawing.Size(974, 594);
            this.tabReservas.TabIndex = 2;
            this.tabReservas.Text = "Operaciones y Reservas";
            this.tabReservas.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(671, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(300, 588);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvReservas);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(668, 572);
            this.panel4.TabIndex = 0;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservas.Location = new System.Drawing.Point(0, 0);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(668, 572);
            this.dgvReservas.TabIndex = 0;
            // 
            // tabRecursos
            // 
            this.tabRecursos.Controls.Add(this.panel5);
            this.tabRecursos.Controls.Add(this.panel3);
            this.tabRecursos.Location = new System.Drawing.Point(4, 25);
            this.tabRecursos.Name = "tabRecursos";
            this.tabRecursos.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecursos.Size = new System.Drawing.Size(974, 596);
            this.tabRecursos.TabIndex = 1;
            this.tabRecursos.Text = "Gestion de Recursos";
            this.tabRecursos.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvRecursos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(968, 326);
            this.panel3.TabIndex = 0;
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToAddRows = false;
            this.dgvRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecursos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecursos.Location = new System.Drawing.Point(0, 0);
            this.dgvRecursos.MultiSelect = false;
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.RowHeadersWidth = 51;
            this.dgvRecursos.RowTemplate.Height = 24;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(968, 326);
            this.dgvRecursos.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.panel2);
            this.tabClientes.Controls.Add(this.panel1);
            this.tabClientes.Location = new System.Drawing.Point(4, 25);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(974, 596);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Gestion Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.clbEstado);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtDni);
            this.panel2.Controls.Add(this.txtIdCliente);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 251);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImportar);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Location = new System.Drawing.Point(463, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportar/Importar Clientes";
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(109, 55);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(17, 55);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // clbEstado
            // 
            this.clbEstado.AutoSize = true;
            this.clbEstado.Enabled = false;
            this.clbEstado.Location = new System.Drawing.Point(341, 23);
            this.clbEstado.Name = "clbEstado";
            this.clbEstado.Size = new System.Drawing.Size(78, 20);
            this.clbEstado.TabIndex = 17;
            this.clbEstado.Text = "ACTIVO";
            this.clbEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estado";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Cliente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(150, 76);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(150, 23);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(28, 133);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(28, 77);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 4;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(28, 23);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 22);
            this.txtIdCliente.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(213, 201);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(123, 201);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 201);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 340);
            this.panel1.TabIndex = 0;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(968, 340);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabClientes);
            this.tabPrincipal.Controls.Add(this.tabRecursos);
            this.tabPrincipal.Controls.Add(this.tabReservas);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 28);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(982, 625);
            this.tabPrincipal.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // errorPro
            // 
            this.errorPro.ContainerControl = this;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox7);
            this.panel5.Controls.Add(this.textBox6);
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 329);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(968, 264);
            this.panel5.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(256, 47);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(257, 101);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(256, 154);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabReservas.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.tabRecursos.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.tabClientes.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabReservas;
        private System.Windows.Forms.TabPage tabRecursos;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox clbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.ErrorProvider errorPro;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


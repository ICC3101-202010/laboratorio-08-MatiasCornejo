namespace WindowsFormsApp1
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
            this.btnAgregarLocal = new System.Windows.Forms.Button();
            this.btnRevisarInformacion = new System.Windows.Forms.Button();
            this.btnLocales = new System.Windows.Forms.Button();
            this.panelListaLocales = new System.Windows.Forms.Panel();
            this.btnVolverListLocales = new System.Windows.Forms.Button();
            this.listLocales = new System.Windows.Forms.ListBox();
            this.panelAgregarLocal = new System.Windows.Forms.Panel();
            this.btnVolverDeELegirtipoDeLocal = new System.Windows.Forms.Button();
            this.btnRecreacional = new System.Windows.Forms.Button();
            this.btnCine = new System.Windows.Forms.Button();
            this.btnRestaurante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTienda = new System.Windows.Forms.Button();
            this.panelRegistroNuevTienda = new System.Windows.Forms.Panel();
            this.labelIngresardatos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreTienda = new System.Windows.Forms.TextBox();
            this.txtnombredueño = new System.Windows.Forms.TextBox();
            this.txtHoraAperturatienda = new System.Windows.Forms.TextBox();
            this.txtIdTienda = new System.Windows.Forms.TextBox();
            this.txtHoraCierrreTienda = new System.Windows.Forms.TextBox();
            this.btnFinalizarCreacionTienda = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnagregarnuevocine = new System.Windows.Forms.Button();
            this.txtHoracierreCine = new System.Windows.Forms.TextBox();
            this.txtHoraaperturacine = new System.Windows.Forms.TextBox();
            this.txtIdCine = new System.Windows.Forms.TextBox();
            this.txtnombreDueñoCine = new System.Windows.Forms.TextBox();
            this.txtNombreCine = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelListaLocales.SuspendLayout();
            this.panelAgregarLocal.SuspendLayout();
            this.panelRegistroNuevTienda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarLocal
            // 
            this.btnAgregarLocal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarLocal.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLocal.Location = new System.Drawing.Point(118, 52);
            this.btnAgregarLocal.Name = "btnAgregarLocal";
            this.btnAgregarLocal.Size = new System.Drawing.Size(201, 71);
            this.btnAgregarLocal.TabIndex = 0;
            this.btnAgregarLocal.Text = "Agregar Nuevo  Local";
            this.btnAgregarLocal.UseVisualStyleBackColor = false;
            this.btnAgregarLocal.Click += new System.EventHandler(this.btnAgregarLocal_Click);
            // 
            // btnRevisarInformacion
            // 
            this.btnRevisarInformacion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRevisarInformacion.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisarInformacion.Location = new System.Drawing.Point(118, 156);
            this.btnRevisarInformacion.Name = "btnRevisarInformacion";
            this.btnRevisarInformacion.Size = new System.Drawing.Size(201, 71);
            this.btnRevisarInformacion.TabIndex = 1;
            this.btnRevisarInformacion.Text = "Revisar informacion locales\r\n";
            this.btnRevisarInformacion.UseVisualStyleBackColor = false;
            // 
            // btnLocales
            // 
            this.btnLocales.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLocales.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocales.Location = new System.Drawing.Point(118, 260);
            this.btnLocales.Name = "btnLocales";
            this.btnLocales.Size = new System.Drawing.Size(201, 71);
            this.btnLocales.TabIndex = 2;
            this.btnLocales.Text = "Locales";
            this.btnLocales.UseVisualStyleBackColor = false;
            this.btnLocales.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelListaLocales
            // 
            this.panelListaLocales.BackColor = System.Drawing.Color.PeachPuff;
            this.panelListaLocales.Controls.Add(this.btnVolverListLocales);
            this.panelListaLocales.Controls.Add(this.listLocales);
            this.panelListaLocales.Location = new System.Drawing.Point(513, 118);
            this.panelListaLocales.Name = "panelListaLocales";
            this.panelListaLocales.Size = new System.Drawing.Size(247, 222);
            this.panelListaLocales.TabIndex = 4;
            this.panelListaLocales.Visible = false;
            // 
            // btnVolverListLocales
            // 
            this.btnVolverListLocales.Location = new System.Drawing.Point(3, 197);
            this.btnVolverListLocales.Name = "btnVolverListLocales";
            this.btnVolverListLocales.Size = new System.Drawing.Size(75, 23);
            this.btnVolverListLocales.TabIndex = 6;
            this.btnVolverListLocales.Text = "Volver";
            this.btnVolverListLocales.UseVisualStyleBackColor = true;
            // 
            // listLocales
            // 
            this.listLocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLocales.FormattingEnabled = true;
            this.listLocales.ItemHeight = 25;
            this.listLocales.Location = new System.Drawing.Point(32, 12);
            this.listLocales.Name = "listLocales";
            this.listLocales.Size = new System.Drawing.Size(193, 179);
            this.listLocales.TabIndex = 0;
            this.listLocales.SelectedIndexChanged += new System.EventHandler(this.listLocales_SelectedIndexChanged);
            // 
            // panelAgregarLocal
            // 
            this.panelAgregarLocal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelAgregarLocal.Controls.Add(this.panelRegistroNuevTienda);
            this.panelAgregarLocal.Controls.Add(this.btnVolverDeELegirtipoDeLocal);
            this.panelAgregarLocal.Controls.Add(this.btnRecreacional);
            this.panelAgregarLocal.Controls.Add(this.btnCine);
            this.panelAgregarLocal.Controls.Add(this.btnRestaurante);
            this.panelAgregarLocal.Controls.Add(this.label1);
            this.panelAgregarLocal.Controls.Add(this.btnTienda);
            this.panelAgregarLocal.Location = new System.Drawing.Point(3, 12);
            this.panelAgregarLocal.Name = "panelAgregarLocal";
            this.panelAgregarLocal.Size = new System.Drawing.Size(424, 374);
            this.panelAgregarLocal.TabIndex = 1;
            this.panelAgregarLocal.Visible = false;
            // 
            // btnVolverDeELegirtipoDeLocal
            // 
            this.btnVolverDeELegirtipoDeLocal.Location = new System.Drawing.Point(34, 318);
            this.btnVolverDeELegirtipoDeLocal.Name = "btnVolverDeELegirtipoDeLocal";
            this.btnVolverDeELegirtipoDeLocal.Size = new System.Drawing.Size(75, 23);
            this.btnVolverDeELegirtipoDeLocal.TabIndex = 5;
            this.btnVolverDeELegirtipoDeLocal.Text = "Volver";
            this.btnVolverDeELegirtipoDeLocal.UseVisualStyleBackColor = true;
            this.btnVolverDeELegirtipoDeLocal.Click += new System.EventHandler(this.btnVolverDeELegirtipoDeLocal_Click);
            // 
            // btnRecreacional
            // 
            this.btnRecreacional.Location = new System.Drawing.Point(103, 259);
            this.btnRecreacional.Name = "btnRecreacional";
            this.btnRecreacional.Size = new System.Drawing.Size(163, 32);
            this.btnRecreacional.TabIndex = 4;
            this.btnRecreacional.Text = "Recreacional";
            this.btnRecreacional.UseVisualStyleBackColor = true;
            this.btnRecreacional.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCine
            // 
            this.btnCine.Location = new System.Drawing.Point(103, 210);
            this.btnCine.Name = "btnCine";
            this.btnCine.Size = new System.Drawing.Size(163, 32);
            this.btnCine.TabIndex = 3;
            this.btnCine.Text = "Cine";
            this.btnCine.UseVisualStyleBackColor = true;
            this.btnCine.Click += new System.EventHandler(this.btnCine_Click);
            // 
            // btnRestaurante
            // 
            this.btnRestaurante.Location = new System.Drawing.Point(103, 156);
            this.btnRestaurante.Name = "btnRestaurante";
            this.btnRestaurante.Size = new System.Drawing.Size(163, 32);
            this.btnRestaurante.TabIndex = 2;
            this.btnRestaurante.Text = "Restaurante";
            this.btnRestaurante.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione tipo de local";
            // 
            // btnTienda
            // 
            this.btnTienda.Location = new System.Drawing.Point(103, 106);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(163, 32);
            this.btnTienda.TabIndex = 0;
            this.btnTienda.Text = "Tienda";
            this.btnTienda.UseVisualStyleBackColor = true;
            this.btnTienda.Click += new System.EventHandler(this.btnTienda_Click);
            // 
            // panelRegistroNuevTienda
            // 
            this.panelRegistroNuevTienda.Controls.Add(this.panel1);
            this.panelRegistroNuevTienda.Controls.Add(this.label8);
            this.panelRegistroNuevTienda.Controls.Add(this.label7);
            this.panelRegistroNuevTienda.Controls.Add(this.btnFinalizarCreacionTienda);
            this.panelRegistroNuevTienda.Controls.Add(this.txtHoraCierrreTienda);
            this.panelRegistroNuevTienda.Controls.Add(this.txtHoraAperturatienda);
            this.panelRegistroNuevTienda.Controls.Add(this.txtIdTienda);
            this.panelRegistroNuevTienda.Controls.Add(this.txtnombredueño);
            this.panelRegistroNuevTienda.Controls.Add(this.txtNombreTienda);
            this.panelRegistroNuevTienda.Controls.Add(this.label6);
            this.panelRegistroNuevTienda.Controls.Add(this.label5);
            this.panelRegistroNuevTienda.Controls.Add(this.label4);
            this.panelRegistroNuevTienda.Controls.Add(this.label3);
            this.panelRegistroNuevTienda.Controls.Add(this.label2);
            this.panelRegistroNuevTienda.Controls.Add(this.labelIngresardatos);
            this.panelRegistroNuevTienda.Location = new System.Drawing.Point(3, 3);
            this.panelRegistroNuevTienda.Name = "panelRegistroNuevTienda";
            this.panelRegistroNuevTienda.Size = new System.Drawing.Size(418, 368);
            this.panelRegistroNuevTienda.TabIndex = 6;
            this.panelRegistroNuevTienda.Visible = false;
            // 
            // labelIngresardatos
            // 
            this.labelIngresardatos.AutoSize = true;
            this.labelIngresardatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresardatos.Location = new System.Drawing.Point(65, 37);
            this.labelIngresardatos.Name = "labelIngresardatos";
            this.labelIngresardatos.Size = new System.Drawing.Size(238, 31);
            this.labelIngresardatos.TabIndex = 0;
            this.labelIngresardatos.Text = "Ingrese los datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre tienda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre dueño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id tienda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora apertura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora Cierre";
            // 
            // txtNombreTienda
            // 
            this.txtNombreTienda.Location = new System.Drawing.Point(194, 103);
            this.txtNombreTienda.Name = "txtNombreTienda";
            this.txtNombreTienda.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTienda.TabIndex = 6;
            // 
            // txtnombredueño
            // 
            this.txtnombredueño.Location = new System.Drawing.Point(194, 138);
            this.txtnombredueño.Name = "txtnombredueño";
            this.txtnombredueño.Size = new System.Drawing.Size(100, 20);
            this.txtnombredueño.TabIndex = 7;
            // 
            // txtHoraAperturatienda
            // 
            this.txtHoraAperturatienda.Location = new System.Drawing.Point(194, 220);
            this.txtHoraAperturatienda.Name = "txtHoraAperturatienda";
            this.txtHoraAperturatienda.Size = new System.Drawing.Size(100, 20);
            this.txtHoraAperturatienda.TabIndex = 9;
            // 
            // txtIdTienda
            // 
            this.txtIdTienda.Location = new System.Drawing.Point(194, 180);
            this.txtIdTienda.Name = "txtIdTienda";
            this.txtIdTienda.Size = new System.Drawing.Size(100, 20);
            this.txtIdTienda.TabIndex = 8;
            // 
            // txtHoraCierrreTienda
            // 
            this.txtHoraCierrreTienda.Location = new System.Drawing.Point(194, 264);
            this.txtHoraCierrreTienda.Name = "txtHoraCierrreTienda";
            this.txtHoraCierrreTienda.Size = new System.Drawing.Size(100, 20);
            this.txtHoraCierrreTienda.TabIndex = 10;
            // 
            // btnFinalizarCreacionTienda
            // 
            this.btnFinalizarCreacionTienda.Location = new System.Drawing.Point(280, 322);
            this.btnFinalizarCreacionTienda.Name = "btnFinalizarCreacionTienda";
            this.btnFinalizarCreacionTienda.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizarCreacionTienda.TabIndex = 11;
            this.btnFinalizarCreacionTienda.Text = "Continuar";
            this.btnFinalizarCreacionTienda.UseVisualStyleBackColor = true;
            this.btnFinalizarCreacionTienda.Click += new System.EventHandler(this.btnFinalizarCreacionTienda_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(300, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ej :11:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(298, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ej :21:00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnagregarnuevocine);
            this.panel1.Controls.Add(this.txtHoracierreCine);
            this.panel1.Controls.Add(this.txtHoraaperturacine);
            this.panel1.Controls.Add(this.txtIdCine);
            this.panel1.Controls.Add(this.txtnombreDueñoCine);
            this.panel1.Controls.Add(this.txtNombreCine);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 365);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(328, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "ej :21:00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(330, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "ej :11:00";
            // 
            // btnagregarnuevocine
            // 
            this.btnagregarnuevocine.Location = new System.Drawing.Point(310, 322);
            this.btnagregarnuevocine.Name = "btnagregarnuevocine";
            this.btnagregarnuevocine.Size = new System.Drawing.Size(75, 23);
            this.btnagregarnuevocine.TabIndex = 25;
            this.btnagregarnuevocine.Text = "Continuar";
            this.btnagregarnuevocine.UseVisualStyleBackColor = true;
            this.btnagregarnuevocine.Visible = false;
            this.btnagregarnuevocine.Click += new System.EventHandler(this.btnagregarnuevocine_Click);
            // 
            // txtHoracierreCine
            // 
            this.txtHoracierreCine.Location = new System.Drawing.Point(224, 262);
            this.txtHoracierreCine.Name = "txtHoracierreCine";
            this.txtHoracierreCine.Size = new System.Drawing.Size(100, 20);
            this.txtHoracierreCine.TabIndex = 24;
            // 
            // txtHoraaperturacine
            // 
            this.txtHoraaperturacine.Location = new System.Drawing.Point(224, 218);
            this.txtHoraaperturacine.Name = "txtHoraaperturacine";
            this.txtHoraaperturacine.Size = new System.Drawing.Size(100, 20);
            this.txtHoraaperturacine.TabIndex = 23;
            // 
            // txtIdCine
            // 
            this.txtIdCine.Location = new System.Drawing.Point(224, 178);
            this.txtIdCine.Name = "txtIdCine";
            this.txtIdCine.Size = new System.Drawing.Size(100, 20);
            this.txtIdCine.TabIndex = 22;
            // 
            // txtnombreDueñoCine
            // 
            this.txtnombreDueñoCine.Location = new System.Drawing.Point(224, 136);
            this.txtnombreDueñoCine.Name = "txtnombreDueñoCine";
            this.txtnombreDueñoCine.Size = new System.Drawing.Size(100, 20);
            this.txtnombreDueñoCine.TabIndex = 21;
            // 
            // txtNombreCine
            // 
            this.txtNombreCine.Location = new System.Drawing.Point(224, 101);
            this.txtNombreCine.Name = "txtNombreCine";
            this.txtNombreCine.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCine.TabIndex = 20;
            this.txtNombreCine.TextChanged += new System.EventHandler(this.txtNombreCine_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Hora Cierre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Hora apertura";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Id Cine";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Nombre dueño";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(36, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Nombre cine";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(95, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(238, 31);
            this.label16.TabIndex = 14;
            this.label16.Text = "Ingrese los datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(918, 614);
            this.Controls.Add(this.panelAgregarLocal);
            this.Controls.Add(this.panelListaLocales);
            this.Controls.Add(this.btnLocales);
            this.Controls.Add(this.btnRevisarInformacion);
            this.Controls.Add(this.btnAgregarLocal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelListaLocales.ResumeLayout(false);
            this.panelAgregarLocal.ResumeLayout(false);
            this.panelAgregarLocal.PerformLayout();
            this.panelRegistroNuevTienda.ResumeLayout(false);
            this.panelRegistroNuevTienda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarLocal;
        private System.Windows.Forms.Button btnRevisarInformacion;
        private System.Windows.Forms.Button btnLocales;
        private System.Windows.Forms.Panel panelListaLocales;
        private System.Windows.Forms.Panel panelAgregarLocal;
        private System.Windows.Forms.Button btnVolverDeELegirtipoDeLocal;
        private System.Windows.Forms.Button btnRecreacional;
        private System.Windows.Forms.Button btnCine;
        private System.Windows.Forms.Button btnRestaurante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTienda;
        private System.Windows.Forms.ListBox listLocales;
        private System.Windows.Forms.Button btnVolverListLocales;
        private System.Windows.Forms.Panel panelRegistroNuevTienda;
        private System.Windows.Forms.TextBox txtHoraCierrreTienda;
        private System.Windows.Forms.TextBox txtHoraAperturatienda;
        private System.Windows.Forms.TextBox txtIdTienda;
        private System.Windows.Forms.TextBox txtnombredueño;
        private System.Windows.Forms.TextBox txtNombreTienda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIngresardatos;
        private System.Windows.Forms.Button btnFinalizarCreacionTienda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnagregarnuevocine;
        private System.Windows.Forms.TextBox txtHoracierreCine;
        private System.Windows.Forms.TextBox txtHoraaperturacine;
        private System.Windows.Forms.TextBox txtIdCine;
        private System.Windows.Forms.TextBox txtnombreDueñoCine;
        private System.Windows.Forms.TextBox txtNombreCine;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}


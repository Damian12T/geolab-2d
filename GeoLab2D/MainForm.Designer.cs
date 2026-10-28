namespace GeoLab2D
{
    partial class MainForm
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
            this.grpFigura = new System.Windows.Forms.GroupBox();
            this.lblFigura = new System.Windows.Forms.Label();
            this.cboFigura = new System.Windows.Forms.ComboBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.nudLado = new System.Windows.Forms.NumericUpDown();
            this.lblCentroX = new System.Windows.Forms.Label();
            this.nudCentroX = new System.Windows.Forms.NumericUpDown();
            this.lblCentroY = new System.Windows.Forms.Label();
            this.nudCentroY = new System.Windows.Forms.NumericUpDown();
            this.lblRotacion = new System.Windows.Forms.Label();
            this.nudRotacion = new System.Windows.Forms.NumericUpDown();
            this.lblSeparacion = new System.Windows.Forms.Label();
            this.nudSeparacion = new System.Windows.Forms.NumericUpDown();
            this.lblN = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.lblK = new System.Windows.Forms.Label();
            this.nudK = new System.Windows.Forms.NumericUpDown();
            this.lblColores = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnContorno = new System.Windows.Forms.Button();
            this.chkCuadricula = new System.Windows.Forms.CheckBox();
            this.chkEjes = new System.Windows.Forms.CheckBox();
            this.chkOriginal = new System.Windows.Forms.CheckBox();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.lblEscala = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabResultados = new System.Windows.Forms.TabPage();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.tabVectores = new System.Windows.Forms.TabPage();
            this.lblA = new System.Windows.Forms.Label();
            this.txtAx = new System.Windows.Forms.TextBox();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.txtBy = new System.Windows.Forms.TextBox();
            this.btnMagA = new System.Windows.Forms.Button();
            this.btnMagB = new System.Windows.Forms.Button();
            this.btnDirA = new System.Windows.Forms.Button();
            this.btnDirB = new System.Windows.Forms.Button();
            this.btnProductoPunto = new System.Windows.Forms.Button();
            this.btnDeterminante = new System.Windows.Forms.Button();
            this.btnTodoVectores = new System.Windows.Forms.Button();
            this.txtVectores = new System.Windows.Forms.TextBox();
            this.tabGeometria = new System.Windows.Forms.TabPage();
            this.lblGA = new System.Windows.Forms.Label();
            this.txtGAx = new System.Windows.Forms.TextBox();
            this.txtGAy = new System.Windows.Forms.TextBox();
            this.lblGB = new System.Windows.Forms.Label();
            this.txtGBx = new System.Windows.Forms.TextBox();
            this.txtGBy = new System.Windows.Forms.TextBox();
            this.lblGC = new System.Windows.Forms.Label();
            this.txtGCx = new System.Windows.Forms.TextBox();
            this.txtGCy = new System.Windows.Forms.TextBox();
            this.lblGP = new System.Windows.Forms.Label();
            this.txtGPx = new System.Windows.Forms.TextBox();
            this.txtGPy = new System.Windows.Forms.TextBox();
            this.lblPoligono = new System.Windows.Forms.Label();
            this.cboPoligono = new System.Windows.Forms.ComboBox();
            this.lblTolerancia = new System.Windows.Forms.Label();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.btnDistancia = new System.Windows.Forms.Button();
            this.btnOrientacion = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnPertenencia = new System.Windows.Forms.Button();
            this.txtGeometria = new System.Windows.Forms.TextBox();
            this.tabProyeccion = new System.Windows.Forms.TabPage();
            this.lblPA = new System.Windows.Forms.Label();
            this.txtPAx = new System.Windows.Forms.TextBox();
            this.txtPAy = new System.Windows.Forms.TextBox();
            this.lblPB = new System.Windows.Forms.Label();
            this.txtPBx = new System.Windows.Forms.TextBox();
            this.txtPBy = new System.Windows.Forms.TextBox();
            this.lblPP = new System.Windows.Forms.Label();
            this.txtPPx = new System.Windows.Forms.TextBox();
            this.txtPPy = new System.Windows.Forms.TextBox();
            this.btnProyectar = new System.Windows.Forms.Button();
            this.txtProyeccion = new System.Windows.Forms.TextBox();
            this.tabTransformaciones = new System.Windows.Forms.TabPage();
            this.lblTx = new System.Windows.Forms.Label();
            this.txtTx = new System.Windows.Forms.TextBox();
            this.lblTy = new System.Windows.Forms.Label();
            this.txtTy = new System.Windows.Forms.TextBox();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.lblSx = new System.Windows.Forms.Label();
            this.txtSx = new System.Windows.Forms.TextBox();
            this.lblSy = new System.Windows.Forms.Label();
            this.txtSy = new System.Windows.Forms.TextBox();
            this.chkUniforme = new System.Windows.Forms.CheckBox();
            this.chkCentro = new System.Windows.Forms.CheckBox();
            this.btnTrasladar = new System.Windows.Forms.Button();
            this.btnRotar = new System.Windows.Forms.Button();
            this.btnEscalar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.txtTransformaciones = new System.Windows.Forms.TextBox();
            this.tabPruebas = new System.Windows.Forms.TabPage();
            this.btnPruebas = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.dgvPruebas = new System.Windows.Forms.DataGridView();
            this.grpFigura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCentroX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCentroY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabResultados.SuspendLayout();
            this.tabVectores.SuspendLayout();
            this.tabGeometria.SuspendLayout();
            this.tabProyeccion.SuspendLayout();
            this.tabTransformaciones.SuspendLayout();
            this.tabPruebas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPruebas)).BeginInit();
            this.SuspendLayout();
            //
            // grpFigura
            //
            this.grpFigura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpFigura.Controls.Add(this.lblFigura);
            this.grpFigura.Controls.Add(this.cboFigura);
            this.grpFigura.Controls.Add(this.lblLado);
            this.grpFigura.Controls.Add(this.nudLado);
            this.grpFigura.Controls.Add(this.lblCentroX);
            this.grpFigura.Controls.Add(this.nudCentroX);
            this.grpFigura.Controls.Add(this.lblCentroY);
            this.grpFigura.Controls.Add(this.nudCentroY);
            this.grpFigura.Controls.Add(this.lblRotacion);
            this.grpFigura.Controls.Add(this.nudRotacion);
            this.grpFigura.Controls.Add(this.lblSeparacion);
            this.grpFigura.Controls.Add(this.nudSeparacion);
            this.grpFigura.Controls.Add(this.lblN);
            this.grpFigura.Controls.Add(this.nudN);
            this.grpFigura.Controls.Add(this.lblK);
            this.grpFigura.Controls.Add(this.nudK);
            this.grpFigura.Controls.Add(this.lblColores);
            this.grpFigura.Controls.Add(this.cboColor);
            this.grpFigura.Controls.Add(this.btnColor);
            this.grpFigura.Controls.Add(this.btnContorno);
            this.grpFigura.Controls.Add(this.chkCuadricula);
            this.grpFigura.Controls.Add(this.chkEjes);
            this.grpFigura.Controls.Add(this.chkOriginal);
            this.grpFigura.Controls.Add(this.lblAyuda);
            this.grpFigura.Location = new System.Drawing.Point(12, 12);
            this.grpFigura.Name = "grpFigura";
            this.grpFigura.Size = new System.Drawing.Size(258, 676);
            this.grpFigura.TabIndex = 0;
            this.grpFigura.TabStop = false;
            this.grpFigura.Text = "Figura";
            //
            // lblFigura
            //
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(10, 25);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(115, 15);
            this.lblFigura.Text = "Seleccione la figura:";
            //
            // cboFigura
            //
            this.cboFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFigura.FormattingEnabled = true;
            this.cboFigura.Items.AddRange(new object[] {
            "Hexágono de 6 colores",
            "Flor de margarita",
            "Polígono estrellado"});
            this.cboFigura.Location = new System.Drawing.Point(10, 45);
            this.cboFigura.Name = "cboFigura";
            this.cboFigura.Size = new System.Drawing.Size(238, 23);
            this.cboFigura.TabIndex = 1;
            this.cboFigura.SelectedIndexChanged += new System.EventHandler(this.cboFigura_SelectedIndexChanged);
            //
            // lblLado
            //
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(10, 89);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(55, 15);
            this.lblLado.Text = "Lado (u):";
            //
            // nudLado
            //
            this.nudLado.DecimalPlaces = 2;
            this.nudLado.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudLado.Location = new System.Drawing.Point(140, 85);
            this.nudLado.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLado.Name = "nudLado";
            this.nudLado.Size = new System.Drawing.Size(108, 23);
            this.nudLado.TabIndex = 2;
            this.nudLado.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudLado.ValueChanged += new System.EventHandler(this.Parametro_ValueChanged);
            //
            // lblCentroX
            //
            this.lblCentroX.AutoSize = true;
            this.lblCentroX.Location = new System.Drawing.Point(10, 121);
            this.lblCentroX.Name = "lblCentroX";
            this.lblCentroX.Size = new System.Drawing.Size(73, 15);
            this.lblCentroX.Text = "Centro X (u):";
            //
            // nudCentroX
            //
            this.nudCentroX.DecimalPlaces = 1;
            this.nudCentroX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCentroX.Location = new System.Drawing.Point(140, 117);
            this.nudCentroX.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudCentroX.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
            this.nudCentroX.Name = "nudCentroX";
            this.nudCentroX.Size = new System.Drawing.Size(108, 23);
            this.nudCentroX.TabIndex = 3;
            this.nudCentroX.ValueChanged += new System.EventHandler(this.Parametro_ValueChanged);
            //
            // lblCentroY
            //
            this.lblCentroY.AutoSize = true;
            this.lblCentroY.Location = new System.Drawing.Point(10, 153);
            this.lblCentroY.Name = "lblCentroY";
            this.lblCentroY.Size = new System.Drawing.Size(73, 15);
            this.lblCentroY.Text = "Centro Y (u):";
            //
            // nudCentroY
            //
            this.nudCentroY.DecimalPlaces = 1;
            this.nudCentroY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCentroY.Location = new System.Drawing.Point(140, 149);
            this.nudCentroY.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudCentroY.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            -2147483648});
            this.nudCentroY.Name = "nudCentroY";
            this.nudCentroY.Size = new System.Drawing.Size(108, 23);
            this.nudCentroY.TabIndex = 4;
            this.nudCentroY.ValueChanged += new System.EventHandler(this.Parametro_ValueChanged);
            //
            // lblRotacion
            //
            this.lblRotacion.AutoSize = true;
            this.lblRotacion.Location = new System.Drawing.Point(10, 185);
            this.lblRotacion.Name = "lblRotacion";
            this.lblRotacion.Size = new System.Drawing.Size(77, 15);
            this.lblRotacion.Text = "Rotación (°):";
            //
            // nudRotacion
            //
            this.nudRotacion.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRotacion.Location = new System.Drawing.Point(140, 181);
            this.nudRotacion.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudRotacion.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudRotacion.Name = "nudRotacion";
            this.nudRotacion.Size = new System.Drawing.Size(108, 23);
            this.nudRotacion.TabIndex = 5;
            this.nudRotacion.ValueChanged += new System.EventHandler(this.Parametro_ValueChanged);
            //
            // lblSeparacion
            //
            this.lblSeparacion.AutoSize = true;
            this.lblSeparacion.Location = new System.Drawing.Point(10, 217);
            this.lblSeparacion.Name = "lblSeparacion";
            this.lblSeparacion.Size = new System.Drawing.Size(113, 15);
            this.lblSeparacion.Text = "Separación pétalos:";
            //
            // nudSeparacion
            //
            this.nudSeparacion.DecimalPlaces = 2;
            this.nudSeparacion.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudSeparacion.Location = new System.Drawing.Point(140, 213);
            this.nudSeparacion.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSeparacion.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudSeparacion.Name = "nudSeparacion";
            this.nudSeparacion.Size = new System.Drawing.Size(108, 23);
            this.nudSeparacion.TabIndex = 6;
            this.nudSeparacion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeparacion.ValueChanged += new System.EventHandler(this.Parametro_ValueChanged);
            //
            // lblN
            //
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(10, 249);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(66, 15);
            this.lblN.Text = "Vértices N:";
            //
            // nudN
            //
            this.nudN.Location = new System.Drawing.Point(140, 245);
            this.nudN.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(108, 23);
            this.nudN.TabIndex = 7;
            this.nudN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudN.ValueChanged += new System.EventHandler(this.Parametro_ValueChanged);
            //
            // lblK
            //
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(10, 281);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(49, 15);
            this.lblK.Text = "Salto K:";
            //
            // nudK
            //
            this.nudK.Location = new System.Drawing.Point(140, 277);
            this.nudK.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudK.Name = "nudK";
            this.nudK.Size = new System.Drawing.Size(108, 23);
            this.nudK.TabIndex = 8;
            this.nudK.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudK.ValueChanged += new System.EventHandler(this.Parametro_ValueChanged);
            //
            // lblColores
            //
            this.lblColores.AutoSize = true;
            this.lblColores.Location = new System.Drawing.Point(10, 322);
            this.lblColores.Name = "lblColores";
            this.lblColores.Size = new System.Drawing.Size(50, 15);
            this.lblColores.Text = "Colores:";
            //
            // cboColor
            //
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(10, 342);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(150, 23);
            this.cboColor.TabIndex = 9;
            //
            // btnColor
            //
            this.btnColor.Location = new System.Drawing.Point(166, 341);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(82, 25);
            this.btnColor.TabIndex = 10;
            this.btnColor.Text = "Cambiar...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            //
            // btnContorno
            //
            this.btnContorno.Location = new System.Drawing.Point(10, 374);
            this.btnContorno.Name = "btnContorno";
            this.btnContorno.Size = new System.Drawing.Size(238, 27);
            this.btnContorno.TabIndex = 11;
            this.btnContorno.Text = "Color del contorno...";
            this.btnContorno.UseVisualStyleBackColor = true;
            this.btnContorno.Click += new System.EventHandler(this.btnContorno_Click);
            //
            // chkCuadricula
            //
            this.chkCuadricula.AutoSize = true;
            this.chkCuadricula.Checked = true;
            this.chkCuadricula.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCuadricula.Location = new System.Drawing.Point(10, 420);
            this.chkCuadricula.Name = "chkCuadricula";
            this.chkCuadricula.Size = new System.Drawing.Size(125, 19);
            this.chkCuadricula.TabIndex = 12;
            this.chkCuadricula.Text = "Mostrar cuadrícula";
            this.chkCuadricula.UseVisualStyleBackColor = true;
            this.chkCuadricula.CheckedChanged += new System.EventHandler(this.Vista_CheckedChanged);
            //
            // chkEjes
            //
            this.chkEjes.AutoSize = true;
            this.chkEjes.Checked = true;
            this.chkEjes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEjes.Location = new System.Drawing.Point(10, 445);
            this.chkEjes.Name = "chkEjes";
            this.chkEjes.Size = new System.Drawing.Size(93, 19);
            this.chkEjes.TabIndex = 13;
            this.chkEjes.Text = "Mostrar ejes";
            this.chkEjes.UseVisualStyleBackColor = true;
            this.chkEjes.CheckedChanged += new System.EventHandler(this.Vista_CheckedChanged);
            //
            // chkOriginal
            //
            this.chkOriginal.AutoSize = true;
            this.chkOriginal.Checked = true;
            this.chkOriginal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOriginal.Location = new System.Drawing.Point(10, 470);
            this.chkOriginal.Name = "chkOriginal";
            this.chkOriginal.Size = new System.Drawing.Size(160, 19);
            this.chkOriginal.TabIndex = 14;
            this.chkOriginal.Text = "Mostrar figura original";
            this.chkOriginal.UseVisualStyleBackColor = true;
            this.chkOriginal.CheckedChanged += new System.EventHandler(this.Vista_CheckedChanged);
            //
            // lblAyuda
            //
            this.lblAyuda.ForeColor = System.Drawing.Color.DimGray;
            this.lblAyuda.Location = new System.Drawing.Point(10, 505);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(238, 80);
            this.lblAyuda.Text = "Las coordenadas son matemáticas (el eje Y crece hacia arriba). La escala se reduce sola si la figura no cabe. En la pestaña Geometría puede hacer clic en el lienzo para colocar el punto P.";
            //
            // picCanvas
            //
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picCanvas.Location = new System.Drawing.Point(280, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(820, 650);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.Resize += new System.EventHandler(this.picCanvas_Resize);
            //
            // lblCoordenadas
            //
            this.lblCoordenadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Location = new System.Drawing.Point(280, 668);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(84, 15);
            this.lblCoordenadas.Text = "x = 0;  y = 0";
            //
            // lblEscala
            //
            this.lblEscala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEscala.AutoSize = true;
            this.lblEscala.ForeColor = System.Drawing.Color.DimGray;
            this.lblEscala.Location = new System.Drawing.Point(480, 668);
            this.lblEscala.Name = "lblEscala";
            this.lblEscala.Size = new System.Drawing.Size(140, 15);
            this.lblEscala.Text = "Escala: 40 px por unidad";
            //
            // tabControl
            //
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabResultados);
            this.tabControl.Controls.Add(this.tabVectores);
            this.tabControl.Controls.Add(this.tabGeometria);
            this.tabControl.Controls.Add(this.tabProyeccion);
            this.tabControl.Controls.Add(this.tabTransformaciones);
            this.tabControl.Controls.Add(this.tabPruebas);
            this.tabControl.Location = new System.Drawing.Point(1110, 12);
            this.tabControl.Multiline = true;
            this.tabControl.Padding = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(378, 676);
            this.tabControl.TabIndex = 2;
            //
            // tabResultados
            //
            this.tabResultados.Controls.Add(this.txtResultados);
            this.tabResultados.Location = new System.Drawing.Point(4, 24);
            this.tabResultados.Name = "tabResultados";
            this.tabResultados.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultados.Size = new System.Drawing.Size(370, 648);
            this.tabResultados.TabIndex = 0;
            this.tabResultados.Text = "Resultados";
            this.tabResultados.UseVisualStyleBackColor = true;
            //
            // txtResultados
            //
            this.txtResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultados.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtResultados.Location = new System.Drawing.Point(3, 3);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultados.Size = new System.Drawing.Size(364, 642);
            this.txtResultados.TabIndex = 0;
            this.txtResultados.WordWrap = false;
            //
            // tabVectores
            //
            this.tabVectores.Controls.Add(this.lblA);
            this.tabVectores.Controls.Add(this.txtAx);
            this.tabVectores.Controls.Add(this.txtAy);
            this.tabVectores.Controls.Add(this.lblB);
            this.tabVectores.Controls.Add(this.txtBx);
            this.tabVectores.Controls.Add(this.txtBy);
            this.tabVectores.Controls.Add(this.btnMagA);
            this.tabVectores.Controls.Add(this.btnMagB);
            this.tabVectores.Controls.Add(this.btnDirA);
            this.tabVectores.Controls.Add(this.btnDirB);
            this.tabVectores.Controls.Add(this.btnProductoPunto);
            this.tabVectores.Controls.Add(this.btnDeterminante);
            this.tabVectores.Controls.Add(this.btnTodoVectores);
            this.tabVectores.Controls.Add(this.txtVectores);
            this.tabVectores.Location = new System.Drawing.Point(4, 24);
            this.tabVectores.Name = "tabVectores";
            this.tabVectores.Padding = new System.Windows.Forms.Padding(3);
            this.tabVectores.Size = new System.Drawing.Size(370, 648);
            this.tabVectores.TabIndex = 1;
            this.tabVectores.Text = "Vectores";
            this.tabVectores.UseVisualStyleBackColor = true;
            //
            // lblA
            //
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(10, 18);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(94, 15);
            this.lblA.Text = "Vector A (x, y):";
            //
            // txtAx
            //
            this.txtAx.Location = new System.Drawing.Point(130, 15);
            this.txtAx.Name = "txtAx";
            this.txtAx.Size = new System.Drawing.Size(100, 23);
            this.txtAx.TabIndex = 0;
            this.txtAx.Text = "3";
            //
            // txtAy
            //
            this.txtAy.Location = new System.Drawing.Point(240, 15);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(100, 23);
            this.txtAy.TabIndex = 1;
            this.txtAy.Text = "4";
            //
            // lblB
            //
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(10, 50);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(93, 15);
            this.lblB.Text = "Vector B (x, y):";
            //
            // txtBx
            //
            this.txtBx.Location = new System.Drawing.Point(130, 47);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(100, 23);
            this.txtBx.TabIndex = 2;
            this.txtBx.Text = "-2";
            //
            // txtBy
            //
            this.txtBy.Location = new System.Drawing.Point(240, 47);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(100, 23);
            this.txtBy.TabIndex = 3;
            this.txtBy.Text = "5";
            //
            // btnMagA
            //
            this.btnMagA.Location = new System.Drawing.Point(10, 88);
            this.btnMagA.Name = "btnMagA";
            this.btnMagA.Size = new System.Drawing.Size(80, 28);
            this.btnMagA.TabIndex = 4;
            this.btnMagA.Text = "|A|";
            this.btnMagA.UseVisualStyleBackColor = true;
            this.btnMagA.Click += new System.EventHandler(this.btnMagA_Click);
            //
            // btnMagB
            //
            this.btnMagB.Location = new System.Drawing.Point(95, 88);
            this.btnMagB.Name = "btnMagB";
            this.btnMagB.Size = new System.Drawing.Size(80, 28);
            this.btnMagB.TabIndex = 5;
            this.btnMagB.Text = "|B|";
            this.btnMagB.UseVisualStyleBackColor = true;
            this.btnMagB.Click += new System.EventHandler(this.btnMagB_Click);
            //
            // btnDirA
            //
            this.btnDirA.Location = new System.Drawing.Point(180, 88);
            this.btnDirA.Name = "btnDirA";
            this.btnDirA.Size = new System.Drawing.Size(85, 28);
            this.btnDirA.TabIndex = 6;
            this.btnDirA.Text = "Dirección A";
            this.btnDirA.UseVisualStyleBackColor = true;
            this.btnDirA.Click += new System.EventHandler(this.btnDirA_Click);
            //
            // btnDirB
            //
            this.btnDirB.Location = new System.Drawing.Point(270, 88);
            this.btnDirB.Name = "btnDirB";
            this.btnDirB.Size = new System.Drawing.Size(85, 28);
            this.btnDirB.TabIndex = 7;
            this.btnDirB.Text = "Dirección B";
            this.btnDirB.UseVisualStyleBackColor = true;
            this.btnDirB.Click += new System.EventHandler(this.btnDirB_Click);
            //
            // btnProductoPunto
            //
            this.btnProductoPunto.Location = new System.Drawing.Point(10, 122);
            this.btnProductoPunto.Name = "btnProductoPunto";
            this.btnProductoPunto.Size = new System.Drawing.Size(110, 28);
            this.btnProductoPunto.TabIndex = 8;
            this.btnProductoPunto.Text = "Producto punto";
            this.btnProductoPunto.UseVisualStyleBackColor = true;
            this.btnProductoPunto.Click += new System.EventHandler(this.btnProductoPunto_Click);
            //
            // btnDeterminante
            //
            this.btnDeterminante.Location = new System.Drawing.Point(125, 122);
            this.btnDeterminante.Name = "btnDeterminante";
            this.btnDeterminante.Size = new System.Drawing.Size(110, 28);
            this.btnDeterminante.TabIndex = 9;
            this.btnDeterminante.Text = "Determinante";
            this.btnDeterminante.UseVisualStyleBackColor = true;
            this.btnDeterminante.Click += new System.EventHandler(this.btnDeterminante_Click);
            //
            // btnTodoVectores
            //
            this.btnTodoVectores.Location = new System.Drawing.Point(240, 122);
            this.btnTodoVectores.Name = "btnTodoVectores";
            this.btnTodoVectores.Size = new System.Drawing.Size(115, 28);
            this.btnTodoVectores.TabIndex = 10;
            this.btnTodoVectores.Text = "Calcular todo";
            this.btnTodoVectores.UseVisualStyleBackColor = true;
            this.btnTodoVectores.Click += new System.EventHandler(this.btnTodoVectores_Click);
            //
            // txtVectores
            //
            this.txtVectores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVectores.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtVectores.Location = new System.Drawing.Point(10, 165);
            this.txtVectores.Multiline = true;
            this.txtVectores.Name = "txtVectores";
            this.txtVectores.ReadOnly = true;
            this.txtVectores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVectores.Size = new System.Drawing.Size(350, 470);
            this.txtVectores.TabIndex = 11;
            //
            // tabGeometria
            //
            this.tabGeometria.Controls.Add(this.lblGA);
            this.tabGeometria.Controls.Add(this.txtGAx);
            this.tabGeometria.Controls.Add(this.txtGAy);
            this.tabGeometria.Controls.Add(this.lblGB);
            this.tabGeometria.Controls.Add(this.txtGBx);
            this.tabGeometria.Controls.Add(this.txtGBy);
            this.tabGeometria.Controls.Add(this.lblGC);
            this.tabGeometria.Controls.Add(this.txtGCx);
            this.tabGeometria.Controls.Add(this.txtGCy);
            this.tabGeometria.Controls.Add(this.lblGP);
            this.tabGeometria.Controls.Add(this.txtGPx);
            this.tabGeometria.Controls.Add(this.txtGPy);
            this.tabGeometria.Controls.Add(this.lblPoligono);
            this.tabGeometria.Controls.Add(this.cboPoligono);
            this.tabGeometria.Controls.Add(this.lblTolerancia);
            this.tabGeometria.Controls.Add(this.txtTolerancia);
            this.tabGeometria.Controls.Add(this.btnDistancia);
            this.tabGeometria.Controls.Add(this.btnOrientacion);
            this.tabGeometria.Controls.Add(this.btnArea);
            this.tabGeometria.Controls.Add(this.btnPertenencia);
            this.tabGeometria.Controls.Add(this.txtGeometria);
            this.tabGeometria.Location = new System.Drawing.Point(4, 24);
            this.tabGeometria.Name = "tabGeometria";
            this.tabGeometria.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeometria.Size = new System.Drawing.Size(370, 648);
            this.tabGeometria.TabIndex = 2;
            this.tabGeometria.Text = "Geometría";
            this.tabGeometria.UseVisualStyleBackColor = true;
            //
            // lblGA
            //
            this.lblGA.AutoSize = true;
            this.lblGA.Location = new System.Drawing.Point(10, 18);
            this.lblGA.Name = "lblGA";
            this.lblGA.Size = new System.Drawing.Size(92, 15);
            this.lblGA.Text = "Punto A (x, y):";
            //
            // txtGAx
            //
            this.txtGAx.Location = new System.Drawing.Point(130, 15);
            this.txtGAx.Name = "txtGAx";
            this.txtGAx.Size = new System.Drawing.Size(100, 23);
            this.txtGAx.TabIndex = 0;
            this.txtGAx.Text = "0";
            //
            // txtGAy
            //
            this.txtGAy.Location = new System.Drawing.Point(240, 15);
            this.txtGAy.Name = "txtGAy";
            this.txtGAy.Size = new System.Drawing.Size(100, 23);
            this.txtGAy.TabIndex = 1;
            this.txtGAy.Text = "0";
            //
            // lblGB
            //
            this.lblGB.AutoSize = true;
            this.lblGB.Location = new System.Drawing.Point(10, 50);
            this.lblGB.Name = "lblGB";
            this.lblGB.Size = new System.Drawing.Size(91, 15);
            this.lblGB.Text = "Punto B (x, y):";
            //
            // txtGBx
            //
            this.txtGBx.Location = new System.Drawing.Point(130, 47);
            this.txtGBx.Name = "txtGBx";
            this.txtGBx.Size = new System.Drawing.Size(100, 23);
            this.txtGBx.TabIndex = 2;
            this.txtGBx.Text = "4";
            //
            // txtGBy
            //
            this.txtGBy.Location = new System.Drawing.Point(240, 47);
            this.txtGBy.Name = "txtGBy";
            this.txtGBy.Size = new System.Drawing.Size(100, 23);
            this.txtGBy.TabIndex = 3;
            this.txtGBy.Text = "0";
            //
            // lblGC
            //
            this.lblGC.AutoSize = true;
            this.lblGC.Location = new System.Drawing.Point(10, 82);
            this.lblGC.Name = "lblGC";
            this.lblGC.Size = new System.Drawing.Size(92, 15);
            this.lblGC.Text = "Punto C (x, y):";
            //
            // txtGCx
            //
            this.txtGCx.Location = new System.Drawing.Point(130, 79);
            this.txtGCx.Name = "txtGCx";
            this.txtGCx.Size = new System.Drawing.Size(100, 23);
            this.txtGCx.TabIndex = 4;
            this.txtGCx.Text = "2";
            //
            // txtGCy
            //
            this.txtGCy.Location = new System.Drawing.Point(240, 79);
            this.txtGCy.Name = "txtGCy";
            this.txtGCy.Size = new System.Drawing.Size(100, 23);
            this.txtGCy.TabIndex = 5;
            this.txtGCy.Text = "3";
            //
            // lblGP
            //
            this.lblGP.AutoSize = true;
            this.lblGP.Location = new System.Drawing.Point(10, 114);
            this.lblGP.Name = "lblGP";
            this.lblGP.Size = new System.Drawing.Size(90, 15);
            this.lblGP.Text = "Punto P (x, y):";
            //
            // txtGPx
            //
            this.txtGPx.Location = new System.Drawing.Point(130, 111);
            this.txtGPx.Name = "txtGPx";
            this.txtGPx.Size = new System.Drawing.Size(100, 23);
            this.txtGPx.TabIndex = 6;
            this.txtGPx.Text = "1";
            //
            // txtGPy
            //
            this.txtGPy.Location = new System.Drawing.Point(240, 111);
            this.txtGPy.Name = "txtGPy";
            this.txtGPy.Size = new System.Drawing.Size(100, 23);
            this.txtGPy.TabIndex = 7;
            this.txtGPy.Text = "1";
            //
            // lblPoligono
            //
            this.lblPoligono.AutoSize = true;
            this.lblPoligono.Location = new System.Drawing.Point(10, 150);
            this.lblPoligono.Name = "lblPoligono";
            this.lblPoligono.Size = new System.Drawing.Size(58, 15);
            this.lblPoligono.Text = "Polígono:";
            //
            // cboPoligono
            //
            this.cboPoligono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPoligono.FormattingEnabled = true;
            this.cboPoligono.Location = new System.Drawing.Point(130, 147);
            this.cboPoligono.Name = "cboPoligono";
            this.cboPoligono.Size = new System.Drawing.Size(210, 23);
            this.cboPoligono.TabIndex = 8;
            //
            // lblTolerancia
            //
            this.lblTolerancia.AutoSize = true;
            this.lblTolerancia.Location = new System.Drawing.Point(10, 182);
            this.lblTolerancia.Name = "lblTolerancia";
            this.lblTolerancia.Size = new System.Drawing.Size(66, 15);
            this.lblTolerancia.Text = "Tolerancia:";
            //
            // txtTolerancia
            //
            this.txtTolerancia.Location = new System.Drawing.Point(130, 179);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(100, 23);
            this.txtTolerancia.TabIndex = 9;
            this.txtTolerancia.Text = "0.000001";
            //
            // btnDistancia
            //
            this.btnDistancia.Location = new System.Drawing.Point(10, 218);
            this.btnDistancia.Name = "btnDistancia";
            this.btnDistancia.Size = new System.Drawing.Size(170, 28);
            this.btnDistancia.TabIndex = 10;
            this.btnDistancia.Text = "Distancia A - B";
            this.btnDistancia.UseVisualStyleBackColor = true;
            this.btnDistancia.Click += new System.EventHandler(this.btnDistancia_Click);
            //
            // btnOrientacion
            //
            this.btnOrientacion.Location = new System.Drawing.Point(186, 218);
            this.btnOrientacion.Name = "btnOrientacion";
            this.btnOrientacion.Size = new System.Drawing.Size(170, 28);
            this.btnOrientacion.TabIndex = 11;
            this.btnOrientacion.Text = "Orientación A, B, C";
            this.btnOrientacion.UseVisualStyleBackColor = true;
            this.btnOrientacion.Click += new System.EventHandler(this.btnOrientacion_Click);
            //
            // btnArea
            //
            this.btnArea.Location = new System.Drawing.Point(10, 252);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(170, 28);
            this.btnArea.TabIndex = 12;
            this.btnArea.Text = "Área y perímetro";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            //
            // btnPertenencia
            //
            this.btnPertenencia.Location = new System.Drawing.Point(186, 252);
            this.btnPertenencia.Name = "btnPertenencia";
            this.btnPertenencia.Size = new System.Drawing.Size(170, 28);
            this.btnPertenencia.TabIndex = 13;
            this.btnPertenencia.Text = "¿P está en el polígono?";
            this.btnPertenencia.UseVisualStyleBackColor = true;
            this.btnPertenencia.Click += new System.EventHandler(this.btnPertenencia_Click);
            //
            // txtGeometria
            //
            this.txtGeometria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeometria.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtGeometria.Location = new System.Drawing.Point(10, 295);
            this.txtGeometria.Multiline = true;
            this.txtGeometria.Name = "txtGeometria";
            this.txtGeometria.ReadOnly = true;
            this.txtGeometria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGeometria.Size = new System.Drawing.Size(350, 340);
            this.txtGeometria.TabIndex = 14;
            //
            // tabProyeccion
            //
            this.tabProyeccion.Controls.Add(this.lblPA);
            this.tabProyeccion.Controls.Add(this.txtPAx);
            this.tabProyeccion.Controls.Add(this.txtPAy);
            this.tabProyeccion.Controls.Add(this.lblPB);
            this.tabProyeccion.Controls.Add(this.txtPBx);
            this.tabProyeccion.Controls.Add(this.txtPBy);
            this.tabProyeccion.Controls.Add(this.lblPP);
            this.tabProyeccion.Controls.Add(this.txtPPx);
            this.tabProyeccion.Controls.Add(this.txtPPy);
            this.tabProyeccion.Controls.Add(this.btnProyectar);
            this.tabProyeccion.Controls.Add(this.txtProyeccion);
            this.tabProyeccion.Location = new System.Drawing.Point(4, 24);
            this.tabProyeccion.Name = "tabProyeccion";
            this.tabProyeccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabProyeccion.Size = new System.Drawing.Size(370, 648);
            this.tabProyeccion.TabIndex = 3;
            this.tabProyeccion.Text = "Proyección";
            this.tabProyeccion.UseVisualStyleBackColor = true;
            //
            // lblPA
            //
            this.lblPA.AutoSize = true;
            this.lblPA.Location = new System.Drawing.Point(10, 18);
            this.lblPA.Name = "lblPA";
            this.lblPA.Size = new System.Drawing.Size(105, 15);
            this.lblPA.Text = "Extremo A (x, y):";
            //
            // txtPAx
            //
            this.txtPAx.Location = new System.Drawing.Point(130, 15);
            this.txtPAx.Name = "txtPAx";
            this.txtPAx.Size = new System.Drawing.Size(100, 23);
            this.txtPAx.TabIndex = 0;
            this.txtPAx.Text = "-4";
            //
            // txtPAy
            //
            this.txtPAy.Location = new System.Drawing.Point(240, 15);
            this.txtPAy.Name = "txtPAy";
            this.txtPAy.Size = new System.Drawing.Size(100, 23);
            this.txtPAy.TabIndex = 1;
            this.txtPAy.Text = "-2";
            //
            // lblPB
            //
            this.lblPB.AutoSize = true;
            this.lblPB.Location = new System.Drawing.Point(10, 50);
            this.lblPB.Name = "lblPB";
            this.lblPB.Size = new System.Drawing.Size(104, 15);
            this.lblPB.Text = "Extremo B (x, y):";
            //
            // txtPBx
            //
            this.txtPBx.Location = new System.Drawing.Point(130, 47);
            this.txtPBx.Name = "txtPBx";
            this.txtPBx.Size = new System.Drawing.Size(100, 23);
            this.txtPBx.TabIndex = 2;
            this.txtPBx.Text = "5";
            //
            // txtPBy
            //
            this.txtPBy.Location = new System.Drawing.Point(240, 47);
            this.txtPBy.Name = "txtPBy";
            this.txtPBy.Size = new System.Drawing.Size(100, 23);
            this.txtPBy.TabIndex = 3;
            this.txtPBy.Text = "1";
            //
            // lblPP
            //
            this.lblPP.AutoSize = true;
            this.lblPP.Location = new System.Drawing.Point(10, 82);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(90, 15);
            this.lblPP.Text = "Punto P (x, y):";
            //
            // txtPPx
            //
            this.txtPPx.Location = new System.Drawing.Point(130, 79);
            this.txtPPx.Name = "txtPPx";
            this.txtPPx.Size = new System.Drawing.Size(100, 23);
            this.txtPPx.TabIndex = 4;
            this.txtPPx.Text = "0";
            //
            // txtPPy
            //
            this.txtPPy.Location = new System.Drawing.Point(240, 79);
            this.txtPPy.Name = "txtPPy";
            this.txtPPy.Size = new System.Drawing.Size(100, 23);
            this.txtPPy.TabIndex = 5;
            this.txtPPy.Text = "4";
            //
            // btnProyectar
            //
            this.btnProyectar.Location = new System.Drawing.Point(10, 118);
            this.btnProyectar.Name = "btnProyectar";
            this.btnProyectar.Size = new System.Drawing.Size(346, 30);
            this.btnProyectar.TabIndex = 6;
            this.btnProyectar.Text = "Proyectar P sobre el segmento AB";
            this.btnProyectar.UseVisualStyleBackColor = true;
            this.btnProyectar.Click += new System.EventHandler(this.btnProyectar_Click);
            //
            // txtProyeccion
            //
            this.txtProyeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProyeccion.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtProyeccion.Location = new System.Drawing.Point(10, 160);
            this.txtProyeccion.Multiline = true;
            this.txtProyeccion.Name = "txtProyeccion";
            this.txtProyeccion.ReadOnly = true;
            this.txtProyeccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProyeccion.Size = new System.Drawing.Size(350, 475);
            this.txtProyeccion.TabIndex = 7;
            //
            // tabTransformaciones
            //
            this.tabTransformaciones.Controls.Add(this.lblTx);
            this.tabTransformaciones.Controls.Add(this.txtTx);
            this.tabTransformaciones.Controls.Add(this.lblTy);
            this.tabTransformaciones.Controls.Add(this.txtTy);
            this.tabTransformaciones.Controls.Add(this.lblAngulo);
            this.tabTransformaciones.Controls.Add(this.txtAngulo);
            this.tabTransformaciones.Controls.Add(this.lblSx);
            this.tabTransformaciones.Controls.Add(this.txtSx);
            this.tabTransformaciones.Controls.Add(this.lblSy);
            this.tabTransformaciones.Controls.Add(this.txtSy);
            this.tabTransformaciones.Controls.Add(this.chkUniforme);
            this.tabTransformaciones.Controls.Add(this.chkCentro);
            this.tabTransformaciones.Controls.Add(this.btnTrasladar);
            this.tabTransformaciones.Controls.Add(this.btnRotar);
            this.tabTransformaciones.Controls.Add(this.btnEscalar);
            this.tabTransformaciones.Controls.Add(this.btnRestaurar);
            this.tabTransformaciones.Controls.Add(this.txtTransformaciones);
            this.tabTransformaciones.Location = new System.Drawing.Point(4, 24);
            this.tabTransformaciones.Name = "tabTransformaciones";
            this.tabTransformaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransformaciones.Size = new System.Drawing.Size(370, 648);
            this.tabTransformaciones.TabIndex = 4;
            this.tabTransformaciones.Text = "Transformar";
            this.tabTransformaciones.UseVisualStyleBackColor = true;
            //
            // lblTx
            //
            this.lblTx.AutoSize = true;
            this.lblTx.Location = new System.Drawing.Point(10, 18);
            this.lblTx.Name = "lblTx";
            this.lblTx.Size = new System.Drawing.Size(78, 15);
            this.lblTx.Text = "Traslación X:";
            //
            // txtTx
            //
            this.txtTx.Location = new System.Drawing.Point(130, 15);
            this.txtTx.Name = "txtTx";
            this.txtTx.Size = new System.Drawing.Size(100, 23);
            this.txtTx.TabIndex = 0;
            this.txtTx.Text = "2";
            //
            // lblTy
            //
            this.lblTy.AutoSize = true;
            this.lblTy.Location = new System.Drawing.Point(10, 50);
            this.lblTy.Name = "lblTy";
            this.lblTy.Size = new System.Drawing.Size(77, 15);
            this.lblTy.Text = "Traslación Y:";
            //
            // txtTy
            //
            this.txtTy.Location = new System.Drawing.Point(130, 47);
            this.txtTy.Name = "txtTy";
            this.txtTy.Size = new System.Drawing.Size(100, 23);
            this.txtTy.TabIndex = 1;
            this.txtTy.Text = "1";
            //
            // lblAngulo
            //
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Location = new System.Drawing.Point(10, 82);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(67, 15);
            this.lblAngulo.Text = "Ángulo (°):";
            //
            // txtAngulo
            //
            this.txtAngulo.Location = new System.Drawing.Point(130, 79);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(100, 23);
            this.txtAngulo.TabIndex = 2;
            this.txtAngulo.Text = "30";
            //
            // lblSx
            //
            this.lblSx.AutoSize = true;
            this.lblSx.Location = new System.Drawing.Point(10, 114);
            this.lblSx.Name = "lblSx";
            this.lblSx.Size = new System.Drawing.Size(55, 15);
            this.lblSx.Text = "Escala X:";
            //
            // txtSx
            //
            this.txtSx.Location = new System.Drawing.Point(130, 111);
            this.txtSx.Name = "txtSx";
            this.txtSx.Size = new System.Drawing.Size(100, 23);
            this.txtSx.TabIndex = 3;
            this.txtSx.Text = "1.5";
            //
            // lblSy
            //
            this.lblSy.AutoSize = true;
            this.lblSy.Location = new System.Drawing.Point(10, 146);
            this.lblSy.Name = "lblSy";
            this.lblSy.Size = new System.Drawing.Size(54, 15);
            this.lblSy.Text = "Escala Y:";
            //
            // txtSy
            //
            this.txtSy.Location = new System.Drawing.Point(130, 143);
            this.txtSy.Name = "txtSy";
            this.txtSy.Size = new System.Drawing.Size(100, 23);
            this.txtSy.TabIndex = 4;
            this.txtSy.Text = "0.75";
            //
            // chkUniforme
            //
            this.chkUniforme.AutoSize = true;
            this.chkUniforme.Location = new System.Drawing.Point(10, 178);
            this.chkUniforme.Name = "chkUniforme";
            this.chkUniforme.Size = new System.Drawing.Size(174, 19);
            this.chkUniforme.TabIndex = 5;
            this.chkUniforme.Text = "Escala uniforme (sy = sx)";
            this.chkUniforme.UseVisualStyleBackColor = true;
            this.chkUniforme.CheckedChanged += new System.EventHandler(this.chkUniforme_CheckedChanged);
            //
            // chkCentro
            //
            this.chkCentro.AutoSize = true;
            this.chkCentro.Checked = true;
            this.chkCentro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCentro.Location = new System.Drawing.Point(10, 203);
            this.chkCentro.Name = "chkCentro";
            this.chkCentro.Size = new System.Drawing.Size(283, 19);
            this.chkCentro.TabIndex = 6;
            this.chkCentro.Text = "Rotar y escalar respecto al centro de la figura";
            this.chkCentro.UseVisualStyleBackColor = true;
            //
            // btnTrasladar
            //
            this.btnTrasladar.Location = new System.Drawing.Point(10, 236);
            this.btnTrasladar.Name = "btnTrasladar";
            this.btnTrasladar.Size = new System.Drawing.Size(80, 30);
            this.btnTrasladar.TabIndex = 7;
            this.btnTrasladar.Text = "Trasladar";
            this.btnTrasladar.UseVisualStyleBackColor = true;
            this.btnTrasladar.Click += new System.EventHandler(this.btnTrasladar_Click);
            //
            // btnRotar
            //
            this.btnRotar.Location = new System.Drawing.Point(95, 236);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(80, 30);
            this.btnRotar.TabIndex = 8;
            this.btnRotar.Text = "Rotar";
            this.btnRotar.UseVisualStyleBackColor = true;
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            //
            // btnEscalar
            //
            this.btnEscalar.Location = new System.Drawing.Point(180, 236);
            this.btnEscalar.Name = "btnEscalar";
            this.btnEscalar.Size = new System.Drawing.Size(80, 30);
            this.btnEscalar.TabIndex = 9;
            this.btnEscalar.Text = "Escalar";
            this.btnEscalar.UseVisualStyleBackColor = true;
            this.btnEscalar.Click += new System.EventHandler(this.btnEscalar_Click);
            //
            // btnRestaurar
            //
            this.btnRestaurar.Location = new System.Drawing.Point(265, 236);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(91, 30);
            this.btnRestaurar.TabIndex = 10;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            //
            // txtTransformaciones
            //
            this.txtTransformaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransformaciones.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtTransformaciones.Location = new System.Drawing.Point(10, 280);
            this.txtTransformaciones.Multiline = true;
            this.txtTransformaciones.Name = "txtTransformaciones";
            this.txtTransformaciones.ReadOnly = true;
            this.txtTransformaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTransformaciones.Size = new System.Drawing.Size(350, 355);
            this.txtTransformaciones.TabIndex = 11;
            //
            // tabPruebas
            //
            this.tabPruebas.Controls.Add(this.btnPruebas);
            this.tabPruebas.Controls.Add(this.lblResumen);
            this.tabPruebas.Controls.Add(this.dgvPruebas);
            this.tabPruebas.Location = new System.Drawing.Point(4, 24);
            this.tabPruebas.Name = "tabPruebas";
            this.tabPruebas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPruebas.Size = new System.Drawing.Size(370, 648);
            this.tabPruebas.TabIndex = 5;
            this.tabPruebas.Text = "Pruebas";
            this.tabPruebas.UseVisualStyleBackColor = true;
            //
            // btnPruebas
            //
            this.btnPruebas.Location = new System.Drawing.Point(10, 12);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(150, 30);
            this.btnPruebas.TabIndex = 0;
            this.btnPruebas.Text = "Ejecutar pruebas";
            this.btnPruebas.UseVisualStyleBackColor = true;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            //
            // lblResumen
            //
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(170, 20);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(0, 15);
            //
            // dgvPruebas
            //
            this.dgvPruebas.AllowUserToAddRows = false;
            this.dgvPruebas.AllowUserToDeleteRows = false;
            this.dgvPruebas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPruebas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPruebas.Location = new System.Drawing.Point(10, 52);
            this.dgvPruebas.Name = "dgvPruebas";
            this.dgvPruebas.ReadOnly = true;
            this.dgvPruebas.RowHeadersVisible = false;
            this.dgvPruebas.Size = new System.Drawing.Size(350, 583);
            this.dgvPruebas.TabIndex = 1;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 700);
            this.Controls.Add(this.grpFigura);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.lblCoordenadas);
            this.Controls.Add(this.lblEscala);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1516, 739);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeoLab 2D - Diseñador y analizador geométrico";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFigura.ResumeLayout(false);
            this.grpFigura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCentroX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCentroY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabResultados.ResumeLayout(false);
            this.tabResultados.PerformLayout();
            this.tabVectores.ResumeLayout(false);
            this.tabVectores.PerformLayout();
            this.tabGeometria.ResumeLayout(false);
            this.tabGeometria.PerformLayout();
            this.tabProyeccion.ResumeLayout(false);
            this.tabProyeccion.PerformLayout();
            this.tabTransformaciones.ResumeLayout(false);
            this.tabTransformaciones.PerformLayout();
            this.tabPruebas.ResumeLayout(false);
            this.tabPruebas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPruebas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFigura;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.ComboBox cboFigura;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.NumericUpDown nudLado;
        private System.Windows.Forms.Label lblCentroX;
        private System.Windows.Forms.NumericUpDown nudCentroX;
        private System.Windows.Forms.Label lblCentroY;
        private System.Windows.Forms.NumericUpDown nudCentroY;
        private System.Windows.Forms.Label lblRotacion;
        private System.Windows.Forms.NumericUpDown nudRotacion;
        private System.Windows.Forms.Label lblSeparacion;
        private System.Windows.Forms.NumericUpDown nudSeparacion;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.NumericUpDown nudK;
        private System.Windows.Forms.Label lblColores;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnContorno;
        private System.Windows.Forms.CheckBox chkCuadricula;
        private System.Windows.Forms.CheckBox chkEjes;
        private System.Windows.Forms.CheckBox chkOriginal;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblCoordenadas;
        private System.Windows.Forms.Label lblEscala;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabResultados;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.TabPage tabVectores;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtAx;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.TextBox txtBy;
        private System.Windows.Forms.Button btnMagA;
        private System.Windows.Forms.Button btnMagB;
        private System.Windows.Forms.Button btnDirA;
        private System.Windows.Forms.Button btnDirB;
        private System.Windows.Forms.Button btnProductoPunto;
        private System.Windows.Forms.Button btnDeterminante;
        private System.Windows.Forms.Button btnTodoVectores;
        private System.Windows.Forms.TextBox txtVectores;
        private System.Windows.Forms.TabPage tabGeometria;
        private System.Windows.Forms.Label lblGA;
        private System.Windows.Forms.TextBox txtGAx;
        private System.Windows.Forms.TextBox txtGAy;
        private System.Windows.Forms.Label lblGB;
        private System.Windows.Forms.TextBox txtGBx;
        private System.Windows.Forms.TextBox txtGBy;
        private System.Windows.Forms.Label lblGC;
        private System.Windows.Forms.TextBox txtGCx;
        private System.Windows.Forms.TextBox txtGCy;
        private System.Windows.Forms.Label lblGP;
        private System.Windows.Forms.TextBox txtGPx;
        private System.Windows.Forms.TextBox txtGPy;
        private System.Windows.Forms.Label lblPoligono;
        private System.Windows.Forms.ComboBox cboPoligono;
        private System.Windows.Forms.Label lblTolerancia;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.Button btnDistancia;
        private System.Windows.Forms.Button btnOrientacion;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnPertenencia;
        private System.Windows.Forms.TextBox txtGeometria;
        private System.Windows.Forms.TabPage tabProyeccion;
        private System.Windows.Forms.Label lblPA;
        private System.Windows.Forms.TextBox txtPAx;
        private System.Windows.Forms.TextBox txtPAy;
        private System.Windows.Forms.Label lblPB;
        private System.Windows.Forms.TextBox txtPBx;
        private System.Windows.Forms.TextBox txtPBy;
        private System.Windows.Forms.Label lblPP;
        private System.Windows.Forms.TextBox txtPPx;
        private System.Windows.Forms.TextBox txtPPy;
        private System.Windows.Forms.Button btnProyectar;
        private System.Windows.Forms.TextBox txtProyeccion;
        private System.Windows.Forms.TabPage tabTransformaciones;
        private System.Windows.Forms.Label lblTx;
        private System.Windows.Forms.TextBox txtTx;
        private System.Windows.Forms.Label lblTy;
        private System.Windows.Forms.TextBox txtTy;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Label lblSx;
        private System.Windows.Forms.TextBox txtSx;
        private System.Windows.Forms.Label lblSy;
        private System.Windows.Forms.TextBox txtSy;
        private System.Windows.Forms.CheckBox chkUniforme;
        private System.Windows.Forms.CheckBox chkCentro;
        private System.Windows.Forms.Button btnTrasladar;
        private System.Windows.Forms.Button btnRotar;
        private System.Windows.Forms.Button btnEscalar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.TextBox txtTransformaciones;
        private System.Windows.Forms.TabPage tabPruebas;
        private System.Windows.Forms.Button btnPruebas;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.DataGridView dgvPruebas;
    }
}

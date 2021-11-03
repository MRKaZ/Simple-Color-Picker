namespace Simple_Color_Picker_WinForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.colorPickerPreview = new ColorPicker.ColorPickerController();
            this.cmbFormats = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.imgListPreview = new System.Windows.Forms.ImageList(this.components);
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCopy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroup4 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.listColors = new System.Windows.Forms.ListView();
            this.btnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnAbout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox4 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.grpOptions = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox6 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pnlColorPickerController = new System.Windows.Forms.Panel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.chkTopmost = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonGroupBox5 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cmbZoom = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnUsage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4.Panel)).BeginInit();
            this.kryptonGroup4.Panel.SuspendLayout();
            this.kryptonGroup4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).BeginInit();
            this.kryptonGroupBox4.Panel.SuspendLayout();
            this.kryptonGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpOptions.Panel)).BeginInit();
            this.grpOptions.Panel.SuspendLayout();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox6.Panel)).BeginInit();
            this.kryptonGroupBox6.Panel.SuspendLayout();
            this.kryptonGroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox5.Panel)).BeginInit();
            this.kryptonGroupBox5.Panel.SuspendLayout();
            this.kryptonGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this.kryptonPalette1.ButtonSpecs.FormMax.AllowInheritExtraText = false;
            this.kryptonPalette1.ButtonSpecs.FormMax.AllowInheritImage = false;
            this.kryptonPalette1.ButtonSpecs.FormMax.AllowInheritText = false;
            this.kryptonPalette1.ButtonSpecs.FormMax.AllowInheritToolTipTitle = false;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::Simple_Color_Picker_WinForm.Properties.Resources.mc_green;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::Simple_Color_Picker_WinForm.Properties.Resources.mc_green;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::Simple_Color_Picker_WinForm.Properties.Resources.mc_green;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            // 
            // colorPickerPreview
            // 
            this.colorPickerPreview.ColorLine = System.Drawing.Color.Red;
            this.colorPickerPreview.Image = null;
            this.colorPickerPreview.Location = new System.Drawing.Point(7, 0);
            this.colorPickerPreview.Name = "colorPickerPreview";
            this.colorPickerPreview.ShowLine = true;
            this.colorPickerPreview.Size = new System.Drawing.Size(55, 48);
            this.colorPickerPreview.TabIndex = 1;
            // 
            // cmbFormats
            // 
            this.cmbFormats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormats.DropDownWidth = 149;
            this.cmbFormats.Items.AddRange(new object[] {
            "HTML",
            "RGB",
            "RGB (.NET)",
            "HEX",
            "PHOTOSHOP"});
            this.cmbFormats.Location = new System.Drawing.Point(7, 8);
            this.cmbFormats.Name = "cmbFormats";
            this.cmbFormats.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbFormats.Size = new System.Drawing.Size(106, 23);
            this.cmbFormats.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.cmbFormats.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbFormats.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbFormats.StateCommon.ComboBox.Border.Rounding = 3;
            this.cmbFormats.TabIndex = 4;
            this.cmbFormats.TabStop = false;
            this.cmbFormats.UseMnemonic = false;
            this.cmbFormats.SelectedIndexChanged += new System.EventHandler(this.cmbFormats_SelectedIndexChanged);
            // 
            // imgListPreview
            // 
            this.imgListPreview.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListPreview.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListPreview.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnClear.Size = new System.Drawing.Size(126, 26);
            this.btnClear.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnClear.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnClear.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.btnClear.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btnClear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateCommon.Border.Rounding = 3;
            this.btnClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnClear.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnClear.StatePressed.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnClear.StatePressed.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnClear.TabIndex = 5;
            this.btnClear.TabStop = false;
            this.btnClear.Values.Text = "Clear List";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(151, 6);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCopy.Size = new System.Drawing.Size(50, 26);
            this.btnCopy.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCopy.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCopy.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.btnCopy.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btnCopy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCopy.StateCommon.Border.Rounding = 3;
            this.btnCopy.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnCopy.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnCopy.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnCopy.StatePressed.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnCopy.StatePressed.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnCopy.TabIndex = 5;
            this.btnCopy.TabStop = false;
            this.btnCopy.Values.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // kryptonGroup4
            // 
            this.kryptonGroup4.Location = new System.Drawing.Point(7, 6);
            this.kryptonGroup4.Name = "kryptonGroup4";
            // 
            // kryptonGroup4.Panel
            // 
            this.kryptonGroup4.Panel.Controls.Add(this.txtColor);
            this.kryptonGroup4.Size = new System.Drawing.Size(136, 26);
            this.kryptonGroup4.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup4.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroup4.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonGroup4.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonGroup4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup4.StateCommon.Border.Rounding = 3;
            this.kryptonGroup4.TabIndex = 6;
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.BackColor = System.Drawing.Color.White;
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtColor.Location = new System.Drawing.Point(3, 3);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(125, 21);
            this.txtColor.TabIndex = 0;
            this.txtColor.TabStop = false;
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listColors
            // 
            this.listColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listColors.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.listColors.GridLines = true;
            this.listColors.HideSelection = false;
            this.listColors.Location = new System.Drawing.Point(0, 0);
            this.listColors.MultiSelect = false;
            this.listColors.Name = "listColors";
            this.listColors.Size = new System.Drawing.Size(204, 105);
            this.listColors.SmallImageList = this.imgListPreview;
            this.listColors.TabIndex = 0;
            this.listColors.UseCompatibleStateImageBehavior = false;
            this.listColors.View = System.Windows.Forms.View.SmallIcon;
            this.listColors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listColors_MouseClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(9, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnRemove.Size = new System.Drawing.Size(126, 26);
            this.btnRemove.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnRemove.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnRemove.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.btnRemove.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btnRemove.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemove.StateCommon.Border.Rounding = 3;
            this.btnRemove.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRemove.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnRemove.StatePressed.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.StatePressed.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.TabIndex = 5;
            this.btnRemove.TabStop = false;
            this.btnRemove.Values.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(140, 134);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.cmbFormats);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(125, 64);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox2.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.TabIndex = 2;
            this.kryptonGroupBox2.Values.Heading = "&Formats";
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Location = new System.Drawing.Point(273, 134);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.btnUsage);
            this.kryptonGroupBox3.Panel.Controls.Add(this.btnAbout);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonGroup4);
            this.kryptonGroupBox3.Panel.Controls.Add(this.btnCopy);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(300, 64);
            this.kryptonGroupBox3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox3.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox3.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox3.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox3.TabIndex = 2;
            this.kryptonGroupBox3.Values.Heading = "&Color";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(207, 6);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAbout.Size = new System.Drawing.Size(50, 26);
            this.btnAbout.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnAbout.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnAbout.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.btnAbout.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.btnAbout.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btnAbout.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAbout.StateCommon.Border.Rounding = 3;
            this.btnAbout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnAbout.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnAbout.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnAbout.StatePressed.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnAbout.StatePressed.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnAbout.TabIndex = 5;
            this.btnAbout.TabStop = false;
            this.btnAbout.Values.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(9, 69);
            this.btnExport.Name = "btnExport";
            this.btnExport.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnExport.Size = new System.Drawing.Size(126, 26);
            this.btnExport.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnExport.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnExport.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.btnExport.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btnExport.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExport.StateCommon.Border.Rounding = 3;
            this.btnExport.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnExport.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnExport.StatePressed.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnExport.StatePressed.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnExport.TabIndex = 5;
            this.btnExport.TabStop = false;
            this.btnExport.Values.Text = "Export List";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // kryptonGroupBox4
            // 
            this.kryptonGroupBox4.Location = new System.Drawing.Point(82, 3);
            this.kryptonGroupBox4.Name = "kryptonGroupBox4";
            // 
            // kryptonGroupBox4.Panel
            // 
            this.kryptonGroupBox4.Panel.Controls.Add(this.listColors);
            this.kryptonGroupBox4.Size = new System.Drawing.Size(208, 129);
            this.kryptonGroupBox4.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox4.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox4.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox4.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox4.TabIndex = 2;
            this.kryptonGroupBox4.Values.Heading = "&Colors List";
            // 
            // grpOptions
            // 
            this.grpOptions.Location = new System.Drawing.Point(298, 3);
            this.grpOptions.Name = "grpOptions";
            // 
            // grpOptions.Panel
            // 
            this.grpOptions.Panel.Controls.Add(this.btnExport);
            this.grpOptions.Panel.Controls.Add(this.btnRemove);
            this.grpOptions.Panel.Controls.Add(this.btnClear);
            this.grpOptions.Size = new System.Drawing.Size(147, 129);
            this.grpOptions.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grpOptions.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.grpOptions.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.grpOptions.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.grpOptions.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpOptions.TabIndex = 2;
            this.grpOptions.Values.Heading = "&Options";
            // 
            // kryptonGroupBox6
            // 
            this.kryptonGroupBox6.Location = new System.Drawing.Point(4, 3);
            this.kryptonGroupBox6.Name = "kryptonGroupBox6";
            // 
            // kryptonGroupBox6.Panel
            // 
            this.kryptonGroupBox6.Panel.Controls.Add(this.pnlColorPickerController);
            this.kryptonGroupBox6.Panel.Controls.Add(this.colorPickerPreview);
            this.kryptonGroupBox6.Size = new System.Drawing.Size(72, 129);
            this.kryptonGroupBox6.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox6.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox6.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox6.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox6.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox6.TabIndex = 2;
            this.kryptonGroupBox6.Values.Heading = "&Preview";
            // 
            // pnlColorPickerController
            // 
            this.pnlColorPickerController.Location = new System.Drawing.Point(7, 52);
            this.pnlColorPickerController.Name = "pnlColorPickerController";
            this.pnlColorPickerController.Size = new System.Drawing.Size(55, 48);
            this.pnlColorPickerController.TabIndex = 3;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(451, 12);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.chkTopmost);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(122, 120);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.TabIndex = 2;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // chkTopmost
            // 
            this.chkTopmost.Location = new System.Drawing.Point(16, 16);
            this.chkTopmost.Name = "chkTopmost";
            this.chkTopmost.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.chkTopmost.Size = new System.Drawing.Size(85, 85);
            this.chkTopmost.StateCheckedNormal.Back.Color1 = System.Drawing.Color.White;
            this.chkTopmost.StateCheckedNormal.Back.Color2 = System.Drawing.Color.White;
            this.chkTopmost.StateCheckedNormal.Back.Image = global::Simple_Color_Picker_WinForm.Properties.Resources.CP_ICON;
            this.chkTopmost.StateCheckedPressed.Back.Color1 = System.Drawing.Color.White;
            this.chkTopmost.StateCheckedPressed.Back.Color2 = System.Drawing.Color.White;
            this.chkTopmost.StateCheckedPressed.Back.Image = global::Simple_Color_Picker_WinForm.Properties.Resources.CP_ICON;
            this.chkTopmost.StateCheckedTracking.Back.Color1 = System.Drawing.Color.White;
            this.chkTopmost.StateCheckedTracking.Back.Color2 = System.Drawing.Color.White;
            this.chkTopmost.StateCheckedTracking.Back.Image = global::Simple_Color_Picker_WinForm.Properties.Resources.CP_ICON;
            this.chkTopmost.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.chkTopmost.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.chkTopmost.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.chkTopmost.StateCommon.Back.Image = global::Simple_Color_Picker_WinForm.Properties.Resources.CP_ICON_BW;
            this.chkTopmost.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.chkTopmost.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.chkTopmost.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.chkTopmost.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.chkTopmost.StateCommon.Border.Rounding = 3;
            this.chkTopmost.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.chkTopmost.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.chkTopmost.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.chkTopmost.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.chkTopmost.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.chkTopmost.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.chkTopmost.StatePressed.Back.Image = global::Simple_Color_Picker_WinForm.Properties.Resources.CP_ICON;
            this.chkTopmost.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.chkTopmost.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.chkTopmost.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.chkTopmost.TabIndex = 9;
            this.chkTopmost.Values.Text = "";
            this.chkTopmost.CheckedChanged += new System.EventHandler(this.chkTopmost_CheckedChanged);
            // 
            // kryptonGroupBox5
            // 
            this.kryptonGroupBox5.Location = new System.Drawing.Point(4, 134);
            this.kryptonGroupBox5.Name = "kryptonGroupBox5";
            // 
            // kryptonGroupBox5.Panel
            // 
            this.kryptonGroupBox5.Panel.Controls.Add(this.cmbZoom);
            this.kryptonGroupBox5.Size = new System.Drawing.Size(128, 64);
            this.kryptonGroupBox5.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox5.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox5.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox5.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonGroupBox5.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox5.TabIndex = 2;
            this.kryptonGroupBox5.Values.Heading = "&Zoom";
            // 
            // cmbZoom
            // 
            this.cmbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZoom.DropDownWidth = 149;
            this.cmbZoom.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%"});
            this.cmbZoom.Location = new System.Drawing.Point(7, 8);
            this.cmbZoom.Name = "cmbZoom";
            this.cmbZoom.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbZoom.Size = new System.Drawing.Size(109, 23);
            this.cmbZoom.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.cmbZoom.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbZoom.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbZoom.StateCommon.ComboBox.Border.Rounding = 3;
            this.cmbZoom.TabIndex = 4;
            this.cmbZoom.TabStop = false;
            this.cmbZoom.UseMnemonic = false;
            this.cmbZoom.SelectedIndexChanged += new System.EventHandler(this.cmbZoom_SelectedIndexChanged);
            // 
            // btnUsage
            // 
            this.btnUsage.Location = new System.Drawing.Point(264, 6);
            this.btnUsage.Name = "btnUsage";
            this.btnUsage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnUsage.Size = new System.Drawing.Size(24, 26);
            this.btnUsage.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnUsage.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnUsage.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.btnUsage.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.btnUsage.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btnUsage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUsage.StateCommon.Border.Rounding = 3;
            this.btnUsage.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnUsage.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnUsage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnUsage.StatePressed.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnUsage.StatePressed.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnUsage.TabIndex = 5;
            this.btnUsage.TabStop = false;
            this.btnUsage.Values.Text = "&?";
            this.btnUsage.Click += new System.EventHandler(this.btnUsage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 210);
            this.Controls.Add(this.kryptonGroupBox3);
            this.Controls.Add(this.kryptonGroupBox4);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.kryptonGroupBox6);
            this.Controls.Add(this.kryptonGroupBox5);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.kryptonGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Color Picker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4.Panel)).EndInit();
            this.kryptonGroup4.Panel.ResumeLayout(false);
            this.kryptonGroup4.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4)).EndInit();
            this.kryptonGroup4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).EndInit();
            this.kryptonGroupBox4.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).EndInit();
            this.kryptonGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpOptions.Panel)).EndInit();
            this.grpOptions.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpOptions)).EndInit();
            this.grpOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox6.Panel)).EndInit();
            this.kryptonGroupBox6.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox6)).EndInit();
            this.kryptonGroupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox5.Panel)).EndInit();
            this.kryptonGroupBox5.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox5)).EndInit();
            this.kryptonGroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ColorPicker.ColorPickerController colorPickerPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbFormats;
        private System.Windows.Forms.ImageList imgListPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemove;
        private System.Windows.Forms.ListView listColors;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup4;
        private System.Windows.Forms.TextBox txtColor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCopy;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExport;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpOptions;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox6;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton chkTopmost;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbZoom;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAbout;
        private System.Windows.Forms.Panel pnlColorPickerController;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUsage;
    }
}


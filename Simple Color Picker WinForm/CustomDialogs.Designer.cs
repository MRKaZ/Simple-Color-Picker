namespace Simple_Color_Picker_WinForm
{
    partial class CustomDialogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDialogs));
            this.dialogPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnAction = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogPalette
            // 
            this.dialogPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.dialogPalette.ButtonSpecs.FormClose.AllowInheritExtraText = false;
            this.dialogPalette.ButtonSpecs.FormClose.AllowInheritImage = false;
            this.dialogPalette.ButtonSpecs.FormClose.AllowInheritText = false;
            this.dialogPalette.ButtonSpecs.FormClose.AllowInheritToolTipTitle = false;
            this.dialogPalette.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("dialogPalette.ButtonSpecs.FormClose.Image")));
            this.dialogPalette.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("dialogPalette.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this.dialogPalette.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("dialogPalette.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this.dialogPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.dialogPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.dialogPalette.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dialogPalette.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.dialogPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.dialogPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.dialogPalette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dialogPalette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.dialogPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.dialogPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.dialogPalette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dialogPalette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.dialogPalette.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dialogPalette.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dialogPalette.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dialogPalette.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.dialogPalette.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dialogPalette.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dialogPalette.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dialogPalette.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.dialogPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.dialogPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.dialogPalette.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.dialogPalette.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.dialogPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dialogPalette.FormStyles.FormMain.StateCommon.Border.Width = 1;
            this.dialogPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.dialogPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(152, 107);
            this.btnAction.Name = "btnAction";
            this.btnAction.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAction.Size = new System.Drawing.Size(93, 26);
            this.btnAction.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnAction.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnAction.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.btnAction.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btnAction.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAction.StateCommon.Border.Rounding = 3;
            this.btnAction.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnAction.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnAction.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnAction.StatePressed.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnAction.StatePressed.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnAction.TabIndex = 6;
            this.btnAction.TabStop = false;
            this.btnAction.Values.Text = "Title";
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(93, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(60, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(1, 77);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.ReadOnly = true;
            this.lblMessage.ShortcutsEnabled = false;
            this.lblMessage.Size = new System.Drawing.Size(244, 15);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.TabStop = false;
            this.lblMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomDialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(246, 135);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnAction);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomDialogs";
            this.Palette = this.dialogPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "&Title";
            this.Load += new System.EventHandler(this.CutomDialogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette dialogPalette;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAction;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox lblMessage;
    }
}
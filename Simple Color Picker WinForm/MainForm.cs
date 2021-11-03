using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Simple_Color_Picker_WinForm
{
    /// <summary>
    ///+--------------------------------------------+
    ///|             ZOOM MATH FUNCTION's           |
    ///+--------------------------------------------+
    ///|  500%  |  400%  |  300%  |  200%  |  100%  |
    ///+--------+--------+--------+--------+--------+
    ///|   4    |   8    |   12   |   16   |   20   |
    ///+--------+--------+--------+--------+--------+
    ///|  4/2   |  8/2   |  12/2  |  16/2  |  20/2  |
    ///+--------+--------+--------+--------+--------+
    ///|  4/2   |  8/2   |  12/2  |  16/2  |  20/2  |
    ///+--------+--------+--------+--------+--------+
    /// </summary>
   
    public partial class Form1 : KryptonForm
    {
        #region DLL CALLS 
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion

        #region GLOBAL VALUES
        private Timer TIMER_PICK = new Timer();

        private string allListColors { get; set; }
        private Color COLOR_PIXELS { get; set; }
        #endregion

        public Form1()
        {
            InitializeComponent();

            // Timer for color controller stuff
            TIMER_PICK.Interval = 1;
            TIMER_PICK.Enabled = true;
            TIMER_PICK.Tick += TIMER_Tick;
            TIMER_PICK.Start();

            // Register to Global Hot Key with keys
            // Control (Ctrl) + X for Pick color
            RegisterHotKey(Handle, 0, (int)System.Windows.Input.ModifierKeys.Control, Keys.X.GetHashCode());
            // Control (Ctrl) + C for Copy picked color
            RegisterHotKey(Handle, 1, (int)System.Windows.Input.ModifierKeys.Control, Keys.C.GetHashCode());
            // Control (Ctrl) + S for Export color list
            RegisterHotKey(Handle, 2, (int)System.Windows.Input.ModifierKeys.Control, Keys.S.GetHashCode());
            // Control (Ctrl) + D for Remove the items one by one from the bottom of the list
            RegisterHotKey(Handle, 3, (int)System.Windows.Input.ModifierKeys.Control, Keys.D.GetHashCode());
            // Control (Ctrl) + Shift + D for Remove whole items from the list
            RegisterHotKey(Handle, 4, (int)System.Windows.Input.ModifierKeys.Control | (int)System.Windows.Input.ModifierKeys.Shift, Keys.D.GetHashCode());
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            grpOptions.Enabled = false;

            // Loading settings
            cmbFormats.SelectedIndex = Properties.Settings.Default.PARSE_TYPE;
            cmbZoom.SelectedIndex = Properties.Settings.Default.ZOOM;
            chkTopmost.Checked = Properties.Settings.Default.IS_TOP;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Unregister hotkey with keys id 0 before closing the form.
            UnregisterHotKey(this.Handle, 0);
            UnregisterHotKey(this.Handle, 1);
            UnregisterHotKey(this.Handle, 2);

            // Saving settings
            if (chkTopmost.Checked)
            {
                Properties.Settings.Default.IS_TOP = true;
            }
            else
            {
                Properties.Settings.Default.IS_TOP = false;
            }

            Properties.Settings.Default.PARSE_TYPE = cmbFormats.SelectedIndex;
            Properties.Settings.Default.ZOOM = cmbZoom.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Formats index changes
        /// </summary>
        private void cmbFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFormats.SelectedIndex)
            {
                case 0:
                    {
                        foreach (ListViewItem item in listColors.Items)
                        {
                            item.Text = ColorTranslator.ToHtml((Color)item.Tag);
                            txtColor.Text = ColorTranslator.ToHtml((Color)item.Tag);
                        }
                        break;
                    }
                case 1:
                    {
                        foreach (ListViewItem item in listColors.Items)
                        {
                            Color MyColor = (Color)item.Tag;
                            item.Text = MyColor.R + ", " + MyColor.G + ", " + MyColor.B;
                            txtColor.Text = MyColor.R + ", " + MyColor.G + ", " + MyColor.B;
                        }
                        break;
                    }
                case 2:
                    {
                        foreach (ListViewItem item in listColors.Items)
                        {
                            Color MyColor = (Color)item.Tag;
                            item.Text = MyColor.R + "; " + MyColor.G + "; " + MyColor.B;
                            txtColor.Text = MyColor.R + "; " + MyColor.G + "; " + MyColor.B;
                        }
                        break;
                    }
                case 3:
                    {
                        foreach (ListViewItem item in listColors.Items)
                        {
                            Color MyColor = (Color)item.Tag;
                            item.Text = "0x" + ColorTranslator.ToHtml(MyColor).Replace("#", "");
                            txtColor.Text = "0x" + ColorTranslator.ToHtml(MyColor).Replace("#", "");
                        }
                        break;
                    }
                case 4:
                    {
                        foreach (ListViewItem item in listColors.Items)
                        {
                            Color MyColor = (Color)item.Tag;
                            item.Text = ColorTranslator.ToHtml(MyColor).Replace("#", "");
                            txtColor.Text = ColorTranslator.ToHtml(MyColor).Replace("#", "");
                        }
                        break;
                    }
            }
            Properties.Settings.Default.PARSE_TYPE = cmbFormats.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all item in the list view
            CLEAR_ALL_LIST();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            REMOVE_LIST_ITEMS();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            COPY_PICKED_COLOR();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // About forum
            AboutForum aboutForum = new AboutForum();
            aboutForum.SetTomMost(GET_TOPMOST());
            aboutForum.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            EXPORT_COLOR_LIST();
        }

  
        private void chkTopmost_CheckedChanged(object sender, EventArgs e)
        {
            // TopMost checkup
            if (chkTopmost.Checked)
                TopMost = true;
            else
                TopMost = false;
        }

        private void cmbZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PARSE_TYPE = cmbZoom.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void btnUsage_Click(object sender, EventArgs e)
        {
            // About forum
            UsageForum usageForum = new UsageForum();
            usageForum.SetTomMost(GET_TOPMOST());
            usageForum.Show();
        }

        private void listColors_MouseClick(object sender, MouseEventArgs e)
        {
            if (listColors.Items.Count != 0)
            {
                Clipboard.SetText(listColors.SelectedItems[0].Text);
            }
        }

        #region COLOR CONTROLLER TIMER TICK
        private void TIMER_Tick(object sender, EventArgs e)
        {
            // Init Bitmap func to make list view draw item size 50x50
            Bitmap BITMAP_SQUARE = new Bitmap(PARSE_ZOOM_VALUE(cmbZoom.SelectedIndex), PARSE_ZOOM_VALUE(cmbZoom.SelectedIndex));
            // Init Graphics to make a square
            Graphics GRAPHICS_SQUARE = Graphics.FromImage(BITMAP_SQUARE);
            GRAPHICS_SQUARE.CompositingQuality = CompositingQuality.HighQuality;
            GRAPHICS_SQUARE.InterpolationMode = InterpolationMode.NearestNeighbor;
            GRAPHICS_SQUARE.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            GRAPHICS_SQUARE.SmoothingMode = SmoothingMode.None;
            // Init Point to get mouse X and Y positions
            Point MOUSE_PONIER_POS = new Point(MousePosition.X - PARSE_ZOOM_VALUE(cmbZoom.SelectedIndex) / 2, MousePosition.Y - PARSE_ZOOM_VALUE(cmbZoom.SelectedIndex) / 2);
            // Setup the mouse poniter X,Y position to made square !! DONT CHANGE THIS SIZE 55x55 !!
            GRAPHICS_SQUARE.CopyFromScreen(MOUSE_PONIER_POS, new Point(0, 0), new Size(55, 55));
            // Color Mouse pointer position color
            COLOR_PIXELS = BITMAP_SQUARE.GetPixel(PARSE_ZOOM_VALUE(cmbZoom.SelectedIndex) / 2, PARSE_ZOOM_VALUE(cmbZoom.SelectedIndex) / 2);
            // Color Controller 1 for control colors
            pnlColorPickerController.BackColor = COLOR_PIXELS;
            // Color Controller 2 for preview which color is that contain
            colorPickerPreview.Image = BITMAP_SQUARE;
        }
        #endregion

        #region REGISTERED KEY PROCESS
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // MOD_ALT = 0x0001
            // MOD_CONTROL = 0x0002
            // MOD_SHIFT = 0x0004
            // MOD_WIN = 0x0008
            //https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-hotkey

            // WM_HOTKEY
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                if (id == 0)
                {
                    if (listColors.Items.Count == 0)
                    {
                        // Pick colors
                        PICK_COLORS(COLOR_PIXELS);
                    }
                    else
                    {
                        // Checks if user already picked thats color
                        if (!COLOR_PIXELS.Equals(listColors.Items[listColors.Items.Count - 1].Tag))
                        {
                            // Pick colors
                            PICK_COLORS(COLOR_PIXELS);
                        }
                    }
                }
                else if (id == 1)
                {
                    // copy object
                    COPY_PICKED_COLOR();
                }
                else if (id == 2)
                {
                    // Export the list of colors
                    EXPORT_COLOR_LIST();
                }
                else if (id == 3)
                {
                    // Remove the list items
                    REMOVE_LIST_ITEMS();
                }
                else if (id == 4)
                {
                    // Clear all item in the list view
                    CLEAR_ALL_LIST();
                }
            }

        }
        #endregion

        #region PICK COLORS
        /// <summary>
        /// Picking colors
        /// </summary>
        /// <param name="COLOR"></param>
        private void PICK_COLORS(Color COLOR)
        {
            Bitmap BITMAP_SQUARE = new Bitmap(16, 16);
            Graphics GRAPHICS_SQUARE = Graphics.FromImage(BITMAP_SQUARE);
            // Pickup the the color panel controller color
            GRAPHICS_SQUARE.FillRectangle(new SolidBrush(pnlColorPickerController.BackColor), 0, 0, 100, 16);
            imgListPreview.Images.Add(BITMAP_SQUARE);
            ListViewItem LIST_VIEW_ITEM = new ListViewItem();
            string PARSE_COLOR_TO_TEXT = null;
            switch (cmbFormats.SelectedIndex)
            {
                // If the parsed color HTML
                case 0:
                    PARSE_COLOR_TO_TEXT = ColorTranslator.ToHtml(COLOR);
                    LIST_VIEW_ITEM.Text = ColorTranslator.ToHtml(COLOR);
                    break;
                // If the parsed color RGB
                case 1:
                    PARSE_COLOR_TO_TEXT = COLOR.R + ", " + COLOR.G + ", " + COLOR.B;
                    LIST_VIEW_ITEM.Text = COLOR.R + ", " + COLOR.G + ", " + COLOR.B;
                    break;
                // If the pasred color RGB (.Net)
                case 2:
                    PARSE_COLOR_TO_TEXT = COLOR.R + "; " + COLOR.G + "; " + COLOR.B;
                    LIST_VIEW_ITEM.Text = COLOR.R + "; " + COLOR.G + "; " + COLOR.B;
                    break;
                // If the parsed color HEX
                case 3:
                    PARSE_COLOR_TO_TEXT = "0x" + ColorTranslator.ToHtml(COLOR).Replace("#", "");
                    LIST_VIEW_ITEM.Text = "0x" + ColorTranslator.ToHtml(COLOR).Replace("#", "");
                    break;
                // Setup picked color to photoshop essentials
                case 4:
                    PARSE_COLOR_TO_TEXT = ColorTranslator.ToHtml(COLOR).Replace("#", "");
                    LIST_VIEW_ITEM.Text = ColorTranslator.ToHtml(COLOR).Replace("#", "");
                    break;
            }
            // Set the tgs for the list views
            LIST_VIEW_ITEM.Tag = COLOR;
            // Get the last item from the list view
            LIST_VIEW_ITEM.ImageIndex = imgListPreview.Images.Count - 1;
            // Finally add the color to the list view
            listColors.Items.Add(LIST_VIEW_ITEM).EnsureVisible();
            // Setup the picked color to Text box
            txtColor.Text = PARSE_COLOR_TO_TEXT;

            if (listColors.Items.Count != 0)
                grpOptions.Enabled = true;
            else
                grpOptions.Enabled = false;
        }
        #endregion

        #region COLOR LIST EXPORTER
        private void EXPORT_COLOR_LIST()
        {
            string allListColors = null;
            if (listColors.Items.Count != 0)
            {
                // Get the text from each items in the list view
                foreach (ListViewItem item in listColors.Items)
                {
                    // Append the all texts in to a individual string
                    allListColors += item.Text + Environment.NewLine;
                }

                this.allListColors = allListColors;
                // Color list exporter
                COLOR_LIST_EXPORT_WORKER();

            }
            else
            {
                // Custom dialogs NOT FOUND
                CustomDialogs dialogs = new CustomDialogs();
                dialogs.SetTitle("Empty list");
                dialogs.SetMessage("No Color found to export!");
                dialogs.SetMessageType(0);
                dialogs.SetTopMost(GET_TOPMOST());
                dialogs.SetButtonText("Ok");
                dialogs.Show();
            }
        }
        #endregion

        #region COLOR LIST EXPORTER BG WORKER
        private void COLOR_LIST_EXPORT_WORKER()
        {
            BackgroundWorker COLOR_LIST_EXPORTER = new BackgroundWorker();
            COLOR_LIST_EXPORTER.RunWorkerCompleted += COLOR_LIST_EXPORTER_RunWorkerCompleted;
            COLOR_LIST_EXPORTER.DoWork += COLOR_LIST_EXPORTER_DoWork;

            if (!COLOR_LIST_EXPORTER.IsBusy)
                COLOR_LIST_EXPORTER.RunWorkerAsync();
        }

        private void COLOR_LIST_EXPORTER_DoWork(object sender, DoWorkEventArgs e)
        {
            // List exporter
            EXPORT_LIST(allListColors, "Simple-Color-Picker-Color-List.txt");
        }

        private void COLOR_LIST_EXPORTER_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Custom dialog SUCCESS
            CustomDialogs dialogs = new CustomDialogs();
            dialogs.SetTitle("Done");
            dialogs.SetMessage("Color list exported!");
            dialogs.SetMessageType(3);
            dialogs.SetTopMost(GET_TOPMOST());
            dialogs.SetButtonText("Ok");
            dialogs.Show();
        }

        private void EXPORT_LIST(string colors, string NAME)
        {
            var DATE_TIME = $"[{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}]";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(DATE_TIME);
            stringBuilder.AppendLine(colors);

            var PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (File.Exists(PATH + "\\" + NAME))
            {
                File.Delete(PATH + "\\" + NAME);
            }

            File.AppendAllText(PATH + "\\" + NAME, stringBuilder.ToString());
        }
        #endregion

        #region REMOVE LIST ITEMS ONE BY ONE
        private void REMOVE_LIST_ITEMS()
        {
            if (listColors.Items.Count != 0)
            {
                // Setup remove button // Its removing last item from the list view
                listColors.Items.Remove(listColors.Items[listColors.Items.Count - 1]);

                // Remove color from text box
                REMOVE_TEXT_COLOR();

            }
            else
            {
                // Custom dialog PICK COLOR FIRST
                CustomDialogs dialogs = new CustomDialogs();
                dialogs.SetTitle("Empty list");
                dialogs.SetMessage("Please pick a Color first!");
                dialogs.SetMessageType(0);
                dialogs.SetTopMost(GET_TOPMOST());
                dialogs.SetButtonText("Ok");
                dialogs.Show();
            }
        }
        #endregion

        #region CLEAR WHOLE LIST ITEMS
        private void CLEAR_ALL_LIST()
        {
            if (listColors.Items.Count != 0)
            {
                // Clear the all items in the list view
                listColors.Items.Clear();
                // Remove color from text box
                REMOVE_TEXT_COLOR();
            }
            else
            {
                // Custom dilaog
                CustomDialogs dialogs = new CustomDialogs();
                dialogs.SetTitle("Empty list");
                dialogs.SetMessage("Nothing to clear!");
                dialogs.SetMessageType(0);
                dialogs.SetTopMost(GET_TOPMOST());
                dialogs.SetButtonText("Ok");
                dialogs.Show();
            }
        }
        #endregion

        #region TOP MOST CHECKER
        private bool GET_TOPMOST()
        {
            if (chkTopmost.Checked)
                return true;
            else
                return false;
        }
        #endregion

        #region REMOVE PICKED COLOR FROM TEXT BOX
        private void REMOVE_TEXT_COLOR()
        {
            if (txtColor.Text.Length > 0)
            {
                txtColor.Text = string.Empty;
            }
        }
        #endregion

        #region COPY PICKED COLOR
        private void COPY_PICKED_COLOR()
        {
            if (txtColor.Text.Length > 0)
                // Copy the textbox color to windows clipboard manager
                Clipboard.SetText(txtColor.Text);
            else
            {
                // Custom dialog NOT FOUND
                CustomDialogs dialogs = new CustomDialogs();
                dialogs.SetTitle("Warning");
                dialogs.SetMessage("No Color found to copy!");
                dialogs.SetMessageType(0);
                dialogs.SetTopMost(GET_TOPMOST());
                dialogs.SetButtonText("Ok");
                dialogs.Show();
            }
        }
        #endregion

        #region PARSE ZOOMING VALUE
        private int PARSE_ZOOM_VALUE(int index)
        {
            switch (index)
            {
                case 0:
                    {
                        return 50;
                    }
                case 1:
                    {
                        return 40;
                    }
                case 2:
                    {
                        return 30;
                    }
                case 3:
                    {
                        return 20;
                    }
                case 4:
                    {
                        return 10;
                    }
            }

            return -1;
        }
        #endregion
    }
}

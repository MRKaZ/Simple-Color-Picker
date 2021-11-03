using ComponentFactory.Krypton.Toolkit;

namespace Simple_Color_Picker_WinForm
{
    /// <summary>
    /// Custom WInForum Dialog
    /// </summary>
    public partial class CustomDialogs : KryptonForm
    {
        private string title { get; set; }
        private string message { get; set; }
        private int messageType { get; set; }

        public CustomDialogs()
        {
            InitializeComponent();
        }

        private void CutomDialogs_Load(object sender, System.EventArgs e)
        {
            // Setup title and messages to the dialog!
            Text = title;
            lblMessage.Text = message;

            // Setup dialog icon at the startup
            if (messageType == 0)
            {
                // 0 = WARNING
                picLogo.Image = Properties.Resources.WARNING;
            }
            else if (messageType == 1)
            {
                // 1 = ERROR
                picLogo.Image = Properties.Resources.ERROR;
            }
            else if (messageType == 2)
            {
                // 2 = INFORMATION
                picLogo.Image = Properties.Resources.INFORMATION;
            }
            else if (messageType == 3)
            {
                // 3 = DONE
                picLogo.Image = Properties.Resources.DONE;
            }
        }

        private void btnAction_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        #region INDIVIDUAL STRING FUNCTIONS

        /// <summary>
        /// Dialog Title
        /// </summary>
        /// <param name="title">Title of the dialog which you want</param>
        public void SetTitle(string title)
        {
            this.title = "&" + title;

        }

        /// <summary>
        /// Dialog Message
        /// </summary>
        /// <param name="message">Message of the dialog which you want</param>
        public void SetMessage(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Dialog Type
        /// </summary>
        /// [Dialog types]
        /// Warning = 0,
        /// Error = 1,
        /// Information = 2,
        /// Done = 3,
        /// <param name="messageType">DialogType of the dialog which you want</param>
        public void SetMessageType(int messageType)
        {
            this.messageType = messageType;
        }

        /// <summary>
        /// Setup TopMost to dialog
        /// </summary>
        /// <param name="topmost">Boolean true/false</param>
        public void SetTopMost(bool topmost)
        {
            TopMost = topmost;
        }

        /// <summary>
        /// Setup title to dialog
        /// </summary>
        /// <param name="buttonText">Text to setup dialog title which you want</param>
        public void SetButtonText(string buttonText)
        {
            btnAction.Text = "&" + buttonText;
        }

        #endregion
    }
}

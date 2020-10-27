using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   // dragging form

namespace GUI_Template
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Color currentColor;

        public MainForm()
        {
            InitializeComponent();

            // prevents icon flittering
            this.DoubleBuffered = true;

            // getting rid of the control box
            this.ControlBox = false;
            this.Text = String.Empty;

            // setting minimal size of the form
            this.MinimumSize = new Size(1055, 615);

            // set currentColor to FontColors.color1
            currentColor = FontColors.color2;
        }


        #region Colors

        private struct ThemeColors
        {
            public static Color color1 = Color.FromArgb(245, 157, 34);
            public static Color color2 = Color.FromArgb(237, 118, 58);
            public static Color color3 = Color.FromArgb(236, 92, 65);
            public static Color color4 = Color.FromArgb(226, 50, 70);
            public static Color color5 = Color.FromArgb(201, 31, 80);
            public static Color color6 = Color.FromArgb(168, 22, 85);
            public static Color color7 = Color.FromArgb(127, 21, 85);
            public static Color color8 = Color.FromArgb(84, 23, 82);
        }
        private struct FontColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);
            public static Color color2 = Color.FromArgb(220, 244, 255);
        }
        private struct BackgroundColors
        {
            public static Color color1 = Color.FromArgb(6, 2, 29);
            public static Color color2 = Color.FromArgb(8, 6, 35);
            public static Color color3 = Color.FromArgb(10, 7, 40);
        }

        #endregion


        #region Activate/Desactivate Button

        /// <summary>
        /// Activate visual effects of the button
        /// </summary>
        /// <param name="senderButton"> Sender button </param>
        /// <param name="senderColor"> Chosen theme color </param>
        private void ActivateButton(Button senderButton, Color senderColor)
        {
            
            if(currentButton == null)
            {
                // if no buttons have been activated previously
                panelButton.Visible = true;                 // activate side panel
                panelButton.BackColor = senderColor;        // set side button panel color to theme color
                panelUnderTop.BackColor = senderColor;      // set under top panel color to theme color
                currentButton = senderButton;               // save "senderButton" variable to "currentButton"
                senderButton.ForeColor = senderColor;       // set fore button color to theme
                panelButton.Location = new Point(0, currentButton.Location.Y);  // set panel location
                currentColor = senderColor;                 // save theme color
            }
            else if (senderButton != currentButton) 
            {
                // if new button has been clicked
                DesactivateButton();                        // desactivate previously activated button
                panelButton.Visible = true;                 // activate side panel
                panelButton.BackColor = senderColor;        // set side button panel color to theme color
                panelUnderTop.BackColor = senderColor;      // set under top panel color to theme color
                currentButton = senderButton;               // save "senderButton" variable to "currentButton"
                senderButton.ForeColor = senderColor;       // set fore button color to theme
                panelButton.Location = new Point(0, currentButton.Location.Y);  // set panel location
                currentColor = senderColor;                 // save theme color
            }
            else
            {
                // if clicked button is currently active
                // do nothing
            }
            
        }

        private void DesactivateButton()
        {
            if (currentButton != null) 
            { 
                panelButton.Visible = false;                            // desactivate side panel
                panelUnderTop.BackColor = BackgroundColors.color2;      // change under top panel color to default
                currentButton.ForeColor = FontColors.color1;            // change button font color to default
                currentColor = FontColors.color2;                 // save theme color
            }
        }


        #endregion


        #region Side menu buttons

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, ThemeColors.color1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, ThemeColors.color2);
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            ActivateButton((Button)sender, ThemeColors.color3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, ThemeColors.color4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, ThemeColors.color5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, ThemeColors.color6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, ThemeColors.color7);
        }

        private void labelTopRight_Click(object sender, EventArgs e)
        {
            DesactivateButton();
        }

        #endregion


        #region Top Left Corner buttons

        // Close window button
        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonExit_MouseLeave(object sender, EventArgs e)
        {
            iconButtonExit.IconColor = FontColors.color1;
            iconButtonExit.ForeColor = FontColors.color1;
        }

        private void iconButtonExit_MouseEnter(object sender, EventArgs e)
        {
            iconButtonExit.IconColor = currentColor;
            iconButtonExit.ForeColor = currentColor;
        }


        // Minimize window button
        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void iconButtonMinimize_MouseEnter(object sender, EventArgs e)
        {
            iconButtonMinimize.IconColor = currentColor;
            iconButtonMinimize.ForeColor = currentColor;
        }

        private void iconButtonMinimize_MouseLeave(object sender, EventArgs e)
        {
            iconButtonMinimize.IconColor = FontColors.color1;
            iconButtonMinimize.ForeColor = FontColors.color1;
        }


        #endregion


        #region Mouse Drag

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion
    }
}

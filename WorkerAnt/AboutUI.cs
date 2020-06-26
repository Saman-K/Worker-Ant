using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WorkerAnt
{
    partial class AboutUI : Form
    {
        #region Fields
        private int _mouseXAxis;
        private int _mouseYAxis;
        private bool _mouseDrag;
        #endregion

        #region Initialization
        public AboutUI()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }
        #endregion

        #region Assembly Attribute Accessors
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        #region Form Border Style
        #region ------------------------------------------------------------------------- Move Window
        // Window mouse down
        private void WindowMouseDown(object sender, MouseEventArgs e)
        {
            _mouseDrag = true;
            _mouseXAxis = Cursor.Position.X - this.Left;
            _mouseYAxis = Cursor.Position.Y - this.Top;
        }
        // Window mouse move
        private void WindowMouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDrag)
            {
                this.Left = Cursor.Position.X - _mouseXAxis;
                this.Top = Cursor.Position.Y - _mouseYAxis;
            }
        }
        // Window mouse up
        private void WindowMouseUp(object sender, MouseEventArgs e)
        {
            _mouseDrag = false;
        }
        #endregion

        #region ------------------------------------------------------------------------- Picture box close
        // Close Window
        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }
        // Close mouse leave 
        private void ClosePicBoxMouseLeave(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.Control;
        }
        // Close mouse enter
        private void ClosePicBoxMouseEnter(object sender, EventArgs e)
        {
            picBoxClose.BackColor = SystemColors.ControlDark;
        }

        #endregion
        #endregion

        #region Method
        private void LearnMoreBtn(object sender, EventArgs e)
        {
            Process.Start("https://samank.me");
            Close();
        }
        #endregion
    }
}

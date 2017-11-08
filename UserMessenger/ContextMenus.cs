using System;
using System.Windows.Forms;
using UserMessenger.Properties;

namespace UserMessenger {
    class UserMessengerContextMenu {
        public delegate void ShowMessengerClicked();
        public delegate void RegisterUserClicked();
        public delegate void UnregisterUserClicked();
        public delegate void ExitClicked();

        public ShowMessengerClicked OnShowMessengerClicked {
            get { return showMessenger; }
            set { showMessenger = value; }
        }

        public RegisterUserClicked OnRegisterUserClicked {
            get { return registerUser; }
            set { registerUser = value; }
        }

        public UnregisterUserClicked OnUnregisterUserClicked {
            get { return unregisterUser; }
            set { unregisterUser = value; }
        }

        public bool UserRegistered {
            get { return mUserRegistered; }
            set {
                mUserRegistered = value;
                mUnregisterMenuItem.Visible = mUserRegistered;
                mRegisterMenuItem.Visible = !mUserRegistered;
            }
        }

        public ContextMenuStrip Menu {
            get { return mMenuStrip; }
        }

        public UserMessengerContextMenu() {
            mMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            item = new ToolStripMenuItem();
            item.Text = "Show Messenger";
            item.Click += new EventHandler(ShowMessenger_Click);
            item.Image = Resources.UserMessengerIcon.ToBitmap();
            mMenuStrip.Items.Add(item);

            sep = new ToolStripSeparator();
            mMenuStrip.Items.Add(sep);

            mRegisterMenuItem = new ToolStripMenuItem();
            mRegisterMenuItem.Text = "Register User";
            mRegisterMenuItem.Click += new EventHandler(RegisterUser_Click);
            mRegisterMenuItem.Image = Resources.UserMessengerIcon.ToBitmap();
            mMenuStrip.Items.Add(mRegisterMenuItem);

            mUnregisterMenuItem = new ToolStripMenuItem();
            mUnregisterMenuItem.Text = "Unregister User";
            mUnregisterMenuItem.Click += new EventHandler(UnregisterUser_Click);
            mUnregisterMenuItem.Image = Resources.UserMessengerIcon.ToBitmap();
            mMenuStrip.Items.Add(mUnregisterMenuItem);

            sep = new ToolStripSeparator();
            mMenuStrip.Items.Add(sep);

            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += new EventHandler(Exit_Click);
            item.Image = Resources.Exit;
            mMenuStrip.Items.Add(item);

        }

        private void ShowMessenger_Click(object sender, EventArgs e) {
            if (showMessenger != null) {
                showMessenger();
            }
        }

        private void RegisterUser_Click(object sender, EventArgs e) {
            if (registerUser != null) {
                registerUser();
            }
        }

        private void UnregisterUser_Click(object sender, EventArgs e) {
            if (unregisterUser != null) {
                unregisterUser();
            }
        }

        private void Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private ShowMessengerClicked showMessenger = null;
        private RegisterUserClicked registerUser = null;
        private UnregisterUserClicked unregisterUser = null;

        private ContextMenuStrip mMenuStrip = null;
        ToolStripMenuItem mRegisterMenuItem = null;
        ToolStripMenuItem mUnregisterMenuItem = null;

        private bool mUserRegistered = false;
    }
}

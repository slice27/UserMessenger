using System;
using System.Windows.Forms;
using UserMessenger.Properties;

namespace UserMessenger {
    class UserMessengerIcon : IDisposable {
        public void Dispose() {
            mNi.Dispose();
            mForm.Dispose();
        }

        public UserMessengerIcon() : base() {
            mNi = new NotifyIcon();
            mForm = new MessageForm();
            mCurrentUser = User.LoadCurrentUser();
        }

        public void Display() {
            mNi.MouseClick += new MouseEventHandler(NotifyMouseClick);
            mNi.Icon = Resources.UserMessengerIcon;
            mNi.Text = "User Messenger - " + mCurrentUser.Username;
            mNi.Visible = true;

            mForm.Text = mNi.Text;
            mForm.Icon = Resources.UserMessengerIcon;

            mContext = new UserMessengerContextMenu();
            mNi.ContextMenuStrip = mContext.Menu;
            mContext.OnShowMessengerClicked = ShowMessenger;
            mContext.OnRegisterUserClicked = RegisterUser;
            mContext.OnUnregisterUserClicked = UnregisterUser;

            mContext.UserRegistered = mCurrentUser.IsRegistered();
        }

        private void NotifyMouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ShowMessenger();
            }
        }

        private void ShowMessenger() {
            mForm.ShowDialog();
        }

        private void RegisterUser() {
            mCurrentUser.RegisterUser();
            mContext.UserRegistered = mCurrentUser.IsRegistered();
        }

        private void UnregisterUser() {
            mCurrentUser.UnregisterUser();
            mContext.UserRegistered = mCurrentUser.IsRegistered();
        }

        private NotifyIcon mNi;
        private UserMessengerContextMenu mContext;
        private MessageForm mForm;
        private User mCurrentUser;
    }
}

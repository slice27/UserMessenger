using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserMessenger {
    public partial class MessageForm : Form {
        public MessageForm() {
            InitializeComponent();
            mCurrentUser = User.LoadCurrentUser();
        }

        private void UpdateUsers() {
            UsersListbox.Items.Clear();
            List<User> users = User.GetUsers();
            foreach (User user in users) {
                UsersListbox.Items.Add(user);
            }
        }

        private bool UpdateMessages() {
            bool ret = false;
            InMessageBox.Clear();
            InMessageBox.Text = string.Empty;
            List<Message> messages = Message.GetMessages(mCurrentUser.Id, newMessagesCheckbox.Checked);
            foreach (Message message in messages) {
                if (!message.Received) {
                    ret = true;
                }
                InMessageBox.Text += "\r\n" + message.ToString();
            }
            return ret;
        }

        private void SendMessageToUsers() {
            foreach (int index in UsersListbox.SelectedIndices) {
                Message.SendMessage((UsersListbox.Items[index] as User).Id, mCurrentUser.Id, OutMessageBox.Text);
            }
            OutMessageBox.Clear();
            OutMessageBox.Text = string.Empty;
        }


        private User mCurrentUser = null;

        private void SendButton_Click(object sender, EventArgs e) {
            SendMessageToUsers();
            UpdateUsers();
        }

        private void MessageForm_Shown(object sender, EventArgs e) {
            UpdateUsers();
            UpdateMessages();
        }

        private void newMessagesCheckbox_CheckedChanged(object sender, EventArgs e) {
            UpdateUsers();
            UpdateMessages();
        }

        private void acknowledgeButton_Click(object sender, EventArgs e) {
            Message.AcknowledgeAllMessages(mCurrentUser.Id);
        }

        private void MessageUpdate_Tick(object sender, EventArgs e) {
            if (UpdateMessages() && !Visible) {
                ShowDialog();
            }
        }

        private void OutMessageBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyValue == (char)Keys.Enter) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendMessageToUsers();
            }
        }
    }
}

namespace UserMessenger {
    partial class MessageForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.UsersListbox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SendButton = new System.Windows.Forms.Button();
            this.OutMessageBox = new System.Windows.Forms.TextBox();
            this.InMessageBox = new System.Windows.Forms.TextBox();
            this.SystemUsersLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.newMessagesCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.acknowledgeButton = new System.Windows.Forms.Button();
            this.MessageUpdate = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersListbox
            // 
            this.UsersListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersListbox.FormattingEnabled = true;
            this.UsersListbox.ItemHeight = 16;
            this.UsersListbox.Location = new System.Drawing.Point(3, 42);
            this.UsersListbox.Name = "UsersListbox";
            this.UsersListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.UsersListbox.Size = new System.Drawing.Size(219, 302);
            this.UsersListbox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.InMessageBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(228, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.12293F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.87707F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(573, 302);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.62601F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.37398F));
            this.tableLayoutPanel3.Controls.Add(this.SendButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.OutMessageBox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 232);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(567, 67);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendButton.Location = new System.Drawing.Point(465, 3);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(99, 61);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // OutMessageBox
            // 
            this.OutMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutMessageBox.Location = new System.Drawing.Point(3, 3);
            this.OutMessageBox.Multiline = true;
            this.OutMessageBox.Name = "OutMessageBox";
            this.OutMessageBox.Size = new System.Drawing.Size(456, 61);
            this.OutMessageBox.TabIndex = 1;
            this.OutMessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OutMessageBox_KeyDown);
            // 
            // InMessageBox
            // 
            this.InMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InMessageBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InMessageBox.Location = new System.Drawing.Point(3, 3);
            this.InMessageBox.Multiline = true;
            this.InMessageBox.Name = "InMessageBox";
            this.InMessageBox.ReadOnly = true;
            this.InMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InMessageBox.Size = new System.Drawing.Size(567, 223);
            this.InMessageBox.TabIndex = 2;
            this.InMessageBox.TabStop = false;
            // 
            // SystemUsersLabel
            // 
            this.SystemUsersLabel.AutoSize = true;
            this.SystemUsersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemUsersLabel.Location = new System.Drawing.Point(3, 0);
            this.SystemUsersLabel.Name = "SystemUsersLabel";
            this.SystemUsersLabel.Size = new System.Drawing.Size(219, 39);
            this.SystemUsersLabel.TabIndex = 0;
            this.SystemUsersLabel.Text = "System Users";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.08112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.91888F));
            this.tableLayoutPanel1.Controls.Add(this.SystemUsersLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UsersListbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.29568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.70432F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 347);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.27988F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.72012F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel4.Controls.Add(this.newMessagesCheckbox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.acknowledgeButton, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(228, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(573, 33);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // newMessagesCheckbox
            // 
            this.newMessagesCheckbox.AutoSize = true;
            this.newMessagesCheckbox.Checked = true;
            this.newMessagesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newMessagesCheckbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.newMessagesCheckbox.Location = new System.Drawing.Point(213, 3);
            this.newMessagesCheckbox.Name = "newMessagesCheckbox";
            this.newMessagesCheckbox.Size = new System.Drawing.Size(191, 27);
            this.newMessagesCheckbox.TabIndex = 1;
            this.newMessagesCheckbox.Text = "View Only New Messages";
            this.newMessagesCheckbox.UseVisualStyleBackColor = true;
            this.newMessagesCheckbox.CheckedChanged += new System.EventHandler(this.newMessagesCheckbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Messages";
            // 
            // acknowledgeButton
            // 
            this.acknowledgeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acknowledgeButton.AutoSize = true;
            this.acknowledgeButton.Location = new System.Drawing.Point(410, 3);
            this.acknowledgeButton.Name = "acknowledgeButton";
            this.acknowledgeButton.Size = new System.Drawing.Size(160, 27);
            this.acknowledgeButton.TabIndex = 2;
            this.acknowledgeButton.Text = "Messages Received";
            this.acknowledgeButton.UseVisualStyleBackColor = true;
            this.acknowledgeButton.Click += new System.EventHandler(this.acknowledgeButton_Click);
            // 
            // MessageUpdate
            // 
            this.MessageUpdate.Enabled = true;
            this.MessageUpdate.Interval = 1000;
            this.MessageUpdate.Tick += new System.EventHandler(this.MessageUpdate_Tick);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 347);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageForm";
            this.Text = "Messages";
            this.Shown += new System.EventHandler(this.MessageForm_Shown);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UsersListbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox OutMessageBox;
        private System.Windows.Forms.Label SystemUsersLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox InMessageBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox newMessagesCheckbox;
        private System.Windows.Forms.Button acknowledgeButton;
        private System.Windows.Forms.Timer MessageUpdate;
    }
}


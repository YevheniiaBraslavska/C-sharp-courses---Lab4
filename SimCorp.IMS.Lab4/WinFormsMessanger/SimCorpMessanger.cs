using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimCorp.IMS.MobileLibrary;
using SimCorp.IMS.WinFormApp;

namespace SimCorp.IMS.WinFormsMessanger {
    public partial class SimCorpMessanger : Form {
        public SimCorpMessanger() {
            InitializeComponent();

            //Init
            AddFormatTypesToComboBox();
            for (var i = 0; i < 3; i++) {
                _vUsers.Add("User "+(i+1));
            }
            Mobile.AddMessanger(PushMessage);
        }

        private List<string> _vUsers = new List<string>();
        private SimCorpMobile Mobile = new SimCorpMobile();
        private readonly MessageFormatter _vFormatter = new MessageFormatter();
        private int _vMessageCounter;

        public void SMSPushTimer_Tick(object sender, EventArgs e) {
            //Random choise of user, who send new message
            var random = new Random();
            var randomusernumber = random.Next(0, _vUsers.Count);
            var randomuser = _vUsers[randomusernumber];
            _vMessageCounter += 1;
            var message = GenMessage(randomuser);
            var user = "User " + (randomuser + 1).ToString(CultureInfo.InvariantCulture);
            OnSmsRecieved(this, new SMSRecieverEventArgs(message,Mobile));
        }

        private void FormatTypesBox_SelectedIndexChanged(object sender, EventArgs e) {
            SetFormatter();
        }

        public void OnSmsRecieved(object sender, SMSRecieverEventArgs args) {
            if (InvokeRequired) {
                Invoke(new EventHandler<SMSRecieverEventArgs>(OnSmsRecieved), sender, args);
            }
            Mobile.Memory.Write(sender, args);
        }

        /// <summary>
        /// Generete a standart message and get a user name from mobile number
        /// </summary>
        /// <returns>Generated message structure</returns>
        private UserMessage GenMessage(string user) {
            var text = "Message " + _vMessageCounter;
            return new UserMessage(user, text);
        }

        /// <summary>
        /// Push message onto the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PushMessage(object sender, SMSRecieverEventArgs args) {
            ShowMessages(Mobile.Memory.Messages);
            SelectedUser(Mobile.Memory.Messages);
        }

        private void ShowMessages(List<UserMessage> messages) {
            MessageListView.Items.Clear();
            var messagestoshow = GetValidMessages(messages);
            MessageListView.Items.Clear();
            foreach (var message in messagestoshow) {
                var formattedstring = _vFormatter.NullFormatter() ? message.Text : _vFormatter.Formatter(message);
                MessageListView.Items.Add(new ListViewItem(new[] { message.User, formattedstring }));
            }
        }

        private IEnumerable<UserMessage> GetValidMessages(List<UserMessage> messages) {
            var userfilterres = MessagesFilter.GetMessagesForUser(messages, UsersComboBox.SelectedItem?.ToString());
            var searchfilterres = MessagesFilter.GetSearchMessages(messages, SearchBox.Text);
            var datafilterres = MessagesFilter.GetFromToDateMessages(messages, FromDate.Value, ToDate.Value);
            var messagestoshow = userfilterres.Intersect(searchfilterres);
            messagestoshow = messagestoshow.Intersect(datafilterres);
            return messagestoshow;
        }

        /// <summary>
        /// Set Formatting type to formatter due to active formatting in combo box
        /// </summary>
        private void SetFormatter() {
            switch (FormatTypesBox.SelectedItem.ToString()) {
                case "Start with DateTime":
                _vFormatter.SetFormat(MessageFormatter.StartWithTime);
                break;
                case "End with DateTime":
                _vFormatter.SetFormat(MessageFormatter.EndWithTime);
                break;
                case "Custom":
                _vFormatter.SetFormat(MessageFormatter.Custom);
                break;
                case "Lowercase":
                _vFormatter.SetFormat(MessageFormatter.LowerCase);
                break;
                case "Uppercase":
                _vFormatter.SetFormat(MessageFormatter.UpperCase);
                break;
                default:
                _vFormatter.ClearFormat();
                break;
            }
        }

        private void AddFormatTypesToComboBox() {
            var items = new string[]
            {
                "None",
                "Start with DateTime",
                "End with DateTime",
                "Custom",
                "Lowercase",
                "Uppercase"
            };
            FormatTypesBox.Items.AddRange(items);
            FormatTypesBox.SelectedItem = "None";
        }

        private void SelectedUser(List<UserMessage> messages) {
            AddUsersToComboBox(MessagesFilter.GetAllUsers(messages));
        }

        private void AddUsersToComboBox(List<string> users) {
            var selecteditem = UsersComboBox.SelectedItem;
            UsersComboBox.Items.Clear();
            users.Add("All");
            var items = users.ToArray();
            UsersComboBox.Items.AddRange(items);
            UsersComboBox.SelectedItem = selecteditem;
        }

        private void ClearUnactiveInGroup(GroupBox group) {
            foreach (var control in group.Controls) {
                if (control is GroupBox) {
                    if (CountFocusedInGroup((GroupBox)control) != 0)
                        continue;
                    ClearUnactiveInGroup((GroupBox)control);
                    continue;
                }
                if (((Control)control).Focused)
                    continue;
                if (control is TextBox) {
                    ((TextBox)control).Text = "";
                } else if (control is ComboBox) {
                    ((ComboBox)control).SelectedItem = "All";
                } else if (control is DateTimePicker) {
                    ((DateTimePicker)control).ResetText();
                } else { throw new ArgumentException(); }
            }
        }

        private int CountFocusedInGroup(GroupBox group) {
            return @group.Controls.Cast<object>().Count(control => ((Control)control).Focused);
        }

        private void FromDate_CloseUp(object sender, EventArgs e) {
            if (!MultyFilterCheck.Checked)
                ClearUnactiveInGroup(FiltersGroup);
        }

        private void ToDate_CloseUp(object sender, EventArgs e) {
            if (!MultyFilterCheck.Checked)
                ClearUnactiveInGroup(FiltersGroup);
        }
        private void SearchBox_TextChanged(object sender, EventArgs e) {
            if (!MultyFilterCheck.Checked)
                ClearUnactiveInGroup(FiltersGroup);
        }

        private void UsersComboBox_SelectionChangeCommitted(object sender, EventArgs e) {
            if (!MultyFilterCheck.Checked)
                ClearUnactiveInGroup(FiltersGroup);
        }
    }
}

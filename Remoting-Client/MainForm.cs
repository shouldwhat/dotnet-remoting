using Controller;
using Model;
using System;
using System.Collections;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Windows.Forms;

namespace Remoting_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeConnection();
            InitializeUserList();
            InitializeEventHandler();
        }

        private void InitializeEventHandler()
        {
            AddUserEventManager.SINGLETON.addUserEventHandler += SINGLETON_addUserEventHandler;
        }

        private void SINGLETON_addUserEventHandler(AddUserEventArgs args)
        {
            String name = args.Name;
            String age = args.Age;
            String position = args.Position.ToString();
            String sex = args.Sex.ToString();

            ListViewItem lvi = new ListViewItem(new String[] { name, position, age, sex });

            lv_userList.Items.Add(lvi);
        }

        private void InitializeUserList()
        {
            try
            {
                ArrayList userList = ConnectionBroker.getController().getUserList();
                makeupUserListView(userList);
            }
            catch(Exception)
            {
                MessageBox.Show("[WARNING] Remoting Server Connecting Fail!");
                this.Close();
            }
        }

        private void makeupUserListView(ArrayList userList)
        {
            foreach(User user in userList)
            {
                String name = user.Name;
                String age = user.Age;
                String position = user.Position.ToString();
                String sex = user.Sex.ToString();

                ListViewItem lvi = new ListViewItem(new String[] { name, position, age, sex });

                lv_userList.Items.Add(lvi);
            }
        }

        private void InitializeConnection()
        {
            ConnectionBroker.getInstance().connect();
        }

        AddUserForm addUserForm = null;
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(addUserForm == null)
            {
                addUserForm = new AddUserForm();
                addUserForm.FormClosed += AddUserForm_FormClosed;
                addUserForm.Show();
            }
        }

        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addUserForm = null;
        }
    }
}


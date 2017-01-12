using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remoting_Client
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            InitializeCombobox();
        }

        private void InitializeCombobox()
        {
            this.makeupPositionCombobox();
            this.makeupSexCombobox();
            this.makeupAgeCombobox();
        }

        private void makeupAgeCombobox()
        {
            int maxAge = 45;

            for(int minAge = 19; minAge <= maxAge; minAge++)
            {
                cb_age.Items.Add(minAge);
            }

            cb_age.SelectedIndex = 0;
        }

        private void makeupSexCombobox()
        {
            String[] options = new String[] { "MALE", "FEMALE" };

            cb_sex.Items.AddRange(options);
            cb_sex.SelectedIndex = 0;
        }

        private void makeupPositionCombobox()
        {
            String[] options = new String[] { "STAFF", "ASSISTANT_MANAGER", "MANAGER", "GENERAL_MANAGER" };

            cb_position.Items.AddRange(options);
            cb_position.SelectedIndex = 0;
        }
        private void bt_registUser_Click(object sender, EventArgs e)
        {
            String name = tb_name.Text;
            String age = cb_age.SelectedItem.ToString();
            String sex = cb_sex.SelectedItem.ToString();
            String position = cb_position.SelectedItem.ToString();

            ConnectionBroker.getController().addUser(name, age, sex, position);

            AddUserEventManager.SINGLETON.onAddUserEvent(new AddUserEventArgs(name, age, sex, position));
        }
    }
}

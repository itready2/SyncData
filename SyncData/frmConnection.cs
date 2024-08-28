using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sysClass.sysClass;
using static sqlClass.sqlClass;

namespace SyncData
{
    public partial class frmConnection : DevExpress.XtraEditors.XtraForm
    {
        private getServer gServer = new getServer();
        public int setServerType = 0;

        public frmConnection()
        {
            InitializeComponent();
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            gServer.LoadConfig_1();
            txtServerName.Text = ServerName1;
            txtDatabaseName.Text = DatabaseName1;
            txtUserDB.Text = UserDB1;
            txtPasswordDB.Text = PasswordDB1;

            gServer.LoadConfig_2();
            txtServerName2.Text = ServerName2;
            txtDatabaseName2.Text = DatabaseName2;
            txtUserDB2.Text = UserDB2;
            txtPasswordDB2.Text = PasswordDB2;

            gServer.LoadConfig_3();
            txtServerName3.Text = ServerName3;
            txtDatabaseName3.Text = DatabaseName3;
            txtUserDB3.Text = UserDB3;
            txtPasswordDB3.Text = PasswordDB3;
        }

        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            if (TestConnectSQL(txtServerName.Text, txtDatabaseName.Text, txtUserDB.Text, txtPasswordDB.Text) == true)
            {
                MessageBox.Show($"Connection Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Connection Failed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (TestConnectSQL(txtServerName.Text, txtDatabaseName.Text, txtUserDB.Text, txtPasswordDB.Text) == true)
            {
                gServer.SetConfig_1(txtServerName.Text, txtDatabaseName.Text, txtUserDB.Text, txtPasswordDB.Text);
                MessageBox.Show($"Update Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Connection Failed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnTestConnect2_Click(object sender, EventArgs e)
        {
            if (TestConnectSQL(txtServerName2.Text, txtDatabaseName2.Text, txtUserDB2.Text, txtPasswordDB2.Text) == true)
            {
                MessageBox.Show($"Connection Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Connection Failed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCommit2_Click(object sender, EventArgs e)
        {
            if (TestConnectSQL(txtServerName2.Text, txtDatabaseName2.Text, txtUserDB2.Text, txtPasswordDB2.Text) == true)
            {
                gServer.SetConfig_2(txtServerName2.Text, txtDatabaseName2.Text, txtUserDB2.Text, txtPasswordDB2.Text);
                MessageBox.Show($"Update Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Connection Failed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnTestConnect3_Click(object sender, EventArgs e)
        {
            if (TestConnectSQL(txtServerName3.Text, txtDatabaseName3.Text, txtUserDB3.Text, txtPasswordDB3.Text) == true)
            {
                MessageBox.Show($"Connection Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Connection Failed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCommit3_Click(object sender, EventArgs e)
        {
            if (TestConnectSQL(txtServerName3.Text, txtDatabaseName3.Text, txtUserDB3.Text, txtPasswordDB3.Text) == true)
            {
                gServer.SetConfig_3(txtServerName3.Text, txtDatabaseName3.Text, txtUserDB3.Text, txtPasswordDB3.Text);
                MessageBox.Show($"Update Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Connection Failed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
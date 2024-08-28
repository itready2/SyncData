using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static sysClass.sysClass;

namespace SyncData
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private getServer gServer = new getServer();
        private SqlCommand cmd;
        private SqlDataReader dr;
        private StringBuilder sb;
        private SqlTransaction tr1;

        public Form1()
        {
            InitializeComponent();
            gServer.LoadConfig_1();
            gServer.LoadConfig_2();
            gServer.LoadConfig_3();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(ServerName1);
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
        }
    }
}
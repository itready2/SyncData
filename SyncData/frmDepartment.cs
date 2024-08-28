using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sysClass.sysClass;
using static sqlClass.sqlClass;

namespace SyncData
{
    public partial class frmDepartment : DevExpress.XtraEditors.XtraForm
    {
        private getServer gServer = new getServer();
        private SqlCommand cmd;
        private SqlDataReader dr;
        private StringBuilder sb;
        private SqlTransaction tr1;

        private DataTable dtDNS_DEPARTMENTCOMPOSE = new DataTable();

        private void fncSet_dtDNS_DEPARTMENTCOMPOSE()
        {
            dtDNS_DEPARTMENTCOMPOSE.Columns.Clear();
            dtDNS_DEPARTMENTCOMPOSE.Columns.Add("IID");
            dtDNS_DEPARTMENTCOMPOSE.Columns.Add("CtrlCode");
            dtDNS_DEPARTMENTCOMPOSE.Columns.Add("Code");
            dtDNS_DEPARTMENTCOMPOSE.Columns.Add("EnglishName");
            dtDNS_DEPARTMENTCOMPOSE.Columns.Add("LocalName");
            dtDNS_DEPARTMENTCOMPOSE.Columns.Add("DeptValue");
            dtDNS_DEPARTMENTCOMPOSE.Columns.Add("SetBudget");
            dtDNS_DEPARTMENTCOMPOSE.Columns.Add("SaveMode");
        }

        public frmDepartment()
        {
            InitializeComponent();
            gServer.LoadConfig_1();
            gServer.LoadConfig_2();
            gServer.LoadConfig_3();
            fncSet_dtDNS_DEPARTMENTCOMPOSE();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
        }

        public bool fncLoadData()
        {
            gridContDepartment.DataSource = null;
            dtDNS_DEPARTMENTCOMPOSE.Rows.Clear();

            ConnSQL dbSQL = new ConnSQL();//SQL Server
            dbSQL.ConnectSQL();

            string strCSQL = string.Empty;

            sb = new StringBuilder();

            sb.Append("SELECT DNS_DEPARTMENTCOMPOSE.* ");
            sb.Append("FROM DNS_DEPARTMENTCOMPOSE ");

            cmd = new SqlCommand();

            cmd.Parameters.Clear();
            cmd.CommandText = sb.ToString();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connSQL;
            dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            DataRow row;
            dt.Load(dr);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dtDNS_DEPARTMENTCOMPOSE.NewRow();
                    row["IID"] = dt.Rows[i]["IID"].ToString();
                    row["CtrlCode"] = dt.Rows[i]["CtrlCode"].ToString();
                    row["Code"] = dt.Rows[i]["Code"].ToString();
                    row["EnglishName"] = dt.Rows[i]["EnglishName"].ToString();
                    row["LocalName"] = dt.Rows[i]["LocalName"].ToString();

                    string LocalName = csfncFindData_1C("LocalName", "Dept", "Code", dt.Rows[i]["Code"].ToString());
                    if (string.IsNullOrEmpty(LocalName) == false)
                    {
                        if (LocalName != dt.Rows[i]["LocalName"].ToString())
                        {
                            row["SaveMode"] = "Edit";
                        }
                        else
                        {
                            row["SaveMode"] = "";
                        }
                    }
                    else
                    {
                        row["SaveMode"] = "Add";
                    }

                    dtDNS_DEPARTMENTCOMPOSE.Rows.Add(row);
                }

                gridContDepartment.DataSource = dtDNS_DEPARTMENTCOMPOSE;
            }

            dr.Close();
            dr.Dispose();

            //connSQL.Close();
            //connSQL.Dispose();
            dbSQL = null;
            return true;
        }

        public void fncSyncData()
        {
            //Start Transaction------------------------------------------------------------------------------

            ConnSQL dbSQL = new ConnSQL();
            dbSQL.ConnectSQL();

            SqlTransaction tr1;
            string lvStrSql = "";

            //Start Transaction------------------------------------------------------------------------------
            tr1 = connSQL.BeginTransaction();
            SqlCommand com1 = new SqlCommand();

            com1.CommandType = CommandType.Text;
            com1.Connection = connSQL;

            int cntEffect = 0;
            try
            {
                for (int i = 0; i < dtDNS_DEPARTMENTCOMPOSE.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(dtDNS_DEPARTMENTCOMPOSE.Rows[i]["IID"].ToString()) == false && string.IsNullOrEmpty(dtDNS_DEPARTMENTCOMPOSE.Rows[i]["SaveMode"].ToString()) == false)
                    {
                        cntEffect = cntEffect + 1;
                        if (dtDNS_DEPARTMENTCOMPOSE.Rows[i]["SaveMode"].ToString() == "Edit")
                        {
                            lvStrSql = "UPDATE Dept SET EnglishName='" + dtDNS_DEPARTMENTCOMPOSE.Rows[i]["EnglishName"].ToString() + "', LocalName='" + dtDNS_DEPARTMENTCOMPOSE.Rows[i]["LocalName"].ToString() + "' ";
                            lvStrSql += "Where Code='" + dtDNS_DEPARTMENTCOMPOSE.Rows[i]["Code"].ToString() + "' ";
                        }
                        else if (dtDNS_DEPARTMENTCOMPOSE.Rows[i]["SaveMode"].ToString() == "Add")
                        {
                            lvStrSql = "INSERT INTO Dept (IID, CtrlCode, Code, EnglishName, LocalName) ";
                            lvStrSql += "VALUES ('" + dtDNS_DEPARTMENTCOMPOSE.Rows[i]["IID"].ToString() + "', '" + dtDNS_DEPARTMENTCOMPOSE.Rows[i]["CtrlCode"].ToString() + "', '" + dtDNS_DEPARTMENTCOMPOSE.Rows[i]["Code"].ToString() + "', '" + dtDNS_DEPARTMENTCOMPOSE.Rows[i]["EnglishName"].ToString() + "', '" + dtDNS_DEPARTMENTCOMPOSE.Rows[i]["LocalName"].ToString() + "' ) ";
                        }

                        csExecuteNonQuerySQL(lvStrSql, connSQL, tr1);
                    }
                }

                tr1.Commit();
                com1.Dispose();
            }
            catch (Exception)
            {
                tr1.Rollback();
                com1.Dispose();
            }

            connSQL.Close();
            connSQL.Dispose();

            MessageBox.Show("Save data complete. '" + cntEffect + "' rows ", "Information", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            fncLoadData();
        }

        private void btnSyncData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm to sync data ..."
                , "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            fncSyncData();
        }

        private void gridViewDepartment_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnSetConnection_Click(object sender, EventArgs e)
        {
            frmConnection frm = new frmConnection();
            frm.ShowDialog();

            gServer.LoadConfig_1();
            gServer.LoadConfig_2();
            gServer.LoadConfig_3();
            fncSet_dtDNS_DEPARTMENTCOMPOSE();

            gridContDepartment.DataSource = null;
            dtDNS_DEPARTMENTCOMPOSE.Rows.Clear();
        }
    }
}
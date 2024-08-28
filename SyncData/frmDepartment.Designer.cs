
namespace SyncData
{
    partial class frmDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridContDepartment = new DevExpress.XtraGrid.GridControl();
            this.gridViewDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CtrlCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaveMode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.btnSyncData = new DevExpress.XtraEditors.SimpleButton();
            this.btnSetConnection = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // gridContDepartment
            // 
            this.gridContDepartment.Location = new System.Drawing.Point(27, 33);
            this.gridContDepartment.MainView = this.gridViewDepartment;
            this.gridContDepartment.Name = "gridContDepartment";
            this.gridContDepartment.Size = new System.Drawing.Size(1306, 593);
            this.gridContDepartment.TabIndex = 0;
            this.gridContDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDepartment});
            // 
            // gridViewDepartment
            // 
            this.gridViewDepartment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IID,
            this.CtrlCode,
            this.Code,
            this.LocalName,
            this.SaveMode});
            this.gridViewDepartment.GridControl = this.gridContDepartment;
            this.gridViewDepartment.IndicatorWidth = 35;
            this.gridViewDepartment.Name = "gridViewDepartment";
            this.gridViewDepartment.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewDepartment_CustomDrawRowIndicator);
            // 
            // IID
            // 
            this.IID.Caption = "IID";
            this.IID.FieldName = "IID";
            this.IID.MinWidth = 25;
            this.IID.Name = "IID";
            this.IID.Visible = true;
            this.IID.VisibleIndex = 0;
            this.IID.Width = 94;
            // 
            // CtrlCode
            // 
            this.CtrlCode.Caption = "CtrlCode";
            this.CtrlCode.FieldName = "CtrlCode";
            this.CtrlCode.MinWidth = 25;
            this.CtrlCode.Name = "CtrlCode";
            this.CtrlCode.Visible = true;
            this.CtrlCode.VisibleIndex = 1;
            this.CtrlCode.Width = 94;
            // 
            // Code
            // 
            this.Code.Caption = "Code";
            this.Code.FieldName = "Code";
            this.Code.MinWidth = 25;
            this.Code.Name = "Code";
            this.Code.Visible = true;
            this.Code.VisibleIndex = 2;
            this.Code.Width = 94;
            // 
            // LocalName
            // 
            this.LocalName.Caption = "LocalName";
            this.LocalName.FieldName = "LocalName";
            this.LocalName.MinWidth = 25;
            this.LocalName.Name = "LocalName";
            this.LocalName.Visible = true;
            this.LocalName.VisibleIndex = 3;
            this.LocalName.Width = 94;
            // 
            // SaveMode
            // 
            this.SaveMode.Caption = "SaveMode";
            this.SaveMode.FieldName = "SaveMode";
            this.SaveMode.MinWidth = 25;
            this.SaveMode.Name = "SaveMode";
            this.SaveMode.Visible = true;
            this.SaveMode.VisibleIndex = 4;
            this.SaveMode.Width = 94;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(1129, 643);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(94, 29);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnSyncData
            // 
            this.btnSyncData.Location = new System.Drawing.Point(1240, 643);
            this.btnSyncData.Name = "btnSyncData";
            this.btnSyncData.Size = new System.Drawing.Size(94, 29);
            this.btnSyncData.TabIndex = 2;
            this.btnSyncData.Text = "Sync Data";
            this.btnSyncData.Click += new System.EventHandler(this.btnSyncData_Click);
            // 
            // btnSetConnection
            // 
            this.btnSetConnection.Location = new System.Drawing.Point(27, 643);
            this.btnSetConnection.Name = "btnSetConnection";
            this.btnSetConnection.Size = new System.Drawing.Size(130, 29);
            this.btnSetConnection.TabIndex = 3;
            this.btnSetConnection.Text = "Set Connection";
            this.btnSetConnection.Click += new System.EventHandler(this.btnSetConnection_Click);
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 713);
            this.Controls.Add(this.btnSetConnection);
            this.Controls.Add(this.btnSyncData);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.gridContDepartment);
            this.Name = "frmDepartment";
            this.Text = "frmDepartment";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridContDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn IID;
        private DevExpress.XtraGrid.Columns.GridColumn CtrlCode;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn LocalName;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
        private DevExpress.XtraEditors.SimpleButton btnSyncData;
        private DevExpress.XtraGrid.Columns.GridColumn SaveMode;
        private DevExpress.XtraEditors.SimpleButton btnSetConnection;
    }
}
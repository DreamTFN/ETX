namespace ETX.Forms
{
    partial class frm_Islemler
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
            components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Islemler));
            search_sidePanel = new DevExpress.XtraEditors.SidePanel();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            label1 = new System.Windows.Forms.Label();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            search_Button = new DevExpress.XtraEditors.SimpleButton();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            openclose_Button = new DevExpress.XtraEditors.SimpleButton();
            sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(components);
            yeni_Button = new DevExpress.XtraEditors.SimpleButton();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            search_sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // search_sidePanel
            // 
            search_sidePanel.Controls.Add(groupControl2);
            search_sidePanel.Controls.Add(groupControl1);
            search_sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            search_sidePanel.Location = new System.Drawing.Point(834, 0);
            search_sidePanel.Margin = new System.Windows.Forms.Padding(4);
            search_sidePanel.Name = "search_sidePanel";
            search_sidePanel.Size = new System.Drawing.Size(300, 690);
            search_sidePanel.TabIndex = 2;
            // 
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            groupControl2.Controls.Add(label3);
            groupControl2.Controls.Add(label2);
            groupControl2.Controls.Add(textEdit2);
            groupControl2.Controls.Add(label1);
            groupControl2.Controls.Add(textEdit1);
            groupControl2.Controls.Add(search_Button);
            groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl2.Location = new System.Drawing.Point(45, 0);
            groupControl2.Margin = new System.Windows.Forms.Padding(4);
            groupControl2.Name = "groupControl2";
            groupControl2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            groupControl2.Size = new System.Drawing.Size(255, 690);
            groupControl2.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Silver;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(2, 0);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(251, 32);
            label3.TabIndex = 0;
            label3.Text = "Arama Kriterleri";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 538);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 19);
            label2.TabIndex = 8;
            label2.Text = "Adı";
            // 
            // textEdit2
            // 
            textEdit2.Location = new System.Drawing.Point(49, 533);
            textEdit2.Margin = new System.Windows.Forms.Padding(4);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new System.Drawing.Size(198, 26);
            textEdit2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 571);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 19);
            label1.TabIndex = 6;
            label1.Text = "Adı";
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(6, 599);
            textEdit1.Margin = new System.Windows.Forms.Padding(4);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(242, 26);
            textEdit1.TabIndex = 5;
            // 
            // search_Button
            // 
            search_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            search_Button.ImageOptions.Image = Properties.Resources.zoom_16x161;
            search_Button.Location = new System.Drawing.Point(2, 652);
            search_Button.Margin = new System.Windows.Forms.Padding(4);
            search_Button.Name = "search_Button";
            search_Button.Size = new System.Drawing.Size(251, 38);
            search_Button.TabIndex = 4;
            search_Button.Text = "Ara";
            // 
            // groupControl1
            // 
            groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            groupControl1.Controls.Add(pictureBox1);
            groupControl1.Controls.Add(openclose_Button);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            groupControl1.Location = new System.Drawing.Point(1, 0);
            groupControl1.Margin = new System.Windows.Forms.Padding(4);
            groupControl1.Name = "groupControl1";
            groupControl1.ShowCaption = false;
            groupControl1.Size = new System.Drawing.Size(44, 690);
            groupControl1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.arama_kriterleri;
            pictureBox1.Location = new System.Drawing.Point(2, 37);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(34, 122);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // openclose_Button
            // 
            openclose_Button.Dock = System.Windows.Forms.DockStyle.Top;
            openclose_Button.ImageOptions.Image = Properties.Resources.next_16x16;
            openclose_Button.Location = new System.Drawing.Point(0, 0);
            openclose_Button.Margin = new System.Windows.Forms.Padding(4);
            openclose_Button.Name = "openclose_Button";
            openclose_Button.Size = new System.Drawing.Size(44, 32);
            openclose_Button.TabIndex = 4;
            openclose_Button.Click += openclose_Button_Click;
            // 
            // sqlDataSource1
            // 
            sqlDataSource1.ConnectionName = "laptop-bgqe2alt.Activity.dbo";
            sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select * from StockCard";
            sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] { customSqlQuery1 });
            sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // yeni_Button
            // 
            yeni_Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            yeni_Button.ImageOptions.Image = Properties.Resources.addfile_16x161;
            yeni_Button.Location = new System.Drawing.Point(8, 2);
            yeni_Button.Margin = new System.Windows.Forms.Padding(4);
            yeni_Button.Name = "yeni_Button";
            yeni_Button.Size = new System.Drawing.Size(99, 35);
            yeni_Button.TabIndex = 7;
            yeni_Button.Text = "Yeni";
            yeni_Button.Click += simpleButton1_Click;
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(simpleButton2);
            groupControl3.Controls.Add(yeni_Button);
            groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupControl3.Location = new System.Drawing.Point(0, 650);
            groupControl3.Name = "groupControl3";
            groupControl3.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            groupControl3.ShowCaption = false;
            groupControl3.Size = new System.Drawing.Size(834, 40);
            groupControl3.TabIndex = 8;
            // 
            // simpleButton2
            // 
            simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            simpleButton2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton2.ImageOptions.Image");
            simpleButton2.Location = new System.Drawing.Point(115, 2);
            simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(198, 35);
            simpleButton2.TabIndex = 8;
            simpleButton2.Text = "İşlem Şablonları";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // gridControl
            // 
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridControl.Location = new System.Drawing.Point(0, 0);
            gridControl.MainView = gridView1;
            gridControl.Margin = new System.Windows.Forms.Padding(4);
            gridControl.Name = "gridControl";
            gridControl.Size = new System.Drawing.Size(834, 650);
            gridControl.TabIndex = 9;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl.DoubleClick += gridControl_DoubleClick;
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 512;
            gridView1.GridControl = gridControl;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frm_Islemler
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1134, 690);
            Controls.Add(gridControl);
            Controls.Add(groupControl3);
            Controls.Add(search_sidePanel);
            IconOptions.ShowIcon = false;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "frm_Islemler";
            Text = "İşlemler";
            Load += frm_Islemler_Load;
            search_sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SidePanel search_sidePanel;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton search_Button;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton openclose_Button;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.SimpleButton yeni_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
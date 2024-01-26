namespace ETX.Forms
{
    partial class frm_FizikiAlanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FizikiAlanlar));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            kodu_textEdit = new DevExpress.XtraEditors.TextEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            alanadi_textEdit = new DevExpress.XtraEditors.TextEdit();
            fizikialan_gridControl = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kodu_textEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alanadi_textEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fizikialan_gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(kodu_textEdit);
            groupControl1.Controls.Add(simpleButton1);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(alanadi_textEdit);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.ShowCaption = false;
            groupControl1.Size = new System.Drawing.Size(760, 159);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "groupControl1";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(8, 12);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(36, 19);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "Kodu";
            // 
            // kodu_textEdit
            // 
            kodu_textEdit.Location = new System.Drawing.Point(85, 12);
            kodu_textEdit.Name = "kodu_textEdit";
            kodu_textEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            kodu_textEdit.Properties.Appearance.Options.UseFont = true;
            kodu_textEdit.Properties.MaxLength = 20;
            kodu_textEdit.Size = new System.Drawing.Size(643, 30);
            kodu_textEdit.TabIndex = 7;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(560, 110);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(168, 30);
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "Ekle";
            simpleButton1.Click += simpleButton1_Click_1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(8, 52);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(61, 19);
            labelControl1.TabIndex = 5;
            labelControl1.Text = "Alan Adı";
            // 
            // alanadi_textEdit
            // 
            alanadi_textEdit.Location = new System.Drawing.Point(85, 52);
            alanadi_textEdit.Name = "alanadi_textEdit";
            alanadi_textEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            alanadi_textEdit.Properties.Appearance.Options.UseFont = true;
            alanadi_textEdit.Properties.MaxLength = 150;
            alanadi_textEdit.Size = new System.Drawing.Size(643, 30);
            alanadi_textEdit.TabIndex = 4;
            // 
            // fizikialan_gridControl
            // 
            fizikialan_gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            fizikialan_gridControl.Location = new System.Drawing.Point(0, 159);
            fizikialan_gridControl.MainView = gridView1;
            fizikialan_gridControl.Name = "fizikialan_gridControl";
            fizikialan_gridControl.Size = new System.Drawing.Size(760, 531);
            fizikialan_gridControl.TabIndex = 5;
            fizikialan_gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = fizikialan_gridControl;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frm_FizikiAlanlar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(760, 690);
            Controls.Add(fizikialan_gridControl);
            Controls.Add(groupControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_FizikiAlanlar";
            Text = "Fiziki Alanlar";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kodu_textEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)alanadi_textEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fizikialan_gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit alanadi_textEdit;
        private DevExpress.XtraGrid.GridControl fizikialan_gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit kodu_textEdit;
    }
}
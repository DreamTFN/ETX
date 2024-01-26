namespace ETX.Forms
{
    partial class frm_Islemler_Edit_SablonListesi_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Islemler_Edit_SablonListesi_Edit));
            treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            islemadi_textBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tur_lookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            islemkodu_textBox = new System.Windows.Forms.TextBox();
            exp_memoEdit = new DevExpress.XtraEditors.MemoEdit();
            kaydet_Button = new DevExpress.XtraEditors.SimpleButton();
            sil_Button = new DevExpress.XtraEditors.SimpleButton();
            islemler_groupControl = new DevExpress.XtraEditors.GroupControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            islemekle_Button = new DevExpress.XtraEditors.SimpleButton();
            kaldir_Button = new DevExpress.XtraEditors.SimpleButton();
            save_Button = new DevExpress.XtraEditors.SimpleButton();
            delete_Button = new DevExpress.XtraEditors.SimpleButton();
            treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tur_lookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exp_memoEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemler_groupControl).BeginInit();
            islemler_groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            SuspendLayout();
            // 
            // treeListColumn1
            // 
            treeListColumn1.Caption = "İşlem Bilgisi";
            treeListColumn1.FieldName = "İşlem Bilgisi";
            treeListColumn1.Name = "treeListColumn1";
            treeListColumn1.Visible = true;
            treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn3
            // 
            treeListColumn3.Caption = "treeListColumn3";
            treeListColumn3.FieldName = "treeListColumn3";
            treeListColumn3.Name = "treeListColumn3";
            treeListColumn3.Visible = true;
            treeListColumn3.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(groupControl1);
            panelControl1.Controls.Add(kaydet_Button);
            panelControl1.Controls.Add(sil_Button);
            panelControl1.Controls.Add(islemler_groupControl);
            panelControl1.Controls.Add(save_Button);
            panelControl1.Controls.Add(delete_Button);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Margin = new System.Windows.Forms.Padding(4);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1869, 989);
            panelControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(label4);
            groupControl1.Controls.Add(label3);
            groupControl1.Controls.Add(label2);
            groupControl1.Controls.Add(islemadi_textBox);
            groupControl1.Controls.Add(label1);
            groupControl1.Controls.Add(tur_lookUpEdit);
            groupControl1.Controls.Add(islemkodu_textBox);
            groupControl1.Controls.Add(exp_memoEdit);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            groupControl1.Location = new System.Drawing.Point(2, 2);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(1865, 207);
            groupControl1.TabIndex = 14;
            groupControl1.Text = "Şablon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(975, 52);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 19);
            label4.TabIndex = 27;
            label4.Text = "Açıklama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 154);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 19);
            label3.TabIndex = 26;
            label3.Text = "Bağlı Tür";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 101);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 19);
            label2.TabIndex = 25;
            label2.Text = "Şablon Adı";
            // 
            // islemadi_textBox
            // 
            islemadi_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            islemadi_textBox.Location = new System.Drawing.Point(152, 94);
            islemadi_textBox.Margin = new System.Windows.Forms.Padding(4);
            islemadi_textBox.MaxLength = 150;
            islemadi_textBox.Name = "islemadi_textBox";
            islemadi_textBox.Size = new System.Drawing.Size(740, 32);
            islemadi_textBox.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 19);
            label1.TabIndex = 23;
            label1.Text = "Şablon Kodu";
            // 
            // tur_lookUpEdit
            // 
            tur_lookUpEdit.Location = new System.Drawing.Point(152, 147);
            tur_lookUpEdit.Margin = new System.Windows.Forms.Padding(4);
            tur_lookUpEdit.Name = "tur_lookUpEdit";
            tur_lookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tur_lookUpEdit.Properties.Appearance.Options.UseFont = true;
            tur_lookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tur_lookUpEdit.Properties.NullText = "";
            tur_lookUpEdit.Size = new System.Drawing.Size(740, 30);
            tur_lookUpEdit.TabIndex = 22;
            // 
            // islemkodu_textBox
            // 
            islemkodu_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            islemkodu_textBox.Location = new System.Drawing.Point(152, 45);
            islemkodu_textBox.Margin = new System.Windows.Forms.Padding(4);
            islemkodu_textBox.MaxLength = 20;
            islemkodu_textBox.Name = "islemkodu_textBox";
            islemkodu_textBox.Size = new System.Drawing.Size(740, 32);
            islemkodu_textBox.TabIndex = 20;
            // 
            // exp_memoEdit
            // 
            exp_memoEdit.Location = new System.Drawing.Point(1077, 44);
            exp_memoEdit.Margin = new System.Windows.Forms.Padding(4);
            exp_memoEdit.Name = "exp_memoEdit";
            exp_memoEdit.Properties.MaxLength = 250;
            exp_memoEdit.Size = new System.Drawing.Size(777, 133);
            exp_memoEdit.TabIndex = 21;
            // 
            // kaydet_Button
            // 
            kaydet_Button.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("kaydet_Button.ImageOptions.Image");
            kaydet_Button.Location = new System.Drawing.Point(1688, 215);
            kaydet_Button.Name = "kaydet_Button";
            kaydet_Button.Size = new System.Drawing.Size(168, 40);
            kaydet_Button.TabIndex = 13;
            kaydet_Button.Text = "Kaydet";
            kaydet_Button.Click += kaydet_Button_Click;
            // 
            // sil_Button
            // 
            sil_Button.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("sil_Button.ImageOptions.Image");
            sil_Button.Location = new System.Drawing.Point(1514, 215);
            sil_Button.Name = "sil_Button";
            sil_Button.Size = new System.Drawing.Size(168, 40);
            sil_Button.TabIndex = 12;
            sil_Button.Text = "Sil";
            sil_Button.Click += sil_Button_Click;
            // 
            // islemler_groupControl
            // 
            islemler_groupControl.Controls.Add(gridControl1);
            islemler_groupControl.Controls.Add(panelControl3);
            islemler_groupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            islemler_groupControl.Location = new System.Drawing.Point(2, 279);
            islemler_groupControl.Name = "islemler_groupControl";
            islemler_groupControl.Size = new System.Drawing.Size(1865, 708);
            islemler_groupControl.TabIndex = 11;
            islemler_groupControl.Text = "İşlemler";
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridControl1.Location = new System.Drawing.Point(2, 34);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new System.Windows.Forms.Padding(4);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1861, 616);
            gridControl1.TabIndex = 3;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 512;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(islemekle_Button);
            panelControl3.Controls.Add(kaldir_Button);
            panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl3.Location = new System.Drawing.Point(2, 650);
            panelControl3.Margin = new System.Windows.Forms.Padding(4);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new System.Drawing.Size(1861, 56);
            panelControl3.TabIndex = 1;
            // 
            // islemekle_Button
            // 
            islemekle_Button.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("islemekle_Button.ImageOptions.Image");
            islemekle_Button.Location = new System.Drawing.Point(1684, 8);
            islemekle_Button.Name = "islemekle_Button";
            islemekle_Button.Size = new System.Drawing.Size(168, 40);
            islemekle_Button.TabIndex = 15;
            islemekle_Button.Text = "İşlem Ekle";
            // 
            // kaldir_Button
            // 
            kaldir_Button.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("kaldir_Button.ImageOptions.Image");
            kaldir_Button.Location = new System.Drawing.Point(1510, 8);
            kaldir_Button.Name = "kaldir_Button";
            kaldir_Button.Size = new System.Drawing.Size(168, 40);
            kaldir_Button.TabIndex = 14;
            kaldir_Button.Text = "Kaldır";
            // 
            // save_Button
            // 
            save_Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            save_Button.ImageOptions.Image = Properties.Resources.apply_16x161;
            save_Button.Location = new System.Drawing.Point(3094, 362);
            save_Button.Margin = new System.Windows.Forms.Padding(4);
            save_Button.Name = "save_Button";
            save_Button.Size = new System.Drawing.Size(138, 34);
            save_Button.TabIndex = 9;
            save_Button.Text = "Kaydet";
            // 
            // delete_Button
            // 
            delete_Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            delete_Button.ImageOptions.Image = Properties.Resources.cancel_16x161;
            delete_Button.Location = new System.Drawing.Point(2952, 362);
            delete_Button.Margin = new System.Windows.Forms.Padding(4);
            delete_Button.Name = "delete_Button";
            delete_Button.Size = new System.Drawing.Size(138, 34);
            delete_Button.TabIndex = 10;
            delete_Button.Text = "Sil";
            // 
            // treeListColumn2
            // 
            treeListColumn2.Caption = "treeListColumn2";
            treeListColumn2.FieldName = "treeListColumn2";
            treeListColumn2.Name = "treeListColumn2";
            treeListColumn2.Visible = true;
            treeListColumn2.VisibleIndex = 1;
            // 
            // frm_Islemler_Edit_SablonListesi_Edit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1869, 989);
            Controls.Add(panelControl1);
            IconOptions.ShowIcon = false;
            Name = "frm_Islemler_Edit_SablonListesi_Edit";
            Text = "İşlem Şablonları";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tur_lookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)exp_memoEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemler_groupControl).EndInit();
            islemler_groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl islemler_groupControl;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton save_Button;
        private DevExpress.XtraEditors.SimpleButton delete_Button;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.SimpleButton kaydet_Button;
        private DevExpress.XtraEditors.SimpleButton sil_Button;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit tur_lookUpEdit;
        private System.Windows.Forms.TextBox islemkodu_textBox;
        private DevExpress.XtraEditors.MemoEdit exp_memoEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox islemadi_textBox;
        private DevExpress.XtraEditors.SimpleButton islemekle_Button;
        private DevExpress.XtraEditors.SimpleButton kaldir_Button;
    }
}
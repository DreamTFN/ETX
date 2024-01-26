namespace ETX.Forms
{
    partial class frm_Anlasmalar_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Anlasmalar_Edit));
            tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            label4 = new System.Windows.Forms.Label();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            sil_Button = new DevExpress.XtraEditors.SimpleButton();
            kaydet_Button = new DevExpress.XtraEditors.SimpleButton();
            label3 = new System.Windows.Forms.Label();
            durum_gridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            label2 = new System.Windows.Forms.Label();
            islemadi_textBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            islemkodu_textBox = new System.Windows.Forms.TextBox();
            tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            islemler_gridControl = new DevExpress.XtraGrid.GridControl();
            islemler_gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            info_Button = new DevExpress.XtraEditors.SimpleButton();
            kaldir_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            formula_memoEdit = new DevExpress.XtraEditors.MemoEdit();
            stockcardcode_textBox = new System.Windows.Forms.TextBox();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ekle_Button = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)tabPane1).BeginInit();
            tabPane1.SuspendLayout();
            tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)durum_gridLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)islemler_gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemler_gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)formula_memoEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // tabPane1
            // 
            tabPane1.Controls.Add(tabNavigationPage1);
            tabPane1.Controls.Add(tabNavigationPage2);
            tabPane1.Dock = System.Windows.Forms.DockStyle.Top;
            tabPane1.Location = new System.Drawing.Point(0, 0);
            tabPane1.Name = "tabPane1";
            tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { tabNavigationPage1, tabNavigationPage2 });
            tabPane1.RegularSize = new System.Drawing.Size(1279, 694);
            tabPane1.SelectedPage = tabNavigationPage1;
            tabPane1.Size = new System.Drawing.Size(1279, 694);
            tabPane1.TabIndex = 4;
            tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            tabNavigationPage1.Caption = "Anlaşma Tanımı";
            tabNavigationPage1.Controls.Add(groupControl1);
            tabNavigationPage1.Name = "tabNavigationPage1";
            tabNavigationPage1.Size = new System.Drawing.Size(1279, 645);
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(label4);
            groupControl1.Controls.Add(memoEdit1);
            groupControl1.Controls.Add(sil_Button);
            groupControl1.Controls.Add(kaydet_Button);
            groupControl1.Controls.Add(label3);
            groupControl1.Controls.Add(durum_gridLookUpEdit);
            groupControl1.Controls.Add(label2);
            groupControl1.Controls.Add(islemadi_textBox);
            groupControl1.Controls.Add(label1);
            groupControl1.Controls.Add(islemkodu_textBox);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.ShowCaption = false;
            groupControl1.Size = new System.Drawing.Size(1279, 645);
            groupControl1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 167);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 19);
            label4.TabIndex = 9;
            label4.Text = "Açıklama";
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new System.Drawing.Point(152, 165);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new System.Drawing.Size(1066, 387);
            memoEdit1.TabIndex = 8;
            // 
            // sil_Button
            // 
            sil_Button.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("sil_Button.ImageOptions.Image");
            sil_Button.Location = new System.Drawing.Point(854, 576);
            sil_Button.Name = "sil_Button";
            sil_Button.Size = new System.Drawing.Size(168, 34);
            sil_Button.TabIndex = 7;
            sil_Button.Text = "Sil";
            sil_Button.Click += sil_Button_Click;
            // 
            // kaydet_Button
            // 
            kaydet_Button.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("kaydet_Button.ImageOptions.Image");
            kaydet_Button.Location = new System.Drawing.Point(1050, 576);
            kaydet_Button.Name = "kaydet_Button";
            kaydet_Button.Size = new System.Drawing.Size(168, 34);
            kaydet_Button.TabIndex = 6;
            kaydet_Button.Text = "Kaydet";
            kaydet_Button.Click += kaydet_Button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 33);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 19);
            label3.TabIndex = 5;
            label3.Text = "Durum";
            // 
            // durum_gridLookUpEdit
            // 
            durum_gridLookUpEdit.Location = new System.Drawing.Point(152, 26);
            durum_gridLookUpEdit.Name = "durum_gridLookUpEdit";
            durum_gridLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            durum_gridLookUpEdit.Properties.Appearance.Options.UseFont = true;
            durum_gridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            durum_gridLookUpEdit.Properties.NullText = "";
            durum_gridLookUpEdit.Properties.PopupView = gridLookUpEdit1View;
            durum_gridLookUpEdit.Size = new System.Drawing.Size(1066, 30);
            durum_gridLookUpEdit.TabIndex = 4;
            // 
            // gridLookUpEdit1View
            // 
            gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 123);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 19);
            label2.TabIndex = 3;
            label2.Text = "Anlaşma Adı";
            // 
            // islemadi_textBox
            // 
            islemadi_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            islemadi_textBox.Location = new System.Drawing.Point(152, 116);
            islemadi_textBox.MaxLength = 150;
            islemadi_textBox.Name = "islemadi_textBox";
            islemadi_textBox.Size = new System.Drawing.Size(1066, 32);
            islemadi_textBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 76);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 19);
            label1.TabIndex = 1;
            label1.Text = "Anlaşma Kodu";
            // 
            // islemkodu_textBox
            // 
            islemkodu_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            islemkodu_textBox.Location = new System.Drawing.Point(152, 69);
            islemkodu_textBox.MaxLength = 20;
            islemkodu_textBox.Name = "islemkodu_textBox";
            islemkodu_textBox.Size = new System.Drawing.Size(1066, 32);
            islemkodu_textBox.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            tabNavigationPage2.Caption = "İşlemler";
            tabNavigationPage2.Controls.Add(groupControl2);
            tabNavigationPage2.Name = "tabNavigationPage2";
            tabNavigationPage2.Size = new System.Drawing.Size(1279, 645);
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(islemler_gridControl);
            groupControl2.Controls.Add(groupControl3);
            groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl2.Location = new System.Drawing.Point(0, 0);
            groupControl2.Name = "groupControl2";
            groupControl2.ShowCaption = false;
            groupControl2.Size = new System.Drawing.Size(1279, 645);
            groupControl2.TabIndex = 4;
            // 
            // islemler_gridControl
            // 
            islemler_gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            islemler_gridControl.Location = new System.Drawing.Point(2, 244);
            islemler_gridControl.MainView = islemler_gridView;
            islemler_gridControl.Name = "islemler_gridControl";
            islemler_gridControl.Size = new System.Drawing.Size(1275, 399);
            islemler_gridControl.TabIndex = 10;
            islemler_gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { islemler_gridView });
            // 
            // islemler_gridView
            // 
            islemler_gridView.GridControl = islemler_gridControl;
            islemler_gridView.Name = "islemler_gridView";
            islemler_gridView.OptionsView.ShowAutoFilterRow = true;
            islemler_gridView.OptionsView.ShowFooter = true;
            islemler_gridView.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(info_Button);
            groupControl3.Controls.Add(kaldir_simpleButton);
            groupControl3.Controls.Add(formula_memoEdit);
            groupControl3.Controls.Add(stockcardcode_textBox);
            groupControl3.Controls.Add(labelControl2);
            groupControl3.Controls.Add(labelControl1);
            groupControl3.Controls.Add(ekle_Button);
            groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            groupControl3.Location = new System.Drawing.Point(2, 2);
            groupControl3.Name = "groupControl3";
            groupControl3.ShowCaption = false;
            groupControl3.Size = new System.Drawing.Size(1275, 242);
            groupControl3.TabIndex = 8;
            // 
            // info_Button
            // 
            info_Button.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("info_Button.ImageOptions.Image");
            info_Button.Location = new System.Drawing.Point(1234, 21);
            info_Button.Name = "info_Button";
            info_Button.Size = new System.Drawing.Size(31, 30);
            info_Button.TabIndex = 17;
            info_Button.Click += info_Button_Click;
            // 
            // kaldir_simpleButton
            // 
            kaldir_simpleButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("kaldir_simpleButton.ImageOptions.Image");
            kaldir_simpleButton.Location = new System.Drawing.Point(852, 195);
            kaldir_simpleButton.Name = "kaldir_simpleButton";
            kaldir_simpleButton.Size = new System.Drawing.Size(168, 30);
            kaldir_simpleButton.TabIndex = 16;
            kaldir_simpleButton.Text = "Kaldır";
            kaldir_simpleButton.Click += kaldir_simpleButton_Click;
            // 
            // formula_memoEdit
            // 
            formula_memoEdit.Location = new System.Drawing.Point(190, 60);
            formula_memoEdit.Name = "formula_memoEdit";
            formula_memoEdit.Size = new System.Drawing.Size(1026, 112);
            formula_memoEdit.TabIndex = 15;
            // 
            // stockcardcode_textBox
            // 
            stockcardcode_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            stockcardcode_textBox.Location = new System.Drawing.Point(190, 19);
            stockcardcode_textBox.MaxLength = 20;
            stockcardcode_textBox.Name = "stockcardcode_textBox";
            stockcardcode_textBox.Size = new System.Drawing.Size(1026, 32);
            stockcardcode_textBox.TabIndex = 14;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(10, 62);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(107, 19);
            labelControl2.TabIndex = 12;
            labelControl2.Text = "Miktar Formülü";
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(10, 26);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(80, 19);
            labelControl1.TabIndex = 11;
            labelControl1.Text = "İşlem Kodu";
            // 
            // ekle_Button
            // 
            ekle_Button.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("ekle_Button.ImageOptions.Image");
            ekle_Button.Location = new System.Drawing.Point(1048, 195);
            ekle_Button.Name = "ekle_Button";
            ekle_Button.Size = new System.Drawing.Size(168, 30);
            ekle_Button.TabIndex = 8;
            ekle_Button.Text = "Ekle";
            ekle_Button.Click += ekle_Button_Click;
            // 
            // frm_Anlasmalar_Edit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1279, 696);
            Controls.Add(tabPane1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_Anlasmalar_Edit";
            Text = " Anlaşmalar";
            ((System.ComponentModel.ISupportInitialize)tabPane1).EndInit();
            tabPane1.ResumeLayout(false);
            tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)durum_gridLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)islemler_gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemler_gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)formula_memoEdit.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sil_Button;
        private DevExpress.XtraEditors.SimpleButton kaydet_Button;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GridLookUpEdit durum_gridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox islemadi_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox islemkodu_textBox;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl islemler_gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView islemler_gridView;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton kaldir_simpleButton;
        private DevExpress.XtraEditors.MemoEdit formula_memoEdit;
        private System.Windows.Forms.TextBox stockcardcode_textBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton ekle_Button;
        private DevExpress.XtraEditors.SimpleButton info_Button;
    }
}
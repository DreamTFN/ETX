namespace ETX.Forms
{
    partial class frm_Anlasmalar_Edit_Ornek
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
            formula_memoEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)formula_memoEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // formula_memoEdit
            // 
            formula_memoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            formula_memoEdit.EditValue = "";
            formula_memoEdit.Location = new System.Drawing.Point(0, 0);
            formula_memoEdit.Name = "formula_memoEdit";
            formula_memoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            formula_memoEdit.Properties.Appearance.Options.UseFont = true;
            formula_memoEdit.Properties.ReadOnly = true;
            formula_memoEdit.Size = new System.Drawing.Size(1446, 616);
            formula_memoEdit.TabIndex = 16;
            // 
            // frm_Anlasmalar_Edit_Ornek
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1446, 616);
            Controls.Add(formula_memoEdit);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_Anlasmalar_Edit_Ornek";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Anlasmalar Örnek Formül";
            ((System.ComponentModel.ISupportInitialize)formula_memoEdit.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit formula_memoEdit;
    }
}
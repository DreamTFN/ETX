using DevExpress.XtraEditors;
using ETX.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETX.Entities;

namespace ETX.Forms
{
    public partial class frm_FizikiAlanlar : DevExpress.XtraEditors.XtraForm
    {
        public frm_FizikiAlanlar()
        {
            InitializeComponent();

            SearchPanelShrink(1);

            Fill_Gridview();
        }

        public void SearchPanelShrink(int Start)
        {
            /*
            if (search2_sidePanel.Size.Width >= 30 || Start == 1)
            {
                search_sidePanel.Size = new System.Drawing.Size(20, search_sidePanel.Size.Height);
                openclose_Button.ImageOptions.Image = Properties.Resources.prev_16x16;
            }
            else
            {
                search_sidePanel.Size = new System.Drawing.Size(200, search_sidePanel.Size.Height);
                openclose_Button.ImageOptions.Image = Properties.Resources.next_16x16;
            }
            */
        }


        private void openclose_Button_Click(object sender, EventArgs e)
        {
            SearchPanelShrink(0);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            using (var context = new Context.EtxContext())
            {
                Hall hl = new Hall();

                if (alanadi_textEdit.Text.Length > 0 && kodu_textEdit.Text.Length > 0)
                {
                    hl.Code = kodu_textEdit.Text;
                    hl.Name = alanadi_textEdit.Text;
                    hl.InsertUser = (short)Tools.user_ID;
                    context.Add(hl);
                    int rtn = context.SaveChanges();

                    if (rtn > 0) { Fill_Gridview(); }
                    else { MessageBox.Show("İşlem başarısız. Lütfen tekrar deneyin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("İşlem başarısız. Lütfen alan adı alanını doldurun !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
        }



        private void Fill_Gridview()
        {

            using (var context = new Context.EtxContext())
            {
                var list = (from hl in context.Halls
                            //where hl.Active == true
                            .OrderBy(hl => hl.Active)
                            .OrderBy(hl => hl.Name)
                            select new
                            {
                                ID = hl.Id,
                                Kodu = hl.Code,
                                Adı = hl.Name,
                                Aktif = hl.Active,
                            }).ToList();
                fizikialan_gridControl.DataSource = list;
            }

        }
    }
}
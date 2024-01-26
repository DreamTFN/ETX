using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ETX.Forms
{
    public partial class frm_Deneme : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_Deneme()
        {
            InitializeComponent();
            SearchPanelShrink(1);
        }

        public void SearchPanelShrink (int Start)
        {
            if (search_sidePanel.Size.Width >= 30 || Start == 1)
            {
                search_sidePanel.Size = new System.Drawing.Size(20, search_sidePanel.Size.Height);
                openclose_Button.ImageOptions.Image = Properties.Resources.prev_16x16;
            }
            else
            {
                search_sidePanel.Size = new System.Drawing.Size(200, search_sidePanel.Size.Height);
                openclose_Button.ImageOptions.Image = Properties.Resources.next_16x16;
            }
        }

        private void openclose_Button_Click(object sender, EventArgs e)
        {
            SearchPanelShrink(0);
        }
    }
}

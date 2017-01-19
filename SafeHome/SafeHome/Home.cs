using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeHome
{
    public partial class Home : Form
    {
        List<Panel> listPanels = new List<Panel>();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            listPanels.Add(pnlHome);
            listPanels.Add(pnlLogin);
            listPanels.Add(pnlViewRooms);
            listPanels.Add(pnlAddRoom);
            setAllPanelsInvisible();
            disableButtons();
            pnlLogin.Visible = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            setAllPanelsInvisible();
            pnlHome.Visible = true;
            enableButtons();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            setAllPanelsInvisible();
            pnlLogin.Visible = true;
            disableButtons();
        }

        public void setAllPanelsInvisible()
        {
            foreach (Panel p in listPanels)
            {
                p.Visible = false;
            }
        }

        public void enableButtons()
        {
            btnHome.Enabled = true;
            btnViewRooms.Enabled = true;
            btnLogout.Enabled = true;
        }

        public void disableButtons()
        {
            btnHome.Enabled = false;
            btnViewRooms.Enabled = false;
            btnLogout.Enabled = false;
        }

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            setAllPanelsInvisible();
            pnlViewRooms.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setAllPanelsInvisible();
            pnlHome.Visible = true;
        }
    }
}

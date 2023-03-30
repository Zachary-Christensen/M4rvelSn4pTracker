using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarvelSnapTracker.Classes;

namespace MarvelSnapTracker
{
    public partial class NewDeckForm : Form
    {

        private NavManager _navManager;

        public NewDeckForm()
        {
            InitializeComponent();
        }

        public NewDeckForm(NavManager navManager) : this()
        {
            _navManager = navManager;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (_navManager != null)
            {
                _navManager.RemoveNewDeckForm();
                _navManager.ShowMainMenu();
            }
        }
    }
}

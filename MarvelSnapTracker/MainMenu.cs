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



// https://stackoverflow.com/questions/3507498/reading-csv-files-using-c-sharp
namespace MarvelSnapTracker
{
    public partial class MainMenu : Form
    {

        private NavManager _navManager;
        public MainMenu()
        {
            InitializeComponent();
            _navManager = new NavManager(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewDeck_Click(object sender, EventArgs e)
        {
            _navManager.ShowNewDeckForm();
            _navManager.CloseMainMenu();
        }
    }
}

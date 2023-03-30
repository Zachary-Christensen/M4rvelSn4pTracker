using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelSnapTracker.Classes
{
    public class NavManager
    {

        private MainMenu _mainMenu;
        private NewDeckForm _newDeckForm;

        public NavManager() { }

        public NavManager(MainMenu mainMenu)
        {
            _mainMenu = mainMenu;
        }


        public void CloseMainMenu()
        {
            if (_mainMenu != null)
            {
                _mainMenu.Hide();
            }
        }

        public void ShowMainMenu()
        {
            if (_mainMenu != null)
            {
                _mainMenu.Show();
            }
        }

        public void RemoveNewDeckForm()
        {
            _newDeckForm = null; // must set to null, otherwise null check won't work and function calls like Show() with cause exceptions
        }

        public void ShowNewDeckForm()
        {
            // if does not exist then create one
            if (_newDeckForm == null)
            {
                _newDeckForm = new NewDeckForm(this);
            }
            _newDeckForm.Show();
        }


    }
}

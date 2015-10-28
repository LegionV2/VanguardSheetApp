using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stat_Sheet
{
    public class FormProvider
    {
        private static Form1 _mainMenu;
        private static Form2 _PerkMenu;

        public static Form1 MainMenu
        {
            get
            {
                if (_mainMenu == null)
                {
                    _mainMenu = new Form1();
                }
                return _mainMenu;
            }
        }
        
        public static Form2 PerkMenu
        {
            get
            {
                if (_PerkMenu == null)
                {
                    _PerkMenu = new Form2();
                }
                return _PerkMenu;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_project
{
    static class Pages
    {

        private static MainPage _mainPage = new MainPage();
        private static SignUp _signUp = new SignUp();
        private static Header _header = new Header();

        public static Header Header
        {
            get
            {
                return _header;
            }
        }

        public static MainPage MainPage
        {
            get
            {
                return _mainPage;
            }
        }
        
        public static SignUp SignUp
        {
            get
            {
                return _signUp;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AnyVocab.Views
{
    public partial class BasePage : Page
    {
        protected Frame frame;

        public BasePage(Frame frame)
        {
            this.frame = frame;
        }
    }
}

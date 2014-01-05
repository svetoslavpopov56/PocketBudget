using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketBudget_desktop.ViewModel
{
    public class AppViewModel
    {
        public DateViewModel CurrentDate { get; set; }
        public AppViewModel()
        {
            this.CurrentDate = new DateViewModel();
        }
    }
}

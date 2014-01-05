using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketBudget_desktop.ViewModel
{
    public class DateViewModel
    {
        public string Today { get; set; }

        public DateViewModel()
        {
            this.Today = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}

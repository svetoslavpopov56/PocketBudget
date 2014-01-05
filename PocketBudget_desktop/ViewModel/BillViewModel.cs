using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketBudget_desktop.ViewModel
{
    public class Bills
    {
        public int BillId { get; set; }
        public string Name { get; set; }
        public double Fee { get; set; }
        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }
        public int HasFixedFee { get; set; }
        public double TotalAmount { get; set; }
        public double MonthlyEarnings { get; set; }

        public Bills(string name, double fee, DateTime firstDay, DateTime secondDay, int hasFixedFee, double totalAmount, double monthlyEarnings)
        {
            this.Name = name;
            this.Fee = fee;
            this.FirstDay = firstDay;
            this.LastDay = secondDay;
            this.HasFixedFee = hasFixedFee;
            this.TotalAmount = totalAmount;
            this.MonthlyEarnings = monthlyEarnings;
        }

        public Bills()
        {
        }

        public void Write()
        {
        }
    }
}

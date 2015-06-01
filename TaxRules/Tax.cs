using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRules
{
    public class Tax
    {
        private ErehwonCitizen _citizen;
        private DateTime _today;

        public decimal Calculate(decimal amountToTax)
        {
            decimal taxAmount = 0;

            if (((_today - _citizen.BirthDate).Days / 365) < 5)
                return taxAmount;

            taxAmount = amountToTax * 0.08m;

            if (_today.DayOfWeek == DayOfWeek.Thursday)
                taxAmount += taxAmount;

            if (_citizen.FirstName.StartsWith("J", StringComparison.InvariantCultureIgnoreCase))
                taxAmount += taxAmount;

            if (_citizen.LastName.StartsWith("W", StringComparison.InvariantCultureIgnoreCase))
                taxAmount -= 1;

            return taxAmount > 0 ? taxAmount : 0;
            //Rules
            //1. On Thursdays, all taxes are doubled - DONE
            //2. If FirstName starts with J, all taxes are doubled - DONE
            //3. If LastName starts with W, subtract a dollar from your tax - DONE
            //4. If less than 5 years old, then you don't have to pay sales tax - DONE
            //5. You can never have a negative tax amount - DONE
            //6. Base tax rate is 8% - DONE
        }

        public Tax(ErehwonCitizen citizen)
        {
            _citizen = citizen;
            _today = DateTime.Now;
        }

        public Tax(ErehwonCitizen citizen, DateTime today)
        {
            _citizen = citizen;
            _today = today;            
        }
    }
}

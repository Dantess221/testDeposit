using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public interface IDepositData
    {
        /// <summary>
        /// Today Date
        /// </summary>
        DateTime DateAgreement { get; set; }
        /// <summary>
        /// Term Data
        /// </summary>
        DateTime DateCalculation { get; set; }
        /// <summary>
        /// Type Capitalization
        /// </summary>
        string TypeCapital { get; set; }
        /// <summary>
        /// Sum Deposit
        /// </summary>
        decimal DepositSum { get; set; }
        /// <summary>
        /// Prosent Deposit
        /// </summary>
        double ProsentDepositR { get; set; }

        decimal SumProsentN { get; set; }
        /// <summary>
        /// Replenishment Deposit
        /// </summary>
        decimal ReplenishmentDeposit { get; set; }
    }
}

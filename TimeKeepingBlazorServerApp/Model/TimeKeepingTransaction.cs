using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeKeepingBlazorServerApp.Model
{
    public class TimeKeepingTransaction
    {
        [Key]
        public int TimeKeepingTransactionId { get; set; }
        

        public EmployeeModel Employee { get; set; }
        [Range(1, Int32.MaxValue, ErrorMessage = "Employee is required.")]
        public int EmployeeId { get; set; }
        

        public TransactionType TransactionType { get; set; }
        [Range(1, Byte.MaxValue, ErrorMessage = "Transaction Type is required.")]
        public int TransactionTypeId { get; set; }
        [Required]
        public DateTime TransactionDateTime { get; set; }

    }
}

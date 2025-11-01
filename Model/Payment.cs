using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestControlUts.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public int ClientId { get; set; }
        public int PackageId { get; set; }
        public string TransactionCode { get; set; }
        public double Price  { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
    }
}

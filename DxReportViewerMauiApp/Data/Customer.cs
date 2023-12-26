using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Sql.DataApi;

namespace DxReportViewerMauiApp.Data {
    public class Customer {
        static List<Customer> currentCustomers = new List<Customer>();

        public static List<Customer> Customers { get { return currentCustomers; } }
        static Customer() {
            currentCustomers.Add(new Customer() {
                Address = "Obere Str. 57",
                City = "Berlin",
                CompanyName = "Alfreds Futterkiste",
                ContactName = "Maria Anders",
                ContactTitle = "Sales Representative",
                Country = "Germany",
                CustomerID = "ALFKI",
                Fax = "030-0076545",
                Phone = "030-0074321",
                PostalCode = "12209"
            });
        }

        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

    }
}

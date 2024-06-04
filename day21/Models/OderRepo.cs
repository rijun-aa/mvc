using System.Data.SqlClient;

namespace day21.Models
{
    public class OderRepo
    {

        SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB;Integrated security=true;initial catalog=CustomerDb");
        List<Customer> Details = new List<Customer>();

        public List<Customer> customerdetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Customertb", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Customer details = new Customer();
                details.custid = Convert.ToInt32(rdr[0]);
                details.custname = Convert.ToString(rdr[1]);
                details.custaddress = Convert.ToString(rdr[2]);
                details.custphone = Convert.ToInt64(rdr[3]);
                Details.Add(details);
            }
            rdr.Close();
            con.Close();
            return Details;
        }
        public Customer GetCustomerById(int custid)
        {
            return customerdetails().FirstOrDefault(e => e.custid == custid);
        }

    }
}

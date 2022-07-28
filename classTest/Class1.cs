using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;




namespace classTestFromDB
{
    public class ClassConsumeFromDB
    {
        

        public DataTable GetData(DateTime from, DateTime tod)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\source\\repos\\WebApplication7\\classTest\\Database1.mdf;Integrated Security=True");

            
            SqlCommand c = new SqlCommand("get_data_to_chart", conn);
            c.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@fromdate", from);
            SqlParameter p2 = new SqlParameter("@todate", tod);

            c.Parameters.Add(p);
            c.Parameters.Add(p2);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = c;
            DataTable dt = new DataTable();

            da.Fill(dt);
            

            return dt;
        }
    }
}

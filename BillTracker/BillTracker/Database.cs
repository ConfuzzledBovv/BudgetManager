using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BillTracker
{
    public class Database
    {

        string constr = @"Data Source = localhost\SQLExpress; Integrated Security = true; database = BillTracker; Trusted_Connection = true";
        string createDatabaseConnection = @"Data Source = localhost\SQLExpress; Integrated Security = true; database = master; Trusted_Connection = true";
        private SqlCommand cmd;
        private SqlConnection con;

        public Database()
        {
            con = new SqlConnection(createDatabaseConnection);
            if (!DoesDatabaseExist())
            {
                Console.WriteLine("Milestone reached");
                con = new SqlConnection(createDatabaseConnection);
                cmd = new SqlCommand("CREATE DATABASE BillTracker ON PRIMARY " +
                    "(NAME = BillTracker_Data, " +
                    "FILENAME = 'C:\\Database\\BillTrackerData.mdf', " +
                    "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                    "LOG ON (NAME = BillTracker_Log, " +
                    "FILENAME = 'C:\\Database\\BillTrackerLog.ldf', " +
                    "SIZE = 1MB, MAXSIZE = 5MB, FILEGROWTH = 10%)", con);
                if(CreateDatabase())
                {
                    Console.WriteLine("Database created successfully");
                }
                if(CreateTables())
                {
                    Console.WriteLine("Tables created successfully");
                }
            }
        }

        private bool CreateDatabase()
        {
            if (ExecuteQuery())
            {
                return true;
            }
            return false;
        }

        private bool CreateTables()
        {
            EstablishSqlConnection();
            cmd = new SqlCommand("If not exists (select name from sysobjects where name = 'MonthlyBills') create table MonthlyBills (ID int primary key identity(1,1), Bill varchar(20) not null, Price numeric(8, 2) not null, DueDate varchar(10) not null, Recurring varchar(5));" +
                "If not exists (select name from sysobjects where name = 'MonthlyFood') create table MonthlyFood (Month varchar(9), Year numeric(4, 0), Spent numeric(8, 2), Remains numeric(8, 2));" +
                "If not exists(select name from sysobjects where name = 'LeftOverMonthly') create table LeftOverMonthly(Month varchar(9), Year numeric(4, 0), Remains numeric(8, 2));" +
                "If not exists (select name from sysobjects where name = 'Budget') create table Budget (VariableName varchar(20), Amount numeric(8, 2))" +
                "insert into Budget values('" + "MonthlyBudget" + "','" + 0 + "')," +
                "('" + "MonthlyFoodBudget" + "','" + 0 + "')," +
                "('" + "FoodRemaining" + "','" + 0 + "')," +
                "('" + "FoodSpent" + "','" + 0 + "')", con);

            if (ExecuteQuery())
            {
                return true;
            }
            return false;
        }

        public bool EmptyBillTable()
        {
            EstablishSqlConnection();
            cmd = new SqlCommand("truncate table MonthlyBills", con);

            if (ExecuteQuery())
            {
                return true;
            }
            return false;
        }

        public bool EmptyFoodBillTable()
        {
            EstablishSqlConnection();
            cmd = new SqlCommand("truncate table MonthlyFood", con);

            if (ExecuteQuery())
            {
                return true;
            }
            return false;
        }

        public bool AddBill(string name, decimal price, string date, bool recurring)
        { 
            EstablishSqlConnection();
            cmd = new SqlCommand("insert into MonthlyBills values('" + name + "','" + price + "','" + date + "','" + recurring + "' )", con);

            if (ExecuteQuery())
            {
                return true;
            }
            return false;
        }

        public bool AddFoodBill(decimal price)
        {
            EstablishSqlConnection();
            cmd = new SqlCommand("update Budget set amount = @value where VariableName = 'FoodSpent'", con);
            cmd.Parameters.AddWithValue("@value", price);

            if (ExecuteQuery())
            {
                return true;
            }
            return false;
        }

        public bool NewMonth(decimal foodSpent, decimal foodRemains, decimal normalBillRemains)
        {
            EstablishSqlConnection();
            cmd = new SqlCommand("insert into MonthlyFood values('" + DateTime.Today.Month + "','" + DateTime.Today.Year + "','" + foodSpent + "','" + foodRemains + "')", con);

            if(ExecuteQuery())
            {
                EstablishSqlConnection();
                cmd = new SqlCommand("insert into LeftOverMonthly values('" + DateTime.Today.Month + "','" + DateTime.Today.Year + "','" + normalBillRemains + "')", con);

                if(ExecuteQuery())
                {
                    AddFoodBill(0);
                    DeleteNoneRecurringBills();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteBill(string id)
        {
            EstablishSqlConnection();
            cmd = new SqlCommand("delete from MonthlyBills where id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);

            if(ExecuteQuery())
            {
                return true;
            }
            return false;
        }
        public bool DeleteNoneRecurringBills()
        {
            EstablishSqlConnection();
            cmd = new SqlCommand("delete from MonthlyBills where Recurring = @value", con);
            cmd.Parameters.AddWithValue("@value", "False");

            if(ExecuteQuery())
            {
                return true;
            }
            return false;
        }

        public bool UpdateDatabase(string id, string bill, string price, string date)
        {
            if (bill == "")
            {
                bill = RetrieveBill(bill, id);
            }
            if(price == "")
            {
                price = RetrievePrice(price, id);
            }
            if (date == "")
            {
                date = RetrieveDate(date, id);
            }

            EstablishSqlConnection();
            cmd = new SqlCommand("update MonthlyBills set Bill = @bill, Price = @price, DueDate = @date where ID = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@bill", bill);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@date", date);

            if (ExecuteQuery() == true)
            {
                return true;
            }
            return false;
        }

        public bool UpdateMonthlyBudgetValue(decimal value)
        {
            EstablishSqlConnection();
            cmd = new SqlCommand("update Budget set Amount = @value where VariableName = 'MonthlyBudget' ", con);
            cmd.Parameters.AddWithValue("@value", value);

            if (ExecuteQuery() == true)
            {
                return true;
            }
            return false;
        }

        public bool UpdateMonthlyFoodBudgetValue(decimal value)
        {
            Console.WriteLine(value);
            EstablishSqlConnection();
            cmd = new SqlCommand("update Budget set Amount = @value where VariableName = 'MonthlyFoodBudget' ", con);
            cmd.Parameters.AddWithValue("@value", value);

            if (ExecuteQuery() == true)
            {
                return true;
            }
            return false;
        }

        private void EstablishSqlConnection()
        {
            con = new SqlConnection(constr);
        }

        private string RetrieveBill(string value, string id)
        {
            EstablishSqlConnection();
            cmd = new SqlCommand("select Bill from MonthlyBills where ID = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            value = DataReader(value, "Bill");

            return value;
        }

        public string RetrieveBudget(string variable)
        {
            string value = "";
            EstablishSqlConnection();
            cmd = new SqlCommand("select Amount from Budget where VariableName = '" + variable + "'", con);
            value = DataReader(value, "Amount");
            return value;
        }

        private string RetrievePrice(string value, string id)
        {
            EstablishSqlConnection();
            cmd = new SqlCommand("select Price from MonthlyBills where ID = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            value = DataReader(value, "Price");

            return value;
        }

        private string RetrieveDate(string value, string id)
        {
            EstablishSqlConnection();
            cmd = new SqlCommand("select DueDate from MonthlyBills where ID = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            value = DataReader(value, "DueDate");

            return value;
        }

        public decimal WorkOutSpentMoney(bool isFood, string name = "")
        {
            string parseVariable;
            EstablishSqlConnection();
            if(isFood)
            {
                cmd = new SqlCommand("select Amount from Budget where VariableName = '" + name + "'", con);
                parseVariable = "Amount";
            }
            else
            {
                cmd = new SqlCommand("select Price from MonthlyBills", con);
                parseVariable = "Price";
            }

            SqlDataReader rdr;
            List<decimal> values = new List<decimal>();
            decimal total = 0;
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString() + cmd.ToString());
            }
            using (rdr = cmd.ExecuteReader())
            {
                while(rdr.Read())
                {
                    decimal.TryParse(rdr[parseVariable].ToString(), out decimal temp);
                    values.Add(temp);
                }
            }

            rdr.Close();
            con.Close();

            foreach(decimal d in values)
            {
                total += d;
            }
            return total;
        }

        private string DataReader(string value, string column)
        {
            ExecuteQuery();
            con.Open();
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while(rdr.Read())
                {
                    value = rdr[column].ToString();
                }
            }
            con.Close();
            return value;
        }

        private bool DoesDatabaseExist()
        {
            bool worked = false;
            using (con)
            {

                con.Open();

                using (cmd = new SqlCommand("SELECT * FROM master.dbo.sysdatabases WHERE name = 'BillTracker'", con))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            Console.WriteLine("Database does exist");
                            worked = true;
                            con.Close();
                        }
                    }
                }
                return worked;
            }
        }

        private bool ExecuteQuery()
        {
            bool worked = false;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Opening Connection");
                worked = true;
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.ToString() + cmd.ToString());
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Closing connection");
                    con.Close();
                }
            }
            return worked;
        }
    }
}

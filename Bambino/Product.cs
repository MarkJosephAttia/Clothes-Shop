using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bambino
{
    public class Product
    {
        public int id { get; set; }
        public string serial { get; set; }
        public string barcode { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public int quantity { get; set; }
        public int soldQuantity { get; set; }
        public double price { get; set; }
        public double actPrice { get; set; }

        public static SqlConnection GetConnection()
        {
            string myconnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Bambino.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(myconnstr);
            return conn;
        }

        public DataTable Select()
        {
            SqlConnection conn = GetConnection();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Products ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                conn.Open();
                adapt.Fill(dt);
            }
            catch (Exception ex)
            { }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable SoldSelect(DateTime from, DateTime to)
        {
            SqlConnection conn = GetConnection();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Sold WHERE DateTime >= @From AND DateTime <= @To";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@From", from);
                cmd.Parameters.AddWithValue("@To", to);
                conn.Open();
                adapt.Fill(dt);
            }
            catch (Exception ex)
            { }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable Delete()
        {
            SqlConnection conn = GetConnection();
            DataTable dt = new DataTable();
            try
            {
                string sql = "DELETE FROM Products WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", this.id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable nameNumSelect()
        {
            SqlConnection conn = GetConnection();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT DISTINCT Name, Serial FROM Products WHERE Name Like N'%" + this.name + "%' AND Serial LIKE '%" + this.serial + "%' AND Quantity <> 0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                conn.Open();
                adapt.Fill(dt);
            }
            catch (Exception ex)
            { }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable nameNumSelectNZ()
        {
            SqlConnection conn = GetConnection();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Products WHERE Name Like N'%" + this.name + "%' AND Serial LIKE '%" + this.serial + "%' And Size Like N'%" + this.size.ToString() + "%' And Color Like N'%" + this.color.ToString() + "%' And Barcode Like '%" + this.barcode.ToString() + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Barcode", "");
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);

                conn.Open();
                adapt.Fill(dt);
            }
            catch (Exception ex)
            { }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable sizeSelect()
        {
            SqlConnection conn = GetConnection();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT DISTINCT Size FROM Products WHERE Name=@Name AND Serial=@Serial AND Quantity <> 0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", this.name);
                cmd.Parameters.AddWithValue("@Serial", this.serial);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                conn.Open();
                adapt.Fill(dt);
            }
            catch (Exception ex)
            { }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable colorSelect()
        {
            SqlConnection conn = GetConnection();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT DISTINCT Color FROM Products WHERE Name=@Name AND Serial=@Serial AND Size=@Size AND Quantity <> 0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", this.name);
                cmd.Parameters.AddWithValue("@Serial", this.serial);
                cmd.Parameters.AddWithValue("@Size", this.size);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                conn.Open();
                adapt.Fill(dt);
            }
            catch (Exception ex)
            { }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public void productSelect()
        {
            SqlConnection conn = GetConnection();
            string sql = "SELECT * FROM Products WHERE Name=@Name AND Serial=@Serial AND Size=@Size AND Color=@Color AND Quantity <> 0";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", this.name);
            cmd.Parameters.AddWithValue("@Serial", this.serial);
            cmd.Parameters.AddWithValue("@Size", this.size);
            cmd.Parameters.AddWithValue("@Color", this.color);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                this.name = reader["Name"].ToString();
                this.serial = reader["Serial"].ToString();
                this.color = reader["Color"].ToString();
                this.price = (double)reader["Price"];
                this.actPrice = (double)reader["ActPrice"];
                this.quantity = (int)reader["Quantity"];
                this.soldQuantity = (int)reader["SoldQuantity"];
                this.id = (int)reader["Id"];
                this.size = reader["Size"].ToString();
                this.barcode = reader["Barcode"].ToString();
            }
            conn.Close();
        }

        public void Insert()
        {
            SqlConnection conn = GetConnection();
            string sql = "INSERT INTO Products (Name, Serial, Color, Price, ActPrice, Size, Quantity, SoldQuantity, Barcode) VALUES (@Name, @Serial, @Color, @Price, @ActPrice, @Size, @Quantity, @SoldQuantity, @Barcode) ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", this.name);
            cmd.Parameters.AddWithValue("@Serial", this.serial);
            cmd.Parameters.AddWithValue("@Color", this.color);
            cmd.Parameters.AddWithValue("@Price", this.price);
            cmd.Parameters.AddWithValue("@ActPrice", this.actPrice);
            cmd.Parameters.AddWithValue("@Size", this.size);
            cmd.Parameters.AddWithValue("@Quantity", this.quantity);
            cmd.Parameters.AddWithValue("@SoldQuantity", "0");
            cmd.Parameters.AddWithValue("@Barcode", this.barcode);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void selectID()
        {
            SqlConnection conn = GetConnection();
            string sql = "SELECT * FROM Products WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", this.id);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                this.name = reader["Name"].ToString();
                this.serial = reader["Serial"].ToString();
                this.color = reader["Color"].ToString();
                this.price = (double)reader["Price"];
                this.actPrice = (double)reader["ActPrice"];
                this.quantity = (int)reader["Quantity"];
                this.soldQuantity = (int)reader["SoldQuantity"];
                this.id = (int)reader["Id"];
                this.size = reader["Size"].ToString();
                this.barcode = reader["Barcode"].ToString();
            }
            conn.Close();
        }

        public void Submit(DateTime now, int quantity, double price)
        {
            int pQ = 0;
            int sQ = 0;
            SqlConnection conn1 = GetConnection();
            string sql1 = "SELECT * FROM Products WHERE Id=@Id";
            SqlCommand cmd1 = new SqlCommand(sql1, conn1);
            cmd1.Parameters.AddWithValue("@Id", this.id);
            conn1.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                pQ = (int)reader["Quantity"];
                sQ = (int)reader["SoldQuantity"];
            }
            conn1.Close();

            SqlConnection conn2 = GetConnection();
            string sql2 = "Update Products SET SoldQuantity=@SoldQuantity, Quantity=@Quantity WHERE Id=@Id";
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            cmd2.Parameters.AddWithValue("@Id", this.id);
            cmd2.Parameters.AddWithValue("@Quantity", pQ - quantity);
            cmd2.Parameters.AddWithValue("@SoldQuantity", sQ + pQ);
            conn2.Open();
            cmd2.ExecuteNonQuery();
            conn2.Close();



            SqlConnection conn = GetConnection();
            string sql = "INSERT INTO dbo.Sold (ProductId, Name, Serial, Color, Price, ActPrice, Size, Quantity, Barcode, DateTime) VALUES (@ProductID, @Name, @Serial, @Color, @Price, @ActPrice, @Size, @Quantity, @Barcode, GETDATE()) ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ProductID", this.id);
            cmd.Parameters.AddWithValue("@Name", this.name);
            cmd.Parameters.AddWithValue("@Serial", this.serial);
            cmd.Parameters.AddWithValue("@Color", this.color);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@ActPrice", this.actPrice * quantity);
            cmd.Parameters.AddWithValue("@Size", this.size);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Barcode", this.barcode);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public bool SelectBarcode(string bar)
        {
            SqlConnection conn = GetConnection();
            string sql = "SELECT * FROM Products WHERE Barcode=@Barcode";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Barcode", bar);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            int counter = 0;
            if (reader.Read())
            {
                counter++;
                this.name = reader["Name"].ToString();
                this.serial = reader["Serial"].ToString();
                this.color = reader["Color"].ToString();
                this.price = (double)reader["Price"];
                this.actPrice = (double)reader["ActPrice"];
                this.quantity = (int)reader["Quantity"];
                this.soldQuantity = (int)reader["SoldQuantity"];
                this.id = (int)reader["Id"];
                this.size = reader["Size"].ToString();
                this.barcode = reader["Barcode"].ToString();
            }
            conn.Close();
            if (counter == 1) return true;
            else return false;
        }

        public void Update()
        {
            SqlConnection conn = GetConnection();
            try
            {
                string sql = "Update Products SET Name=@Name, Serial=@Serial, Size=@Size, Color=@Color, Quantity=@Quantity, Price=@Price, ActPrice=@ActPrice, Barcode=@Barcode, SoldQuantity=@SoldQuantity WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", this.id);
                cmd.Parameters.AddWithValue("@Name", this.name);
                cmd.Parameters.AddWithValue("@Serial", this.serial);
                cmd.Parameters.AddWithValue("@Color", this.color);
                cmd.Parameters.AddWithValue("@Price", this.price);
                cmd.Parameters.AddWithValue("@ActPrice", this.actPrice);
                cmd.Parameters.AddWithValue("@Size", this.size);
                cmd.Parameters.AddWithValue("@Quantity", this.quantity);
                cmd.Parameters.AddWithValue("@SoldQuantity", this.soldQuantity);
                cmd.Parameters.AddWithValue("@Barcode", this.barcode);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            finally
            {
                conn.Close();
            }
        }
    }
}

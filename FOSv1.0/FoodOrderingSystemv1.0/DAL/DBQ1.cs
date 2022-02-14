using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using FoodOrderingSystemv1._0.Controls;
using Guna.UI2.WinForms;

namespace FoodOrderingSystemv1._0.DAL
{
    class DBQ1
    {
        public static SqlConnection GetConnection()
        {
            string strConnection = @"Data Source=DESKTOP-8LK74L3\SQLEXPRESS ; Initial Catalog= FOS1; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(strConnection);
            try
            {
                connection.Open();
                //MessageBox.Show("Success!");
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            return connection;
        }

        /*internal void GetProducts(string v, Guna2CustomGradientPanel gP1)
        {
            throw new NotImplementedException();
        }*/

        /////////////////////////////////////// Quries For Admin ////////////////////////////////////////////////

        public static DataSet GetDataThroughAdapterForAdmin() ///////// DISCONNECTED LAYER
        {
            string qry = "Select*From Admin";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Admin");
            return ds;
        }

        public static SqlDataReader GetDataThroughDataReaderForCustomer() //// CONNECTED LAYER
        {
            string qry = "Select*From Customer";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public string GetCustomer(string query, FlowLayoutPanel panel)
        {
            //DBQ1 obj;
            string ret = "";

            try
            {
                //cmd.Connection = conn;
                //cmd.CommandText = query.ToLower();
                //GetConnection();

                reader = GetDataThroughDataReaderForCustomer();

                //reader = cmd.ExecuteReader();

                string id, name, address, pswrd;
                long cellno;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                    address = reader[2].ToString();
                    cellno = long.Parse(reader[3].ToString());
                    pswrd = reader[4].ToString();

                    RecordsCont btn = new RecordsCont();

                    btn.EmpID = id;
                    btn.EmpName = name;
                    btn.EmpAddress = address;
                    btn.EmpPswrd = pswrd;
                    btn.EmpCell = cellno;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                        //panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }

            return ret;
        }


        public static void ACart(Cart Object)
        {
            string Query = "INSERT INTO Cart1 VALUES (@ID , @Names , @Descrip , @Price , @Quantity)";
            SqlConnection connection = DBQ1.GetConnection();
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@ID", Object.ID);
            Command.Parameters.AddWithValue("@Names", Object.Name);
            Command.Parameters.AddWithValue("@Descrip", Object.Desc);
            Command.Parameters.AddWithValue("@Price", Object.Price);
            Command.Parameters.AddWithValue("@Quantity", Object.Quantity);
            //Command.Parameters.AddWithValue("@CID", Object.CID);

            Command.ExecuteNonQuery();
        }

        public static SqlDataReader GetDefaultData()
        {
            string Query = "SELECT * FROM Customer";
            SqlConnection connection = GetConnection();
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.Text;
            return Command.ExecuteReader();
        }

        public static void CCart(string ID, string Name, string Desc, string Price, string Quantity, string Transfers, string Addres)
        {
            string Query = "INSERT INTO Cart2 VALUES (@ID , @Names , @Descrip , @Price , @Quantity,@TransferType,@Addres)";
            SqlConnection connection = DBQ1.GetConnection();
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Names", Name);
            Command.Parameters.AddWithValue("@Descrip", Desc);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@TransferType", Transfers);
            Command.Parameters.AddWithValue("@Addres", Addres);

            Command.ExecuteNonQuery();
        }

        public static void AddAdminRecord(Admin adminobj)
        {

            string qry = "Insert into Admin Values(@AdID,@AdName,@AdAddress,@AdCell,@AdPassword)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@AdID", adminobj.ID);
            command.Parameters.AddWithValue("@AdName", adminobj.Name);
            command.Parameters.AddWithValue("@AdAddress", adminobj.Address);
            command.Parameters.AddWithValue("@AdCell", adminobj.CellNo);
            command.Parameters.AddWithValue("@AdPswrd", adminobj.Password);
            command.ExecuteNonQuery();
        }


        /////////////////////////////////////// Quries For Employee ////////////////////////////////////////////////

        public static DataSet GetDataThroughAdapterForEmployee() ///////// DISCONNECTED LAYER
        {
            string qry = "Select*From Employee";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Employee");
            return ds;
        }

        public static void AddEmployeeRecord(Employee empObj)
        {

            string qry = "Insert into Employee Values(@EmpID,@EmpName,@EmpAddress,@EmpCell,@EmpPswrd)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@EmpID", empObj.ID);
            command.Parameters.AddWithValue("@EmpName", empObj.Name);
            command.Parameters.AddWithValue("@EmpAddress", empObj.Address);
            command.Parameters.AddWithValue("@EmpCell", empObj.CellNo);
            command.Parameters.AddWithValue("@EmpPswrd", empObj.Password);
            command.ExecuteNonQuery();
        }


        public static SqlDataReader GetDataThroughDataReaderForEmployee() //// CONNECTED LAYER
        {
            string qry = "Select*From Employee";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public string GetEmployee(string query, FlowLayoutPanel panel)
        {
            //DBQ1 obj;
            string ret = "";

            try
            {
                //cmd.Connection = conn;
                //cmd.CommandText = query.ToLower();
                //GetConnection();

                reader = GetDataThroughDataReaderForEmployee();

                //reader = cmd.ExecuteReader();

                string id, name, address, pswrd;
                long cellno;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                    address = reader[2].ToString();
                    cellno = long.Parse(reader[3].ToString());
                    pswrd = reader[4].ToString();

                    RecordsCont btn = new RecordsCont();

                    btn.EmpID = id;
                    btn.EmpName = name;
                    btn.EmpAddress = address;
                    btn.EmpPswrd = pswrd;
                    btn.EmpCell = cellno;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                        //panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }

            return ret;
        }

        /////////////////////////////////////// Quries For Customer ////////////////////////////////////////////////

        public static DataSet GetDataThroughAdapterForCustomer() ///////// DISCONNECTED LAYER
        {
            string qry = "Select*From Customer";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Customer");
            return ds;
        }

        public static void AddCustomerRecord(Customer cusObj)
        {

            string qry = "Insert into Customer Values(@CustID,@CustName,@CustAddress,@CustCell,@CustPswrd)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@CustID", cusObj.ID);
            command.Parameters.AddWithValue("@CustName", cusObj.Name);
            command.Parameters.AddWithValue("@CustAddress", cusObj.Address);
            command.Parameters.AddWithValue("@CustCell", cusObj.CellNo);
            command.Parameters.AddWithValue("@CustPswrd", cusObj.Password);
            command.ExecuteNonQuery();
        }

        /////////////////////////////////////// Quries For Product ////////////////////////////////////////////////

        public static DataSet GetDataThroughAdapterForProduct() ///////// DISCONNECTED LAYER
        {
            string qry = "Select*From Product";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Product");
            return ds;
        }

        public static void AddProductRecord(Product Obj)
        {

            string qry = "Insert into Product Values(@ProdID,@ProdDesc,@ProdName,@ProdPrice)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@ProdID", Obj.ProductID);
            command.Parameters.AddWithValue("@ProdName", Obj.ProductName);
            //command.Parameters.AddWithValue("@ProdImg", Obj.ProductImage);
            command.Parameters.AddWithValue("@ProdDesc", Obj.ProductDescription);
            command.Parameters.AddWithValue("@ProdPrice", Obj.ProductPrice);
            command.ExecuteNonQuery();
        }

        /////////////////////////////////////// Quries For Menu ////////////////////////////////////////////////


        public static SqlDataReader GetDataThroughDataReaderForProducts() //// CONNECTED LAYER
        {
            string qry = "Select*From Product";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static DataSet GetDataThroughAdapterForMenu() ///////// DISCONNECTED LAYER
        {
            string qry = "Select*From Menu";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Menu");
            return ds;
        }

        public static void AddMenuRecord(Menu Obj)
        {

            string qry = "Insert into Admin Values(@MenuID,@ProdID,@ProdName,@ProdImg,@ProdDesc,@ProdPrice)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@MenuID", Obj.MenuID);
            command.Parameters.AddWithValue("@ProdID", Obj.ProductID);
            command.Parameters.AddWithValue("@ProdName", Obj.ProductName);
            command.Parameters.AddWithValue("@ProdImg", Obj.ProductImage);
            command.Parameters.AddWithValue("@ProdDesc", Obj.ProductDescription);
            command.Parameters.AddWithValue("@ProdPrice", Obj.ProductPrice);
            command.ExecuteNonQuery();
        }
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader reader;
        public string GetProducts(string query, FlowLayoutPanel panel)
        {
            //DBQ1 obj;
            string ret = "";

            try
            {
                //cmd.Connection = conn;
                //cmd.CommandText = query.ToLower();
                //GetConnection();

                reader = GetDataThroughDataReaderForProducts();

                //reader = cmd.ExecuteReader();

                string id, name, price, desc, quantity;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                    price = reader[3].ToString();
                    desc = reader[2].ToString();
                    //quantity = reader[4].ToString();

                    CustOrderMealCont btn = new CustOrderMealCont();

                    btn.ProductID = id;
                    btn.ProductName = name;
                    btn.ProductDesc = desc;
                    //btn.ProductQuantity = quantity;
                    btn.ProductPrice =  price;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                        //panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }

            return ret;
        }



        public static DataSet GetDataThroughAdapterForOrder() ///////// DISCONNECTED LAYER
        {
            string qry = "Select*From Order1";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Order1");
            return ds;
        }

        public static void AddOrderRecord(Order Obj)
        {

            string qry = "Insert into Order1 Values(@UnitPrice,@Quantity)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            //command.Parameters.AddWithValue("@UnitPrice", Obj.UnitPrice);
            //command.Parameters.AddWithValue("@UnitPrice", Obj.UnitPrice);
            command.Parameters.AddWithValue("@Quantity", Obj.Quantity);
            command.ExecuteNonQuery();
        }

        

        /////////////////////////////////////// Quries For Cart ////////////////////////////////////////////////

        public static DataSet GetDataThroughAdapterForCart() ///////// DISCONNECTED LAYER
        {
            string qry = "Select*From Cart";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Cart");
            return ds;
        }

        public static void AddCartRecord(Cart Obj)
        {

            string qry = "Insert into Admin Values(@CartID,@ProdID,@ProdQuantity,@TotalPrice,@UnitPrice)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@MenuID", Obj.CartID);
            command.Parameters.AddWithValue("@ProdID", Obj.ProductID);
            command.Parameters.AddWithValue("@ProdQuantity", Obj.ProductQuantity);
            command.Parameters.AddWithValue("@TotalPrice", Obj.TotalPrice);
            command.Parameters.AddWithValue("@UnitPrice", Obj.UnitPrice);
            command.ExecuteNonQuery();
        }


        internal static void BCart(PAL.Cart ANF1)
        {
            throw new NotImplementedException();
        }


        public static SqlDataReader GetDataThroughDataReaderForModProduct() //// CONNECTED LAYER
        {
            string qry = "Select*From Product";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public string GetModProduct(string query, FlowLayoutPanel panel)
        {
            //DBQ1 obj;
            string ret = "";

            try
            {
                //cmd.Connection = conn;
                //cmd.CommandText = query.ToLower();
                //GetConnection();

                reader = GetDataThroughDataReaderForModProduct();

                //reader = cmd.ExecuteReader();

                string id, name, desc, price;
                //long cellno;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                    desc = reader[2].ToString();
                    price = reader[3].ToString();
                    //quantity = reader[4].ToString();

                    AdminModProdCont btn = new AdminModProdCont();

                    btn.ProductID = id;
                    btn.ProductName = name;
                    btn.ProductDesc = desc;
                    //btn.ProductQuantity = quantity;
                    btn.ProductPrice = price;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                        //panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }

            return ret;
        }

        public static void DeleteProductRecord(string obj)
        {
            string qry = "Delete From Product Where ProdID=@ProdID";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@ProdID", obj);
            command.ExecuteNonQuery();
        }

        public static void DeleteCart2Record(string obj1, string obj2, string obj3, string obj4)
        {
            string qry = "Delete From Cart2 Where ID=@ProdID,Quantity=@ProdQuantity,TransferType=@TT,Address=@ad";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@ProdID", obj1);
            command.Parameters.AddWithValue("@ProdQuantity", obj2);
            command.Parameters.AddWithValue("@TT", obj3);
            command.Parameters.AddWithValue("@ad", obj4);
            command.ExecuteNonQuery();
        }

        public static SqlDataReader DashBoard1()
        {
            string qry1 = "SELECT COUNT(*) FROM Customer";
            //string qry2 = "SELECT COUNT(*) FROM Employee";
            SqlConnection connection = GetConnection();
            SqlCommand command1 = new SqlCommand(qry1, connection);
            //SqlCommand command2 = new SqlCommand(qry2, connection);

           // string qry = "Select ID from Customers";
            //SqlConnection connection = GetConnection();
            //SqlCommand command = new SqlCommand(qry, connection);
            command1.CommandType = CommandType.Text;
            SqlDataReader reader = command1.ExecuteReader();
            return reader;

            //command1.ExecuteNonQuery();
            //command2.ExecuteNonQuery();
            // EmpCount = Convert.ToInt32(command1.ExecuteScalar());
            //CusCount = Convert.ToInt32(command2.ExecuteScalar());           

           //-- int EmpCount1 = Convert.ToInt32(command1.ExecuteScalar().ToString());
            //int CusCount1 = Convert.ToInt32(command2.ExecuteScalar().ToString());
           
            //--UC_AdminDashboard obj = new UC_AdminDashboard();
           // --obj.LblEmployees = EmpCount1.ToString();
            //obj.LblCustomers = CusCount1.ToString();
            //return ;

        }

        public static SqlDataReader DashBoard2()
        {
            //string qry1 = "SELECT COUNT(*) FROM Customer";
            string qry2 = "SELECT COUNT(*) FROM Employee";
            SqlConnection connection = GetConnection();
            SqlCommand command2 = new SqlCommand(qry2, connection);
                      
            command2.CommandType = CommandType.Text;
            SqlDataReader reader1 = command2.ExecuteReader();
            return reader1;

        }

        public static SqlDataReader DashBoard3()
        {
            //string qry1 = "SELECT COUNT(*) FROM Customer";
            string qry2 = "SELECT COUNT(*) FROM Order1";
            SqlConnection connection = GetConnection();
            SqlCommand command2 = new SqlCommand(qry2, connection);

            command2.CommandType = CommandType.Text;
            SqlDataReader reader1 = command2.ExecuteReader();
            return reader1;

        }


        public static SqlDataReader DashBoard4()
        {
            //string qry1 = "SELECT COUNT(*) FROM Customer";
            string qry2 = "SELECT SUM(Price) FROM Order1";
            SqlConnection connection = GetConnection();
            SqlCommand command2 = new SqlCommand(qry2, connection);

            command2.CommandType = CommandType.Text;
            SqlDataReader reader1 = command2.ExecuteReader();
            return reader1;

        }

        public static void DeleteCartRecord(string obj)
        {
            string qry = "Delete From Cart1";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            //command.Parameters.AddWithValue("@ProdID", obj);
            command.ExecuteNonQuery();
        }

        public static SqlDataReader GetDataThroughDataReaderForCart1() //// CONNECTED LAYER
        {
            string qry = "Select*From Cart1";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public string GetCart1(string query, FlowLayoutPanel panel)
        {
            //DBQ1 obj;
            string ret = "";

            try
            {
                //cmd.Connection = conn;
                //cmd.CommandText = query.ToLower();
                //GetConnection();

                reader = GetDataThroughDataReaderForCart1();

                //reader = cmd.ExecuteReader();

                string id, name, desc, price,quantity;
                //long cellno;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                    desc = reader[2].ToString();
                    price = reader[3].ToString();
                    quantity = reader[4].ToString();
                    //quantity = reader[4].ToString();

                    CustCartMeal btn = new CustCartMeal();

                    btn.ProductID = id;
                    btn.ProductName = name;
                    btn.ProductDesc = desc;
                    btn.ProductQuantity= quantity;
                    btn.ProductPrice = price;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                        //panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }

            return ret;
        }


        public static SqlDataReader GetDataThroughDataReaderForCart2() //// CONNECTED LAYER
        {
            string qry = "Select*From Cart2";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public string GetCart2(string query, FlowLayoutPanel panel)
        {
            //DBQ1 obj;
            string ret = "";

            try
            {
                //cmd.Connection = conn;
                //cmd.CommandText = query.ToLower();
                //GetConnection();

                reader = GetDataThroughDataReaderForCart2();

                //reader = cmd.ExecuteReader();

                string id,name, desc, price, quantity,address,transertype;
                //long cellno;

                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader[1].ToString();
                    desc = reader[2].ToString();
                    price = reader[3].ToString();
                    quantity = reader[4].ToString();
                    transertype = reader[5].ToString();
                    address = reader[6].ToString();

                    OrdersEmpCont btn = new OrdersEmpCont();

                    btn.ProductID = id;
                    btn.ProductName = name;
                    btn.ProductDesc = desc;
                    btn.ProductQuantity = quantity;
                    btn.ProductPrice = price;
                    btn.TT = transertype;
                    btn.Address = address;

                    if (name != string.Empty)
                    {
                        panel.Controls.Add(btn);
                        //panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }

            return ret;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Permissions;
using System.Security.Policy;
using System.Drawing;

namespace ShopMangement

{

    internal class ClsShop
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-U33S9ORF;Initial Catalog=ShopMangegment;Integrated Security=True");

        public string Type { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }

        public string TypeName { get; set; }
        public string ProductName { get; set; }
        public int TypeID { get; set; }


        public int ProductID { get; set; }
        public string Size { get; set; }
        public int MRP { get; set; }
        public int RealPrice { get; set; }






        public int UserID { get; set; }
        public int SizeID { get; set; }
        public string OrderStatus { get; set; }
        public string OrderDate { get; set; }
        public string Product { get; set; }
        public int Total { get; set; }
        //  public float Discount { get; set; }





        public ClsShop(int userid, int sizeid, String orderstatus, string orderdate)
        {
            UserID = userid;
            SizeID = sizeid;
            OrderStatus = orderstatus;
            OrderDate = orderdate;



        }

        public ClsShop(string typename)   // save type constructer
        {
            TypeName = typename;
        }
        public ClsShop(int TypeId, string productname)

        {
            TypeID = TypeId;
            ProductName = productname;
        }

        public ClsShop(String email, string password)
        {

            Email = email;
            Password = password;
        }

        public ClsShop()
        {

        }

        public ClsShop(int pID,int tID)
        {
            ProductID= pID;
            TypeID= tID;
        }

        //public ClsShop(String size)
        //{
        //    Size = size;
        //}

        public ClsShop(int ID)
        {
            TypeID = ID;
        }

        //public ClsShop(string type,string email,int password)
        //{
        //    Type = type;
        //    Email = email;


        //}

        public ClsShop(int typeid, int productid, string size, int mrp, int realPrice)
        {
            TypeID = typeid;
            ProductID = productid;
            Size = size;
            MRP = mrp;
            RealPrice = realPrice;
        }


        public ClsShop(string type, string name, string email, string gender, string state, string mobile, string password)
        {

            Type = type;
            Name = name;
            Email = email;
            Gender = gender;
            State = state;
            Mobile = mobile;
            Password = password;
        }


        public void RegisterData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "RegisterData");
            cmd.Parameters.AddWithValue("@UserType", Type);
            cmd.Parameters.AddWithValue("@UserName", Name);
            cmd.Parameters.AddWithValue("@UserEmail", Email);
            cmd.Parameters.AddWithValue("@UserGender", Gender);
            cmd.Parameters.AddWithValue("@UserState", State);
            cmd.Parameters.AddWithValue("@UserMobile", Mobile);
            cmd.Parameters.AddWithValue("@UserPassword", Password);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SaveData() // Typename data save
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "SaveData");
            cmd.Parameters.AddWithValue("@TypeName", TypeName);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SaveProduct()   // save product 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "SaveProduct");
            cmd.Parameters.AddWithValue("@TypeID", TypeID);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);

            cmd.ExecuteNonQuery();
            con.Close();

        }

        public DataTable GetProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetProduct");
            cmd.Parameters.AddWithValue("@TypeID", TypeID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;


            con.Close();
        }

        public void BookingData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "BookingData");
            cmd.Parameters.AddWithValue("@TypeID", TypeID);
            cmd.Parameters.AddWithValue("@ProductID", ProductID);
            cmd.Parameters.AddWithValue("@Size", Size);
            cmd.Parameters.AddWithValue("@MRP", MRP);
            cmd.Parameters.AddWithValue("@RealPrice", RealPrice);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public DataTable GetType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetType");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }

        public DataTable GetUserLogin()

        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetLogin");
            cmd.Parameters.AddWithValue("@UserEmail", Email);
            cmd.Parameters.AddWithValue("@UserPassword", Password);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;


            con.Close();



        }

        public SqlDataReader LoginData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "LoginData");
            // cmd.Parameters.AddWithValue("@UserType", Type);
            cmd.Parameters.AddWithValue("@UserEmail", Email);
            cmd.Parameters.AddWithValue("@UserPassword", Password);
            SqlDataReader dt = cmd.ExecuteReader();
            return dt;

            con.Close();

        }


        public DataTable GetTypeProduct()   // order form
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetTypeProduct");
            cmd.Parameters.AddWithValue("@TypeID ", TypeID);            //@TypeID,TypeID
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable LoginValidation()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "LoginValidation");
            cmd.Parameters.AddWithValue("@UserEmail", Email);
            cmd.Parameters.AddWithValue("@UserPassword", Password);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetSize");
            cmd.Parameters.AddWithValue("@ProductID", TypeID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public SqlDataReader GetMRP()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetMRP");
            cmd.Parameters.AddWithValue("@SizeID", TypeID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            return dr;

            con.Close();
        }


        public void OrderConfirm()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "OrderConfirmed");
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@SizeID", SizeID);
            cmd.Parameters.AddWithValue("@OrderStatus", OrderStatus);
            cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
            cmd.ExecuteNonQuery();


            con.Close();
        }


        public DataTable GetAllProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetAllProduct");
            cmd.Parameters.AddWithValue("@TypeID", TypeID);
            cmd.Parameters.AddWithValue("@ProductID", ProductID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }


        public DataTable GetOrderProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
        cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetOrderProduct");
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@SizeID", SizeID);
            cmd.Parameters.AddWithValue("@ProductID", ProductID);
            cmd.Parameters.AddWithValue("@TypeName", TypeID);
            SqlDataAdapter adpt= new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
       

        public void UpdatedDiscount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "UpdatedDiscount");
       
            cmd.Parameters.AddWithValue("@OrderID", TypeID);
            cmd.Parameters.AddWithValue("@Discount", ProductID);
           
            cmd.ExecuteNonQuery();
            con.Close();
        }


        //public DataTable GetSearch()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPShopMangement", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@flag", "GetSearch");
        //    cmd.Parameters.AddWithValue("@UserName", Name);
        //    cmd.Parameters.AddWithValue("@ProductName", Name);
        //    SqlDataAdapter adpt = new SqlDataAdapter();
        //    adpt.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    adpt.Fill(dt);
        //    return dt;
        //    con.Close(); 
        //}


        public DataTable UnOrderedProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "UnOrderedProduct");
            //cmd.Parameters.AddWithValue("@TypeName", );
            //cmd.Parameters.AddWithValue("@SizeID", SizeID);
            //cmd.Parameters.AddWithValue("@ProductID", ProductID);
            //cmd.Parameters.AddWithValue("@Type", TypeID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable UnOrderedCustomer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "UnOrderedCustomer");
            
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public void Delete()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopMangement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Delete");
            cmd.Parameters.AddWithValue("@OrderID", TypeID);
            cmd.ExecuteNonQuery();
            con.Close();
        }































    }
}



using System.Data.SqlClient;
namespace BurgerApp.Repository
{
    internal class BurgerRepo
    {
        SqlConnection con = new SqlConnection("Data source = DESKTOP-PQQ575E;Database=BurgerDb ;integrated Security = true");
        public void DisplayAll()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select *from Burgers", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Id :{reader["BId"]}\tName :{reader["BName"]}\tBurger avail location :{reader["BLocation"]}\t ");
            }


            con.Close();
        }

        //insert into table
        public void InsertIntoTable()
        {
            con.Open();
            Console.WriteLine("enter User Id");
            string UserId = Console.ReadLine();
            Console.WriteLine("enter Id of burger ");
            string BId = Console.ReadLine();

            Console.WriteLine("enter Burger Quantity");
            string BQuantity = Console.ReadLine();

            string query = "INSERT INTO Cart (UserId,BId,BName,BLocation,BPrice,BQuantity,Total_Price) SELECT @UserId,BId,BName,BLocation,BPrice,@BQuantity,@BQuantity*BPrice FROM Burgers where BId = @BId ";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@BId", BId);
            cmd.Parameters.AddWithValue("@UserId", BId);
            cmd.Parameters.AddWithValue("@BQuantity", BQuantity);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //view cart
        public void ViewCart()
        {
            con.Open();
            Console.WriteLine("enter User Id");
            string UserId = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("select *from Cart where UserId=@UserId", con);
            cmd.Parameters.AddWithValue("@UserId", UserId);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Cart Id : {reader["CID"]}\t Burger Id :{reader["BId"]}\tBurger Name :{reader["BName"]}\t Burger available location :{reader["BLocation"]}\t Burger Price :{reader["BPrice"]}\t Burger Quantity :{reader["BQuantity"]}\t Burger Total Price :{reader["Total_Price"]} ");
            }

            con.Close();
        }

        //delete record
        public void DeleteFromCart()
        {


            con.Open();
            Console.WriteLine("enter Id of Burger to Remove");
            string DelId = Console.ReadLine();

            string query = "delete from Cart where BId = @id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", DelId);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        //update cart
        public void UpdateCart()
        {
            con.Open();
            Console.WriteLine("enter Id of Cart Item to update");
            string UpdateId = Console.ReadLine();
            Console.WriteLine("Enter Quantity of product to change :");
            string UpQuantity = Console.ReadLine();
            string query1 = "update Cart set BQuantity = @UpQuantity where CId = @UpdateId    update Cart set Total_Price = BQuantity * BPrice where CId = @UpdateId";
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.Parameters.AddWithValue("@UpdateId", UpdateId);
            cmd.Parameters.AddWithValue("UpQuantity", UpQuantity);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ViewBill()
        {
            con.Open();
            Console.WriteLine("enter UserId");
            string UserId = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("select *from Bill where UserId=@UserId", con);
            
            cmd.Parameters.AddWithValue("@UserId", UserId);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"UserId:{reader["UserId"]}\tBillId:{reader["BillId"]}\tCart Id:{reader["CID"]}\tBurger Id:{reader["BId"]}\tBurger Name:{reader["BName"]}\tBurger available location:{reader["BLocation"]}\tBurger Price:{reader["BPrice"]}\tBurger Quantity:{reader["BQuantity"]}\tBurger Total Price:{reader["Total_Price"]}");
            }

            con.Close();
        }

        //insert to bill table
        public void InsertToBillTable()
        {
            con.Open();

            
            Console.WriteLine("enter UserId");
            string UserId = Console.ReadLine();
            string query = "INSERT INTO Bill (UserId,CId,BId,BName,BLocation,BPrice,BQuantity,Total_Price) SELECT UserId,CId,BId,BName,BLocation,BPrice,BQuantity,Total_Price FROM Cart where UserId=@UserId";
            SqlCommand cmd = new SqlCommand(query, con);
            string query1 = "DELETE FROM Cart WHERE UserId=@UserId;";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd.Parameters.AddWithValue("@UserId", UserId);
            
            cmd1.Parameters.AddWithValue("@UserId", UserId);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            Console.WriteLine("Your bill has been generated !");
            Console.WriteLine("Proceed to view bill.........");
            con.Close();
        }

        //by all from cart
        public bool ByAll()
        {
            Console.WriteLine("Proceed to by all items from cart");
            Console.WriteLine("Enter 1 to proceed");
            int val = int.Parse(Console.ReadLine());
            if (val == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //generate bill
        public void GenBill()
        {
            bool Result = ByAll();
            if (Result)
            {
                InsertToBillTable();

            }
        }

        //view 
    }

}
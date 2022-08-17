using System.Data;
using System.Data.SqlClient;

Connection();
static void Connection()
{

    string cs = "Data source = DESKTOP-PQQ575E ;Database=StudentDb1 ;integrated Security = true";
    SqlConnection con = new SqlConnection(cs);
     using (con)
        {
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                Console.WriteLine("connection established !");
            }
        }
    
    con.Close();
}


static void Display()
{

    string cs = "Data source = DESKTOP-PQQ575E;Database=SqlLearning ;integrated Security = true";
    SqlConnection con = new SqlConnection(cs);
    using (con)
    {
        con.Open();
       
        SqlCommand cmd = new SqlCommand("select * from Department ", con);


        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"Id :{reader["DepId"]}\tName :{reader["DepartmentName"]}\t ");
        }
    
    
        
    }

    con.Close();
}


//insert into table
static void InsertIntoTable()
{
    
    string cs = "Data source = DESKTOP-PQQ575E;Database=SqlLearning ;integrated Security = true";
    SqlConnection con = new SqlConnection(cs);
    con.Open();
    Console.WriteLine("enter id");
    string DepId = Console.ReadLine();
    Console.WriteLine("enter deaprtment name");
    string DepartmentName = Console.ReadLine();
  
    string query = "Insert into Department values(@id,@DepName)";
    SqlCommand cmd = new SqlCommand(query, con);
    
    cmd.Parameters.AddWithValue("@id",DepId);
    cmd.Parameters.AddWithValue("@DepName", DepartmentName);
    cmd.ExecuteNonQuery();
    con.Close();
}


//update values of student table
static void UpdateTable()
{
    string cs = "Data source = DESKTOP-PQQ575E;Database=SqlLearning ;integrated Security = true";
    SqlConnection con = new SqlConnection(cs);
    con.Open();
    Console.WriteLine("enter id to update");
    string DelId = Console.ReadLine();
    Console.WriteLine("enter id ");
    string DepId = Console.ReadLine();
    Console.WriteLine("enter deaprtment name");
    string DepartmentName = Console.ReadLine();
    string query1 = "update Department set DepId = @id,DepartmentName = @DepName where DepId = @DelId ";
    SqlCommand cmd = new SqlCommand(query1, con);
    cmd.Parameters.AddWithValue("@DelId", DelId);
    cmd.Parameters.AddWithValue("@id", DepId);
    cmd.Parameters.AddWithValue("@DepName", DepartmentName);
    cmd.ExecuteNonQuery();
    con.Close();


}

//delete record
static void DeleteFromTable()
{

    string cs = "Data source = DESKTOP-PQQ575E;Database=SqlLearning ;integrated Security = true";
    SqlConnection con = new SqlConnection(cs);
    con.Open();
    Console.WriteLine("enter id");
    string DepId = Console.ReadLine();
    
    string query = "delete from Department where DepId = @id";
    SqlCommand cmd = new SqlCommand(query, con);

    cmd.Parameters.AddWithValue("@id", DepId);
  
    cmd.ExecuteNonQuery();
    con.Close();
}


//display all students using dataset and data adapter
static void DisplayUsingDataset()
{
    string cs = "Data source = DESKTOP-PQQ575E;Database=SqlLearning ;integrated Security = true";
    SqlConnection con = new SqlConnection(cs);
    con.Open();
    string query2 = "select * from Department ";
    SqlDataAdapter ds = new SqlDataAdapter(query2,con);
    DataSet dt = new DataSet();
    ds.Fill(dt);
    foreach(DataRow row in dt.Tables[0].Rows)
    {
        Console.WriteLine($"Id :{row["DepId"]}\tName :{row["DepartmentName"]}\t ");

    }
}


//display all students using datatable and data adapter
static void DisplayUsingDataTable()
{
    string cs = "Data source = DESKTOP-PQQ575E;Database=SqlLearning ;integrated Security = true";
    SqlConnection con = new SqlConnection(cs);
    con.Open();
    string query2 = "select * from Department ";
    SqlDataAdapter ds = new SqlDataAdapter(query2, con);
    DataTable dt = new DataTable();
    ds.Fill(dt);
    foreach (DataRow row in dt.Rows)
    {
        Console.WriteLine($"Id :{row["DepId"]}\tName :{row["DepartmentName"]}\t ");

    }
}
//Display();
//DeleteFromTable();
//Display();
//InsertIntoTable();
//Display();
//UpdateTable();
//Display();


//DisplayUsingDataset();
//DisplayUsingDataTable();



//task
static void DisplayTask()
{

    string cs = "Data source = DESKTOP-PQQ575E;Database=SqlLearning ;integrated Security = true";
    SqlConnection con = new SqlConnection(cs);
    using (con)
    {
        con.Open();
        Console.WriteLine("enter employee id");
        string EmpId = Console.ReadLine();
        
        SqlCommand cmd = new SqlCommand("select * from vwEmployeeAndDepartment where EmpId = @EmpId ", con);
        cmd.Parameters.AddWithValue("@EmpId", EmpId);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"EmpId :{reader["EmpId"]}\tEmpName :{reader["EmpName"]}\t EmpCity : {reader["EmpCity"]},DepartmentName : {reader["DepartmentName"]}");
        }
       


    }

    con.Close();
}
DisplayTask();

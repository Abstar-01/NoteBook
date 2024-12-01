namespace NoteBook;

using System;
using System.Data.SqlClient;

public class LoginInformationBackgroundModel {
    private string connection = "Server=DESKTOP-CKFILPO\\SQLEXPRESS;Database=NoteBook_Authentication;User Id=root;Password=1234;";
    public LoginInformationBackgroundModel() {
        
    }

    public void SearchAccount() {
        using (SqlConnection con = new SqlConnection(connection)) {
            try {
                con.Open();
                Console.WriteLine("Opened");
                con.Close();
                Console.WriteLine("Closed");
            }catch (Exception e) {
                Console.WriteLine("Error opening the database");
            }
        }
    }
    
    public void NewAccount(){
        using (SqlConnection con = new SqlConnection(connection)) {
            try {
                con.Open();
                string user;
                bool check = false;
                
                string usr = "TnTen";
                string phone = "2";
                
                    string s = "SELECT UserName FROM UserInformation";
                    SqlCommand com = new SqlCommand(s,con);
                    
                    using (SqlDataReader reader = com.ExecuteReader()) {
                        while (reader.Read()) {
                            if (usr == reader.GetString(0)) {
                                check = true;
                                break;
                            }
                        }
                    }

                if (!check) {
                    string inputing =
                        "INSERT INTO UserInformation(UserName, FirstName, LastName)" +
                        "VALUES (@usr,@FN,@LN)";
                    using (SqlCommand cmd = new SqlCommand(inputing,con)) {
                        cmd.Parameters.AddWithValue("@usr", usr);
                        cmd.Parameters.AddWithValue("@FN", "Abel");
                        cmd.Parameters.AddWithValue("@LN", "Girma");
                        
                        int rows = cmd.ExecuteNonQuery();
                        Console.WriteLine("Done");
                    }
                }else {
                    Console.WriteLine("Username or phonenumber has already been entered");   
                }
            }catch (Exception e) {
                Console.WriteLine("Error opening the database");
            }
        }
    }
}
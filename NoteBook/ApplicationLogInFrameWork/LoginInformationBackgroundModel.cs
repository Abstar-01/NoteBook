namespace NoteBook;

using System;
using System.Data.SqlClient;

public class LoginInformationBackgroundModel {
    private string connection = "Server=DESKTOP-CKFILPO\\SQLEXPRESS;Database=NoteBook_Authentication;User Id=root;Password=1234;";
    public LoginInformationBackgroundModel() {
        
    }

    public static void Main(string[] args)
    {
        LoginInformationBackgroundModel lib = new LoginInformationBackgroundModel();
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
                
            }catch (Exception e) {
                Console.WriteLine("Error opening the database");
            }
        }
    }
}
using Biblioteka_KP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteka_KP.Common;

namespace Biblioteka_KP.Forms
{
    public partial class LoginForm : Form
    {
        SQL.SqlConnector sql;
        public User user = null;
        public LoginForm()
        {
            
            InitializeComponent();

            buttonLogIn.Click += (s, e) => {
                if (validateData(textBoxLogin.Text, textBoxPassword.Text)) user = logIn(textBoxLogin.Text, textBoxPassword.Text);
                if (user != null)
                {
                    
                    new MainForm(user).Show();
                    this.Visible = false;
                }
                
            };
        }

        private bool validateData(string login, string password) {
            if (login == "" || password == "") {
                labelError.Visible = true;
                return false;
            } else return true;
        }

        private User logIn(string login, string password) {
            User user=null;
            sql = new SQL.SqlConnector();
            MySql.Data.MySqlClient.MySqlDataReader reader = sql.sendQuery($"select id, login from user where login='{login}' and password='{MD5.CreateMD5(password)}';");
             while (reader.Read())
             {
                 user = new User(int.Parse(reader["id"].ToString()), reader["login"].ToString());
                    
             }
             reader.Close();
             if(user==null) labelError.Visible = true;
            return user;
            
        
        }

        
    }
}

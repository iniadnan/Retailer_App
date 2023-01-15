using Retailer_App.Models;
using Retailer_App.Setup;
using Retailer_App.Views.Home;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Retailer_App.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public UserViewModel()
        {
            collection = new ObservableCollection<User>();
            dbconn = new Db_Connection();
            model = new User();

            InsertCommand = new RelayCommand(async () => await InsertDataAsync());
            UpdateCommand = new RelayCommand(async () => await UpdateDataAsync());
            DeleteCommand = new RelayCommand(async () => await DeleteDataAsync());
            SelectCommand = new RelayCommand(async () => await ReadDataAsync());
            LoginCommand = new RelayCommand(async () => await LoginDataAsync());
            SelectCommand.Execute(null);
        }

        public RelayCommand InsertCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand SelectCommand { get; set; }
        public RelayCommand LoginCommand { get; set; }

        public ObservableCollection<User> Collection
        {
            get
            {
                return collection;
            }
            set
            {
                collection = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(null));
            }
        }

        public User Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value != null)
                {
                    IsChecked = (value.Status == "Active") ? true : false;
                }
                model = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(null));
            }
        }

        public bool IsChecked
        {
            get
            {
                return check;
            }
            set
            {
                check = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(null));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event Action OnCallBack;

        private readonly Db_Connection dbconn;
        private ObservableCollection<User> collection;
        private User model;
        private bool check;

        private async Task ReadDataAsync()
        {
            dbconn.OpenConnection();

            await Task.Delay(0);
            var query = "SELECT * FROM users";
            var sqlcmd = new SqlCommand(query, dbconn.SqlConnect);
            var sqlresult = sqlcmd.ExecuteReader();

            if (sqlresult.HasRows)
            {
                collection.Clear();
                while (sqlresult.Read())
                {
                    collection.Add(new User
                    {
                        Uid = sqlresult[0].ToString(),
                        Name = sqlresult[1].ToString(),
                        UserName = sqlresult[2].ToString(),
                        Keypass = sqlresult[3].ToString(),
                        Status = (sqlresult[4].ToString() == "1") ?
                        "Active" :
                        "Not Active",
                    });
                }
            }
            dbconn.CloseConnection();
            OnCallBack?.Invoke();
        }

        private async Task InsertDataAsync()
        {
            if (IsValidating())
            {
                dbconn.OpenConnection();
                var state = check ? "1" : "0";
                var query = $"INSERT INTO users VALUES (" +
                            $"'{model.Name}', " +
                            $"'{model.UserName}', " +
                            $"'{model.Keypass}', " +
                            $"'{state}')";
                var sqlcmd = new SqlCommand(query, dbconn.SqlConnect);
                sqlcmd.ExecuteNonQuery();
                dbconn.CloseConnection();
                await ReadDataAsync();
            }
        }

        private async Task UpdateDataAsync()
        {
            if (IsValidating())
            {
                dbconn.OpenConnection();
                var state = check ? "1" : "0";
                var query = $"UPDATE users SET " +
                            $"name = '{model.Name}', " +
                            $"username = '{model.UserName}', " +
                            $"keypass = '{model.Keypass}', " +
                            $"status = '{state}' " +
                            $"WHERE uid = '{model.Uid}'";
                var sqlcmd = new SqlCommand(query, dbconn.SqlConnect);
                sqlcmd.ExecuteNonQuery();
                dbconn.CloseConnection();
                await ReadDataAsync();
            }
        }

        private async Task DeleteDataAsync()
        {
            if (IsValidating())
            {
                var msg = MessageBox.Show("Apakah Kamu Yakin", "Question",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (msg == MessageBoxResult.Yes)
                {
                    dbconn.OpenConnection();
                    var query = $"DELETE FROM users WHERE uid = '{model.Uid}'";
                    var sqlcmd = new SqlCommand(query, dbconn.SqlConnect);
                    sqlcmd.ExecuteNonQuery();
                    dbconn.CloseConnection();
                }
                await ReadDataAsync();
            }
        }

        private async Task LoginDataAsync()
        {
            await Task.Delay(0);
            dbconn.OpenConnection();
            var query = "SELECT * FROM users WHERE username = '" + Model.UserName + "' AND keypass = '" + Model.Keypass + "'";
            var sqlcmd = new SqlCommand(query, dbconn.SqlConnect);
            var sqlresult = sqlcmd.ExecuteReader();

            if(sqlresult.HasRows)
            {
                collection.Clear();
                while (sqlresult.Read()) {
                    App.SessionUid = sqlresult[0].ToString();
                    App.SessionUser = sqlresult[1].ToString();
                }
                App.Dashboard = new Dashboard();
                App.Dashboard.Show();
                OnCallBack?.Invoke();
            } else
            {
                MessageBox.Show("Login Failed please check User or Password", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            dbconn.CloseConnection();
        }

        private bool IsValidating()
        {
            var flag = true;
            if (model.Name == null)
            {
                MessageBox.Show("Teks 1 tidak boleh kosong!!", "Warning",
                                MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
                flag = false;
            }
            else if (model.UserName == null)
            {
                MessageBox.Show("Teks 2 tidak boleh kosong!!", "Warning",
                                MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
                flag = false;
            }
            else if (model.Keypass == null)
            {
                MessageBox.Show("Teks 1 tidak boleh kosong!!", "Warning",
                                MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
                flag = false;
            }
            return flag;
        }
    }
}

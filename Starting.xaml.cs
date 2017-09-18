using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Projekt_philipmetzger
{
    /// <summary>
    /// Interaktionslogik für Starting.xaml
    /// </summary>
    public partial class Starting : Window
    {
        public Starting()
        {
            InitializeComponent();
            Sqlconnection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            throw new NotImplementedException();
        }

        private void Sqlconnection()
        {
            SqlConnection thisConnection = new SqlConnection(@"Server=(local);Database=M120_db;Trusted_Connection=Yes;");
            thisConnection.Open();

            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = ("");

        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            Window overviewWindow = new OverviewWindow();
            overviewWindow.Show();
            this.Close();
        }

        private void checkBoxSaveUsername_Checked(object sender, RoutedEventArgs e)
        {
            bool Saved = false;
            if (Saved == true)
            {
               Properties.Settings.Default.GetUsername;
               Properties.Settings.Default.Save();
            }
            else
            {
                return;
            }

            

        }
        public String GetUsername
        {
            get { return txtBoxUsername.Text; }
        }
    }
}

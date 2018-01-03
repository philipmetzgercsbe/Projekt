using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Projekt_philipmetzger
{
    /// <summary>
    /// Interaktionslogik für OverviewWindow.xaml
    /// </summary>
    public partial class OverviewWindow : Window
    {
        SqlConnection con = new SqlConnection(@"Server=(local);Database=M120_db;Trusted_Connection=Yes;");
        SqlCommand cmd = new SqlCommand();
        

        public OverviewWindow()
        {
            InitializeComponent();



        }
       public static void loadHomeImage()
        {
            BitmapImage bi = new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            bi.BeginInit();
            bi.UriSource = new Uri(@"../images/hotel.jpg", UriKind.Absolute);
            bi.EndInit();
            // Set the image source.
            
        }




        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBox.Text = "";
            String Search = SearchBox.Text;
            if (!String.IsNullOrEmpty(SearchBox.Text) )
            {
                con.Open();
                cmd.CommandText = ("select * from Hotel,Kunde,Kunde_Reise,Reise,Reise_Hotel where" + Search + ";");
                Window searchwindow = new SearchWindow();
                TextBox searchTextOutput = new TextBox();
                SqlDataReader reader = cmd.ExecuteReader();
                //searchTextOutput = reader.Read().ToString();
               

            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Ungültige Eingabe", "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    Application.Current.Shutdown();
                }
            };
            
        }

        private void textBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            cmd.CommandText = ("Select * from Hotel");
            DataGrid hotelSearch = new DataGrid();
            SqlDataReader reader = cmd.ExecuteReader();
            hotelSearch.= reader; 
        }
    }
}

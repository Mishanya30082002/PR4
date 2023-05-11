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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProdavanBaseEntities2 _DB;
        public MainWindow()
        {
            InitializeComponent();
            _DB = new ProdavanBaseEntities2();
        }
        public void ShowTablesAndUpdate()
        {
            if (comBObox.SelectedIndex == 0)
            {
                MainGrid.ItemsSource = _DB.Postavchik.ToList();
                MainGrid.Columns[0].Visibility = Visibility.Hidden;
                
            }
            if (comBObox.SelectedIndex == 1)
            {
                MainGrid.ItemsSource = _DB.Postavka.ToList();
                MainGrid.Columns[0].Visibility = Visibility.Hidden;
                
            }
            if (comBObox.SelectedIndex == 2)
            {
                MainGrid.ItemsSource = _DB.Tovar.ToList();
                MainGrid.Columns[0].Visibility = Visibility.Hidden;
            }
            if (comBObox.SelectedIndex == 3)
            {
                MainGrid.ItemsSource = _DB.Zakaz.ToList();
                MainGrid.Columns[0].Visibility = Visibility.Hidden;

            }
            if (comBObox.SelectedIndex == 4)
            {
                MainGrid.ItemsSource = _DB.Zakazchik.ToList();
                MainGrid.Columns[0].Visibility = Visibility.Hidden;

            }
            
        }
        public void ShowTables()
        {
            if (comBObox.SelectedIndex == 0)
            {
                MainGrid.Columns[0].Visibility = Visibility.Hidden;
                
            }
            if (comBObox.SelectedIndex == 1)
            {
                MainGrid.Columns[0].Visibility = Visibility.Hidden;
                

            }
            if (comBObox.SelectedIndex == 2)
            {
                MainGrid.Columns[0].Visibility = Visibility.Hidden;
            }
            if (comBObox.SelectedIndex == 3)
            {
                MainGrid.Columns[0].Visibility = Visibility.Hidden;

            }
            if (comBObox.SelectedIndex == 4)
            {
                MainGrid.Columns[0].Visibility = Visibility.Hidden;

            }
        }

        private void comBObox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowTablesAndUpdate();
        }

        private void TextLookFor_TextChanged(object sender, TextChangedEventArgs e)
        {
            string inputtext = TextLookFor.Text.ToLower();

            if (comBObox.SelectedIndex == 0 && TextLookFor.Text != "")
            {
                List<Postavchik> listJ = _DB.Postavchik.ToList();
                var postavchik = listJ.Where(
                l => l.id.ToString().ToLower().Contains(inputtext) ||
                l.NazvanieOrganizacii.ToString().ToLower().Contains(inputtext) ||
                l.PhoneNumber.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = postavchik.ToList();
            }
            else if (comBObox.SelectedIndex == 0 && TextLookFor.Text == "")
            {
                ShowTablesAndUpdate();
            }

            if (comBObox.SelectedIndex == 1)
            {
                List<Postavka> listS = _DB.Postavka.ToList();
                var postavka = listS.Where(
                l => l.id.ToString().ToLower().Contains(inputtext) ||
                l.Postavchik.ToString().ToLower().Contains(inputtext) ||
                l.Tovar.ToString().ToLower().Contains(inputtext) ||
                l.Kolichestvo.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = postavka.ToList();
            }
            else if (comBObox.SelectedIndex == 1 && TextLookFor.Text == "")
            {
                ShowTablesAndUpdate();
            }

            if (comBObox.SelectedIndex == 2)
            {
                List<Tovar> listS = _DB.Tovar.ToList();
                var tovar = listS.Where(
                l => l.id.ToString().ToLower().Contains(inputtext) ||
                l.NazvanieTovara.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = tovar.ToList();

            }
            else if (comBObox.SelectedIndex == 2 && TextLookFor.Text == "")
            {
                ShowTablesAndUpdate();
            }

            if (comBObox.SelectedIndex == 3)
            {
                List<Zakaz> listS = _DB.Zakaz.ToList();
                var zakaz = listS.Where(
                l => l.id.ToString().ToLower().Contains(inputtext) ||
                l.Zakazchik.ToString().ToLower().Contains(inputtext) ||
                l.Tovar.ToString().ToLower().Contains(inputtext) ||
                l.Kolichestvo.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = zakaz.ToList();

            }
            else if (comBObox.SelectedIndex == 3 && TextLookFor.Text == "")
            {
                ShowTablesAndUpdate();
            }

            if (comBObox.SelectedIndex == 4)
            {
                List<Zakazchik> listS = _DB.Zakazchik.ToList();
                var zakazchik = listS.Where(
                l => l.id.ToString().ToLower().Contains(inputtext) ||
                l.FIO.ToString().ToLower().Contains(inputtext) ||
                l.PhoneNumber.ToString().ToLower().Contains(inputtext) ||
                l.Email.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = zakazchik.ToList();

            }
            else if (comBObox.SelectedIndex == 4 && TextLookFor.Text == "")
            {
                ShowTablesAndUpdate();
            }
        }

        private void b_ADD_Click(object sender, RoutedEventArgs e)
        {
            if (comBObox.SelectedIndex == 0)
            {
                Postavchik postacxhik = new Postavchik();
                postacxhik.NazvanieOrganizacii = null;
                postacxhik.PhoneNumber = null;
                _DB.Postavchik.Add(postacxhik);
                _DB.SaveChanges();
                ShowTablesAndUpdate();
            }
            if (comBObox.SelectedIndex == 1)
            {
                Postavka postavka = new Postavka();
                postavka.Postavchik = null;
                postavka.Tovar = null;
                postavka.Kolichestvo = null;
                _DB.Postavka.Add(postavka);
                _DB.SaveChanges();
                ShowTablesAndUpdate();

            }
            if (comBObox.SelectedIndex == 2)
            {
                Tovar tovar = new Tovar();
                tovar.NazvanieTovara = null;
                _DB.Tovar.Add(tovar);
                _DB.SaveChanges();
                ShowTablesAndUpdate();

            }
            if (comBObox.SelectedIndex == 3)
            {
                Zakaz zakaz = new Zakaz();
                zakaz.Zakazchik = null;
                zakaz.Tovar = null;
                zakaz.Kolichestvo = null;
                _DB.Zakaz.Add(zakaz);
                _DB.SaveChanges();
                ShowTablesAndUpdate();

            }
            if (comBObox.SelectedIndex == 4)
            {
                Zakazchik zakazchik = new Zakazchik();
                zakazchik.FIO = null;
                zakazchik.PhoneNumber = null;
                zakazchik.Email = null;
                _DB.Zakazchik.Add(zakazchik);
                _DB.SaveChanges();
                ShowTablesAndUpdate();

            }
        }

        private void b_REMOVE_Click(object sender, RoutedEventArgs e)
        {
            if (comBObox.SelectedIndex == 0)
            {
                Postavchik postavchik = MainGrid.SelectedItem as Postavchik;
                _DB.Postavchik.Remove(postavchik);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.Postavchik.ToList();
                ShowTables();
            }
            if (comBObox.SelectedIndex == 1)
            {
                Postavka postavka = MainGrid.SelectedItem as Postavka;
                _DB.Postavka.Remove(postavka);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.Postavka.ToList();
                ShowTables();

            }
            if (comBObox.SelectedIndex == 2)
            {
                Tovar tovar = MainGrid.SelectedItem as Tovar;
                _DB.Tovar.Remove(tovar);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.Tovar.ToList();
                ShowTables();

            }
            if (comBObox.SelectedIndex == 3)
            {
                Zakaz zakaz = MainGrid.SelectedItem as Zakaz;
                _DB.Zakaz.Remove(zakaz);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.Zakaz.ToList();
                ShowTables();

            }
            if (comBObox.SelectedIndex == 4)
            {
                Zakazchik zakazchik = MainGrid.SelectedItem as Zakazchik;
                _DB.Zakazchik.Remove(zakazchik);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.Zakazchik.ToList();
                ShowTables();

            }
        }

        private void b_Update_Click(object sender, RoutedEventArgs e)
        {
            ShowTablesAndUpdate();
        }

        private void b_SAVE_Click(object sender, RoutedEventArgs e)
        {
            if (comBObox.SelectedIndex == 0)
            {

                _DB.SaveChanges();
                ShowTablesAndUpdate();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form2 : Form
    {
        List<Client> clients = new List<Client>();
        List<Vehicle> vehicles = new List<Vehicle>();
        List<Rental> rentals = new List<Rental>();
        public Form2()
        {
            InitializeComponent();
        }
        private void LoadClients(string file)
        {
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                Client client = new Client();
                client.Nit = Convert.ToInt32(sr.ReadLine());
                client.Name = sr.ReadLine();
                client.Adress = sr.ReadLine();
                clients.Add(client);
            }
            fs.Close();
            sr.Close();
        }
        private void LoadVehicles(string file)
        {
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Id = sr.ReadLine();
                vehicle.Brand = sr.ReadLine();
                vehicle.Model = Convert.ToInt32(sr.ReadLine());
                vehicle.Color = sr.ReadLine();
                vehicle.KMPrice = (float)Convert.ToDouble(sr.ReadLine());
                vehicles.Add(vehicle);
            }
            fs.Close();
            sr.Close();
        }
        private void LoadDataGridViews()
        {

            greaterKMLabel.Text = rentals.OrderByDescending(x => x.KMTraveled)
                .ToList()[0].KMTraveled.ToString();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = rentals;
            dataGridView3.Refresh();
        }

        private void reigstrarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadClients("Clientes.txt");
            LoadVehicles("Vehiculos.txt");
            LoadRentals("Alquileres.txt");
            LoadDataGridViews();
        }

        private void rentalButton_Click_1(object sender, EventArgs e)
        {
            Rental rental = new Rental();
            rental.StartDate = DateTime.Now;
            rental.EndDate = dateTimePicker2.Value;
            int nit = Convert.ToInt32(nitTextBox.Text);
            var client = clients.Find(c => c.Nit == nit);
            rental.Name = client.Name;
            string id = rentalIdTextBox.Text;
            var vehicle = vehicles.Find(v => v.Id.Equals(id));
            rental.Brand = vehicle.Brand;
            rental.Id = vehicle.Id;
            rental.KMPrice = vehicle.KMPrice;
            rental.Color = vehicle.Color;
            rental.Model = vehicle.Model;
            rental.KMTraveled = vehicle.KMPrice * Convert.ToInt32(traveledTextBox.Text);
            rentals.Add(rental);
            LoadDataGridViews();
            SaveRentals();
        }
        private void SaveRentals()
        {
            string file = "Alquileres.txt";
            FileStream fs = new FileStream(file, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (Rental rental in rentals)
            {
                sw.WriteLine(rental.Name);
                sw.WriteLine(rental.StartDate);
                sw.WriteLine(rental.EndDate);
                sw.WriteLine(rental.KMTraveled);
                sw.WriteLine(rental.Id);
                sw.WriteLine(rental.Brand);
                sw.WriteLine(rental.Model);
                sw.WriteLine(rental.Color);
                sw.WriteLine(rental.KMPrice);
            }
            sw.Close();
            fs.Close();
        }
        private void LoadRentals(string file)
        {
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                Rental rental = new Rental();
                rental.Name = sr.ReadLine();
                rental.StartDate = Convert.ToDateTime(sr.ReadLine());
                rental.EndDate = Convert.ToDateTime(sr.ReadLine());
                rental.KMTraveled = (float)Convert.ToDouble(sr.ReadLine());
                rental.Id = sr.ReadLine();
                rental.Brand = sr.ReadLine();
                rental.Model = Convert.ToInt32(sr.ReadLine());
                rental.Color = sr.ReadLine();
                rental.KMPrice = (float)Convert.ToDouble(sr.ReadLine());
                rentals.Add(rental);

            }
            fs.Close();
            sr.Close();
        }
    }
}

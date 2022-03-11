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
    public partial class Form1 : Form
    {
        List<Client> clients = new List<Client>();
        List<Vehicle> vehicles = new List<Vehicle>();
        List<Rental> rentals = new List<Rental>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClients("Clientes.txt");
            LoadVehicles("Vehiculos.txt");
            LoadDataGridViews();
            
        }
        private void LoadDataGridViews()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clients;
            dataGridView1.Refresh();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = vehicles;
            dataGridView2.Refresh();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = rentals;
            dataGridView3.Refresh();

        }
        private void LoadClients(string file)
        {
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while(sr.Peek() != -1)
            {
                Client client = new Client();
                client.Nit = Convert.ToInt32(sr.ReadLine());
                client.Name = sr.ReadLine();
                client.Adress = sr.ReadLine();
                clients.Add(client);
            }
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
                vehicle.Model = sr.ReadLine();
                vehicle.Color = sr.ReadLine();
                vehicle.KMPrice = (float)Convert.ToDouble(sr.ReadLine());
                vehicles.Add(vehicle);
            }
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Id = idTextBox.Text;
            vehicle.Brand = brandTextBox.Text;
            vehicle.Model = modelTextBox.Text;
            vehicle.KMPrice =(float)Convert.ToDouble(KMPriceTextBox.Text);
            vehicle.Color = colorTextBox.Text;
            vehicles.Add(vehicle);
            LoadDataGridViews();
        }

        private void rentalButton_Click(object sender, EventArgs e)
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
            rental.KMTraveled = vehicle.KMPrice * Convert.ToInt32(  traveledTextBox.Text);
            rentals.Add(rental);

            LoadDataGridViews();
        }
    }
}

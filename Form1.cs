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
        private void SaveVehicles()
        {
            string file = "Vehiculos.txt";
            FileStream fs = new FileStream(file, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach(Vehicle vehicle in vehicles)
            {
                sw.WriteLine(vehicle.Id);
                sw.WriteLine(vehicle.Brand);
                sw.WriteLine(vehicle.Model);
                sw.WriteLine(vehicle.Color);
                sw.WriteLine(vehicle.KMPrice);
            }
            sw.Close();
            fs.Close();
        }
        private void LoadDataGridViews()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clients;
            dataGridView1.Refresh();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = vehicles;
            dataGridView2.Refresh();

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
            fs.Close ();
            sr.Close ();
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

        private void inputButton_Click(object sender, EventArgs e)
        {

            if (vehicles.FindIndex(v => v.Id.Equals(idTextBox.Text)) == -1)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Id = idTextBox.Text;
                vehicle.Brand = brandTextBox.Text;
                vehicle.Model = Convert.ToInt32(modelTextBox.Text);
                vehicle.KMPrice = (float)Convert.ToDouble(KMPriceTextBox.Text);
                vehicle.Color = colorTextBox.Text;
                vehicles.Add(vehicle);
                LoadDataGridViews();
                SaveVehicles();
            }
            else
            {
                MessageBox.Show("El vehiculo esta repetido", "Error");
            }

        }

        private void alquilarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Show();
            this.Visible = false;
        }
    }
}

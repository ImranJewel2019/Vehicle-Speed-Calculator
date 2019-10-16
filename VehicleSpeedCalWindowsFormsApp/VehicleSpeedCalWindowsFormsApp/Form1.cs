using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSpeedCalWindowsFormsApp
{
    public partial class Form1 : Form
    {
        Vehicle aVehicle;
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowSpeedDetails(object sender, EventArgs e)
        {
            maxSpeedTextBox.Text = aVehicle.GetMaxSpeed().ToString();
            minSpeedTextBox.Text = aVehicle.GetMinSpeed().ToString();
            averageSpeedTextBox.Text = aVehicle.GetAverageSpeed().ToString();
        }

        private void CreateVehicle_Click(object sender, EventArgs e)
        {
            string vehicleName = vehicleNameTextBox.Text;
            string registration = regNoTextBox.Text;

            aVehicle = new Vehicle(vehicleName, registration);
        }

        private void EnterSpeed_Click(object sender, EventArgs e)
        {
            string speed = speedTextBox.Text;
            if (string.IsNullOrEmpty(speed)) speed = "0";

            aVehicle.SetSpeed(Convert.ToInt32(speed));
        }


    }
}

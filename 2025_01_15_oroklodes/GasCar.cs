using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_01_15_oroklodes
{
    class GasCar : Car
    {

        public GasCar(string licensePlate = "BBB-222")
        {
            fuel = "benzin";
            //licensePlate = "BBB-222";
            this.licensePlate = licensePlate;
            licensePlateLabel.Text = licensePlate;
            Label oneLabel = new Label() { Text = $"Üzemanyag: {fuel}", Top = 10, Left = 2 };
            this.Controls.Add(oneLabel);
        }
        public override void ClickEvent(Object s, EventArgs e)
        {
            MessageBox.Show($"Az üzemanyag: {fuel}");
        }
    }
}

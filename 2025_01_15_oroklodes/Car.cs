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
    class Car : UserControl
    {
        public string fuel { get; set; }
        public string licensePlate { get; set; }
        public Label licensePlateLabel { get; set; }
        public Car()
        {
            this.Width = 100;
            this.Height = 60;
            this.BackColor = Color.Aqua;
            licensePlate = "AAA-111";
            licensePlateLabel = new Label() { Text = licensePlate, Top = 40, Left = 25, AutoSize = true};
            this.Controls.Add(licensePlateLabel);
            this.Click += ClickEvent;
        }
        public virtual void ClickEvent(Object s, EventArgs e)
        {
            MessageBox.Show($"Az a rendszáma: {licensePlate}");
        }
    }
}

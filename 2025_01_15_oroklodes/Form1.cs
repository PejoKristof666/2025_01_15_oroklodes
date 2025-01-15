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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        void Start()
        {
            Car oneCar = new Car();
            this.Controls.Add(oneCar);
            GasCar carTwo = new GasCar() { Top = oneCar.Bottom + 10 };
            this.Controls.Add(carTwo);
            GasCar carThree = new GasCar() { Top = oneCar.Bottom + 80 };
            this.Controls.Add(carThree);
        }
    }
}

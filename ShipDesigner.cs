using sim.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//debug
using System.Runtime.InteropServices;

namespace sim
{
    public partial class ShipDesigner : Form
    {

        private List<Part> AllParts;
        private List<Part> hardpoints;
        private MainWindow mainWindow;

        public ShipDesigner(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            //debug
            AllocConsole();
            hullComboBox.DataSource = Enum.GetValues(typeof(HullType));
            AllParts = new List<Part>();

            AllParts.Add(new Part());
            AllParts.Add(new RepairModule("V1-Basic repair module", 10, "Basic repair module repairing 3 damage every 5 ticks.", 5));
            AllParts.Add(new Weapon("Simple kinetic repeater", 15, 4, "Simple machinegun that deals ~15 damage every 4 ticks."));
            AllParts.Add(new HealthModule("Reinforced steel plating", "An extra layer of armor applied to the hull, provides 10% more health", 0.10f));

            partList.DataSource = AllParts;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (shipNameBox.Text.Length != 0)
            {
                mainWindow.AddShip(new Ship((HullType)hullComboBox.SelectedItem, shipNameBox.Text, null, 100 * (int)(HullType)hullComboBox.SelectedItem, new List<Part>(hardpoints)));
            }
        }

        private void hullComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hardpointsCount = (int)(HullType)hullComboBox.SelectedItem;
            hardpoints = new List<Part>();
            for (int i = 0; i < hardpointsCount; i++)
            {
                hardpoints.Add(new Part());
            }
            hardpointList.DataSource = hardpoints;
        }

        //debug
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void partList_SelectedIndexChanged(object sender, EventArgs e)
        {
            hardpoints[hardpointList.SelectedIndex] = AllParts[partList.SelectedIndex];
            hardpointList.DataSource = null;
            hardpointList.DataSource = hardpoints;


            if (hardpointList.SelectedItem != null)
            {

                Part? selectedItem = (Part?)partList.SelectedItem;
                partDiscBox.Text = selectedItem.Description;
            }


        }
    }
}

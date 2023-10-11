using sim.model;
using System.ComponentModel;

namespace sim
{
    public partial class MainWindow : Form
    {

        private BindingList<Ship> Ships1, Ships2;
        public Ship Ship1, Ship2;
        private int tickCounter = 0;

        public MainWindow()
        {
            InitializeComponent();
            Ships1 = new BindingList<Ship>();
            Ships2 = new BindingList<Ship>();
            shipBox1.DataSource = Ships1;
            shipBox2.DataSource = Ships2;
        }

        public void AddShip(Ship ship)
        {
            
            Ships1.Add(ship);
            Ships2.Add(ship);
            SelectShips();
            //LoadShipInfo();
        }

        private void CreateShipButton_Click(object sender, EventArgs e)
        {
            Form designer = new ShipDesigner(this);
            designer.ShowDialog();
        }

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            if (shipBox1.SelectedItem != null && shipBox2.SelectedItem != null)
            {
                shipBox1.Enabled = false;
                shipBox2.Enabled = false;

                Ship1.Enemy = Ship2;
                Ship2.Enemy = Ship1;

                Thread thread = new Thread(new ThreadStart(this.Simulate));
                thread.IsBackground = true;
                thread.Start();

                //shipBox1.Enabled = true;
                //shipBox2.Enabled = true;
            }

        }

        private void Simulate()
        {


            while (Ship1.CurrentHealth != 0 || Ship2.CurrentHealth != 0 )
            {

                battleConsole.Invoke(new Action(() =>
                {
                    battleConsole.SelectionStart = battleConsole.TextLength;
                    battleConsole.SelectionLength = 0;
                    battleConsole.SelectionColor = Color.Blue;
                }));
                
                Ship1.UpdateTick(battleConsole);
                battleConsole.Invoke(new Action(() =>
                {
                    battleConsole.SelectionStart = battleConsole.TextLength;
                    battleConsole.SelectionLength = 0;
                    battleConsole.SelectionColor = Color.Red;
                }));
                Ship2.UpdateTick(battleConsole);

                

                tickCounter++;

                LoadShipInfo();
                Thread.Sleep(400);
            }


        }

        private void shipBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ship1 = shipBox1.SelectedItem as Ship;
            ResetAndLoadShip(Ship1);
        }

        private void shipBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ship2 = shipBox2.SelectedItem as Ship;
            ResetAndLoadShip(Ship2);
        }

        private void ResetAndLoadShip(Ship ship)
        {
            if (ship != null)
            {
                ship.ResetStats();
                ship.ApplyParts();
                LoadShipInfo();
            }
        }

        private void SelectShips()
        {
            Ship1 = shipBox1.SelectedItem as Ship;
            Ship2 = shipBox2.SelectedItem as Ship;
            ResetAndLoadShip(Ship1);
            ResetAndLoadShip(Ship2);
        }

        private void LoadShipInfo()
        {
            if (Ship1 != null && Ship2 != null)
            {
                if(progressBar1.InvokeRequired || progressBar2.InvokeRequired || healthLabel1.InvokeRequired || healthLabel2.InvokeRequired || tickLabel.InvokeRequired)
                {
                    progressBar1.Invoke(new Action((LoadShipInfo)));
                        return;
                }

                Console.WriteLine((Ship1.CurrentHealth / Ship1.CurrentMaxHealth) * 100);

                progressBar1.Value = (int)(((float)Ship1.CurrentHealth / (float)Ship1.CurrentMaxHealth) * 100.0f);
                progressBar2.Value = (int)(((float)Ship2.CurrentHealth / (float)Ship2.CurrentMaxHealth) * 100.0f);
                healthLabel1.Text = Ship1.CurrentHealth.ToString() + " / " + Ship1.CurrentMaxHealth.ToString();
                healthLabel2.Text = Ship2.CurrentHealth.ToString() + " / " + Ship2.CurrentMaxHealth.ToString();

                tickLabel.Text = "Tick: " + tickCounter.ToString();
            }
        }
    }
}
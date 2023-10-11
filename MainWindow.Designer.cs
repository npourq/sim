namespace sim
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreateShipButton = new Button();
            SimulateButton = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            shipBox1 = new ComboBox();
            shipBox2 = new ComboBox();
            tickLabel = new Label();
            battleConsole = new RichTextBox();
            healthLabel1 = new Label();
            healthLabel2 = new Label();
            SuspendLayout();
            // 
            // CreateShipButton
            // 
            CreateShipButton.Location = new Point(12, 12);
            CreateShipButton.Name = "CreateShipButton";
            CreateShipButton.Size = new Size(128, 23);
            CreateShipButton.TabIndex = 0;
            CreateShipButton.Text = "Create ships";
            CreateShipButton.UseVisualStyleBackColor = true;
            CreateShipButton.Click += CreateShipButton_Click;
            // 
            // SimulateButton
            // 
            SimulateButton.Location = new Point(58, 415);
            SimulateButton.Name = "SimulateButton";
            SimulateButton.Size = new Size(106, 23);
            SimulateButton.TabIndex = 1;
            SimulateButton.Text = "Simulate";
            SimulateButton.UseVisualStyleBackColor = true;
            SimulateButton.Click += SimulateButton_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 60);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(525, 23);
            progressBar1.TabIndex = 2;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(268, 379);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(525, 23);
            progressBar2.TabIndex = 3;
            // 
            // shipBox1
            // 
            shipBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            shipBox1.FormattingEnabled = true;
            shipBox1.Location = new Point(636, 60);
            shipBox1.Name = "shipBox1";
            shipBox1.Size = new Size(152, 23);
            shipBox1.TabIndex = 4;
            shipBox1.SelectedIndexChanged += shipBox1_SelectedIndexChanged;
            // 
            // shipBox2
            // 
            shipBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            shipBox2.FormattingEnabled = true;
            shipBox2.Location = new Point(12, 379);
            shipBox2.Name = "shipBox2";
            shipBox2.Size = new Size(152, 23);
            shipBox2.TabIndex = 5;
            shipBox2.SelectedIndexChanged += shipBox2_SelectedIndexChanged;
            // 
            // tickLabel
            // 
            tickLabel.AutoSize = true;
            tickLabel.Location = new Point(12, 419);
            tickLabel.Name = "tickLabel";
            tickLabel.Size = new Size(40, 15);
            tickLabel.TabIndex = 7;
            tickLabel.Text = "Tick: 0";
            // 
            // battleConsole
            // 
            battleConsole.Location = new Point(12, 89);
            battleConsole.Name = "battleConsole";
            battleConsole.ReadOnly = true;
            battleConsole.Size = new Size(776, 284);
            battleConsole.TabIndex = 8;
            battleConsole.Text = "";
            // 
            // healthLabel1
            // 
            healthLabel1.AutoSize = true;
            healthLabel1.Location = new Point(565, 63);
            healthLabel1.Name = "healthLabel1";
            healthLabel1.Size = new Size(38, 15);
            healthLabel1.TabIndex = 9;
            healthLabel1.Text = "-- / --";
            // 
            // healthLabel2
            // 
            healthLabel2.AutoSize = true;
            healthLabel2.Location = new Point(196, 384);
            healthLabel2.Name = "healthLabel2";
            healthLabel2.Size = new Size(38, 15);
            healthLabel2.TabIndex = 10;
            healthLabel2.Text = "-- / --";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(healthLabel2);
            Controls.Add(healthLabel1);
            Controls.Add(battleConsole);
            Controls.Add(tickLabel);
            Controls.Add(shipBox2);
            Controls.Add(shipBox1);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(SimulateButton);
            Controls.Add(CreateShipButton);
            Name = "MainWindow";
            Text = "Sim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateShipButton;
        private Button SimulateButton;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ComboBox shipBox1;
        private ComboBox shipBox2;
        private Label tickLabel;
        private RichTextBox battleConsole;
        private Label healthLabel1;
        private Label healthLabel2;
    }
}
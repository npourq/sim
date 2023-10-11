namespace sim
{
    partial class ShipDesigner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            shipNameBox = new ComboBox();
            label1 = new Label();
            hardpointList = new ListBox();
            label2 = new Label();
            hullComboBox = new ComboBox();
            SaveButton = new Button();
            partList = new ListBox();
            partDiscBox = new RichTextBox();
            SuspendLayout();
            // 
            // shipNameBox
            // 
            shipNameBox.FormattingEnabled = true;
            shipNameBox.Location = new Point(76, 6);
            shipNameBox.Name = "shipNameBox";
            shipNameBox.Size = new Size(216, 23);
            shipNameBox.TabIndex = 0;
            shipNameBox.Text = "Ship name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // hardpointList
            // 
            hardpointList.FormattingEnabled = true;
            hardpointList.ItemHeight = 15;
            hardpointList.Location = new Point(12, 64);
            hardpointList.Name = "hardpointList";
            hardpointList.Size = new Size(280, 334);
            hardpointList.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Hull type:";
            // 
            // hullComboBox
            // 
            hullComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            hullComboBox.FormattingEnabled = true;
            hullComboBox.Location = new Point(76, 35);
            hullComboBox.Name = "hullComboBox";
            hullComboBox.Size = new Size(216, 23);
            hullComboBox.TabIndex = 3;
            hullComboBox.SelectedIndexChanged += hullComboBox_SelectedIndexChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(116, 412);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // partList
            // 
            partList.FormattingEnabled = true;
            partList.ItemHeight = 15;
            partList.Location = new Point(298, 64);
            partList.Name = "partList";
            partList.Size = new Size(280, 334);
            partList.TabIndex = 6;
            partList.SelectedIndexChanged += partList_SelectedIndexChanged;
            // 
            // partDiscBox
            // 
            partDiscBox.Location = new Point(584, 64);
            partDiscBox.Name = "partDiscBox";
            partDiscBox.Size = new Size(251, 334);
            partDiscBox.TabIndex = 7;
            partDiscBox.Text = "";
            // 
            // ShipDesigner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(partDiscBox);
            Controls.Add(partList);
            Controls.Add(SaveButton);
            Controls.Add(label2);
            Controls.Add(hullComboBox);
            Controls.Add(hardpointList);
            Controls.Add(label1);
            Controls.Add(shipNameBox);
            Name = "ShipDesigner";
            Text = "Ship designer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox shipNameBox;
        private Label label1;
        private ListBox hardpointList;
        private Label label2;
        private ComboBox hullComboBox;
        private Button SaveButton;
        private ListBox partList;
        private RichTextBox partDiscBox;
    }
}
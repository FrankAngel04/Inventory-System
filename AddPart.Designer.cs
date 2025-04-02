namespace FrankInventorySystem
{
    partial class AddPart
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
            this.modifyPartLabel = new System.Windows.Forms.Label();
            this.inHouseRadio = new System.Windows.Forms.RadioButton();
            this.outSourcedRadio = new System.Windows.Forms.RadioButton();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.invTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifyPartLabel
            // 
            this.modifyPartLabel.AutoSize = true;
            this.modifyPartLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartLabel.Location = new System.Drawing.Point(25, 29);
            this.modifyPartLabel.Name = "modifyPartLabel";
            this.modifyPartLabel.Size = new System.Drawing.Size(62, 16);
            this.modifyPartLabel.TabIndex = 0;
            this.modifyPartLabel.Text = "Add Part";
            // 
            // inHouseRadio
            // 
            this.inHouseRadio.AutoSize = true;
            this.inHouseRadio.Location = new System.Drawing.Point(121, 29);
            this.inHouseRadio.Name = "inHouseRadio";
            this.inHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.inHouseRadio.TabIndex = 0;
            this.inHouseRadio.TabStop = true;
            this.inHouseRadio.Text = "In-House";
            this.inHouseRadio.UseVisualStyleBackColor = true;
            this.inHouseRadio.CheckedChanged += new System.EventHandler(this.inHouseRadio_CheckedChanged);
            // 
            // outSourcedRadio
            // 
            this.outSourcedRadio.AutoSize = true;
            this.outSourcedRadio.Location = new System.Drawing.Point(234, 29);
            this.outSourcedRadio.Name = "outSourcedRadio";
            this.outSourcedRadio.Size = new System.Drawing.Size(82, 17);
            this.outSourcedRadio.TabIndex = 1;
            this.outSourcedRadio.TabStop = true;
            this.outSourcedRadio.Text = "OutSourced";
            this.outSourcedRadio.UseVisualStyleBackColor = true;
            this.outSourcedRadio.CheckedChanged += new System.EventHandler(this.outSourcedRadio_CheckedChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(124, 97);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(107, 126);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(91, 156);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 5;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(79, 186);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(63, 13);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price / Cost";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(118, 215);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 7;
            this.minLabel.Text = "Min";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(84, 248);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Machine ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(167, 126);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // invTextBox
            // 
            this.invTextBox.Location = new System.Drawing.Point(167, 156);
            this.invTextBox.Name = "invTextBox";
            this.invTextBox.Size = new System.Drawing.Size(100, 20);
            this.invTextBox.TabIndex = 4;
            this.invTextBox.TextChanged += new System.EventHandler(this.invTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(167, 97);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(167, 186);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 5;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(167, 215);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(67, 20);
            this.minTextBox.TabIndex = 6;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(167, 248);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 8;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(268, 215);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 16;
            this.maxLabel.Text = "Max";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(314, 215);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(67, 20);
            this.maxTextBox.TabIndex = 7;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(121, 353);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(89, 47);
            this.save.TabIndex = 9;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(234, 353);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(89, 47);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.invTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.outSourcedRadio);
            this.Controls.Add(this.inHouseRadio);
            this.Controls.Add(this.modifyPartLabel);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifyPartLabel;
        private System.Windows.Forms.RadioButton inHouseRadio;
        private System.Windows.Forms.RadioButton outSourcedRadio;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox invTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
    }
}
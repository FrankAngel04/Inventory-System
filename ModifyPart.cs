using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrankInventorySystem
{
    public partial class ModifyPart : Form
    {
        private Inventory inventory;
        public ModifyPart(Inventory inventory, Part showText)
        {
            InitializeComponent();
            this.inventory = inventory;
            // Set the form's start position to the center of the screen
            StartPosition = FormStartPosition.CenterScreen;

            // Populate the text boxes with the part's current properties
            idTextBox.Text = showText.PartID.ToString();
            nameTextBox.Text = showText.Name;
            invTextBox.Text = showText.InStock.ToString();
            priceTextBox.Text = showText.Price.ToString();
            minTextBox.Text = showText.Min.ToString();
            maxTextBox.Text = showText.Max.ToString();

            // If the part is an InHouse part or a Outsourced part
            if (showText is Inhouse inhousePart)
            {
                // Check the inHouseRadio button and set the textBox text to the MachineID
                inHouseRadio.Checked = true;
                textBox.Text = inhousePart.MachineID.ToString();
            }
            else if (showText is Outsourced outsourcedPart)
            {
                // Check the outSourcedRadio button and set the textBox text to the CompanyName
                outSourcedRadio.Checked = true;
                textBox.Text = outsourcedPart.CompanyName;
            }
        }

        // If the inHouseRadio button is checked, it changes the label text to "Machine ID".
        // If the text in the textBox is not a number, it changes the background color to red.
        // Otherwise, it changes the background color to the default color.
        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseRadio.Checked)
            {
                label.Text = "Machine ID";
                textBox.BackColor = !int.TryParse(textBox.Text, out _) ? Color.Red : SystemColors.Window;
            }
        }

        // If the outSourcedRadio button is checked, it changes the label text to "Company Name".
        // If the text in the textBox is empty, it changes the background color to red.
        // Otherwise, it changes the background color to the default color.
        private void outSourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (outSourcedRadio.Checked)
            {
                label.Text = "Company Name";
                textBox.BackColor = string.IsNullOrWhiteSpace(textBox.Text) ? Color.Red : SystemColors.Window;
            }
        }

        // These methods are triggered when the text in the TextBox changes.
        // If it's incorrect, it changes the background color of the text box to red.
        // Otherwise, it changes the background color to the default color.
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.BackColor = string.IsNullOrWhiteSpace(nameTextBox.Text) ? Color.Red : SystemColors.Window;
        }

        private void invTextBox_TextChanged(object sender, EventArgs e)
        {
            invTextBox.BackColor = !int.TryParse(invTextBox.Text, out _) ? Color.Red : SystemColors.Window;
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            priceTextBox.BackColor = !decimal.TryParse(priceTextBox.Text, out _) ? Color.Red : SystemColors.Window;
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            minTextBox.BackColor = !int.TryParse(minTextBox.Text, out _) ? Color.Red : SystemColors.Window;
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            maxTextBox.BackColor = !int.TryParse(maxTextBox.Text, out _) ? Color.Red : SystemColors.Window;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (inHouseRadio.Checked)
            {
                textBox.BackColor = !int.TryParse(textBox.Text, out _) ? Color.Red : SystemColors.Window;
            }
            else if (outSourcedRadio.Checked)
            {
                textBox.BackColor = string.IsNullOrWhiteSpace(textBox.Text) ? Color.Red : SystemColors.Window;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            // Reset the background color of all TextBoxes
            nameTextBox.BackColor = SystemColors.Window;
            invTextBox.BackColor = SystemColors.Window;
            priceTextBox.BackColor = SystemColors.Window;
            minTextBox.BackColor = SystemColors.Window;
            maxTextBox.BackColor = SystemColors.Window;
            textBox.BackColor = SystemColors.Window;

            // Initialize an error message string
            StringBuilder errorMessage = new StringBuilder();

            // Validate the inputs and append error messages to the string
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.BackColor = Color.Red;
                errorMessage.AppendLine("Enter a name!");
            }
            if (!int.TryParse(invTextBox.Text, out int inStock))
            {
                invTextBox.BackColor = Color.Red;
                errorMessage.AppendLine("Enter a numerical inventory count!");
            }
            if (!decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                priceTextBox.BackColor = Color.Red;
                errorMessage.AppendLine("Enter a numerical price!");
            }
            if (!int.TryParse(minTextBox.Text, out int min))
            {
                minTextBox.BackColor = Color.Red;
                errorMessage.AppendLine("Enter a numerical minimum value!");
            }
            if (!int.TryParse(maxTextBox.Text, out int max))
            {
                maxTextBox.BackColor = Color.Red;
                errorMessage.AppendLine("Enter a numerical maximum value!");
            }
            if (inHouseRadio.Checked && !int.TryParse(textBox.Text, out int machineID))
            {
                textBox.BackColor = Color.Red;
                errorMessage.AppendLine("Enter a numerical machine ID!");
            }
            else if (outSourcedRadio.Checked && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = Color.Red;
                errorMessage.AppendLine("Enter a company name!");
            }

            // If the error message string is not empty, display it in a message box
            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage.ToString(), "Error");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Max cannot be Smaller than Min!", "Error");
                return;
            }

            if (inStock < min)
            {
                MessageBox.Show("Inventory cannot be less than Min!", "Error");
                return;
            }
            else if (inStock > max)
            {
                MessageBox.Show("Inventory cannot exceed Max!", "Error");
                return;
            }

            // Get the value from the TextBox
            int partId = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            
            // Creates a new part and adds it to the list of all parts
            if (inHouseRadio.Checked)
            {
                int machine = int.Parse(textBox.Text);
                var newPart = new Inhouse(partId, name, inStock, price, min, max, machine);
                inventory.UpdatePart(partId, newPart);
            }
            else if (outSourcedRadio.Checked)
            {
                string companyName = textBox.Text;
                var newPart = new Outsourced(partId, name, inStock, price, min, max, companyName);
                inventory.UpdatePart(partId, newPart);
            }
            // Close the form
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

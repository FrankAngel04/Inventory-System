using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrankInventorySystem
{
    public partial class ModifyProduct : Form
    {
        // Create a new BindingList to hold the parts to add to the product
        BindingList<Part> partsToAdd = new BindingList<Part>();

        private Inventory inventory;
        private Product product;

        // Constructor
        public ModifyProduct(Inventory inventory, Product product, Product selectedProduct)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.product = product;
            // Set the form's start position to the center of the screen
            StartPosition = FormStartPosition.CenterScreen;
            Shown += Inventory_Shown;
            MouseDown += (s, e) => DeselectAll();

            // Populate the text boxes with the part's current properties
            idTextBox.Text = selectedProduct.ProductID.ToString();
            nameTextBox.Text = selectedProduct.Name;
            invTextBox.Text = selectedProduct.InStock.ToString();
            priceTextBox.Text = selectedProduct.Price.ToString();
            minTextBox.Text = selectedProduct.Min.ToString();
            maxTextBox.Text = selectedProduct.Max.ToString();

            foreach (Part part in selectedProduct.AssociatedParts)
            {
                partsToAdd.Add(part);
            }
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            // Load the parts and products into the DataGridViews
            partsDgv.DataSource = inventory.AllParts;
            associatedProductDgv.DataSource = partsToAdd;
        }

        private void Inventory_Shown(object sender, EventArgs e)
        {
            // It clears the selection in the partsDgv and associatedProductDgv DataGridViews
            partsDgv.ClearSelection();
            associatedProductDgv.ClearSelection();
        }

        private void DeselectAll()
        {
            // Clear the selection of the DataGridViews
            partsDgv.ClearSelection();
            associatedProductDgv.ClearSelection();
        }

        private void search_Click(object sender, EventArgs e)
        {
            // Get the part ID from a text box or some other input
            string lookupValue = searchTextBox.Text;

            if (string.IsNullOrWhiteSpace(lookupValue))
            {
                MessageBox.Show("Please enter in the search bar!", "Part Search");
                return;
            }
            // Loop through the parts in the DataGridView
            foreach (DataGridViewRow row in partsDgv.Rows)
            {
                // If the part name contains the lookup value, call LookupAssociatedPart
                if (row.Cells[1].Value.ToString().ToLower().Contains(lookupValue.ToLower()))
                {
                    // Get the PartID from the DataGridViewRow
                    int partID = (int)row.Cells[0].Value;

                    // Call LookupAssociatedPart with the found PartID
                    product.LookupAssociatedPart(partID);

                    // Select the row
                    if (row.Index < partsDgv.Rows.Count)
                    {
                        partsDgv.CurrentCell = partsDgv[1, row.Index];
                    }
                    return;
                }
            }

            // If the loop completes without finding a match and returning, display a message
            MessageBox.Show("Part Not Found!", "Part Search");
        }
        // Validate the inputs and changes the background color of invalid TextBoxes
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

        private void add_Click(object sender, EventArgs e)
        {
            // Get the selected part from the ModifyPart DataGridView
            Part selectedPart = (Part)partsDgv.CurrentRow.DataBoundItem;

            if (partsDgv.CurrentRow == null || !partsDgv.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a Part to add!", "Select Part");
                return;
            }
            // Add the new AssociatedParts object to the AssociatedParts list
            //product.AddAssociatedPart(selectedPart);
            partsToAdd.Add(selectedPart);

            // Clear the selection in the associated parts DataGridView
            associatedProductDgv.ClearSelection();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (associatedProductDgv.CurrentRow == null || !associatedProductDgv.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a associated part to delete!", "Delete Part");
                return;
            }
            // Get the selected part from the associatedProductDgv DataGridView
            Part delete = (Part)associatedProductDgv.CurrentRow.DataBoundItem;

            var result = MessageBox.Show("Are you sure you want to delete this?", "Delete Part", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Remove the part from the partsToAdd BindingList
                partsToAdd.Remove(delete);
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
                errorMessage.AppendLine("Enter a numerical inventory amount!");
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
                errorMessage.AppendLine("Enter a numerical max value!");
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

            // Check if AssociatedParts.Associated is empty
            /*if (!partsToAdd.Any())
            {
                MessageBox.Show("Please add at least one associated part!","Error");
                return;
            }*/

            // Get the value from the TextBox
            int partId = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;

            // Creates a new part and adds it to the list of all parts
            Product newProduct = new Product(partId, name, inStock, price, min, max);

            // Add the new AssociatedParts object to the AssociatedParts list
            foreach (Part newPart in partsToAdd)
            {
                newProduct.AddAssociatedPart(newPart);
            }

            // Adds the new product to the inventory
            inventory.UpdateProduct(partId, newProduct);

            // Close the form
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

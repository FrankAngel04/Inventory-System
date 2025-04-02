using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrankInventorySystem
{
    public partial class Main : Form
    {
        private Inventory inventory;
        private Product product;
        public Main()
        {
            InitializeComponent();
            inventory = new Inventory();
            product = new Product(1, "Default Product", 0, 0.0m, 0, 0);
            // Set the form's start position to the center of the screen
            StartPosition = FormStartPosition.CenterScreen;
            Shown += Inventory_Shown;
            MouseDown += (s, e) => DeselectAll();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            partsDgv.DataSource = inventory.AllParts;
            productsDgv.DataSource = inventory.Products;

            // Create and add parts
            var inhouseTemp1 = new Inhouse(0, "Wheel", 15, 12m, 5, 25, 1234);
            var inhouseTemp2 = new Inhouse(1, "Pedal", 11, 8m, 5, 25, 1234);
            var outsouredTemp1 = new Outsourced(2, "Chain", 12, 8m, 5, 25, "Builder");
            var outsouredTemp2 = new Outsourced(3, "Seat", 8, 4m, 5, 25, "Builder");
            inventory.AddPart(inhouseTemp1);
            inventory.AddPart(inhouseTemp2);
            inventory.AddPart(outsouredTemp1);
            inventory.AddPart(outsouredTemp2);

            // Create and add a product
            var productTemp1 = new Product(0, "Red Bicycle", 15, 11m, 5, 20);
            var productTemp2 = new Product(1, "Yellow Bicycle", 19, 9m, 5, 20);
            var productTemp3 = new Product(2, "Blue Bicycle", 5, 12m, 5, 20);
            inventory.AddProduct(productTemp1);
            inventory.AddProduct(productTemp2);
            inventory.AddProduct(productTemp3);

            /*var associated1 = new Product(1, "associated1", 5, 2.00m, 1, 100);
            product.AddAssociatedPart(associated1);*/
        }

        private void Inventory_Shown(object sender, EventArgs e)
        {
            partsDgv.ClearSelection();
            productsDgv.ClearSelection();
        }

        private void DeselectAll()
        {
            // Clear the selection of the DataGridViews
            partsDgv.ClearSelection();
            productsDgv.ClearSelection();
        }

        private void lookupPart_Click(object sender, EventArgs e)
        {
            // Get the part ID from a text box or some other input
            string lookupValue = partsTextBox.Text;

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
                    inventory.LookupPart(partID);

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

        private void addPart_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddPart form
            AddPart addPartForm = new AddPart(inventory);

            // Show the AddPart form
            addPartForm.ShowDialog();
        }

        private void updatePart_Click(object sender, EventArgs e)
        {
            if (partsDgv.CurrentRow == null || !partsDgv.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a row to modify!", "Modify Part");
                return;
            }
            // Create an instance of the ModifyPart form
            Part showText = (Part)partsDgv.CurrentRow.DataBoundItem;
            ModifyPart updateForm = new ModifyPart(inventory, showText);

            updateForm.Show();
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            if (partsDgv.CurrentRow == null || !partsDgv.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a row to delete!", "Delete Part");
                return;
            }

            Part delete = (Part)partsDgv.CurrentRow.DataBoundItem;

            var result = MessageBox.Show("Are you sure you want to delete this?", "Delete Part", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                inventory.DeletePart(delete);
            }
        }

        private void lookupProduct_Click(object sender, EventArgs e)
        {
            // Get the part ID from a text box or some other input
            string lookupValue = productsTextBox.Text;

            if (string.IsNullOrWhiteSpace(lookupValue))
            {
                MessageBox.Show("Please enter in the search bar!", "Product Search");
                return;
            }
            // Loop through the parts in the DataGridView
            foreach (DataGridViewRow row in productsDgv.Rows)
            {
                // If the part name contains the lookup value, call LookupAssociatedPart
                if (row.Cells[1].Value.ToString().ToLower().Contains(lookupValue.ToLower()))
                {
                    // Get the PartID from the DataGridViewRow
                    int partID = (int)row.Cells[0].Value;

                    // Call LookupAssociatedPart with the found PartID
                    inventory.LookupProduct(partID);

                    // Select the row
                    if (row.Index < productsDgv.Rows.Count)
                    {
                        productsDgv.CurrentCell = productsDgv[1, row.Index];
                    }
                    return;
                }
            }

            // If the loop completes without finding a match and returning, display a message
            MessageBox.Show("Product Not Found!", "Product Search");
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            AddProduct addForm = new AddProduct(inventory, product);

            addForm.Show();
        }

        private void updateProduct_Click(object sender, EventArgs e)
        {
            if (productsDgv.CurrentRow == null || !productsDgv.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a row to Modify!", "Modify Product");
                return;
            }

            // Create an instance of the ModifyPart form
            Product selectedProduct = (Product)productsDgv.CurrentRow.DataBoundItem;
            ModifyProduct updateForm = new ModifyProduct(inventory, product, selectedProduct);

            updateForm.Show();
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (productsDgv.CurrentRow == null || !productsDgv.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a row to delete!", "Delete Product");
                return;
            }

            Product delete = (Product)productsDgv.CurrentRow.DataBoundItem;

            var result = MessageBox.Show("Are you sure you want to delete this?", "Delete Product", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (delete.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Product has a part assigned to it!\nPlease removed assigned parts!","Error");
                    return;
                }
                else
                {
                    inventory.RemoveProduct(delete.ProductID);
                } 
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

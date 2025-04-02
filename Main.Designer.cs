namespace FrankInventorySystem
{
    partial class Main
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
            this.partsDgv = new System.Windows.Forms.DataGridView();
            this.productsDgv = new System.Windows.Forms.DataGridView();
            this.addPart = new System.Windows.Forms.Button();
            this.updatePart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.updateProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.productsTextBox = new System.Windows.Forms.TextBox();
            this.lookupPart = new System.Windows.Forms.Button();
            this.lookupProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // partsDgv
            // 
            this.partsDgv.AllowUserToAddRows = false;
            this.partsDgv.AllowUserToResizeRows = false;
            this.partsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDgv.Location = new System.Drawing.Point(34, 81);
            this.partsDgv.MultiSelect = false;
            this.partsDgv.Name = "partsDgv";
            this.partsDgv.ReadOnly = true;
            this.partsDgv.RowHeadersVisible = false;
            this.partsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDgv.Size = new System.Drawing.Size(377, 278);
            this.partsDgv.TabIndex = 2;
            // 
            // productsDgv
            // 
            this.productsDgv.AllowUserToAddRows = false;
            this.productsDgv.AllowUserToResizeRows = false;
            this.productsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDgv.Location = new System.Drawing.Point(440, 81);
            this.productsDgv.MultiSelect = false;
            this.productsDgv.Name = "productsDgv";
            this.productsDgv.ReadOnly = true;
            this.productsDgv.RowHeadersVisible = false;
            this.productsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDgv.Size = new System.Drawing.Size(377, 278);
            this.productsDgv.TabIndex = 7;
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(174, 394);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(75, 42);
            this.addPart.TabIndex = 3;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // updatePart
            // 
            this.updatePart.Location = new System.Drawing.Point(255, 394);
            this.updatePart.Name = "updatePart";
            this.updatePart.Size = new System.Drawing.Size(75, 42);
            this.updatePart.TabIndex = 3;
            this.updatePart.Text = "Modify";
            this.updatePart.UseVisualStyleBackColor = true;
            this.updatePart.Click += new System.EventHandler(this.updatePart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(336, 394);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 42);
            this.deletePart.TabIndex = 4;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(742, 394);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 42);
            this.deleteProduct.TabIndex = 10;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // updateProduct
            // 
            this.updateProduct.Location = new System.Drawing.Point(661, 394);
            this.updateProduct.Name = "updateProduct";
            this.updateProduct.Size = new System.Drawing.Size(75, 42);
            this.updateProduct.TabIndex = 9;
            this.updateProduct.Text = "Modify";
            this.updateProduct.UseVisualStyleBackColor = true;
            this.updateProduct.Click += new System.EventHandler(this.updateProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(580, 394);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 42);
            this.addProduct.TabIndex = 8;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(246, 41);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(165, 20);
            this.partsTextBox.TabIndex = 1;
            // 
            // productsTextBox
            // 
            this.productsTextBox.Location = new System.Drawing.Point(645, 41);
            this.productsTextBox.Name = "productsTextBox";
            this.productsTextBox.Size = new System.Drawing.Size(171, 20);
            this.productsTextBox.TabIndex = 6;
            // 
            // lookupPart
            // 
            this.lookupPart.Location = new System.Drawing.Point(165, 41);
            this.lookupPart.Name = "lookupPart";
            this.lookupPart.Size = new System.Drawing.Size(75, 23);
            this.lookupPart.TabIndex = 0;
            this.lookupPart.Text = "Search";
            this.lookupPart.UseVisualStyleBackColor = true;
            this.lookupPart.Click += new System.EventHandler(this.lookupPart_Click);
            // 
            // lookupProduct
            // 
            this.lookupProduct.Location = new System.Drawing.Point(563, 41);
            this.lookupProduct.Name = "lookupProduct";
            this.lookupProduct.Size = new System.Drawing.Size(75, 23);
            this.lookupProduct.TabIndex = 5;
            this.lookupProduct.Text = "Search";
            this.lookupProduct.UseVisualStyleBackColor = true;
            this.lookupProduct.Click += new System.EventHandler(this.lookupProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inventory Management System";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(742, 465);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 40);
            this.exit.TabIndex = 11;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Products";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lookupProduct);
            this.Controls.Add(this.lookupPart);
            this.Controls.Add(this.productsTextBox);
            this.Controls.Add(this.partsTextBox);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.updateProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.updatePart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.productsDgv);
            this.Controls.Add(this.partsDgv);
            this.Name = "Main";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView productsDgv;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button updatePart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button updateProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.TextBox productsTextBox;
        private System.Windows.Forms.Button lookupPart;
        private System.Windows.Forms.Button lookupProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView partsDgv;
    }
}


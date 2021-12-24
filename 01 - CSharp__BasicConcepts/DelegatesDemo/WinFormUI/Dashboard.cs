using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class frmDashboard : Form
    {
        private ShoppingCartModel cart = new ShoppingCartModel();
        public frmDashboard()
        {
            InitializeComponent();
            PopulateCartWithDemoData();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { Id = Guid.NewGuid(), ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { Id = Guid.NewGuid(), ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { Id = Guid.NewGuid(), ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { Id = Guid.NewGuid(), ItemName = "Blueberries", Price = 8.84M });
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, PrintOutDiscountAlert);
            MessageBox.Show($"The total for the cart: {total:C2}", "Total Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal(
                (subtotal) =>
                {
                    txtSubTotal.Text = $"{subtotal:C2}";
                },
                (products, subTotal) =>
                {
                    return subTotal - products.Count;
                },
                (message) =>
                {
                    
                }
            );

            txtTotal.Text = $"{total:C2}";
        }

        private void PrintOutDiscountAlert(string message)
        {
            MessageBox.Show(message, "Discount Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SubTotalAlert(decimal subTotal)
        {
            MessageBox.Show($"The subtotal for the cart: {subTotal:C2}", "SubTotal Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private decimal CalculateLeveledDiscount(List<ProductModel> products, decimal subTotal)
        {
            return subTotal - products.Count;

        }
        
    }
}

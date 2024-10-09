using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDbFirst
{
    public partial class FrmProduct : System.Windows.Forms.Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }


        DbBusinessEntities db = new DbBusinessEntities();
        void ProductList()
        {
            dataGridView1.DataSource = db.TblProduct.ToList();    
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblProduct product = new TblProduct();
            product.ProductName = txtProductName.Text;
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);
            product.ProductStock = int.Parse(txtProductStock.Text);
            product.ProductId = int.Parse(cBoxCategory.SelectedValue.ToString());
            db.TblProduct.Add(product);
            db.SaveChanges();
            ProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(int.Parse(txtProductId.Text));
            db.TblProduct.Remove(value);
            db.SaveChanges();
            ProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(int.Parse(txtProductId.Text));
            value.ProductName = txtProductName.Text;
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductStock = int.Parse(txtProductStock.Text);
            value.ProductId = int.Parse(cBoxCategory.SelectedValue.ToString());
            db.SaveChanges();
            ProductList();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = db.TblCategory.ToList();
            cBoxCategory.DisplayMember = "CategoryName";
            cBoxCategory.ValueMember = "CategoryId";
            cBoxCategory.DataSource = values;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProductListWithCategory_Click(object sender, EventArgs e)
        {
           var value = db.TblProduct.Join(db.TblCategory,
                product => product.ProductId,
                category => category.CategoryId,
                (product, category) => new
                {
                    ProductId = product.ProductName,
                    ProductName = category.CategoryName,
                    ProductPrice = product.ProductPrice,
                    ProductStock = product.ProductStock,
                    CategoryId = product.ProductId,
                    CategoryName = category.CategoryName
                }).ToList();
            dataGridView1.DataSource = value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Where(x => x.ProductName == txtProductName.Text).ToList();
            dataGridView1.DataSource = value;
        }
    }
}

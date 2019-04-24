using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Child : Form
    {
        private Product product;
        List<Country> country = null;

        public Child()
        {
            InitializeComponent();
            initialCountry();
            cBCity.DataSource = country;
            cBCity.ValueMember = "Name";

        }

        public void initialCountry()
        {
           
            country = new List<Country>()
            {
                new Country{ Name = "Великобритания"},
                new Country{ Name = "Франция"},
                new Country{ Name = "Германия"},
                new Country{ Name = "Россия"},
                new Country{ Name = "Чехия"},
            };
        }

        public Child(Product product)
        {
            InitializeComponent();
            initialCountry();
            cBCity.DataSource = country;
            cBCity.ValueMember = "Name";

            this.product = product;

            TName = product.Name;
            TCountry = product.Country;
            TPrice = product.Price;
        }

        public string TName
        {
            set
            {
                txtName.Text = value;
            }
            get {
                return txtName.Text;
            }
        }
        public string TCountry
        {
            set
            {
                cBCity.Text = value;
            }

            get
            {
                return cBCity.Text;
            }
        }
        public string TPrice
        {
            set
            {
                txtPrice.Text = value;
            }

            get
            {
                return txtPrice.Text;
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TName) || String.IsNullOrEmpty(TCountry) || String.IsNullOrEmpty(TPrice))
                MessageBox.Show("Для того, чтобы добавить в список заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else 
                this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

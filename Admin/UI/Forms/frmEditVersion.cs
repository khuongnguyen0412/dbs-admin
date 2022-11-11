using Admin.BLL;
using Admin.DAL.Models;
using Admin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.UI.Forms
{
    public partial class frmEditVersion : Form
    {
        public frmEditVersion()
        {
            InitializeComponent();
        }
        string Name = "";
        private void frmEditVersion_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            Product product = ProductBLL.GetInstance.GetById(frmManageVersion.productId);
            txbNameSoftware.Text = product.Name;
            txbVersion.Text = product.CurrentVersion;
            Name = product.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool status = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == "")
                    {
                        status = false;
                    }
                }
            }
            if (!status)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phần mềm", "Message");
                return;
            }
            try
            {
                if (Name != txbNameSoftware.Text)
                {
                    if (!ProductBLL.GetInstance.CheckExist(txbNameSoftware.Text))
                    {
                        Product product = new Product();
                        product.Id = frmManageVersion.productId;
                        product.Name = txbNameSoftware.Text;
                        product.CurrentVersion = txbVersion.Text;
                        //Cập nhật
                        if (ProductBLL.GetInstance.Update(product))
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật phần mềm thất bại vui lòng thử lại sau", "Message");
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Phần mềm đã tồn tại trong hệ thống", "Message");
                    }
                }
                else
                {
                    Product product = new Product();
                    product.Id = frmManageVersion.productId;
                    product.Name = txbNameSoftware.Text;
                    product.CurrentVersion = txbVersion.Text;
                    //Cập nhật
                    if (ProductBLL.GetInstance.Update(product))
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phần mềm thất bại vui lòng thử lại sau", "Message");
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}

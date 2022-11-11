using Admin.BLL;
using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.Forms
{
    public partial class frmAddVersion : Form
    {
        public frmAddVersion()
        {
            InitializeComponent();
        }

        private void frmEditVersion_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
                if (!ProductBLL.GetInstance.CheckExist(txbNameSoftware.Text))
                {
                    Product product = new Product();
                    product.Name = txbNameSoftware.Text;
                    product.CurrentVersion = txbVersion.Text;
                    //Thêm vào db
                    if (ProductBLL.GetInstance.Insert(product))
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới phần mềm thất bại vui lòng thử lại sau", "Message");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Phần mềm đã tồn tại trong hệ thống", "Message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}

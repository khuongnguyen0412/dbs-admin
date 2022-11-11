using Admin.BLL;
using Admin.DAL.Models;
using Admin.UI.Forms;
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
    public partial class frmManageVersion : Form
    {
        public frmManageVersion()
        {
            InitializeComponent();
        }


        private void btnAddVersion_Click_1(object sender, EventArgs e)
        {
            frmAddVersion frm = new frmAddVersion();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới phần mềm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Load data
            LoadData();
        }

        private void frmManageVersion_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            //Load data
            LoadData();
        }

        private void LoadData()
        {
            lvwVersion.Clear();
            lvwVersion.Columns.Add("Id");
            lvwVersion.Columns.Add("#");
            lvwVersion.Columns.Add("#");
            lvwVersion.Columns.Add("Tên phần mềm");
            lvwVersion.Columns.Add("Phiên bản");
            lvwVersion.Columns[0].Width = 0;
            lvwVersion.Columns[1].Width = 0;
            lvwVersion.Columns[2].Width = 40;
            lvwVersion.Columns[3].Width = 150;
            lvwVersion.Columns[4].Width = 500;

            List<Product> products = ProductBLL.GetInstance.GetAll();
            int i = 1;
            foreach (Product item in products)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Font = new Font(lvwVersion.Font, FontStyle.Regular);
                listViewItem.SubItems.Add(item.Id.ToString());
                listViewItem.SubItems.Add(i++.ToString());
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.CurrentVersion);
                lvwVersion.Items.Add(listViewItem);
            }
        }
        public static int productId = 0;
        private void lvwVersion_Click(object sender, EventArgs e)
        {
            if (lvwVersion.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = lvwVersion.SelectedItems[0];
                productId = int.Parse(listViewItem.SubItems[1].Text);
            }
        }

        private void btnUpdateVersion_Click(object sender, EventArgs e)
        {
            if (productId == 0)
            {
                MessageBox.Show("Vui lòng chọn phần mềm cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmEditVersion frm = new frmEditVersion();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Cập nhật phần mềm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Load data
                    LoadData();
                    productId = 0;
                }
            }
        }

        private void btnDeleteVersion_Click(object sender, EventArgs e)
        {
            if (productId == 0)
            {
                MessageBox.Show("Vui lòng chọn phần mềm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa phần mềm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ProductBLL.GetInstance.Delete(productId))
                    {
                        MessageBox.Show("Xóa phần mềm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Load data
                        LoadData();
                        productId = 0;
                    }
                }
                else
                {
                    productId = 0;
                }
            }
            productId = 0;
        }
    }
}

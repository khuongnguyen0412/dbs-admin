using Admin.BLL;
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
    public partial class frmChooseComputerStatistic : Form
    {
        public frmChooseComputerStatistic()
        {
            InitializeComponent();
        }

        private void frmChooseComputerStatistic_Load(object sender, EventArgs e)
        {
            LoadComputerName();
            if (cboComputer.Items.Count==0)
            {
                MessageBox.Show("Chưa có thông tin máy tính cần thống kê","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void LoadComputerName()
        {
            cboComputer.Items.Clear();
            List<string> computerName1 = InformationDetailsBLL.GetInstance.GetAllData().Select(x => x.ComputerName).Distinct().ToList();
            List<string> computerName2 = UndefinedSoftwareBLL.GetInstance.GetAllData().Select(x => x.ComputerName).Distinct().ToList();
            foreach (var item in computerName2)
            {
                computerName1.Add(item);
            }
            foreach (string item in computerName1.Distinct())
            {
                cboComputer.Items.Add(item);
            }
            if (computerName1.Count > 0)
            {
                cboComputer.SelectedIndex = 0;
            }
        }
        public string ComputerName = "";
        private void btnShow_Click(object sender, EventArgs e)
        {
            ComputerName = cboComputer.Text;
            DialogResult = DialogResult.OK;
        }
    }
}

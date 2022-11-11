using Admin.BLL;
using Admin.DAL.Models;
using Admin.DTO;
using Admin.Forms;
using Admin.UI.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }


        private void btnAddCSV_Click_1(object sender, EventArgs e)
        {
            using (frmChooseFile frm = new frmChooseFile())
            {
                frm.ShowDialog();
            }
            LoadComputerName();

            //Check change

            LoadComputerNameWarrning();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            frmManageVersion frm = new frmManageVersion();
            frm.ShowDialog();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //Load data for combobox
            LoadComputerName();
            LoadComputerNameWarrning();

            //Load information type
            LoadInformationType();

            //Load data for statustic type
            LoadCboChooseStatisticType();
        }

        private void LoadCboChooseStatisticType()
        {
            ComboBoxItem item1 = new ComboBoxItem();
            item1.Name = "Thống kê những máy đang sử dụng phiên bản window cũ";
            item1.Value = "Old version OS";
            cboChooseStatisticType.Items.Add(item1);
            ComboBoxItem item2 = new ComboBoxItem();
            item2.Name = "Thống kê các máy có chương trình diệt virus chưa được cập nhật";
            item2.Value = "Old version antivirus";
            cboChooseStatisticType.Items.Add(item2);
            ComboBoxItem item3 = new ComboBoxItem();
            item3.Name = "Thống kê tất cả các phần mềm đang được cài đặt";
            item3.Value = "All software";
            cboChooseStatisticType.Items.Add(item3);
            ComboBoxItem item4 = new ComboBoxItem();
            item4.Name = "Thống kê tên các file có đuôi exe";
            item4.Value = "Undefined software";
            cboChooseStatisticType.Items.Add(item4);
            cboChooseStatisticType.SelectedIndex = 0;
        }

        private void LoadInformationType()
        {
            #region Tất cả
            //Level 1
            cboChooseInformationType.Nodes.Add("Tất cả");
            cboChooseInformationType.Nodes[0].FontStyle = FontStyle.Bold; //Set fontStyle
            #endregion
            #region Phần cứng
            //Level 1
            cboChooseInformationType.Nodes[0].Nodes.Add("Phần cứng");
            cboChooseInformationType.Nodes[0].Nodes[0].FontStyle = FontStyle.Bold; //Set fontStyle
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[0].Nodes.Add("Processor details");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[0].Nodes.Add("System and Motherboard details");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[0].Nodes.Add("Memory details");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[0].Nodes.Add("Storage details");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[0].Nodes.Add("Video system");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[0].Nodes.Add("Multimedia details");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[0].Nodes.Add("Network adapters details");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[0].Nodes.Add("Devices details");
            #endregion
            #region Phần mềm
            //Level 1
            cboChooseInformationType.Nodes[0].Nodes.Add("Phần mềm");
            cboChooseInformationType.Nodes[0].Nodes[1].FontStyle = FontStyle.Bold; //Set fontStyle
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[1].Nodes.Add("OS details");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[1].Nodes.Add("Hotfixes");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[1].Nodes.Add("All software");
            cboChooseInformationType.Nodes[0].Nodes[1].Nodes.Add("Security & Protection");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[1].Nodes.Add("License audit");
            #endregion
            #region Thông tin khác
            //Level 1
            cboChooseInformationType.Nodes[0].Nodes.Add("Thông tin khác");
            cboChooseInformationType.Nodes[0].Nodes[2].FontStyle = FontStyle.Bold; //Set fontStyle
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[2].Nodes.Add("Shared resources details");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[2].Nodes.Add("Local user accounts details");
            //Level 2
            cboChooseInformationType.Nodes[0].Nodes[2].Nodes.Add("Undefined software");
            #endregion

            //Set ShowCheckBoxes
            cboChooseInformationType.ShowCheckBoxes = true;

            cboChooseInformationType.Nodes[0].Checked = true;
        }
        private void LoadComputerName()
        {
            cboChooseComputer.Items.Clear();
            List<string> computerName1 = InformationDetailsBLL.GetInstance.GetAllData().Select(x => x.ComputerName).Distinct().ToList();
            List<string> computerName2 = UndefinedSoftwareBLL.GetInstance.GetAllData().Select(x => x.ComputerName).Distinct().ToList();
            foreach (var item in computerName2)
            {
                computerName1.Add(item);
            }
            foreach (string item in computerName1.Distinct())
            {
                cboChooseComputer.Items.Add(item);
            }
            if (computerName1.Count > 0)
            {
                cboChooseComputer.SelectedIndex = 0;
            }
        }
        private void LoadComputerNameWarrning()
        {
            cboChooseComputerWarning.Text = "";
            cboChooseComputerWarning.Items.Clear();
            List<Computer> Computers = ComputerBLL.GetInstance.GetDataForComboBox();

            foreach (Computer item in Computers)
            {
                cboChooseComputerWarning.Items.Add(item.ComputerName);
            }
            if (Computers.Count > 0)
            {
                tabWarning.Text = "CẢNH BÁO (" + Computers.Count + ")";
                cboChooseComputerWarning.SelectedIndex = 0;
            }
            else
            {
                tabWarning.ForeColor = Color.Black;
                tabWarning.Text = "CẢNH BÁO";
            }
        }
        void ShowProcessorDetails(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            //Processor details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần cứng")
                {
                    treeView.Nodes[i].Nodes.Add("Processor details");
                    break;
                }
            }
            //Add pre name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Processor details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Processor details")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false)
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add name
            //foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Processor details"))
            //{
            //    for (int n = 0; n < treeView.Nodes.Count; n++)
            //    {
            //        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
            //        {
            //            if (treeView.Nodes[n].Nodes[i].Text == "Processor details")
            //            {
            //                for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
            //                {
            //                    if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
            //                    {
            //                        bool b = false;
            //                        for (int l = 0; l < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; l++)
            //                        {
            //                            if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[l].Text == item.Name)
            //                            {
            //                                b = true;
            //                            }
            //                        }
            //                        if (b == false)
            //                        {
            //                            treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(item.Name);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Processor details"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Processor details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 1;
        }
        void ShowSystemMotherboardDetails(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần cứng")
                {
                    treeView.Nodes[i].Nodes.Add("System & Motherboard details");
                    break;
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "System & Motherboard details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "System & Motherboard details")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false)
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "System & Motherboard details"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "System & Motherboard details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 1;
        }
        void ShowMemoryDetails(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 1;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần cứng")
                {
                    treeView.Nodes[i].Nodes.Add("Memory details");
                    break;
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Memory details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {

                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Memory details")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false && !item.Name.Contains("#"))
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add name more
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Memory details"))
            {
                if (item.Name.Contains("#"))
                {
                    for (int n = 0; n < treeView.Nodes.Count; n++)
                    {
                        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                        {
                            if (treeView.Nodes[n].Nodes[i].Text == "Memory details")
                            {
                                bool b = false;
                                for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                                {
                                    if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name.Remove(item.Name.Length - 3))
                                    {
                                        b = true;
                                    }
                                }
                                if (b == false)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name.Remove(item.Name.Length - 3));
                                }
                            }
                        }
                    }
                }
            }
            //Add name more #
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Memory details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Memory details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name.Remove(item.Name.Length - 3))
                                {
                                    bool b = false;
                                    for (int l = 0; l < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; l++)
                                    {
                                        if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[l].Text == item.Name)
                                        {
                                            b = true;
                                        }
                                    }
                                    if (b == false)
                                    {
                                        treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(item.Name);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Add key -value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Memory details" && x.SubName == null))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Memory details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            hashtable.Clear();
            count = 0;
            //Add sub name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Memory details" && x.SubName != null))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Memory details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    bool b = false;
                                    for (int l = 0; l < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; l++)
                                    {
                                        if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[l].Text == item.SubName)
                                        {
                                            b = true;
                                        }
                                    }
                                    if (b == false)
                                    {
                                        treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(item.SubName);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            hashtable.Clear();
            count = 0;
            //Add key - value for sub name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Memory details" && x.SubName != null))
            {
                if (hashtable[item.SubName] is null)
                {
                    count = 0;
                    hashtable.Add(item.SubName, ++count);
                }
                else
                {
                    hashtable[item.SubName] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Memory details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == "General memory info")
                                {
                                    for (int m = 0; m < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; m++)
                                    {
                                        if ((treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Text == "Paging files" || treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Text == "Virtual memory") && treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Text == item.SubName)
                                        {
                                            treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.SubName], item.Key, item.Value));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            hashtable.Clear();
            count = 0;
            //Add key - value more
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Memory details"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Memory details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == "Memory slot")
                                {
                                    for (int m = 0; m < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; m++)
                                    {
                                        if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Text == item.Name)
                                        {
                                            treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            count = 1;
        }
        void ShowStorageDetails(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 1;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần cứng")
                {
                    treeView.Nodes[i].Nodes.Add("Storage details");
                    break;
                }
            }
            //Add pre name #
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Storage details"))
            {
                if (item.Name.Contains("#"))
                {
                    for (int n = 0; n < treeView.Nodes.Count; n++)
                    {
                        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                        {
                            if (treeView.Nodes[n].Nodes[i].Text == "Storage details")
                            {
                                bool b = false;
                                for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                                {
                                    if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name.Remove(item.Name.Length - 3))
                                    {
                                        b = true;
                                    }
                                }
                                if (b == false)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name.Remove(item.Name.Length - 3));
                                }
                            }
                        }
                    }
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Storage details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Storage details")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false && !item.Name.Contains("#"))
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add name more for #
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Storage details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Storage details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name.Remove(item.Name.Length - 3))
                                {
                                    bool b = false;
                                    for (int l = 0; l < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; l++)
                                    {
                                        if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[l].Text == item.Name)
                                        {
                                            b = true;
                                        }
                                    }
                                    if (b == false)
                                    {
                                        treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(item.Name);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Storage details"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Storage details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 0;
            //Add key - value more
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Storage details"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Storage details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == "Hard disk drive")
                                {
                                    for (int m = 0; m < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; m++)
                                    {
                                        if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Text == item.Name)
                                        {
                                            treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        void ShowVideoSystem(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            //Processor details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần cứng")
                {
                    treeView.Nodes[i].Nodes.Add("Video system");
                    break;
                }
            }
            //Add pre name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Video system"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Video system")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false)
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add name
            //foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Video system"))
            //{
            //    for (int n = 0; n < treeView.Nodes.Count; n++)
            //    {
            //        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
            //        {
            //            if (treeView.Nodes[n].Nodes[i].Text == "Video system")
            //            {
            //                for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
            //                {
            //                    if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name.Remove(item.Name.Length - 3))
            //                    {
            //                        bool b = false;
            //                        for (int l = 0; l < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; l++)
            //                        {
            //                            if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[l].Text == item.Name)
            //                            {
            //                                b = true;
            //                            }
            //                        }
            //                        if (b == false)
            //                        {
            //                            treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(item.Name);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Video system"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Video system")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 1;
        }
        void ShowMultimediaDetails(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 1;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần cứng")
                {
                    treeView.Nodes[i].Nodes.Add("Multimedia details");
                    break;
                }
            }
            //Add pre name #
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Multimedia details"))
            {
                if (item.Name.Contains("#"))
                {
                    for (int n = 0; n < treeView.Nodes.Count; n++)
                    {
                        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                        {
                            if (treeView.Nodes[n].Nodes[i].Text == "Multimedia details")
                            {
                                bool b = false;
                                for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                                {
                                    if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name.Remove(item.Name.Length - 3))
                                    {
                                        b = true;
                                    }
                                }
                                if (b == false)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name.Remove(item.Name.Length - 3));
                                }
                            }
                        }
                    }
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Multimedia details"))
            {
                if (item.SubName != null)
                {
                    for (int n = 0; n < treeView.Nodes.Count; n++)
                    {
                        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                        {
                            if (treeView.Nodes[n].Nodes[i].Text == "Multimedia details")
                            {
                                bool b = false;
                                for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                                {
                                    if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                    {
                                        b = true;
                                    }
                                }
                                if (b == false && !item.Name.Contains("#"))
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                                }
                            }
                        }
                    }
                }
            }
            //Add name more for #
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Multimedia details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Multimedia details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name.Remove(item.Name.Length - 3))
                                {
                                    bool b = false;
                                    for (int l = 0; l < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; l++)
                                    {
                                        if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[l].Text == item.Name)
                                        {
                                            b = true;
                                        }
                                    }
                                    if (b == false)
                                    {
                                        treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(item.Name);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Add name more for sub(parent) name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Multimedia details"))
            {
                if (item.SubName != null)
                {
                    for (int n = 0; n < treeView.Nodes.Count; n++)
                    {
                        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                        {
                            if (treeView.Nodes[n].Nodes[i].Text == "Multimedia details")
                            {
                                for (int h = 0; h < treeView.Nodes[n].Nodes[i].Nodes.Count; h++)
                                {
                                    bool b = false;
                                    for (int m = 0; m < treeView.Nodes[n].Nodes[i].Nodes[h].Nodes.Count; m++)
                                    {
                                        if (treeView.Nodes[n].Nodes[i].Nodes[h].Nodes[m].Text == item.SubName && !treeView.Nodes[n].Nodes[i].Nodes[h].Text.Contains("Sound device"))
                                        {
                                            b = true;
                                        }
                                    }
                                    if (b == false && !treeView.Nodes[n].Nodes[i].Nodes[h].Text.Contains("Sound device") && treeView.Nodes[n].Nodes[i].Nodes[h].Text == item.Name)
                                    {
                                        treeView.Nodes[n].Nodes[i].Nodes[h].Nodes.Add(item.SubName);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Add key - value for #
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Multimedia details"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Multimedia details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                for (int m = 0; m < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; m++)
                                {
                                    if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Text == item.Name)
                                    {
                                        treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            count = 0;
            hashtable.Clear();
            //Add key - value for sub name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Multimedia details"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Multimedia details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == "Video codecs" || treeView.Nodes[n].Nodes[i].Nodes[j].Text == "Audio codecs")
                                {
                                    for (int m = 0; m < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; m++)
                                    {
                                        if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Text == item.SubName)
                                        {
                                            treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        void ShowNetworkAdaptersDetails(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần cứng")
                {
                    treeView.Nodes[i].Nodes.Add("Network adapters details");
                    break;
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Network adapters details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Network adapters details")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false)
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Network adapters details"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Network adapters details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 1;
        }
        void ShowDevicesDetails(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 1;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần cứng")
                {
                    treeView.Nodes[i].Nodes.Add("Devices details");
                    break;
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Devices details"))
            {
                if (item.SubName != null)
                {
                    for (int n = 0; n < treeView.Nodes.Count; n++)
                    {
                        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                        {
                            if (treeView.Nodes[n].Nodes[i].Text == "Devices details")
                            {
                                bool b = false;
                                for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                                {
                                    if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                    {
                                        b = true;
                                    }
                                }
                                if (b == false && !item.Name.Contains("#"))
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                                }
                            }
                        }
                    }
                }
            }
            //Add name more for #
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Devices details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Devices details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name.Remove(item.Name.Length - 3))
                                {
                                    bool b = false;
                                    for (int l = 0; l < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; l++)
                                    {
                                        if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[l].Text == item.Name)
                                        {
                                            b = true;
                                        }
                                    }
                                    if (b == false)
                                    {
                                        treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(item.Name);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Add key - value for name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Devices details"))
            {
                if (item.SubName == null)
                {
                    if (hashtable[item.Name] is null)
                    {
                        count = 0;
                        hashtable.Add(item.Name, ++count);
                    }
                    else
                    {
                        hashtable[item.Name] = ++count;
                    }
                    for (int n = 0; n < treeView.Nodes.Count; n++)
                    {
                        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                        {
                            if (treeView.Nodes[n].Nodes[i].Text == "Devices details")
                            {
                                for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                                {
                                    if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                    {
                                        treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            count = 0;
            //Add sub name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Devices details"))
            {
                if (item.SubName != null)
                {
                    for (int n = 0; n < treeView.Nodes.Count; n++)
                    {
                        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                        {
                            if (treeView.Nodes[n].Nodes[i].Text == "Devices details")
                            {
                                for (int h = 0; h < treeView.Nodes[n].Nodes[i].Nodes.Count; h++)
                                {
                                    bool b = false;
                                    for (int m = 0; m < treeView.Nodes[n].Nodes[i].Nodes[h].Nodes.Count; m++)
                                    {
                                        if (treeView.Nodes[n].Nodes[i].Nodes[h].Nodes[m].Text == item.SubName)
                                        {
                                            b = true;
                                        }
                                    }
                                    if (b == false && treeView.Nodes[n].Nodes[i].Nodes[h].Text == item.Name)
                                    {
                                        treeView.Nodes[n].Nodes[i].Nodes[h].Nodes.Add(item.SubName);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Add key - value for sub name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Devices details"))
            {
                if (item.SubName != null)
                {
                    if (hashtable[item.SubName] is null)
                    {
                        count = 0;
                        hashtable.Add(item.SubName, ++count);
                    }
                    else
                    {
                        hashtable[item.SubName] = ++count;
                    }
                    for (int n = 0; n < treeView.Nodes.Count; n++)
                    {
                        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                        {
                            if (treeView.Nodes[n].Nodes[i].Text == "Devices details")
                            {
                                for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                                {
                                    for (int m = 0; m < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; m++)
                                    {
                                        if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Text == item.SubName)
                                        {
                                            treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.SubName], item.Key, item.Value));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        void ShowOSDetails(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần mềm")
                {
                    treeView.Nodes[i].Nodes.Add("OS details");
                    break;
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "OS details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "OS details")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false)
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "OS details"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "OS details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 1;
        }
        void ShowHotfixes(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            //Processor details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần mềm")
                {
                    treeView.Nodes[i].Nodes.Add("Hotfixes");
                    break;
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Hotfixes"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Hotfixes")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false)
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add sub name
            //foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Hotfixes"))
            //{
            //    for (int n = 0; n < treeView.Nodes.Count; n++)
            //    {
            //        for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
            //        {
            //            if (treeView.Nodes[n].Nodes[i].Text == "Hotfixes")
            //            {
            //                for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
            //                {
            //                    if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name.Remove(item.Name.Length - 3))
            //                    {
            //                        bool b = false;
            //                        for (int l = 0; l < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; l++)
            //                        {
            //                            if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[l].Text == item.Name)
            //                            {
            //                                b = true;
            //                            }
            //                        }
            //                        if (b == false)
            //                        {
            //                            treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(item.Name);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            ////Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Hotfixes"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Hotfixes")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 1;
        }
        void ShowAllSoftware(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần mềm")
                {
                    treeView.Nodes[i].Nodes.Add("All software");
                    break;
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "All software"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "All software")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false)
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "All software"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "All software")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-4} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 1;
        }
        void ShowSecurityProtection(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần mềm")
                {
                    treeView.Nodes[i].Nodes.Add("Security & Protection");
                    break;
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Security & Protection"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Security & Protection")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false)
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Security & Protection"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Security & Protection")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 1;
        }
        void ShowLicenseAudit(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Phần mềm")
                {
                    treeView.Nodes[i].Nodes.Add("License audit");
                    break;
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "License audit"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "License audit")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false)
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "License audit"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "License audit")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 1;

            for (int n = 0; n < treeView.Nodes.Count; n++)
            {
                for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                {
                    if (treeView.Nodes[n].Nodes[i].Text == "License audit")
                    {
                        for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                        {
                            treeView.Nodes[n].Nodes[i].Nodes[j].ForeColor = Color.DarkGreen;
                            for (int m = 0; m < treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Count; m++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Text.Contains("ProductKey") && treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].Text.Contains("Unknow"))
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].ForeColor = Color.Red;
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes[m].ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }
            }
        }
        void ShowSharedResourcesDetails(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Thông tin khác")
                {
                    treeView.Nodes[i].Nodes.Add("Shared resources details");
                    break;
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Shared resources details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Shared resources details")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false)
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Shared resources details"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Shared resources details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 1;
        }
        void ShowLocalUserAccountsDetails(List<InformationDetail> informationDetails, TreeView treeView)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            //System & Motherboard details
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Thông tin khác")
                {
                    treeView.Nodes[i].Nodes.Add("Local user accounts details");
                    break;
                }
            }
            //Add name
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Local user accounts details"))
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Local user accounts details")
                        {
                            bool b = false;
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    b = true;
                                }
                            }
                            if (b == false)
                            {
                                treeView.Nodes[n].Nodes[i].Nodes.Add(item.Name);
                            }
                        }
                    }
                }
            }
            //Add key - value
            foreach (InformationDetail item in informationDetails.Where(x => x.Group == "Local user accounts details"))
            {
                if (hashtable[item.Name] is null)
                {
                    count = 0;
                    hashtable.Add(item.Name, ++count);
                }
                else
                {
                    hashtable[item.Name] = ++count;
                }
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Local user accounts details")
                        {
                            for (int j = 0; j < treeView.Nodes[n].Nodes[i].Nodes.Count; j++)
                            {
                                if (treeView.Nodes[n].Nodes[i].Nodes[j].Text == item.Name)
                                {
                                    treeView.Nodes[n].Nodes[i].Nodes[j].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-10}", hashtable[item.Name], item.Key, item.Value));
                                }
                            }
                        }
                    }
                }
            }
            count = 1;
        }
        void ShowUndefinedSoftware(List<UndefinedSoftware> undefinedSoftwares, TreeView treeView)
        {
            //Add groups
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if (treeView.Nodes[i].Text == "Thông tin khác")
                {
                    treeView.Nodes[i].Nodes.Add("Undefined software");
                    break;
                }
            }
            int count = 1;
            foreach (UndefinedSoftware item in undefinedSoftwares)
            {
                for (int n = 0; n < treeView.Nodes.Count; n++)
                {
                    for (int i = 0; i < treeView.Nodes[n].Nodes.Count; i++)
                    {
                        if (treeView.Nodes[n].Nodes[i].Text == "Undefined software")
                        {
                            treeView.Nodes[n].Nodes[i].Nodes.Add(String.Format("{0,-3} {1,-40} {2,-20} {3,-20} {4,-20}", count++, item.Name, item.CreateDate, item.Size, item.Location));
                        }
                    }
                }
            }
        }
        private void btnShowInfor_Click(object sender, EventArgs e)
        {
            if (cboChooseComputer.Text == "")
            {
                MessageBox.Show("Vui lòng chọn máy tính để hiển thị thông tin", "Thông báo");
                return;
            }
            if (cboChooseInformationType.CheckedNodes.Count() > 0)
            {
                List<string> checkedNodes = new List<string>();
                foreach (ComboTreeNode item in cboChooseInformationType.CheckedNodes)
                {
                    checkedNodes.Add(item.Text);
                }
                //Clear
                treeInformation.Nodes.Clear();
                treeInformation.Nodes.Add("Phần cứng");
                treeInformation.Nodes.Add("Phần mềm");
                treeInformation.Nodes.Add("Thông tin khác");

                Information information = InformationBLL.GetInstance.GetLastRecordByComputerName(cboChooseComputer.Text);
                List<InformationDetail> informationDetails = InformationDetailsBLL.GetInstance.GetByComputerNameAndInformationId(cboChooseComputer.Text, information.Id);
                List<UndefinedSoftware> undefinedSoftwares = UndefinedSoftwareBLL.GetInstance.GetByComputerNameAndInformationId(cboChooseComputer.Text, information.Id);
                foreach (string item in checkedNodes)
                {
                    if (item == "Video system")
                    {
                        ShowVideoSystem(informationDetails, treeInformation);
                    }
                    else if (item == "Processor details")
                    {
                        ShowProcessorDetails(informationDetails, treeInformation);
                    }
                    else if (item == "System and Motherboard details")
                    {
                        ShowSystemMotherboardDetails(informationDetails, treeInformation);
                    }
                    else if (item == "Memory details")
                    {
                        ShowMemoryDetails(informationDetails, treeInformation);
                    }
                    else if (item == "Storage details")
                    {
                        ShowStorageDetails(informationDetails, treeInformation);
                    }
                    else if (item == "Multimedia details")
                    {
                        ShowMultimediaDetails(informationDetails, treeInformation);
                    }
                    else if (item == "Network adapters details")
                    {
                        ShowNetworkAdaptersDetails(informationDetails, treeInformation);
                    }
                    else if (item == "Devices details")
                    {
                        ShowDevicesDetails(informationDetails, treeInformation);
                    }
                    else if (item == "OS details")
                    {
                        ShowOSDetails(informationDetails, treeInformation);
                    }
                    else if (item == "Hotfixes")
                    {
                        ShowHotfixes(informationDetails, treeInformation);
                    }
                    else if (item == "All software")
                    {
                        ShowAllSoftware(informationDetails, treeInformation);
                    }
                    else if (item == "Security & Protection")
                    {
                        ShowSecurityProtection(informationDetails, treeInformation);
                    }
                    else if (item == "License audit")
                    {
                        ShowLicenseAudit(informationDetails, treeInformation);
                    }
                    else if (item == "Shared resources details")
                    {
                        ShowSharedResourcesDetails(informationDetails, treeInformation);
                    }
                    else if (item == "Local user accounts details")
                    {
                        ShowLocalUserAccountsDetails(informationDetails, treeInformation);
                    }
                    else if (item == "Undefined software")
                    {
                        ShowUndefinedSoftware(undefinedSoftwares, treeInformation);
                    }
                }
                bool pc = false;
                bool pm = false;
                if (treeInformation.Nodes[0].Nodes.Count == 0)
                {
                    treeInformation.Nodes[0].Remove();
                    pc = true;
                }
                if (pc)
                {
                    if (treeInformation.Nodes[0].Nodes.Count == 0)
                    {
                        treeInformation.Nodes[0].Remove();
                        pm = true;
                    }
                    if (pm)
                    {
                        if (treeInformation.Nodes[0].Nodes.Count == 0)
                        {
                            treeInformation.Nodes[0].Remove();
                        }
                    }
                }
                else
                {
                    if (treeInformation.Nodes[1].Nodes.Count == 0)
                    {
                        treeInformation.Nodes[1].Remove();
                        pm = true;
                    }
                    if (pm)
                    {
                        if (treeInformation.Nodes[1].Nodes.Count == 0)
                        {
                            treeInformation.Nodes[1].Remove();
                        }
                    }
                }
                if (pc && pm == false)
                {
                    if (treeInformation.Nodes[1].Nodes.Count == 0)
                    {
                        treeInformation.Nodes[1].Remove();
                    }
                }
                if (!pc && !pm)
                {
                    if (treeInformation.Nodes[2].Nodes.Count == 0)
                    {
                        treeInformation.Nodes[2].Remove();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại thông tin cần hiển thị", "Thông báo");
                return;
            }
        }
        int informationIdCurrent = 0;
        private void btnShowWarrning_Click(object sender, EventArgs e)
        {
            if (cboChooseComputerWarning.Text == "")
            {
                MessageBox.Show("Vui lòng chọn máy tính cần hiển thị");
                return;
            }
            List<int> informationIds = InformationBLL.GetInstance.GetDataForWarringByComputerName(cboChooseComputerWarning.Text);

            if (informationIds == null)
            {
                MessageBox.Show("Máy tính " + cboChooseComputerWarning.Text + " không có thay đổi thông tin phần cứng nào so với trước");
                return;
            }
            if (informationIds.Count == 2)
            {
                tvBefore.Nodes.Clear();
                tvBefore.Nodes.Add("Phần cứng");
                tvCurrent.Nodes.Clear();
                tvCurrent.Nodes.Add("Phần cứng");

                informationIdCurrent = informationIds[0];

                List<InformationDetail> informationDetailsBefore = InformationDetailsBLL.GetInstance.GetByComputerNameAndInformationId(cboChooseComputerWarning.Text, informationIds[1]);
                List<InformationDetail> informationDetailsCurrent = InformationDetailsBLL.GetInstance.GetByComputerNameAndInformationId(cboChooseComputerWarning.Text, informationIds[0]);

                ShowProcessorDetails(informationDetailsBefore, tvBefore);
                ShowSystemMotherboardDetails(informationDetailsBefore, tvBefore);
                ShowMemoryDetails(informationDetailsBefore, tvBefore);
                ShowStorageDetails(informationDetailsBefore, tvBefore);
                ShowMultimediaDetails(informationDetailsBefore, tvBefore);
                ShowVideoSystem(informationDetailsBefore, tvBefore);
                ShowNetworkAdaptersDetails(informationDetailsBefore, tvBefore);
                ShowDevicesDetails(informationDetailsBefore, tvBefore);

                ShowProcessorDetails(informationDetailsCurrent, tvCurrent);
                ShowSystemMotherboardDetails(informationDetailsCurrent, tvCurrent);
                ShowMemoryDetails(informationDetailsCurrent, tvCurrent);
                ShowStorageDetails(informationDetailsCurrent, tvCurrent);
                ShowMultimediaDetails(informationDetailsCurrent, tvCurrent);
                ShowVideoSystem(informationDetailsCurrent, tvCurrent);
                ShowNetworkAdaptersDetails(informationDetailsCurrent, tvCurrent);
                ShowDevicesDetails(informationDetailsCurrent, tvCurrent);

                List<TreeNode> ltn1 = new List<TreeNode>();
                getallTreeNode(this.tvBefore.Nodes, ltn1);
                List<TreeNode> ltn2 = new List<TreeNode>();
                getallTreeNode(this.tvCurrent.Nodes, ltn2);
                List<TreeNode> ltn = new List<TreeNode>();
                //find the difference
                foreach (TreeNode tn2 in ltn2)
                {
                    List<TreeNode> tmp = new List<TreeNode>();
                    foreach (TreeNode tn1 in ltn1)
                    {
                        if (tn1.Parent == null && tn2.Parent == null && tn1.Text.Equals(tn2.Text))
                        {
                            tmp.Add(tn2);
                        }
                        if (tn1.Parent != null && tn2.Parent != null)
                        {

                            if (tn1.Text.Equals(tn2.Text) && tn1.Parent.Text.Equals(tn2.Parent.Text))
                            {
                                tmp.Add(tn2);
                            }
                        }
                    }
                    if (tmp == null || tmp.Count == 0)
                    {
                        ltn.Add(tn2);
                    }
                }
                foreach (TreeNode tn in ltn)
                {
                    this.tvCurrent.SelectedNode = tn;
                    this.tvCurrent.SelectedNode.ForeColor = Color.Red;
                    this.tvCurrent.SelectedNode.Parent.ForeColor = Color.Red;
                    this.tvCurrent.SelectedNode.Parent.Parent.ForeColor = Color.Red;
                    if (this.tvCurrent.SelectedNode.Parent.Parent.Parent != null)
                    {
                        this.tvCurrent.SelectedNode.Parent.Parent.Parent.ForeColor = Color.Red;
                        if (this.tvCurrent.SelectedNode.Parent.Parent.Parent.Parent != null)
                        {
                            this.tvCurrent.SelectedNode.Parent.Parent.Parent.Parent.ForeColor = Color.Red;
                        }
                    }
                }
                // 
                ltn.Clear();
                foreach (TreeNode tn1 in ltn1)
                {
                    List<TreeNode> tmp = new List<TreeNode>();
                    foreach (TreeNode tn2 in ltn2)
                    {
                        if (tn2.Parent == null && tn1.Parent == null && tn2.Text.Equals(tn1.Text))
                        {
                            tmp.Add(tn1);
                        }
                        if (tn2.Parent != null && tn1.Parent != null)
                        {

                            if (tn2.Text.Equals(tn1.Text) && tn2.Parent.Text.Equals(tn1.Parent.Text))
                            {
                                tmp.Add(tn1);
                            }
                        }
                    }
                    if (tmp == null || tmp.Count == 0)
                    {
                        ltn.Add(tn1);
                    }
                }
                foreach (TreeNode tn in ltn)
                {
                    this.tvBefore.SelectedNode = tn;
                    this.tvBefore.SelectedNode.ForeColor = Color.Red;
                    this.tvBefore.SelectedNode.Parent.ForeColor = Color.Red;
                    this.tvBefore.SelectedNode.Parent.Parent.ForeColor = Color.Red;
                    if (this.tvBefore.SelectedNode.Parent.Parent.Parent != null)
                    {
                        this.tvBefore.SelectedNode.Parent.Parent.Parent.ForeColor = Color.Red;
                        if (this.tvCurrent.SelectedNode.Parent.Parent.Parent.Parent != null)
                        {
                            this.tvCurrent.SelectedNode.Parent.Parent.Parent.Parent.ForeColor = Color.Red;
                        }
                    }
                }

                tvBefore.CollapseAll();
                tvBefore.Nodes[0].Expand();
                tvCurrent.CollapseAll();
                tvCurrent.Nodes[0].Expand();
            }
        }
        private void getallTreeNode(TreeNodeCollection nodes, List<TreeNode> ltn)
        {
            foreach (TreeNode td in nodes)
            {
                ltn.Add(td);
                if (td.Nodes.Count > 0)
                    getallTreeNode(td.Nodes, ltn);
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tvBefore.Nodes.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xác nhận các thông tin không?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ComputerBLL.GetInstance.ComfirmChange(cboChooseComputerWarning.Text);
                    tvBefore.Nodes.Clear();
                    tvCurrent.Nodes.Clear();
                    LoadComputerNameWarrning();
                    MessageBox.Show("Xác nhận thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa có thông tin để xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            lvwStatistic.Clear();
            ComboBoxItem item = cboChooseStatisticType.SelectedItem as ComboBoxItem;
            if (item.Value == "Old version OS")
            {
                lvwStatistic.Columns.Add("#");
                lvwStatistic.Columns.Add("#");
                lvwStatistic.Columns.Add("Tên máy tính");
                lvwStatistic.Columns.Add("Phiên bản hiện tại");
                lvwStatistic.Columns.Add("Phiên bản cuối");
                lvwStatistic.Columns[0].Width = 0;
                lvwStatistic.Columns[1].Width = 40;
                lvwStatistic.Columns[2].Width = 150;
                lvwStatistic.Columns[3].Width = 300;
                List<Computer> computers = StatisticBLL.GetInstance.GetListComputerIsOldVersionOS();
                if (computers.Count > 0)
                {
                    int i = 1;
                    foreach (Computer computer in computers)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Font = new Font(lvwStatistic.Font, FontStyle.Regular);
                        listViewItem.SubItems.Add(i++.ToString());
                        listViewItem.SubItems.Add(computer.ComputerName);
                        listViewItem.SubItems.Add(ComputerBLL.GetInstance.GetLastOSVersionByComputerName(computer.ComputerName));
                        lvwStatistic.Items.Add(listViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("Hiện tại không có máy tính nào sử dụng Windows phiên bản cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (item.Value == "Old version antivirus")
            {
                lvwStatistic.Columns.Add("#");
                lvwStatistic.Columns.Add("#");
                lvwStatistic.Columns.Add("Tên máy tính");
                lvwStatistic.Columns.Add("Phiên bản hiện tại");
                lvwStatistic.Columns[0].Width = 0;
                lvwStatistic.Columns[1].Width = 40;
                lvwStatistic.Columns[2].Width = 150;
                lvwStatistic.Columns[3].Width = 300;
                List<Computer> computers = StatisticBLL.GetInstance.GetListComputerIsOldVersionAntivirus();
                if (computers.Count > 0)
                {
                    int i = 1;
                    foreach (Computer computer in computers)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Font = new Font(lvwStatistic.Font, FontStyle.Regular);
                        listViewItem.SubItems.Add(i++.ToString());
                        listViewItem.SubItems.Add(computer.ComputerName);
                        listViewItem.SubItems.Add(ComputerBLL.GetInstance.GetLastAntivirusVersionByComputerName(computer.ComputerName));
                        lvwStatistic.Items.Add(listViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("Hiện tại không có máy tính nào chưa cập nhật chương trình Antivirus!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (item.Value == "All software")
            {
                lvwStatistic.Columns.Add("#");
                lvwStatistic.Columns.Add("#");
                lvwStatistic.Columns.Add("Tên phần mềm");
                lvwStatistic.Columns.Add("Nhà phát hành");
                lvwStatistic.Columns.Add("Phiên bản");
                lvwStatistic.Columns.Add("Ngày cài đặt");
                lvwStatistic.Columns.Add("Dung lượng");
                lvwStatistic.Columns.Add("Vị trí");
                lvwStatistic.Columns.Add("Phiên bản cuối");
                lvwStatistic.Columns[0].Width = 0;
                lvwStatistic.Columns[1].Width = 40;
                lvwStatistic.Columns[2].Width = 250;
                lvwStatistic.Columns[3].Width = 180;
                lvwStatistic.Columns[4].Width = 150;
                lvwStatistic.Columns[5].Width = 100;
                lvwStatistic.Columns[6].Width = 120;
                lvwStatistic.Columns[7].Width = 200;
                lvwStatistic.Columns[8].Width = 200;
                frmChooseComputerStatistic frm = new frmChooseComputerStatistic();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    string computerName = frm.ComputerName;

                    List<InformationDetail> informationDetails = StatisticBLL.GetInstance.GetListSoftwareByComputerName(computerName);
                    if (informationDetails.Count > 0)
                    {
                        int i = 1;
                        List<string> tmp = new List<string>();
                        foreach (InformationDetail informationdt in informationDetails)
                        {
                            tmp.Add(informationdt.Value);
                        }
                        for (int j = 0; j < tmp.Count - 6; j += 6)
                        {
                            ListViewItem listViewItem = new ListViewItem();
                            listViewItem.Font = new Font(lvwStatistic.Font, FontStyle.Regular);
                            listViewItem.SubItems.Add(i++.ToString());
                            listViewItem.SubItems.Add(tmp[j]);
                            listViewItem.SubItems.Add(tmp[j + 1]);
                            listViewItem.SubItems.Add(tmp[j + 2]);
                            listViewItem.SubItems.Add(tmp[j + 3]);
                            listViewItem.SubItems.Add(tmp[j + 4]);
                            listViewItem.SubItems.Add(tmp[j + 5]);
                            Product product = ProductBLL.GetInstance.GetByName(tmp[j]);

                            if (product == null)
                            {
                                listViewItem.SubItems.Add("Chưa có thông tin");

                            }
                            else
                            {
                                if (tmp[j + 2] != product.CurrentVersion)
                                {
                                    listViewItem.SubItems.Add(product.CurrentVersion);
                                    listViewItem.ForeColor = Color.Red;
                                }
                                else
                                {
                                    listViewItem.SubItems.Add(product.CurrentVersion);
                                }
                            }

                            lvwStatistic.Items.Add(listViewItem);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có phần mềm nào trong máy tính này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (item.Value == "Undefined software")
            {
                lvwStatistic.Columns.Add("#");
                lvwStatistic.Columns.Add("#");
                lvwStatistic.Columns.Add("Tên phần mềm");
                lvwStatistic.Columns.Add("Ngày tạo");
                lvwStatistic.Columns.Add("Kích thước");
                lvwStatistic.Columns.Add("Vị trí");
                lvwStatistic.Columns[0].Width = 0;
                lvwStatistic.Columns[1].Width = 40;
                lvwStatistic.Columns[2].Width = 250;
                lvwStatistic.Columns[3].Width = 200;
                lvwStatistic.Columns[4].Width = 150;
                lvwStatistic.Columns[5].Width = 400;
                frmChooseComputerStatistic frm = new frmChooseComputerStatistic();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    string computerName = frm.ComputerName;

                    List<UndefinedSoftware> undefinedSoftwares = StatisticBLL.GetInstance.GetListUndefinedSoftwareByComputerName(computerName);
                    if (undefinedSoftwares.Count > 0)
                    {
                        int i = 1;
                        foreach (UndefinedSoftware undefinedSoftware in undefinedSoftwares)
                        {
                            ListViewItem listViewItem = new ListViewItem();
                            listViewItem.Font = new Font(lvwStatistic.Font, FontStyle.Regular);
                            listViewItem.SubItems.Add(i++.ToString());
                            listViewItem.SubItems.Add(undefinedSoftware.Name);
                            listViewItem.SubItems.Add(undefinedSoftware.CreateDate);
                            listViewItem.SubItems.Add(undefinedSoftware.Size);
                            listViewItem.SubItems.Add(undefinedSoftware.Location);
                            lvwStatistic.Items.Add(listViewItem);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hiện tại không có Undefined software nào trên máy tính này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

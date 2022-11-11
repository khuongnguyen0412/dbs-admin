using Admin.BLL;
using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.Forms
{
    public partial class frmChooseFile : Form
    {
        public frmChooseFile()
        {
            InitializeComponent();
        }

        private void picChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse CSV Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
                Multiselect = true
            };

            path.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    path.Add(file);
                }
            }
            btnConfirm.Text = "Thêm (" + path.Count + ")";
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            picChooseFile_Click(sender, e);
        }



        private void lblLinkFile_Click(object sender, EventArgs e)
        {
            picChooseFile_Click(sender, e);
        }

        private void pnlChooseFile_Click(object sender, EventArgs e)
        {

            picChooseFile_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static List<string> path = new List<string>();
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;

            if (path.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn File để thêm vào hệ thống", "Thông báo");
                return;
            }
            //Show controls
            lblPercent.Visible = true;

            Cursor.Current = Cursors.AppStarting;
            Application.DoEvents();


            progressBar1.Value = 0;
            if (path.Count == 1)
            {
                string filePath = "";
                filePath = path[0];
                StreamReader streamReaderChecking = new StreamReader(filePath);
                StreamReader streamReaderChecking2 = new StreamReader(filePath);
                StreamReader streamReaderChecking3 = new StreamReader(filePath);
                StreamReader streamReader = new StreamReader(filePath);
                string[] totalData = new string[File.ReadAllLines(filePath).Length];

                //Checking csv file
                int index = 0;
                bool status = false;
                string mesage = "Dòng thứ: ";
                while (!streamReaderChecking.EndOfStream)
                {
                    string[] line = streamReaderChecking.ReadLine().Split(',');
                    if (line.Length < 6)
                    {
                        mesage += index + ", ";
                        status = true;
                    }
                    index++;
                }
                if (status)
                {
                    MessageBox.Show(mesage.Remove(mesage.Length - 2) + " trong file không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBar1.Value = 0;
                    lblPercent.Visible = false;
                    return;
                }

                //Add information
                Information information = new Information();
                information.ImportDate = DateTime.Now;
                string lineRead = streamReaderChecking2.ReadToEnd();
                if (lineRead == null || lineRead == "")
                {
                    MessageBox.Show("File không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] data = streamReaderChecking3.ReadLine().Split(',');
                information.ComputerName = data[1];
                InformationBLL.GetInstance.Insert(information);
                //Get last information Id
                int informantionId = InformationBLL.GetInstance.GetLastRecord().Id;

                int rowCount = 0;
                progressBar1.Maximum = index;

                while (!streamReader.EndOfStream)
                {
                    progressBar1.PerformStep();
                    lblPercent.Text = rowCount++ + "/" + index;
                    progressBar1.Value = rowCount;
                    Application.DoEvents();

                    string line = streamReader.ReadLine();
                    if (line[line.Length - 1] == ',')
                    {
                        totalData = line.Split(',');
                        if (totalData[2] == "Undefined software")
                        {
                            UndefinedSoftware undefinedSoftware = new UndefinedSoftware();
                            undefinedSoftware.ComputerName = totalData[1];
                            undefinedSoftware.UndefinedSoftware1 = totalData[2];
                            undefinedSoftware.Name = totalData[3];
                            undefinedSoftware.CreateDate = totalData[4];
                            undefinedSoftware.Size = totalData[5];
                            undefinedSoftware.Location = totalData[6];

                            undefinedSoftware.InformationId = informantionId;
                            UndefinedSoftwareBLL.GetInstance.Insert(undefinedSoftware);
                        }
                        else
                        {
                            InformationDetail informationDetail = new InformationDetail();
                            informationDetail.ComputerName = totalData[1];
                            informationDetail.Information = totalData[2];
                            informationDetail.Group = totalData[3];
                            if (totalData.Length == 8)
                            {
                                if (totalData[7] == "")
                                {
                                    informationDetail.Name = totalData[4];
                                    informationDetail.Key = totalData[5];
                                    informationDetail.Value = totalData[6];
                                }
                                else
                                {
                                    informationDetail.Name = totalData[4];
                                    informationDetail.SubName = totalData[5];
                                    informationDetail.Key = totalData[6];
                                    informationDetail.Value = totalData[7];
                                }
                            }
                            else if (totalData.Length == 7)
                            {
                                if (totalData[6] == "")
                                {
                                    informationDetail.Name = totalData[4];
                                    informationDetail.Key = totalData[5];
                                    informationDetail.Value = "Unknow";
                                }
                                else
                                {
                                    informationDetail.Name = totalData[4];
                                    informationDetail.Key = totalData[5];
                                    informationDetail.Value = totalData[6];
                                }
                            }
                            else
                            {
                                if (totalData[7] == "")
                                {
                                    informationDetail.Name = totalData[4];
                                    informationDetail.Key = totalData[5];
                                    informationDetail.Value = totalData[6];
                                }
                                else
                                {
                                    informationDetail.Name = totalData[4];
                                    informationDetail.SubName = totalData[5];
                                    informationDetail.Key = totalData[6];
                                    informationDetail.Value = totalData[7];
                                }
                            }

                            informationDetail.InformationId = informantionId;
                            InformationDetailsBLL.GetInstance.Insert(informationDetail);

                            //Insert computer
                            if (totalData[4] == "Common details" && totalData[5] == "Status")
                            {
                                if (totalData[6] == "OK")
                                {
                                    Computer computer = new Computer();
                                    computer.Id = totalData[0];
                                    computer.ComputerName = totalData[1];
                                    computer.IsOldVersionOS = false;
                                    computer.IsOldVersionAntivirus = false;
                                    ComputerBLL.GetInstance.Insert(computer);
                                }
                                else
                                {
                                    Computer computer = new Computer();
                                    computer.Id = totalData[0];
                                    computer.ComputerName = totalData[1];
                                    computer.IsOldVersionOS = true;
                                    computer.IsOldVersionAntivirus = false;
                                    ComputerBLL.GetInstance.Insert(computer);
                                }
                            }

                            //Update computer
                            if (totalData[4] == "ANTIVIRUS" && totalData[5] == "Status" && !totalData[6].Contains("OK"))
                            {
                                Computer computer = ComputerBLL.GetInstance.GetByComputerName(totalData[1]);
                                ComputerBLL.GetInstance.Update(computer.Id, true);
                            }
                        }
                    }
                    else
                    {
                        totalData = line.Split(',');
                        if (totalData[2] == "Undefined software")
                        {
                            UndefinedSoftware undefinedSoftware = new UndefinedSoftware();
                            undefinedSoftware.ComputerName = totalData[1];
                            undefinedSoftware.UndefinedSoftware1 = totalData[2];
                            undefinedSoftware.Name = totalData[3];
                            undefinedSoftware.CreateDate = totalData[4];
                            undefinedSoftware.Size = totalData[5];
                            undefinedSoftware.Location = totalData[6];

                            undefinedSoftware.InformationId = informantionId;
                            UndefinedSoftwareBLL.GetInstance.Insert(undefinedSoftware);
                        }
                        else
                        {
                            InformationDetail informationDetail = new InformationDetail();
                            informationDetail.ComputerName = totalData[1];
                            informationDetail.Information = totalData[2];
                            informationDetail.Group = totalData[3];
                            if (totalData.Length == 8)
                            {
                                informationDetail.Name = totalData[4];
                                informationDetail.SubName = totalData[5];
                                informationDetail.Key = totalData[6];
                                informationDetail.Value = totalData[7];
                            }
                            else
                            {
                                informationDetail.Name = totalData[4];
                                informationDetail.Key = totalData[5];
                                informationDetail.Value = totalData[6];
                            }

                            informationDetail.InformationId = informantionId;
                            InformationDetailsBLL.GetInstance.Insert(informationDetail);

                            //Insert computer
                            if (totalData[4] == "Common details" && totalData[5] == "Status")
                            {
                                if (totalData[6] == "OK")
                                {
                                    Computer computer = new Computer();
                                    computer.Id = totalData[0];
                                    computer.ComputerName = totalData[1];
                                    computer.IsOldVersionOS = false;
                                    computer.IsOldVersionAntivirus = false;
                                    ComputerBLL.GetInstance.Insert(computer);
                                }
                                else
                                {
                                    Computer computer = new Computer();
                                    computer.Id = totalData[0];
                                    computer.ComputerName = totalData[1];
                                    computer.IsOldVersionOS = true;
                                    computer.IsOldVersionAntivirus = false;
                                    ComputerBLL.GetInstance.Insert(computer);
                                }
                            }

                            //Update computer
                            if (totalData[4] == "ANTIVIRUS" && totalData[5] == "Status" && !totalData[6].Contains("OK"))
                            {
                                Computer computer = ComputerBLL.GetInstance.GetByComputerName(totalData[1]);
                                ComputerBLL.GetInstance.Update(computer.Id, true);
                            }
                        }
                    }
                }

                Cursor.Current = Cursors.Default;
                InformationDetailsBLL.GetInstance.Insert(null, true);

                frmMessageSuccess frm = new frmMessageSuccess();
                frm.lblMesage.Text = "Đã thêm thành công vào hệ thống.";
                frm.ShowDialog();
            }
            else
            {
                int count = 0;
                int countAdded = 0;
                int index = 0;
                bool status = false;
                bool checking = false;
                string filenamemessage = "Các dòng không hợp lệ: ";
                string mesage = "";
                foreach (string pathItem in path)
                {
                    count++;
                    StreamReader streamReaderChecking = new StreamReader(pathItem);
                    StreamReader streamReaderChecking2 = new StreamReader(pathItem);
                    StreamReader streamReaderChecking3 = new StreamReader(pathItem);
                    StreamReader streamReader = new StreamReader(pathItem);
                    string[] totalData = new string[File.ReadAllLines(pathItem).Length];

                    //Checking csv file
                    while (!streamReaderChecking.EndOfStream)
                    {
                        string[] line = streamReaderChecking.ReadLine().Split(',');
                        if (line.Length < 6)
                        {
                            mesage += index + ", ";
                            status = true;
                            checking = true;
                        }
                        index++;
                    }
                    if (status)
                    {
                        filenamemessage += mesage.Remove(mesage.Length - 2) + "\n" + pathItem + " không hợp lệ\n" + "Các dòng không hợp lệ: ";
                        status = false;
                        mesage = "";
                        continue;
                    }

                    //Add information
                    Information information = new Information();
                    information.ImportDate = DateTime.Now;
                    string lineRead = streamReaderChecking2.ReadToEnd();
                    if (lineRead == null || lineRead == "")
                    {
                        MessageBox.Show("File không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string[] data = streamReaderChecking3.ReadLine().Split(',');
                    information.ComputerName = data[1];
                    InformationBLL.GetInstance.Insert(information);
                    //Get last information Id
                    int informantionId = InformationBLL.GetInstance.GetLastRecord().Id;

                    int rowCount = 0;
                    progressBar1.Maximum = index;

                    while (!streamReader.EndOfStream)
                    {
                        progressBar1.PerformStep();
                        lblPercent.Text = rowCount++ + "/" + index+ " (" + count + "/" + path.Count + ")";
                        progressBar1.Value = rowCount;
                        Application.DoEvents();

                        string line = streamReader.ReadLine();
                        if (line[line.Length - 1] == ',')
                        {
                            totalData = line.Split(',');
                            if (totalData[2] == "Undefined software")
                            {
                                UndefinedSoftware undefinedSoftware = new UndefinedSoftware();
                                undefinedSoftware.ComputerName = totalData[1];
                                undefinedSoftware.UndefinedSoftware1 = totalData[2];
                                undefinedSoftware.Name = totalData[3];
                                undefinedSoftware.CreateDate = totalData[4];
                                undefinedSoftware.Size = totalData[5];
                                undefinedSoftware.Location = totalData[6];

                                undefinedSoftware.InformationId = informantionId;
                                UndefinedSoftwareBLL.GetInstance.Insert(undefinedSoftware);
                            }
                            else
                            {
                                InformationDetail informationDetail = new InformationDetail();
                                informationDetail.ComputerName = totalData[1];
                                informationDetail.Information = totalData[2];
                                informationDetail.Group = totalData[3];
                                if (totalData.Length == 8)
                                {
                                    if (totalData[7] == "")
                                    {
                                        informationDetail.Name = totalData[4];
                                        informationDetail.Key = totalData[5];
                                        informationDetail.Value = totalData[6];
                                    }
                                    else
                                    {
                                        informationDetail.Name = totalData[4];
                                        informationDetail.SubName = totalData[5];
                                        informationDetail.Key = totalData[6];
                                        informationDetail.Value = totalData[7];
                                    }
                                }
                                else if (totalData.Length == 7)
                                {
                                    if (totalData[6] == "")
                                    {
                                        informationDetail.Name = totalData[4];
                                        informationDetail.Key = totalData[5];
                                        informationDetail.Value = "Unknow";
                                    }
                                    else
                                    {
                                        informationDetail.Name = totalData[4];
                                        informationDetail.Key = totalData[5];
                                        informationDetail.Value = totalData[6];
                                    }
                                }
                                else
                                {
                                    if (totalData[7] == "")
                                    {
                                        informationDetail.Name = totalData[4];
                                        informationDetail.Key = totalData[5];
                                        informationDetail.Value = totalData[6];
                                    }
                                    else
                                    {
                                        informationDetail.Name = totalData[4];
                                        informationDetail.SubName = totalData[5];
                                        informationDetail.Key = totalData[6];
                                        informationDetail.Value = totalData[7];
                                    }
                                }

                                informationDetail.InformationId = informantionId;
                                InformationDetailsBLL.GetInstance.Insert(informationDetail);

                                //Insert computer
                                if (totalData[4] == "Common details" && totalData[5] == "Status")
                                {
                                    if (totalData[6] == "OK")
                                    {
                                        Computer computer = new Computer();
                                        computer.Id = totalData[0];
                                        computer.ComputerName = totalData[1];
                                        computer.IsOldVersionOS = false;
                                        computer.IsOldVersionAntivirus = false;
                                        ComputerBLL.GetInstance.Insert(computer);
                                    }
                                    else
                                    {
                                        Computer computer = new Computer();
                                        computer.Id = totalData[0];
                                        computer.ComputerName = totalData[1];
                                        computer.IsOldVersionOS = true;
                                        computer.IsOldVersionAntivirus = false;
                                        ComputerBLL.GetInstance.Insert(computer);
                                    }
                                }

                                //Update computer
                                if (totalData[4] == "ANTIVIRUS" && totalData[5] == "Status" && !totalData[6].Contains("OK"))
                                {
                                    Computer computer = ComputerBLL.GetInstance.GetByComputerName(totalData[1]);
                                    ComputerBLL.GetInstance.Update(computer.Id, true);
                                }
                            }
                        }
                        else
                        {
                            totalData = line.Split(',');
                            if (totalData[2] == "Undefined software")
                            {
                                UndefinedSoftware undefinedSoftware = new UndefinedSoftware();
                                undefinedSoftware.ComputerName = totalData[1];
                                undefinedSoftware.UndefinedSoftware1 = totalData[2];
                                undefinedSoftware.Name = totalData[3];
                                undefinedSoftware.CreateDate = totalData[4];
                                undefinedSoftware.Size = totalData[5];
                                undefinedSoftware.Location = totalData[6];

                                undefinedSoftware.InformationId = informantionId;
                                UndefinedSoftwareBLL.GetInstance.Insert(undefinedSoftware);
                            }
                            else
                            {
                                InformationDetail informationDetail = new InformationDetail();
                                informationDetail.ComputerName = totalData[1];
                                informationDetail.Information = totalData[2];
                                informationDetail.Group = totalData[3];
                                if (totalData.Length == 8)
                                {
                                    informationDetail.Name = totalData[4];
                                    informationDetail.SubName = totalData[5];
                                    informationDetail.Key = totalData[6];
                                    informationDetail.Value = totalData[7];
                                }
                                else
                                {
                                    informationDetail.Name = totalData[4];
                                    informationDetail.Key = totalData[5];
                                    informationDetail.Value = totalData[6];
                                }

                                informationDetail.InformationId = informantionId;
                                InformationDetailsBLL.GetInstance.Insert(informationDetail);

                                //Insert computer
                                if (totalData[4] == "Common details" && totalData[5] == "Status")
                                {
                                    if (totalData[6] == "OK")
                                    {
                                        Computer computer = new Computer();
                                        computer.Id = totalData[0];
                                        computer.ComputerName = totalData[1];
                                        computer.IsOldVersionOS = false;
                                        computer.IsOldVersionAntivirus = false;
                                        ComputerBLL.GetInstance.Insert(computer);
                                    }
                                    else
                                    {
                                        Computer computer = new Computer();
                                        computer.Id = totalData[0];
                                        computer.ComputerName = totalData[1];
                                        computer.IsOldVersionOS = true;
                                        computer.IsOldVersionAntivirus = false;
                                        ComputerBLL.GetInstance.Insert(computer);
                                    }
                                }

                                //Update computer
                                if (totalData[4] == "ANTIVIRUS" && totalData[5] == "Status" && !totalData[6].Contains("OK"))
                                {
                                    Computer computer = ComputerBLL.GetInstance.GetByComputerName(totalData[1]);
                                    ComputerBLL.GetInstance.Update(computer.Id, true);
                                }
                            }
                        }
                    }

                    progressBar1.Value = 0;
                    lblPercent.Text = "0";
                    index = 0;
                    countAdded++;
                }
                Cursor.Current = Cursors.Default;

                if (checking)
                {
                    MessageBox.Show(filenamemessage.Remove(filenamemessage.Length - 23), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                frmMessageSuccess frm = new frmMessageSuccess();
                frm.lblMesage.Text = "Đã thêm " + countAdded + "/" + path.Count + " máy tính đã chọn vào hệ thống.";
                frm.ShowDialog();
            }
            //save change
            InformationDetailsBLL.GetInstance.Insert(null, true);
            btnConfirm.Text = "Thêm (0)";
            progressBar1.Value = 0;
            lblPercent.Visible = false;
            path.Clear();

            btnConfirm.Enabled = true;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

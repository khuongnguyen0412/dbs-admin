using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DAL
{
    public class ComputerDAL
    {
        private static ComputerDAL Instance;
        private InformationComputerEntities db = new InformationComputerEntities();
        public static ComputerDAL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new ComputerDAL();
                }
                return Instance;
            }
        }
        private ComputerDAL() { }
        #region Get All Data
        public List<Computer> GetAllData()
        {
            return db.Computers.ToList();
        }
        #endregion
        #region Insert
        public bool Insert(Computer computerInsert)
        {
            List<Computer> Computers = db.Computers.ToList();
            List<string> ids = new List<string>();
            foreach (Computer item in Computers)
            {
                if (computerInsert.ComputerName == item.ComputerName)
                {
                    ids.Add(item.Id);
                }
            }
            if (ids.Count > 0)
            {
                foreach (string id in ids)
                {
                    Computer Computer = db.Computers.Find(id);
                    Computer.IsOldVersionAntivirus = computerInsert.IsOldVersionAntivirus;
                    Computer.IsOldVersionOS = computerInsert.IsOldVersionOS;
                    Computer.IsConfirmChanged = false;
                    db.SaveChanges();
                }
            }
            else
            {
                computerInsert.IsConfirmChanged = false;
                db.Computers.Add(computerInsert);
                db.SaveChanges();
            }
            return true;
        }
        #endregion
        #region Comfirm change
        public bool ComfirmChange(string computerName)
        {
            try
            {
                Computer computer = db.Computers.ToList().SingleOrDefault(x => x.ComputerName == computerName);
                computer.IsConfirmChanged = true;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #region Get Data for combobox
        public List<Computer> GetDataForComboBox()
        {
            List<Computer> Computers = db.Computers.ToList();
            List<Information> information = db.Information.ToList();
            List<Computer> tmp = new List<Computer>();
            int count = 0;
            List<int> Ids = new List<int>();
            foreach (Computer item in Computers)
            {
                foreach (Information item2 in information)
                {
                    if (item.ComputerName == item2.ComputerName && item.IsConfirmChanged == false)
                    {
                        Ids.Add(item2.Id);
                    }
                }
                if (Ids.Count >= 2)
                {
                    count++;

                    int before = Ids[Ids.Count - 2];
                    int current = Ids[Ids.Count - 1];

                    List<InformationDetail> informationDetailsBefore = db.InformationDetails.Where(x => x.InformationId == before && x.Information == "Hardware information").ToList();
                    List<InformationDetail> informationDetailsCurrent = db.InformationDetails.Where(x => x.InformationId == current && x.Information == "Hardware information").ToList();
                    for (int i = 0; i < informationDetailsBefore.Count; i++)
                    {
                        if (informationDetailsBefore[i].Key == informationDetailsCurrent[i].Key)
                        {
                            if (informationDetailsBefore[i].Value != informationDetailsCurrent[i].Value)
                            {
                                count++;
                                break;
                            }
                        }
                    }
                }
                if (count >= 2)
                {
                    tmp.Add(item);
                    count = 0;
                    Ids.Clear();
                }
                else
                {
                    count = 0;
                    Ids.Clear();
                }
            }
            return tmp;
        }
        #endregion
        #region Get last OS version by computer name
        public string GetLastOSVersionByComputerName(string computerName)
        {
            try
            {
                string version = db.InformationDetails.ToList().LastOrDefault(x => x.ComputerName == computerName && x.Name == "Common details" && x.Key == "Version").Value;
                return version;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region Get last antivirus version by computer name
        public string GetLastAntivirusVersionByComputerName(string computerName)
        {
            try
            {
                string version = db.InformationDetails.ToList().LastOrDefault(x => x.ComputerName == computerName && x.Name == "ANTIVIRUS" && x.Key == "Version").Value;
                return version;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region Get by computer name
        public Computer GetByComputerName(string computerName)
        {
            try
            {
                Computer computer = db.Computers.FirstOrDefault(x => x.ComputerName == computerName);
                return computer;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region Update version antivirus
        public bool Update(string Id, bool status)
        {
            try
            {
                Computer computer = db.Computers.Find(Id);
                computer.IsOldVersionAntivirus = true;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}

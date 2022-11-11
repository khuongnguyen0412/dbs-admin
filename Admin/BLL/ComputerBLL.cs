using Admin.DAL;
using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BLL
{
    public class ComputerBLL
    {
        private static ComputerBLL Instance;
        public static ComputerBLL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new ComputerBLL();
                }
                return Instance;
            }
        }
        private ComputerBLL() { }
        #region Get All Data
        public List<Computer> GetAllData()
        {
            return ComputerDAL.GetInstance.GetAllData();
        }
        #endregion
        #region Insert
        public bool Insert(Computer computer)
        {
            return ComputerDAL.GetInstance.Insert(computer);
        }
        #endregion

        #region Comfirm change
        public bool ComfirmChange(string computerName)
        {
            return ComputerDAL.GetInstance.ComfirmChange(computerName);
        }
        #endregion

        #region Get Data for combobox
        public List<Computer> GetDataForComboBox()
        {
            return ComputerDAL.GetInstance.GetDataForComboBox();
        }
        #endregion
        #region Get last OS version by computer name
        public string GetLastOSVersionByComputerName(string computerName)
        {
            return ComputerDAL.GetInstance.GetLastOSVersionByComputerName(computerName);
        }
        #endregion
        #region Get last antivirus version by computer name
        public string GetLastAntivirusVersionByComputerName(string computerName)
        {
            return ComputerDAL.GetInstance.GetLastAntivirusVersionByComputerName(computerName);
        }
        #endregion
        #region Get by computer name
        public Computer GetByComputerName(string computerName)
        {
            return ComputerDAL.GetInstance.GetByComputerName(computerName);
        }
        #endregion
        #region Update version antivirus
        public bool Update(string Id, bool status)
        {
            return ComputerDAL.GetInstance.Update(Id, status);
        }
        #endregion
    }
}

using Admin.DAL;
using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BLL
{
    public class UndefinedSoftwareBLL
    {
        private static UndefinedSoftwareBLL Instance;
        public static UndefinedSoftwareBLL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new UndefinedSoftwareBLL();
                }
                return Instance;
            }
        }
        private UndefinedSoftwareBLL() { }
        #region Get all
        public List<UndefinedSoftware> GetAllData()
        {
            return UndefinedSoftwareDAL.GetInstance.GetAllData();
        }
        #endregion
        #region Insert
        public bool Insert(UndefinedSoftware undefinedSoftware)
        {
            return UndefinedSoftwareDAL.GetInstance.Insert(undefinedSoftware);
        }
        #endregion
        #region Get by computer name and information id
        public List<UndefinedSoftware> GetByComputerNameAndInformationId(string computerName, int informationId)
        {
            return UndefinedSoftwareDAL.GetInstance.GetByComputerNameAndInformationId(computerName, informationId);
        }
        #endregion
    }
}

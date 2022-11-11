using Admin.DAL;
using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BLL
{
    public class StatisticBLL
    {
        private static StatisticBLL Instance;
        public static StatisticBLL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new StatisticBLL();
                }
                return Instance;
            }
        }
        private StatisticBLL() { }
        #region Get list computer is old version OS
        public List<Computer> GetListComputerIsOldVersionOS()
        {
            return StatisticDAL.GetInstance.GetListComputerIsOldVersionOS();
        }
        #endregion
        #region Get list computer is old version antivirus
        public List<Computer> GetListComputerIsOldVersionAntivirus()
        {
            return StatisticDAL.GetInstance.GetListComputerIsOldVersionAntivirus();
        }
        #endregion
        #region Get list software by compter name
        public List<InformationDetail> GetListSoftwareByComputerName(string computerName)
        {
            return StatisticDAL.GetInstance.GetListSoftwareByComputerName(computerName);
        }
        #endregion
        #region Get list Undefined software by compter name
        public List<UndefinedSoftware> GetListUndefinedSoftwareByComputerName(string computerName)
        {
            return StatisticDAL.GetInstance.GetListUndefinedSoftwareByComputerName(computerName);
        }
        #endregion
    }
}

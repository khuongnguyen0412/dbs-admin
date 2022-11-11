using Admin.DAL;
using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BLL
{
    public class InformationBLL
    {
        private static InformationBLL Instance;
        public static InformationBLL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new InformationBLL();
                }
                return Instance;
            }
        }
        private InformationBLL() { }
        #region
        public List<Information> GetAllData()
        {
            return InformationDAL.GetInstance.GetAllData();
        }
        #endregion
        #region Insert
        public bool Insert(Information information)
        {
            return InformationDAL.GetInstance.Insert(information);
        }
        #endregion
        #region Get last record
        public Information GetLastRecord()
        {
            return InformationDAL.GetInstance.GetLastRecord();
        }
        #endregion
        #region Get last record bu computer name
        public Information GetLastRecordByComputerName(string computerName)
        {
            return InformationDAL.GetInstance.GetLastRecordByComputerName(computerName);
        }
        #endregion
        #region Get informationId for warrning by computer name
        public List<int> GetDataForWarringByComputerName(string computerName)
        {
            return InformationDAL.GetInstance.GetDataForWarringByComputerName(computerName);
        }
        #endregion
    }
}

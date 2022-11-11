using Admin.DAL;
using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BLL
{
    public class InformationDetailsBLL
    {
        private static InformationDetailsBLL Instance;
        public static InformationDetailsBLL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new InformationDetailsBLL();
                }
                return Instance;
            }
        }
        private InformationDetailsBLL() { }
        #region Get all
        public List<InformationDetail> GetAllData()
        {
            return InformationDetailsDAL.GetInstance.GetAllData();
        }
        #endregion
        #region Insert
        public bool Insert(InformationDetail informationDetail, bool saveChange=false)
        {
            return InformationDetailsDAL.GetInstance.Insert(informationDetail, saveChange);
        }
        #endregion
        #region Get by computer name and information id
        public List<InformationDetail> GetByComputerNameAndInformationId(string computerName, int informationId)
        {
            return InformationDetailsDAL.GetInstance.GetByComputerNameAndInformationId(computerName, informationId);
        }
        #endregion
    }
}

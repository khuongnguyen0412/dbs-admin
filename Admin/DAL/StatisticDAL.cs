using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DAL
{
    public class StatisticDAL
    {
        private static StatisticDAL Instance;
        private InformationComputerEntities db = new InformationComputerEntities();
        public static StatisticDAL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new StatisticDAL();
                }
                return Instance;
            }
        }
        private StatisticDAL() { }
        #region Get list computer is old version OS
        public List<Computer> GetListComputerIsOldVersionOS()
        {
            return db.Computers.Where(x => x.IsOldVersionOS == true).ToList();
        }
        #endregion
        #region Get list computer is old version antivirus
        public List<Computer> GetListComputerIsOldVersionAntivirus()
        {
            return db.Computers.Where(x => x.IsOldVersionAntivirus == true).ToList();
        }
        #endregion
        #region Get list software by compter name
        public List<InformationDetail> GetListSoftwareByComputerName(string computerName)
        {
            Information information = db.Information.ToList().LastOrDefault(x => x.ComputerName == computerName);
            List<InformationDetail> informationDetails = db.InformationDetails.Where(x => x.InformationId == information.Id && x.Information == "Software information" && x.Group == "All software").ToList();
            return informationDetails;
        }
        #endregion
        #region Get list Undefined software by compter name
        public List<UndefinedSoftware> GetListUndefinedSoftwareByComputerName(string computerName)
        {
            Information information = db.Information.ToList().LastOrDefault(x => x.ComputerName == computerName);
            List<UndefinedSoftware> undefinedSoftwares = db.UndefinedSoftwares.Where(x => x.InformationId == information.Id).ToList();
            return undefinedSoftwares;
        }
        #endregion
    }
}

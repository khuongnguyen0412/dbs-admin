using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DAL
{
    public class InformationDAL
    {
        private static InformationDAL Instance;
        private InformationComputerEntities db = new InformationComputerEntities();
        public static InformationDAL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new InformationDAL();
                }
                return Instance;
            }
        }
        private InformationDAL() { }
        #region Get All Data
        public List<Information> GetAllData()
        {
            return db.Information.ToList();
        }
        #endregion
        #region Get last record
        public Information GetLastRecord()
        {
            return db.Information.ToList().LastOrDefault();
        }
        #endregion
        #region Get last record bu computer name
        public Information GetLastRecordByComputerName(string computerName)
        {
            InformationDetail informationDetail = db.InformationDetails.ToList().LastOrDefault(x => x.ComputerName == computerName);
            if (informationDetail != null)
            {
            List<Information> informations = db.Information.ToList();
            return informations.LastOrDefault(x => x.Id == informationDetail.InformationId);
            }
            else
            {
                UndefinedSoftware undefinedSoftware = db.UndefinedSoftwares.ToList().LastOrDefault(x => x.ComputerName == computerName);
                List<Information> informations = db.Information.ToList();
                return informations.LastOrDefault(x => x.Id == undefinedSoftware.InformationId);
            }
        }
        #endregion
        #region Get informationId for warrning by computer name
        public List<int> GetDataForWarringByComputerName(string computerName)
        {
            List<Information> informations = db.Information.Where(x => x.ComputerName == computerName).ToList();
            if (informations.Count == 1)
            {
                return null;
            }
            Information current = informations[informations.Count - 1];
            Information before = informations[informations.Count - 2];
            List<int> tmp = new List<int>();
            tmp.Add(current.Id);
            tmp.Add(before.Id);
            return tmp;
        }
        #endregion
        #region Insert
        public bool Insert(Information information)
        {
            try
            {
                db.Information.Add(information);
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

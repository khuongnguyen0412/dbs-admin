using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DAL
{
    public class UndefinedSoftwareDAL
    {
        private static UndefinedSoftwareDAL Instance;
        private InformationComputerEntities db = new InformationComputerEntities();
        public static UndefinedSoftwareDAL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new UndefinedSoftwareDAL();
                }
                return Instance;
            }
        }
        private UndefinedSoftwareDAL() { }

        #region Get All Data
        public List<UndefinedSoftware> GetAllData()
        {
            return db.UndefinedSoftwares.ToList();
        }
        #endregion
        #region Get by computer name
        public List<UndefinedSoftware> GetByComputerNameAndInformationId(string computerName, int informationId)
        {
            return db.UndefinedSoftwares.Where(x => x.ComputerName == computerName && x.InformationId == informationId).ToList();
        }
        #endregion

        #region Insert
        public bool Insert(UndefinedSoftware undefinedSoftware)
        {
            try
            {
                db.UndefinedSoftwares.Add(undefinedSoftware);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}

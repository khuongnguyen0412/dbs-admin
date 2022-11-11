using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.DAL
{
    public class InformationDetailsDAL
    {
        private static InformationDetailsDAL Instance;
        private InformationComputerEntities db = new InformationComputerEntities();
        public static InformationDetailsDAL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new InformationDetailsDAL();
                }
                return Instance;
            }
        }
        private InformationDetailsDAL() { }

        #region Get All Data
        public List<InformationDetail> GetAllData()
        {
            try
            {
                return db.InformationDetails.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi database: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }
        #endregion
        #region Get by computer name
        public List<InformationDetail> GetByComputerNameAndInformationId(string computerName, int informationId)
        {
            return db.InformationDetails.Where(x => x.ComputerName == computerName && x.InformationId == informationId).ToList();
        }
        #endregion

        #region Insert
        public bool Insert(InformationDetail informationDetail, bool saveChange)
        {
            try
            {
                db.Configuration.AutoDetectChangesEnabled = false;
                db.Configuration.ValidateOnSaveEnabled = false;
                if (saveChange)
                {
                    db.SaveChanges();
                    return true;
                }
                db.InformationDetails.Add(informationDetail);
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

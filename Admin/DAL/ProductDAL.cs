using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DAL
{
    public class ProductDAL
    {
        private static ProductDAL Instance;
        private InformationComputerEntities db = new InformationComputerEntities();
        public static ProductDAL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new ProductDAL();
                }
                return Instance;
            }
        }
        private ProductDAL() { }
        #region Get current version
        public string GetCurrentVersion(string productName)
        {
            return db.Products.FirstOrDefault(x => x.Name == productName).CurrentVersion;
        }
        #endregion
        #region Get All
        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }
        #endregion
        #region Get By Id
        public Product GetById(int Id)
        {
            return db.Products.SingleOrDefault(x=>x.Id==Id);
        }
        #endregion
        #region Get By Name
        public Product GetByName(string Name)
        {
            return db.Products.SingleOrDefault(x => x.Name == Name);
        }
        #endregion
        #region Insert
        public bool Insert(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #region Update
        public bool Update(Product product)
        {
            try
            {
                Product productUpdate = db.Products.SingleOrDefault(x=>x.Id == product.Id);
                productUpdate.Name = product.Name;
                productUpdate.CurrentVersion = product.CurrentVersion;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #region Check exist
        public bool CheckExist(string name)
        {
            try
            {
                var tmp = db.Products.Where(x => x.Name == name);
                if (tmp.Count() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #region Delete
        public bool Delete(int Id)
        {
            try
            {
                Product product = db.Products.SingleOrDefault(x => x.Id == Id);
                db.Products.Remove(product);
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

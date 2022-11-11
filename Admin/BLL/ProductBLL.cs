using Admin.DAL;
using Admin.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BLL
{
    public class ProductBLL
    {
        private static ProductBLL Instance;
        public static ProductBLL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new ProductBLL();
                }
                return Instance;
            }
        }
        private ProductBLL() { }
        #region Get Windows version
        public string GetCurrentVersion(string productName)
        {
            return ProductDAL.GetInstance.GetCurrentVersion(productName);
        }
        #endregion
        #region Insert
        public bool Insert(Product product)
        {
            return ProductDAL.GetInstance.Insert(product);
        }
        #endregion
        #region Check exist
        public bool CheckExist(string name)
        {
            return ProductDAL.GetInstance.CheckExist(name);
        }
        #endregion
        #region Get All
        public List<Product> GetAll()
        {
            return ProductDAL.GetInstance.GetAll();
        }
        #endregion
        #region Get By Id
        public Product GetById(int Id)
        {
            return ProductDAL.GetInstance.GetById(Id);
        }
        #endregion
        #region Update
        public bool Update(Product product)
        {
            return ProductDAL.GetInstance.Update(product);
        }
        #endregion
        #region Delete
        public bool Delete(int Id)
        {
            return ProductDAL.GetInstance.Delete(Id);
        }
        #endregion
        #region Get By Name
        public Product GetByName(string Name)
        {
            return ProductDAL.GetInstance.GetByName(Name);
        }
        #endregion
    }
}

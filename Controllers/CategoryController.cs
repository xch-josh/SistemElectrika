using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Models.CategoryModels;
using Models.DataBase;

namespace Controllers
{
    public class CategoryController
    {
        public async Task<List<CategoryViewModel>> GetData()
        {
            var lst = new List<CategoryViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.Categorias
                       where x.Categoria != "N/A"
                       select new CategoryViewModel
                       {
                           Id = x.IdCategoria,
                           Categoria = x.Categoria
                       }).ToListAsync();
            }

            return lst;
        }

        public void Insert(CategoryAddModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var category = new Categorias();

                category.Categoria = model.Category.ToUpper();

                db.Categorias.Add(category);
                db.SaveChanges();
            }
        }

        public void Edit(CategoryEditModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var category = db.Categorias.Find(model.Id);

                category.Categoria = model.Category.ToUpper();

                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var category = db.Categorias.Find(id);

                db.Entry(category).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<GetCategoriesModel> GetCategories()
        {
            var lst = new List<GetCategoriesModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = (from x in db.Categorias
                       orderby x.Categoria ascending
                       select new GetCategoriesModel
                       {
                           Id = x.IdCategoria,
                           Category = x.Categoria
                       }).ToList();
            }

            return lst;
        }
    }
}

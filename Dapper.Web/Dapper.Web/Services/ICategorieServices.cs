using Dapper.Web.Entities;

namespace Dapper.Web.Services
{
    public interface ICategorieServices
    {
        public Categorie Insert(Categorie categorie);
        public IEnumerable<Categorie> GetAll(Categorie categorie);
        public IEnumerable<Categorie> GetById(long Id);
        public long Delete(long Id);
        public void Update(Categorie categorie);
    }
}

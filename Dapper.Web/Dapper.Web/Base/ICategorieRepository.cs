using Dapper.Web.Entities;

namespace Dapper.Web.Base
{
    public interface ICategorieRepository
    {
        public Categorie Create(Categorie categorie);
        public IEnumerable<Categorie> GetAll(Categorie categorie);
        public IEnumerable<Categorie> GetById(long Id);
        public long Delete(long Id);
        public void Update(Categorie categorie);

    }
}

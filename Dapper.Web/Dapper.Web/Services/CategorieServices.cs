using Dapper.Web.Base;
using Dapper.Web.Entities;

namespace Dapper.Web.Services
{
    public class CategorieServices : ICategorieServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategorieServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Categorie Insert(Categorie categorie)
        {
            var result = _unitOfWork.CategorieRepository.Create(categorie);
            return result;
        }

        public long Delete(long Id)
        {
            return _unitOfWork.CategorieRepository.Delete(Id);  
        }

        public IEnumerable<Categorie> GetAll(Categorie categorie)
        {
           return _unitOfWork.CategorieRepository.GetAll(categorie);
        }

        public IEnumerable<Categorie> GetById(long Id)
        {
            return _unitOfWork.CategorieRepository.GetById(Id);
        }

        public void Update(Categorie categorie)
        {
            _unitOfWork.CategorieRepository.Update(categorie);
        }
    }
}

using Dapper.Web.DbContext;

namespace Dapper.Web.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICategorieRepository _categorieRepository;
        private readonly IDapperContext _dapperContext;

        public UnitOfWork(ICategorieRepository categorieRepository, IDapperContext dapperContext)
        {
            _categorieRepository = categorieRepository;
            _dapperContext = dapperContext;
        }


        public ICategorieRepository CategorieRepository => _categorieRepository ?? new CategorieRepository(_dapperContext);
    }
}

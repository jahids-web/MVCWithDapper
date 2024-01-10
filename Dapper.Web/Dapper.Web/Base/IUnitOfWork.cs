namespace Dapper.Web.Base
{
    public interface IUnitOfWork
    {
        public ICategorieRepository CategorieRepository { get; }
    }
}

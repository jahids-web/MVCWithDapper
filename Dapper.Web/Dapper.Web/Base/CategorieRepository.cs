using Dapper.Web.DbContext;
using Dapper.Web.Entities;

namespace Dapper.Web.Base
{
    public class CategorieRepository : ICategorieRepository
    {
        private readonly IDapperContext _context;

        public CategorieRepository(IDapperContext context) 
        {
            _context = context;
        }

        public Categorie Create(Categorie categorie)
        {
            try
            {
                var sqlQuery = @"Insert into Categorie (CategorieName) Values(@CategorieName)";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.ExecuteScalar<Categorie>(sqlQuery, new {categorie});
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
            

        }

        public long Delete(long Id)
        {
            try
            {
                var sqlQuery = @"DELETE FROM Categorie WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.Execute(sqlQuery, new { Id });
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public IEnumerable<Categorie> GetAll(Categorie categorie)
        {
            try
            {
                var sqlQuery = @"SELETE * FROM Categorie";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.Query<Categorie>(sqlQuery, new { categorie });
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public IEnumerable<Categorie> GetById(long Id)
        {
            try
            {
                var sqlQuery = @"SELECT * FROM Categorie WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.Query<Categorie>(sqlQuery, new { Id });
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public void Update(Categorie categorie)
        {
            try
            {
                var sqlQuery = @"UPDATE Categorie SET CategorieName = @CategorieName, WHERE Id = @Id";

                using var connection = _context.CreateConnection();
                connection.Open();
                connection.Execute(sqlQuery, new { categorie.CategorieName });
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }
    }
}

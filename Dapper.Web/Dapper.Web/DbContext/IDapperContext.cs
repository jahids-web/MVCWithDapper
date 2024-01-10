using System.Data;

namespace Dapper.Web.DbContext
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
    }
}

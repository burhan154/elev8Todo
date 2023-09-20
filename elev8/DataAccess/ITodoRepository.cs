using elev8.EntityFramework;
using elev8.Models;

namespace elev8.DataAccess
{
    public interface ITodoRepository : IRepository<Todo>
    {
        public Todo ChangeChecked(int id);
        public Todo AddByDesc(string desc);
        public void DeleteById(int id);
    }
}

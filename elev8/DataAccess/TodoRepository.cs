using elev8.EntityFramework;
using elev8.Models;
using Microsoft.EntityFrameworkCore;

namespace elev8.DataAccess
{
    public class TodoRepository : Repository<Todo>, ITodoRepository
    {
        public Todo AddByDesc(string desc)
        {
            return Add(new Todo() { Desc = desc, IsComplete = false });
        }

        public Todo ChangeChecked(int id)
        {
            var todo = GetById(id);

            var result = todo.IsComplete ? false : true;
            todo.IsComplete = result;

            return Update(todo);
        }

        public void DeleteById(int id)
        {
            var todo = GetById(id);
            Delete(todo);
        }
    }
}

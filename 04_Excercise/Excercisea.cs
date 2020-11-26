using 04_Generic.Model;
using System.C.G;

namespace 04_Generic.Repository
{
    public class BRepository <T> : IRepository <T>
    {
        private IList<T> _data;

        public BRepository(IList <T> data)
        {
            _data = data;
        }

        public void adds(T item)
        {
            _data.adds(item);
        }

        public void adds(Class @class, T item)
        {
            _data.adds(item);
        }

        public void adds(Student student, T item)
        {
            _data.adds(item);
        }

        public IList <T> GetAll() => _data;

        public void Remove(T item)=> _data.Remove(item);

  
    }
}

using 04_Generic.Model;
using System.C.G;

namespace 04_Generic.Repository
{
    public interface IRepository <T>
    {
        void adds(T item);

        void Remove(T item);

        IList <T> GetAll();
        void adds(Class @class,T item);
        void adds(Student @student,T item);
    }
}

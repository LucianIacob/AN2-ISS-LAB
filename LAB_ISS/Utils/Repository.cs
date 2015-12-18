using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_ISS
{
    public interface Repository<T>
    {
        void addObject(T o);
        bool removeObject(T o);
        bool findObject(T o);
        T[] getAll();
    }

    public class MemoryRepository<T> : Repository<T>
    {
        protected List<T> data;

        private List<IObserver<T>> observers = new List<IObserver<T>>();
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<T>> _observers;
            private IObserver<T> _observer;

            public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public MemoryRepository()
        {
            data = new List<T>();
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public void Notify(T next)
        {
            foreach (IObserver<T> obs in this.observers)
                obs.OnNext(next);
        }

        public void addObject(T o)
        {
            data.Add(o);
            data = data.OrderBy(v => v.ToString()).ToList();
            this.Notify(o);
        }

        public bool removeObject(T o)
        {
            foreach (T b in data.ToList())
                if (String.Compare(b.ToString(), o.ToString()) == 0)
                {
                    data.Remove(b);
                    this.Notify(b);
                }
            return data.Remove(o);
        }

        public bool findObject(T o)
        {
            foreach (T a in data)
            {
                if (String.Compare(a.ToString(), o.ToString()) == 0)
                    return true;
            }
            return false;
        }

        public T[] getAll()
        {
            return data.ToArray();
        }

        public int length()
        {
            return data.Count;
        }
    }
}
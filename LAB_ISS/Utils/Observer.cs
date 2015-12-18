using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ISS.Controller
{
    public class MyObserver<T> : IObserver<T>
    {
        private String name;

        public MyObserver(String name)
        {
            this.name = name;
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine(this.name + "has completed!");
        }
        public virtual void OnError(Exception e)
        {

        }
        public virtual void OnNext(T obj)
        {
            Console.WriteLine("Observer {0} notified of {1}", this.name, obj);
        }
    }
}

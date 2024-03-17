using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul5_1302220064
{
    internal class Datageneric<T>  
    {
       private T data;

       public Datageneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            
            Console.WriteLine("Data yang tersimpan adalah : " +  data);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleNameSpace;

namespace VehicleArrayNameSpace
{
    public class VehicleArray:IEnumerable<Vehicle>
    {
       public VehicleArray() { }
        Vehicle[] vehiclelist = new Vehicle[5];
        int count = 0;

        public void Add(Vehicle v)
        {
            if (count == vehiclelist.Length)
                Array.Resize(ref vehiclelist, vehiclelist.Length * 2);

            vehiclelist[count++] = v;
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return vehiclelist[i];
            }
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Vehicle this[int index]                       //Indexers
        {
            get
            {
                Vehicle tmp;

                if (index >= 0 && index <= count - 1)
                {
                    tmp = vehiclelist[index];
                }
                else
                {
                    tmp = null;
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= count - 1)
                {
                    vehiclelist[index] = value;
                }
            }
        }

    }
}

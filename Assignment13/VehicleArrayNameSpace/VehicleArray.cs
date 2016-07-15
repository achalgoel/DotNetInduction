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

    }
}

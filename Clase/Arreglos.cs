using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos1_DLL.Clase
{
    internal class Arreglos
    {
        public void MostrarArreglos() 
        {
            int[] arreglos = {2,4,6,8,10};
            for(int x=0; x<arreglos.Length;x++) 
            {
                Console.WriteLine(arreglos[x]);
            }

            Console.ReadKey();
        }
    }
}

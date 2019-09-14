using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArray
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int []arr = ArrayCreator.Create(5, 7);
            Console.WriteLine(string.Join(" ",arr));

            Scale<int> scale = new Scale<int>(3, 6);
            Console.WriteLine(scale.GetHeavier());
        }
    }
}

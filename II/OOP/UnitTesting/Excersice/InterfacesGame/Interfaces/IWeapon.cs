using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Interfaces
{
    public interface IWeapon
    {

        int AttackPoints
        {
            get;
        }

        int DurabilityPoints
        {
            get;
        }
        void Attack(ITarget target);
    }
}

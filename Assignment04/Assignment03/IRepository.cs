using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    interface IRepository
    {
        public void Load(string fileName);
        public void Save(string fileName);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezhnev_CatFramework
{
    public class CatException : ArgumentException
    {
        public CatException(string message) : base(message) { }
    }
}

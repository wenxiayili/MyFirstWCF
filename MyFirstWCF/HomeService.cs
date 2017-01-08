using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWCF
{
    /// <summary>
    /// 实现类
    /// </summary>
    public class HomeService:IHomeService
    {
        public int GetLength(string name)
        {
            return name.Length;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    interface IListDs
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Append(String name,String phone,String QQ,String Wechat);
       
        bool Delete(int i);
        Node GetElem(int i);
        int Locate(String vname);
    }
}

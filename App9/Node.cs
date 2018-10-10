using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    public class Node
    {
       public String name;
       public String phone;
        public String QQ;
        public String Wechat;
         public Node next;
        public Node(String aname,String aphone,Node p)
        {
            name = aname;
            phone = aphone;
            next = p;
        }

        public Node(Node p) {
            next = p;
        }

        public Node(String name,String phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public Node(String name,String phone,String QQ,String Wechat) {
            this.QQ = QQ;
            this.phone = phone;
            this.name = name;
            this.Wechat = Wechat;
        }

        public Node()
        {
            name = null;
            phone = null;
            next = null;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    public class FakeList : IListDs
    {
        private Node head;
        public Node Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }
        public FakeList()
        {
            head = null;
        }
        public int GetLength()
        {
            Node p = head;
            int len = 0;
            while (p != null)
            {
                p = p.next;
                len++;
            }
            return len;
        }

        public void Clear()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Append(String name,String phone,String QQ,String Wechat)
        {
            Node q = new Node(name,phone,QQ,Wechat);
            Node p = new Node();
            if (head == null)
            {
                head = q;
                return;
            }
            p = head;
            while (p.next != null)
            {
                p = p.next;
            }
            p.next = q;
        }
       

        public Node GetElem(int i)
        {
            if (IsEmpty())
            {
                return null;
            }
            Node p = new Node();
            p = head;
            int j = 1;
            while (p.next != null && j < i)
            {
                p = p.next;
                j++;
            }
            if (j == i)
            {
                return p;
            }
            else
            {
                return null;
            }
        }

        public int Locate(String vname)
        {
            if (IsEmpty())
            {
                return -1;
            }
            Node p = new Node();
            p = head;
            int i = 1;
            while ((p.next != null) && (!p.name.Equals(vname)))
            {
                p = p.next;
                i++;
            }
            if (p == null)
            {
                return -1;
            }
            else
            {
                return i;
            }
        }


        public bool Delete(int i)
        {
            if (IsEmpty() || i < 1||i>GetLength())
            {
                return false;
            }
            Node q = new Node();
            if (i == 1)
            {
                q = head;
                head = head.next;
                return true;
            }
            Node p = head;
            int j = 1;
            while (p.next != null && j < i)
            {
                q = p;
                p = p.next;
                j++;
            }
            if (j == i)
            {
                q.next = p.next;
                return true;
            }
            else
            {
                return false;
            }
        }


       

      
    }
}

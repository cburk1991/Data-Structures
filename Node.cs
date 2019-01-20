using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Node<T>
    {
            public Node<T> nextNode = null;
            public Node<T> previousNode = null;
            public T value;
    }
}

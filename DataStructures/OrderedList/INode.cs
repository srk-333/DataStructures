using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.OrderedList
{
    public class INode<T>
    {
        public T data;
        public INode<T> next;
        /// <summary>
        /// data intialization
        /// </summary>
        /// <param name="value"></param>
        public INode(T value)
        {
            this.data = value;
            this.next = null;
        }
    }
}
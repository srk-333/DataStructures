using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.UnorderedList
{
    public class Node<T>
    {
        //Variables.
        public T data;
        public Node<T> next;
        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }           
    }
}

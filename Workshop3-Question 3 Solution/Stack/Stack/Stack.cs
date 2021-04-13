//CAB301 - Workshop 3 
//Maolin Tang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        static int CAPACITY = 10;
        private int capacity;
        private int numElements;
        private int[] data;


        /// constructor initializes stack
        public Stack() {
            capacity = CAPACITY;
            numElements = 0;
            data = new int[CAPACITY];
        }

        /// returns number of elements in the stack
        public int size()
        {
            return numElements;
        }

        /// return true if the stack is empty
        public bool empty()
        {
            return numElements == 0;
        }

        /// adds an element to the top of the stack
        public void push(int value)
        {
            if (numElements != capacity)
            {
                data[numElements] = value;
                numElements=numElements+1;
            }
            else
            {
                Console.WriteLine("Stack is full - cannot add any more elements to stack");
            }
        }

        /// returns the element from the top of the stack and removes it
        public int pop()
        {
            int topValue = data[numElements - 1];
            numElements=numElements-1;
            return topValue;
        }

        /// returns the element from the top of the stack
        public int peek()
        {
            return data[numElements - 1];
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackNQueue
{
    class MyStack <T> : Buffer <T>, IMyStack<T>
    {
        private int top = 0;

        public MyStack(int size) : base(size) { }

        public T Pop()                                            //returns top value in the stack
        {
            if (top == 0)
            {
                return (default (T));                                       //return 0 if stack is empty
            }
            else
            {
                return (bufferMtrx[--top]);                       //return top value and decrease pointer
            }
        }

        public void Push(T value)                                 //push the value to the next free sell
        {
            if (top != bufferMtrx.Length)
            {
                bufferMtrx[top] = value;
                top++;
            }
        }

        public override bool IsEmpty()                                       //return true if stack is empty
        {
            if (top == 0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public override bool IsFull()                                        //return true if stack is full
        {
            if (top == bufferMtrx.Length)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public override T Peek()                                           //return top value without deletion
        {
            if (top == 0)
            {
                return (default(T));
            }
            else
            {
                return (bufferMtrx[top - 1]);
            }
        }

    }
}

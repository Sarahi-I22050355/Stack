using System;

namespace Stack
{
    public class Stack
    {
        private int maxSize;
        private int top;
        private int[] stackArray;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new int[maxSize];
            top = -1;
        }

        public void Push(int value)
        {
            if (top < maxSize - 1)
            {
                stackArray[++top] = value;
            }
            else
            {
                Console.WriteLine("The stack is full. You cannot add more elements.");
            }
        }

        public int Pop()
        {
            if (top >= 0)
            {
                return stackArray[top--];
            }
            else
            {
                Console.WriteLine("The stack is empty. You cannot extract any element.");
                return -1; // Return value to indicate an error
            }
        }

        public int Peek()
        {
            if (top >= 0)
            {
                return stackArray[top];
            }
            else
            {
                Console.WriteLine("The stack is empty. You cannot peek at any element.");
                return -1; // Return value to indicate an error
            }
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public int Size()
        {
            return top + 1;
        }
    }
}

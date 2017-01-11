using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayBased;
using IBuffer;
using System.Diagnostics;
using DynamicArray;
using LinkedList;
using System.Collections;


namespace PerformanceTest
{
    class TestExecuter : ITestExecuter
    {
        public long InsertTime { get; set; }
        public long ExtractTime { get; set; }
        public bool MyQueueTest (string userSelection, int operAmount)
        {
            IMyQueue<int> queue = null;
            switch (userSelection)
            {
                case "Usual array":
                    {
                        queue = new MyQueue<int>(operAmount);
                        break;
                    }

                case "Dynamic array":
                    {
                        queue = new DynamicQueue<int>(operAmount);
                        break;
                    }

                case "Linked list":
                    {
                        queue = new LinkedQueue<int>(operAmount);
                        break;
                    }

                default:
                    {
                        return false;
                    }
            }

                Stopwatch watch = new Stopwatch();
                watch.Start();
                for (int i = 0; i < operAmount; i++)
                {
                    queue.Enqueue(i);
                }
                InsertTime = watch.ElapsedMilliseconds;
                watch.Restart();
                for (int i = 0; i < operAmount; i++)
                {
                    queue.Dequeue();
                }
                watch.Stop();
                ExtractTime = watch.ElapsedMilliseconds;
            return true;

        }

        public bool MyStackTest(string userSelection, int operAmount)
        {
            IMyStack<int> stack = null;
            switch (userSelection)
            {
                case "Usual array":
                    {
                        stack = new MyStack<int>(operAmount);
                        break;
                    }

                case "Dynamic array":
                    {
                        stack = new DynamicStack<int>(operAmount);
                        break;
                    }

                case "Linked list":
                    {
                        stack = new LinkedStack<int>(operAmount);
                        break;
                    }

                default:
                    {
                        return false;
                    }
            }

            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < operAmount; i++)
            {
                stack.Push(i);
            }
            InsertTime = watch.ElapsedMilliseconds;
            watch.Restart();
            for (int i = 0; i < operAmount; i++)
            {
                stack.Pop();
            }
            watch.Stop();
            ExtractTime = watch.ElapsedMilliseconds;
            return true;
        }

        public bool NetQueueTest(int operAmount)
        {
            Queue<int> queue = new Queue<int>(operAmount);
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < operAmount; i++)
            {
                queue.Enqueue(i);
            }
            InsertTime = watch.ElapsedMilliseconds;
            watch.Restart();
            for (int i = 0; i < operAmount; i++)
            {
                queue.Dequeue();
            }
            watch.Stop();
            ExtractTime = watch.ElapsedMilliseconds;
            return true;
        }

        public bool NetStackTest(int operAmount)
        {
            Stack<int> stack = new Stack<int>(operAmount);
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < operAmount; i++)
            {
                stack.Push(i);
            }
            InsertTime = watch.ElapsedMilliseconds;
            watch.Restart();
            for (int i = 0; i < operAmount; i++)
            {
                stack.Pop();
            }
            watch.Stop();
            ExtractTime = watch.ElapsedMilliseconds;
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArrayBased;
using IBuffer;
using System.Diagnostics;
using DynamicArray;
using LinkedList;
using System.Collections;

namespace PerformanceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void MyStakTest_Click(object sender, EventArgs e)
        {
            IMyQueue<int> queue = null;
            int operAmount = (int)myQueueOperAmount.Value;
            switch (myQueueSelect.GetItemText(myQueueSelect.SelectedItem))
            {
                case "Usual array":
                    {
                        queue = new MyQueue<int>(operAmount);
                        break;
                    }

                case "Dynamic array":
                    {
                        queue = new DynamicQueue<int> (operAmount);
                        break;
                    }

                case "Linked list":
                    {
                        queue = new LinkedQueue<int>(operAmount);
                        break;
                    }

                default:
                    {
                        MessageBox.Show("Nothing selected");
                        break;
                    }
            }

            if (queue != null)
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                for (int i = 0; i < operAmount; i++)
                {
                    queue.Enqueue(i);
                }
                myQueueEnqResult.Text = watch.ElapsedMilliseconds.ToString();
                watch.Restart();
                for (int i = 0; i < operAmount; i++)
                {
                   queue.Dequeue();
                }
                watch.Stop();
                myQueueDeqResult.Text = watch.ElapsedMilliseconds.ToString();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MyQueueDeqResult_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int operAmount = (int)netQamountOper.Value;
            Queue<int> queue = new Queue<int>(operAmount);
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < operAmount; i++)
            {
                queue.Enqueue(i);
            }
            netEnqueueResult.Text = watch.ElapsedMilliseconds.ToString();
            watch.Restart();
            for (int i = 0; i < operAmount; i++)
            {
                queue.Dequeue();
            }
            watch.Stop();
            netDequeueResult.Text = watch.ElapsedMilliseconds.ToString();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IMyStack<int> stack = null;
            int operAmount = (int) myStakAmountOper.Value;
            switch (myStackSelect.Text)
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
                        MessageBox.Show("Nothing selected");
                        break;
                    }
            }

            if (stack != null)
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                for (int i = 0; i < operAmount; i++)
                {
                    stack.Push(i);
                }
                myStackPushResult.Text = watch.ElapsedMilliseconds.ToString();
                watch.Restart();
                for (int i = 0; i < operAmount; i++)
                {
                    stack.Pop();
                }
                watch.Stop();
                myStackPopResult.Text = watch.ElapsedMilliseconds.ToString();
            }

        }

        private void MyStackSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void netStackTest_Click(object sender, EventArgs e)
        {
            int operAmount = (int)netStackAmountOper.Value;
            Stack<int> stack = new Stack<int>(operAmount);
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < operAmount; i++)
            {
                stack.Push(i);
            }
            netStackPushResult.Text = watch.ElapsedMilliseconds.ToString();
            watch.Restart();
            for (int i = 0; i < operAmount; i++)
            {
                stack.Pop();
            }
            watch.Stop();
            netStackPopResult.Text = watch.ElapsedMilliseconds.ToString();

        }
    }
}

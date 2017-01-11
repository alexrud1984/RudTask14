using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceTest
{
    public partial class Form1 : Form
    {
        private TestExecuter executer = new TestExecuter();
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

        private void MyQueueTest_Click(object sender, EventArgs e)
        {
            if (executer.MyQueueTest(myQueueSelect.GetItemText(myQueueSelect.SelectedItem), (int)myQueueOperAmount.Value))
            {
                myQueueEnqResult.Text = executer.InsertTime.ToString();
                myQueueDeqResult.Text = executer.ExtractTime.ToString();
            }

            else
            {
                MessageBox.Show("Nothing selected");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MyQueueDeqResult_Click(object sender, EventArgs e)
        {

        }

        private void NetQueueTest_Click(object sender, EventArgs e)
        {

            if (executer.NetQueueTest((int)netQamountOper.Value) )
            {
                netEnqueueResult.Text = executer.InsertTime.ToString();
                netDequeueResult.Text = executer.ExtractTime.ToString();
            }

            else
            {
                MessageBox.Show("Nothing selected");
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void MyStackTest_Click(object sender, EventArgs e)
        {

            if (executer.MyStackTest(myStackSelect.Text, (int)myStakAmountOper.Value))
            {
                myStackPushResult.Text = executer.InsertTime.ToString();
                myStackPopResult.Text = executer.ExtractTime.ToString();
            }

            else
            {
                MessageBox.Show("Nothing selected");
            }

        }

        private void MyStackSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NetStackTest_Click(object sender, EventArgs e)
        {

            if (executer.NetStackTest((int)netStackAmountOper.Value))
            {
                netStackPushResult.Text = executer.InsertTime.ToString();
                netStackPopResult.Text = executer.ExtractTime.ToString();
            }

            else
            {
                MessageBox.Show("Nothing selected");
            }

        }
    }
}

namespace PerformanceTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myQueueSelect = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.myQueueTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.myQueueOperAmount = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.myQueueDeqResult = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.myQueueEnqResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.netQamountOper = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.netDequeueResult = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.netEnqueueResult = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.netQueueTest = new System.Windows.Forms.Button();
            this.DotNet = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.myStakAmountOper = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.myStackPopResult = new System.Windows.Forms.Label();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.myStackPushResult = new System.Windows.Forms.Label();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.myStackSelect = new System.Windows.Forms.ComboBox();
            this.myStackTest = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.netStackAmountOper = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.netStackPopResult = new System.Windows.Forms.Label();
            this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.netStackPushResult = new System.Windows.Forms.Label();
            this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.netStackTest = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myQueueOperAmount)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netQamountOper)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myStakAmountOper)).BeginInit();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netStackAmountOper)).BeginInit();
            this.flowLayoutPanel14.SuspendLayout();
            this.flowLayoutPanel15.SuspendLayout();
            this.flowLayoutPanel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // myQueueSelect
            // 
            this.myQueueSelect.FormattingEnabled = true;
            this.myQueueSelect.Items.AddRange(new object[] {
            "Usual array",
            "Dynamic array",
            "Linked list"});
            this.myQueueSelect.Location = new System.Drawing.Point(78, 3);
            this.myQueueSelect.Name = "myQueueSelect";
            this.myQueueSelect.Size = new System.Drawing.Size(121, 24);
            this.myQueueSelect.TabIndex = 0;
            this.myQueueSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.myQueueSelect);
            this.flowLayoutPanel1.Controls.Add(this.myQueueTest);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(343, 32);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Based on:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // myQueueTest
            // 
            this.myQueueTest.Location = new System.Drawing.Point(205, 3);
            this.myQueueTest.Name = "myQueueTest";
            this.myQueueTest.Size = new System.Drawing.Size(75, 23);
            this.myQueueTest.TabIndex = 5;
            this.myQueueTest.Text = "Test";
            this.myQueueTest.UseVisualStyleBackColor = true;
            this.myQueueTest.Click += new System.EventHandler(this.MyQueueTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Stack";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel3);
            this.groupBox1.Controls.Add(this.flowLayoutPanel5);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Queue testing";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.myQueueOperAmount);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 68);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(343, 36);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Emount of operations";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // myQueueOperAmount
            // 
            this.myQueueOperAmount.Location = new System.Drawing.Point(143, 3);
            this.myQueueOperAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.myQueueOperAmount.Name = "myQueueOperAmount";
            this.myQueueOperAmount.Size = new System.Drawing.Size(120, 22);
            this.myQueueOperAmount.TabIndex = 6;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label4);
            this.flowLayoutPanel5.Controls.Add(this.myQueueDeqResult);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(6, 172);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(343, 35);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dequeue result (ms):";
            // 
            // myQueueDeqResult
            // 
            this.myQueueDeqResult.AutoSize = true;
            this.myQueueDeqResult.Location = new System.Drawing.Point(140, 6);
            this.myQueueDeqResult.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.myQueueDeqResult.Name = "myQueueDeqResult";
            this.myQueueDeqResult.Size = new System.Drawing.Size(53, 16);
            this.myQueueDeqResult.TabIndex = 6;
            this.myQueueDeqResult.Text = "None    ";
            this.myQueueDeqResult.Click += new System.EventHandler(this.MyQueueDeqResult_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.myQueueEnqResult);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 122);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(343, 32);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enqueue result (ms):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // myQueueEnqResult
            // 
            this.myQueueEnqResult.AutoSize = true;
            this.myQueueEnqResult.Location = new System.Drawing.Point(138, 6);
            this.myQueueEnqResult.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.myQueueEnqResult.Name = "myQueueEnqResult";
            this.myQueueEnqResult.Size = new System.Drawing.Size(41, 16);
            this.myQueueEnqResult.TabIndex = 6;
            this.myQueueEnqResult.Text = "None";
            this.myQueueEnqResult.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel4);
            this.groupBox2.Controls.Add(this.flowLayoutPanel6);
            this.groupBox2.Controls.Add(this.flowLayoutPanel7);
            this.groupBox2.Controls.Add(this.flowLayoutPanel8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(397, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 222);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".Net queue testing";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label6);
            this.flowLayoutPanel4.Controls.Add(this.netQamountOper);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 68);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(343, 36);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Emount of operations";
            // 
            // netQamountOper
            // 
            this.netQamountOper.Location = new System.Drawing.Point(143, 3);
            this.netQamountOper.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.netQamountOper.Name = "netQamountOper";
            this.netQamountOper.Size = new System.Drawing.Size(120, 22);
            this.netQamountOper.TabIndex = 6;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label7);
            this.flowLayoutPanel6.Controls.Add(this.netDequeueResult);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(6, 172);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(343, 35);
            this.flowLayoutPanel6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dequeue result (ms):";
            // 
            // netDequeueResult
            // 
            this.netDequeueResult.AutoSize = true;
            this.netDequeueResult.Location = new System.Drawing.Point(140, 6);
            this.netDequeueResult.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.netDequeueResult.Name = "netDequeueResult";
            this.netDequeueResult.Size = new System.Drawing.Size(53, 16);
            this.netDequeueResult.TabIndex = 6;
            this.netDequeueResult.Text = "None    ";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label9);
            this.flowLayoutPanel7.Controls.Add(this.netEnqueueResult);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(6, 122);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(343, 32);
            this.flowLayoutPanel7.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Enqueue result (ms):";
            // 
            // netEnqueueResult
            // 
            this.netEnqueueResult.AutoSize = true;
            this.netEnqueueResult.Location = new System.Drawing.Point(138, 6);
            this.netEnqueueResult.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.netEnqueueResult.Name = "netEnqueueResult";
            this.netEnqueueResult.Size = new System.Drawing.Size(41, 16);
            this.netEnqueueResult.TabIndex = 6;
            this.netEnqueueResult.Text = "None";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label11);
            this.flowLayoutPanel8.Controls.Add(this.DotNet);
            this.flowLayoutPanel8.Controls.Add(this.netQueueTest);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(343, 32);
            this.flowLayoutPanel8.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Based on:";
            // 
            // netQueueTest
            // 
            this.netQueueTest.Location = new System.Drawing.Point(116, 3);
            this.netQueueTest.Name = "netQueueTest";
            this.netQueueTest.Size = new System.Drawing.Size(75, 23);
            this.netQueueTest.TabIndex = 5;
            this.netQueueTest.Text = "Test";
            this.netQueueTest.UseVisualStyleBackColor = true;
            this.netQueueTest.Click += new System.EventHandler(this.NetQueueTest_Click);
            // 
            // DotNet
            // 
            this.DotNet.AutoSize = true;
            this.DotNet.Location = new System.Drawing.Point(78, 6);
            this.DotNet.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.DotNet.Name = "DotNet";
            this.DotNet.Size = new System.Drawing.Size(32, 16);
            this.DotNet.TabIndex = 6;
            this.DotNet.Text = ".Net";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel9);
            this.groupBox3.Controls.Add(this.flowLayoutPanel10);
            this.groupBox3.Controls.Add(this.flowLayoutPanel11);
            this.groupBox3.Controls.Add(this.flowLayoutPanel12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 222);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "My Stack testing";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label8);
            this.flowLayoutPanel9.Controls.Add(this.myStakAmountOper);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(6, 68);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(343, 36);
            this.flowLayoutPanel9.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Emount of operations";
            // 
            // myStakAmountOper
            // 
            this.myStakAmountOper.Location = new System.Drawing.Point(143, 3);
            this.myStakAmountOper.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.myStakAmountOper.Name = "myStakAmountOper";
            this.myStakAmountOper.Size = new System.Drawing.Size(120, 22);
            this.myStakAmountOper.TabIndex = 6;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.label10);
            this.flowLayoutPanel10.Controls.Add(this.myStackPopResult);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(6, 172);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(343, 35);
            this.flowLayoutPanel10.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Pop result (ms):";
            // 
            // myStackPopResult
            // 
            this.myStackPopResult.AutoSize = true;
            this.myStackPopResult.Location = new System.Drawing.Point(109, 6);
            this.myStackPopResult.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.myStackPopResult.Name = "myStackPopResult";
            this.myStackPopResult.Size = new System.Drawing.Size(53, 16);
            this.myStackPopResult.TabIndex = 6;
            this.myStackPopResult.Text = "None    ";
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.label13);
            this.flowLayoutPanel11.Controls.Add(this.myStackPushResult);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(6, 122);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(343, 32);
            this.flowLayoutPanel11.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Push result (ms):";
            // 
            // myStackPushResult
            // 
            this.myStackPushResult.AutoSize = true;
            this.myStackPushResult.Location = new System.Drawing.Point(114, 6);
            this.myStackPushResult.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.myStackPushResult.Name = "myStackPushResult";
            this.myStackPushResult.Size = new System.Drawing.Size(41, 16);
            this.myStackPushResult.TabIndex = 6;
            this.myStackPushResult.Text = "None";
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Controls.Add(this.label15);
            this.flowLayoutPanel12.Controls.Add(this.myStackSelect);
            this.flowLayoutPanel12.Controls.Add(this.myStackTest);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(343, 32);
            this.flowLayoutPanel12.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 6);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Based on:";
            // 
            // myStackSelect
            // 
            this.myStackSelect.FormattingEnabled = true;
            this.myStackSelect.Items.AddRange(new object[] {
            "Usual array",
            "Dynamic array",
            "Linked list"});
            this.myStackSelect.Location = new System.Drawing.Point(78, 3);
            this.myStackSelect.Name = "myStackSelect";
            this.myStackSelect.Size = new System.Drawing.Size(121, 24);
            this.myStackSelect.TabIndex = 0;
            this.myStackSelect.SelectedIndexChanged += new System.EventHandler(this.MyStackSelect_SelectedIndexChanged);
            // 
            // myStackTest
            // 
            this.myStackTest.Location = new System.Drawing.Point(205, 3);
            this.myStackTest.Name = "myStackTest";
            this.myStackTest.Size = new System.Drawing.Size(75, 23);
            this.myStackTest.TabIndex = 5;
            this.myStackTest.Text = "Test";
            this.myStackTest.UseVisualStyleBackColor = true;
            this.myStackTest.Click += new System.EventHandler(this.MyStackTest_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel13);
            this.groupBox4.Controls.Add(this.flowLayoutPanel14);
            this.groupBox4.Controls.Add(this.flowLayoutPanel15);
            this.groupBox4.Controls.Add(this.flowLayoutPanel16);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(397, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 222);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = ".Net stack testing";
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.Controls.Add(this.label12);
            this.flowLayoutPanel13.Controls.Add(this.netStackAmountOper);
            this.flowLayoutPanel13.Location = new System.Drawing.Point(6, 68);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(343, 36);
            this.flowLayoutPanel13.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Emount of operations";
            // 
            // netStackAmountOper
            // 
            this.netStackAmountOper.Location = new System.Drawing.Point(143, 3);
            this.netStackAmountOper.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.netStackAmountOper.Name = "netStackAmountOper";
            this.netStackAmountOper.Size = new System.Drawing.Size(120, 22);
            this.netStackAmountOper.TabIndex = 6;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.label14);
            this.flowLayoutPanel14.Controls.Add(this.netStackPopResult);
            this.flowLayoutPanel14.Location = new System.Drawing.Point(6, 172);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(343, 35);
            this.flowLayoutPanel14.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Pop result (ms):";
            // 
            // netStackPopResult
            // 
            this.netStackPopResult.AutoSize = true;
            this.netStackPopResult.Location = new System.Drawing.Point(109, 6);
            this.netStackPopResult.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.netStackPopResult.Name = "netStackPopResult";
            this.netStackPopResult.Size = new System.Drawing.Size(53, 16);
            this.netStackPopResult.TabIndex = 6;
            this.netStackPopResult.Text = "None    ";
            // 
            // flowLayoutPanel15
            // 
            this.flowLayoutPanel15.Controls.Add(this.label17);
            this.flowLayoutPanel15.Controls.Add(this.netStackPushResult);
            this.flowLayoutPanel15.Location = new System.Drawing.Point(6, 122);
            this.flowLayoutPanel15.Name = "flowLayoutPanel15";
            this.flowLayoutPanel15.Size = new System.Drawing.Size(343, 32);
            this.flowLayoutPanel15.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 6);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "Push result (ms):";
            // 
            // netStackPushResult
            // 
            this.netStackPushResult.AutoSize = true;
            this.netStackPushResult.Location = new System.Drawing.Point(114, 6);
            this.netStackPushResult.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.netStackPushResult.Name = "netStackPushResult";
            this.netStackPushResult.Size = new System.Drawing.Size(41, 16);
            this.netStackPushResult.TabIndex = 6;
            this.netStackPushResult.Text = "None";
            // 
            // flowLayoutPanel16
            // 
            this.flowLayoutPanel16.Controls.Add(this.label19);
            this.flowLayoutPanel16.Controls.Add(this.label20);
            this.flowLayoutPanel16.Controls.Add(this.netStackTest);
            this.flowLayoutPanel16.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel16.Name = "flowLayoutPanel16";
            this.flowLayoutPanel16.Size = new System.Drawing.Size(343, 32);
            this.flowLayoutPanel16.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 6);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 16);
            this.label19.TabIndex = 4;
            this.label19.Text = "Based on:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(78, 6);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 16);
            this.label20.TabIndex = 6;
            this.label20.Text = ".Net";
            // 
            // netStackTest
            // 
            this.netStackTest.Location = new System.Drawing.Point(116, 3);
            this.netStackTest.Name = "netStackTest";
            this.netStackTest.Size = new System.Drawing.Size(75, 23);
            this.netStackTest.TabIndex = 5;
            this.netStackTest.Text = "Test";
            this.netStackTest.UseVisualStyleBackColor = true;
            this.netStackTest.Click += new System.EventHandler(this.NetStackTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 547);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Performance Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myQueueOperAmount)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netQamountOper)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myStakAmountOper)).EndInit();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netStackAmountOper)).EndInit();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.flowLayoutPanel15.ResumeLayout(false);
            this.flowLayoutPanel15.PerformLayout();
            this.flowLayoutPanel16.ResumeLayout(false);
            this.flowLayoutPanel16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox myQueueSelect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button myQueueTest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label myQueueEnqResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label myQueueDeqResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown myQueueOperAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown netQamountOper;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label netDequeueResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label netEnqueueResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button netQueueTest;
        private System.Windows.Forms.Label DotNet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown myStakAmountOper;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label myStackPopResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label myStackPushResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox myStackSelect;
        private System.Windows.Forms.Button myStackTest;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown netStackAmountOper;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label netStackPopResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label netStackPushResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button netStackTest;
    }
}


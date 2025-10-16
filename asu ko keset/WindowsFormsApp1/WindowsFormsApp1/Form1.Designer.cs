namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.huntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelClayAmt = new System.Windows.Forms.Label();
            this.labelCropAmt = new System.Windows.Forms.Label();
            this.labelWoodAmt = new System.Windows.Forms.Label();
            this.labelIronAmt = new System.Windows.Forms.Label();
            this.groupBoxProduction = new System.Windows.Forms.GroupBox();
            this.labelCropProduction = new System.Windows.Forms.Label();
            this.labelWoodProduction = new System.Windows.Forms.Label();
            this.labelIronProduction = new System.Windows.Forms.Label();
            this.labelClayProduction = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.buttonUpgrade = new System.Windows.Forms.Button();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.timerGameUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerProduction = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxProduction.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huntToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 28);
            // 
            // huntToolStripMenuItem
            // 
            this.huntToolStripMenuItem.Name = "huntToolStripMenuItem";
            this.huntToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.huntToolStripMenuItem.Text = "hunt";
            this.huntToolStripMenuItem.Click += new System.EventHandler(this.huntToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Crop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wood";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Iron";
            // 
            // labelClayAmt
            // 
            this.labelClayAmt.AutoSize = true;
            this.labelClayAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClayAmt.Location = new System.Drawing.Point(16, 43);
            this.labelClayAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClayAmt.Name = "labelClayAmt";
            this.labelClayAmt.Size = new System.Drawing.Size(17, 18);
            this.labelClayAmt.TabIndex = 7;
            this.labelClayAmt.Text = "0";
            // 
            // labelCropAmt
            // 
            this.labelCropAmt.AutoSize = true;
            this.labelCropAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCropAmt.Location = new System.Drawing.Point(188, 43);
            this.labelCropAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCropAmt.Name = "labelCropAmt";
            this.labelCropAmt.Size = new System.Drawing.Size(17, 18);
            this.labelCropAmt.TabIndex = 8;
            this.labelCropAmt.Text = "0";
            // 
            // labelWoodAmt
            // 
            this.labelWoodAmt.AutoSize = true;
            this.labelWoodAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWoodAmt.Location = new System.Drawing.Point(123, 43);
            this.labelWoodAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWoodAmt.Name = "labelWoodAmt";
            this.labelWoodAmt.Size = new System.Drawing.Size(17, 18);
            this.labelWoodAmt.TabIndex = 9;
            this.labelWoodAmt.Text = "0";
            // 
            // labelIronAmt
            // 
            this.labelIronAmt.AutoSize = true;
            this.labelIronAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIronAmt.Location = new System.Drawing.Point(69, 43);
            this.labelIronAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIronAmt.Name = "labelIronAmt";
            this.labelIronAmt.Size = new System.Drawing.Size(17, 18);
            this.labelIronAmt.TabIndex = 10;
            this.labelIronAmt.Text = "0";
            // 
            // groupBoxProduction
            // 
            this.groupBoxProduction.Controls.Add(this.labelCropProduction);
            this.groupBoxProduction.Controls.Add(this.labelWoodProduction);
            this.groupBoxProduction.Controls.Add(this.labelIronProduction);
            this.groupBoxProduction.Controls.Add(this.labelClayProduction);
            this.groupBoxProduction.Controls.Add(this.label8);
            this.groupBoxProduction.Controls.Add(this.label7);
            this.groupBoxProduction.Controls.Add(this.label6);
            this.groupBoxProduction.Controls.Add(this.label5);
            this.groupBoxProduction.Location = new System.Drawing.Point(819, 84);
            this.groupBoxProduction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxProduction.Name = "groupBoxProduction";
            this.groupBoxProduction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxProduction.Size = new System.Drawing.Size(380, 156);
            this.groupBoxProduction.TabIndex = 11;
            this.groupBoxProduction.TabStop = false;
            this.groupBoxProduction.Text = "Production Per Hour";
            // 
            // labelCropProduction
            // 
            this.labelCropProduction.AutoSize = true;
            this.labelCropProduction.Location = new System.Drawing.Point(68, 121);
            this.labelCropProduction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCropProduction.Name = "labelCropProduction";
            this.labelCropProduction.Size = new System.Drawing.Size(14, 16);
            this.labelCropProduction.TabIndex = 7;
            this.labelCropProduction.Text = "0";
            // 
            // labelWoodProduction
            // 
            this.labelWoodProduction.AutoSize = true;
            this.labelWoodProduction.Location = new System.Drawing.Point(68, 94);
            this.labelWoodProduction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWoodProduction.Name = "labelWoodProduction";
            this.labelWoodProduction.Size = new System.Drawing.Size(14, 16);
            this.labelWoodProduction.TabIndex = 6;
            this.labelWoodProduction.Text = "0";
            // 
            // labelIronProduction
            // 
            this.labelIronProduction.AutoSize = true;
            this.labelIronProduction.Location = new System.Drawing.Point(68, 62);
            this.labelIronProduction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIronProduction.Name = "labelIronProduction";
            this.labelIronProduction.Size = new System.Drawing.Size(14, 16);
            this.labelIronProduction.TabIndex = 5;
            this.labelIronProduction.Text = "0";
            // 
            // labelClayProduction
            // 
            this.labelClayProduction.AutoSize = true;
            this.labelClayProduction.Location = new System.Drawing.Point(68, 39);
            this.labelClayProduction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClayProduction.Name = "labelClayProduction";
            this.labelClayProduction.Size = new System.Drawing.Size(14, 16);
            this.labelClayProduction.TabIndex = 4;
            this.labelClayProduction.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Crop:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Wood:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Iron:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Clay:";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.labelDetails);
            this.groupBoxDetails.Controls.Add(this.buttonUpgrade);
            this.groupBoxDetails.Location = new System.Drawing.Point(819, 258);
            this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDetails.Size = new System.Drawing.Size(380, 262);
            this.groupBoxDetails.TabIndex = 12;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Building Details";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(32, 52);
            this.labelDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(51, 16);
            this.labelDetails.TabIndex = 1;
            this.labelDetails.Text = "label13";
            this.labelDetails.Visible = false;
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpgrade.Enabled = false;
            this.buttonUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpgrade.Location = new System.Drawing.Point(144, 214);
            this.buttonUpgrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(108, 41);
            this.buttonUpgrade.TabIndex = 0;
            this.buttonUpgrade.Text = "Upgrade";
            this.buttonUpgrade.UseVisualStyleBackColor = false;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.labelTimer);
            this.groupBoxTime.Location = new System.Drawing.Point(15, 544);
            this.groupBoxTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTime.Size = new System.Drawing.Size(788, 92);
            this.groupBoxTime.TabIndex = 13;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Upgrade Time:";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(11, 26);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(51, 16);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "label13";
            this.labelTimer.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 236);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 193);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 27);
            this.button3.TabIndex = 15;
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(660, 314);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 27);
            this.button4.TabIndex = 16;
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(563, 127);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 27);
            this.button5.TabIndex = 17;
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(592, 409);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 27);
            this.button6.TabIndex = 18;
            this.button6.Text = "0";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(476, 359);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 27);
            this.button7.TabIndex = 19;
            this.button7.Text = "0";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(456, 444);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(27, 27);
            this.button8.TabIndex = 20;
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(319, 431);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(27, 27);
            this.button9.TabIndex = 21;
            this.button9.Text = "0";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(269, 310);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(27, 27);
            this.button10.TabIndex = 22;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(493, 193);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(27, 27);
            this.button11.TabIndex = 23;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(409, 181);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(27, 27);
            this.button12.TabIndex = 24;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(460, 112);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(27, 27);
            this.button13.TabIndex = 25;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(324, 112);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(27, 27);
            this.button14.TabIndex = 26;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(269, 236);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(27, 27);
            this.button15.TabIndex = 27;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(237, 166);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(27, 27);
            this.button16.TabIndex = 28;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(148, 236);
            this.button17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(27, 27);
            this.button17.TabIndex = 29;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(159, 322);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(27, 27);
            this.button18.TabIndex = 30;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // timerGameUpdate
            // 
            this.timerGameUpdate.Enabled = true;
            this.timerGameUpdate.Interval = 60;
            this.timerGameUpdate.Tick += new System.EventHandler(this.timerGameUpdate_Tick);
            // 
            // timerProduction
            // 
            this.timerProduction.Enabled = true;
            this.timerProduction.Interval = 1000;
            this.timerProduction.Tick += new System.EventHandler(this.timerProduction_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxProduction);
            this.Controls.Add(this.labelIronAmt);
            this.Controls.Add(this.labelWoodAmt);
            this.Controls.Add(this.labelCropAmt);
            this.Controls.Add(this.labelClayAmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxProduction.ResumeLayout(false);
            this.groupBoxProduction.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem huntToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelClayAmt;
        private System.Windows.Forms.Label labelCropAmt;
        private System.Windows.Forms.Label labelWoodAmt;
        private System.Windows.Forms.Label labelIronAmt;
        private System.Windows.Forms.GroupBox groupBoxProduction;
        private System.Windows.Forms.Label labelWoodProduction;
        private System.Windows.Forms.Label labelIronProduction;
        private System.Windows.Forms.Label labelClayProduction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCropProduction;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Button buttonUpgrade;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Timer timerGameUpdate;
        private System.Windows.Forms.Timer timerProduction;
    }
}


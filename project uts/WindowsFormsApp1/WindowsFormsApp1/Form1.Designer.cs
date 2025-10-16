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
            this.buttonIron4 = new System.Windows.Forms.Button();
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
            this.buttonIron2 = new System.Windows.Forms.Button();
            this.buttonIron3 = new System.Windows.Forms.Button();
            this.buttonCrop5 = new System.Windows.Forms.Button();
            this.buttonWood4 = new System.Windows.Forms.Button();
            this.buttonClay4 = new System.Windows.Forms.Button();
            this.buttonWood3 = new System.Windows.Forms.Button();
            this.buttonWood2 = new System.Windows.Forms.Button();
            this.buttonClay1 = new System.Windows.Forms.Button();
            this.buttonCrop4 = new System.Windows.Forms.Button();
            this.buttonClay3 = new System.Windows.Forms.Button();
            this.buttonClay2 = new System.Windows.Forms.Button();
            this.buttonCrop6 = new System.Windows.Forms.Button();
            this.buttonWood1 = new System.Windows.Forms.Button();
            this.buttonCrop3 = new System.Windows.Forms.Button();
            this.buttonIron1 = new System.Windows.Forms.Button();
            this.buttonCrop1 = new System.Windows.Forms.Button();
            this.buttonCrop2 = new System.Windows.Forms.Button();
            this.timerGameUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerProduction = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.labelFPS = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
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
            // buttonIron4
            // 
            this.buttonIron4.Location = new System.Drawing.Point(689, 230);
            this.buttonIron4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIron4.Name = "buttonIron4";
            this.buttonIron4.Size = new System.Drawing.Size(25, 33);
            this.buttonIron4.TabIndex = 2;
            this.buttonIron4.Text = "0";
            this.buttonIron4.UseVisualStyleBackColor = true;
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
            this.labelDetails.Location = new System.Drawing.Point(8, 29);
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
            // buttonIron2
            // 
            this.buttonIron2.Location = new System.Drawing.Point(557, 233);
            this.buttonIron2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIron2.Name = "buttonIron2";
            this.buttonIron2.Size = new System.Drawing.Size(24, 28);
            this.buttonIron2.TabIndex = 14;
            this.buttonIron2.Text = "0";
            this.buttonIron2.UseVisualStyleBackColor = true;
            // 
            // buttonIron3
            // 
            this.buttonIron3.Location = new System.Drawing.Point(620, 185);
            this.buttonIron3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIron3.Name = "buttonIron3";
            this.buttonIron3.Size = new System.Drawing.Size(37, 36);
            this.buttonIron3.TabIndex = 15;
            this.buttonIron3.Text = "0";
            this.buttonIron3.UseVisualStyleBackColor = true;
            // 
            // buttonCrop5
            // 
            this.buttonCrop5.Location = new System.Drawing.Point(659, 310);
            this.buttonCrop5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrop5.Name = "buttonCrop5";
            this.buttonCrop5.Size = new System.Drawing.Size(28, 30);
            this.buttonCrop5.TabIndex = 16;
            this.buttonCrop5.Text = "0";
            this.buttonCrop5.UseVisualStyleBackColor = true;
            // 
            // buttonWood4
            // 
            this.buttonWood4.Location = new System.Drawing.Point(557, 126);
            this.buttonWood4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWood4.Name = "buttonWood4";
            this.buttonWood4.Size = new System.Drawing.Size(32, 36);
            this.buttonWood4.TabIndex = 17;
            this.buttonWood4.Text = "0";
            this.buttonWood4.UseVisualStyleBackColor = true;
            // 
            // buttonClay4
            // 
            this.buttonClay4.Location = new System.Drawing.Point(589, 407);
            this.buttonClay4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClay4.Name = "buttonClay4";
            this.buttonClay4.Size = new System.Drawing.Size(28, 30);
            this.buttonClay4.TabIndex = 18;
            this.buttonClay4.Text = "0";
            this.buttonClay4.UseVisualStyleBackColor = true;
            // 
            // buttonWood3
            // 
            this.buttonWood3.Location = new System.Drawing.Point(469, 351);
            this.buttonWood3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWood3.Name = "buttonWood3";
            this.buttonWood3.Size = new System.Drawing.Size(33, 34);
            this.buttonWood3.TabIndex = 19;
            this.buttonWood3.Text = "0";
            this.buttonWood3.UseVisualStyleBackColor = true;
            // 
            // buttonWood2
            // 
            this.buttonWood2.Location = new System.Drawing.Point(457, 441);
            this.buttonWood2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWood2.Name = "buttonWood2";
            this.buttonWood2.Size = new System.Drawing.Size(24, 30);
            this.buttonWood2.TabIndex = 20;
            this.buttonWood2.Text = "0";
            this.buttonWood2.UseVisualStyleBackColor = true;
            // 
            // buttonClay1
            // 
            this.buttonClay1.Location = new System.Drawing.Point(319, 430);
            this.buttonClay1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClay1.Name = "buttonClay1";
            this.buttonClay1.Size = new System.Drawing.Size(20, 30);
            this.buttonClay1.TabIndex = 21;
            this.buttonClay1.Text = "0";
            this.buttonClay1.UseVisualStyleBackColor = true;
            // 
            // buttonCrop4
            // 
            this.buttonCrop4.Location = new System.Drawing.Point(268, 302);
            this.buttonCrop4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrop4.Name = "buttonCrop4";
            this.buttonCrop4.Size = new System.Drawing.Size(35, 32);
            this.buttonCrop4.TabIndex = 22;
            this.buttonCrop4.Text = "0";
            this.buttonCrop4.UseVisualStyleBackColor = true;
            // 
            // buttonClay3
            // 
            this.buttonClay3.Location = new System.Drawing.Point(493, 185);
            this.buttonClay3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClay3.Name = "buttonClay3";
            this.buttonClay3.Size = new System.Drawing.Size(28, 36);
            this.buttonClay3.TabIndex = 23;
            this.buttonClay3.Text = "0";
            this.buttonClay3.UseVisualStyleBackColor = true;
            // 
            // buttonClay2
            // 
            this.buttonClay2.Location = new System.Drawing.Point(405, 185);
            this.buttonClay2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClay2.Name = "buttonClay2";
            this.buttonClay2.Size = new System.Drawing.Size(32, 33);
            this.buttonClay2.TabIndex = 24;
            this.buttonClay2.Text = "0";
            this.buttonClay2.UseVisualStyleBackColor = true;
            // 
            // buttonCrop6
            // 
            this.buttonCrop6.Location = new System.Drawing.Point(457, 102);
            this.buttonCrop6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrop6.Name = "buttonCrop6";
            this.buttonCrop6.Size = new System.Drawing.Size(29, 37);
            this.buttonCrop6.TabIndex = 25;
            this.buttonCrop6.Text = "0";
            this.buttonCrop6.UseVisualStyleBackColor = true;
            // 
            // buttonWood1
            // 
            this.buttonWood1.Location = new System.Drawing.Point(319, 110);
            this.buttonWood1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWood1.Name = "buttonWood1";
            this.buttonWood1.Size = new System.Drawing.Size(29, 30);
            this.buttonWood1.TabIndex = 26;
            this.buttonWood1.Text = "0";
            this.buttonWood1.UseVisualStyleBackColor = true;
            // 
            // buttonCrop3
            // 
            this.buttonCrop3.Location = new System.Drawing.Point(268, 235);
            this.buttonCrop3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrop3.Name = "buttonCrop3";
            this.buttonCrop3.Size = new System.Drawing.Size(35, 28);
            this.buttonCrop3.TabIndex = 27;
            this.buttonCrop3.Text = "0";
            this.buttonCrop3.UseVisualStyleBackColor = true;
            // 
            // buttonIron1
            // 
            this.buttonIron1.Location = new System.Drawing.Point(233, 162);
            this.buttonIron1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIron1.Name = "buttonIron1";
            this.buttonIron1.Size = new System.Drawing.Size(29, 31);
            this.buttonIron1.TabIndex = 28;
            this.buttonIron1.Text = "0";
            this.buttonIron1.UseVisualStyleBackColor = true;
            // 
            // buttonCrop1
            // 
            this.buttonCrop1.Location = new System.Drawing.Point(148, 233);
            this.buttonCrop1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrop1.Name = "buttonCrop1";
            this.buttonCrop1.Size = new System.Drawing.Size(32, 28);
            this.buttonCrop1.TabIndex = 29;
            this.buttonCrop1.Text = "0";
            this.buttonCrop1.UseVisualStyleBackColor = true;
            // 
            // buttonCrop2
            // 
            this.buttonCrop2.Location = new System.Drawing.Point(156, 322);
            this.buttonCrop2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrop2.Name = "buttonCrop2";
            this.buttonCrop2.Size = new System.Drawing.Size(24, 32);
            this.buttonCrop2.TabIndex = 30;
            this.buttonCrop2.Text = "0";
            this.buttonCrop2.UseVisualStyleBackColor = true;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(779, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "FPS: ";
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Location = new System.Drawing.Point(819, 9);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(14, 16);
            this.labelFPS.TabIndex = 32;
            this.labelFPS.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(779, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Game Speed:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(880, 34);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(14, 16);
            this.labelSpeed.TabIndex = 34;
            this.labelSpeed.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelFPS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonCrop2);
            this.Controls.Add(this.buttonCrop1);
            this.Controls.Add(this.buttonIron1);
            this.Controls.Add(this.buttonCrop3);
            this.Controls.Add(this.buttonWood1);
            this.Controls.Add(this.buttonCrop6);
            this.Controls.Add(this.buttonClay2);
            this.Controls.Add(this.buttonClay3);
            this.Controls.Add(this.buttonCrop4);
            this.Controls.Add(this.buttonClay1);
            this.Controls.Add(this.buttonWood2);
            this.Controls.Add(this.buttonWood3);
            this.Controls.Add(this.buttonClay4);
            this.Controls.Add(this.buttonWood4);
            this.Controls.Add(this.buttonCrop5);
            this.Controls.Add(this.buttonIron3);
            this.Controls.Add(this.buttonIron2);
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
            this.Controls.Add(this.buttonIron4);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
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
        private System.Windows.Forms.Button buttonIron4;
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
        private System.Windows.Forms.Button buttonIron2;
        private System.Windows.Forms.Button buttonIron3;
        private System.Windows.Forms.Button buttonCrop5;
        private System.Windows.Forms.Button buttonWood4;
        private System.Windows.Forms.Button buttonClay4;
        private System.Windows.Forms.Button buttonWood3;
        private System.Windows.Forms.Button buttonWood2;
        private System.Windows.Forms.Button buttonClay1;
        private System.Windows.Forms.Button buttonCrop4;
        private System.Windows.Forms.Button buttonClay3;
        private System.Windows.Forms.Button buttonClay2;
        private System.Windows.Forms.Button buttonCrop6;
        private System.Windows.Forms.Button buttonWood1;
        private System.Windows.Forms.Button buttonCrop3;
        private System.Windows.Forms.Button buttonIron1;
        private System.Windows.Forms.Button buttonCrop1;
        private System.Windows.Forms.Button buttonCrop2;
        private System.Windows.Forms.Timer timerGameUpdate;
        private System.Windows.Forms.Timer timerProduction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelSpeed;
    }
}


namespace AnimalShelter
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
            this.lbAnimalOverview = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAnimalType = new System.Windows.Forms.Label();
            this.cbAnimalSorts = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpInfoDate = new System.Windows.Forms.DateTimePicker();
            this.cbInfoOwner = new System.Windows.Forms.ComboBox();
            this.btSaveAnimalInfo = new System.Windows.Forms.Button();
            this.btEditAnimalInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbInfoHabit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInfoPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInfoName = new System.Windows.Forms.TextBox();
            this.btAddAnimal = new System.Windows.Forms.Button();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.dtpInfoWalkDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbInfoReservedYes = new System.Windows.Forms.RadioButton();
            this.rbInfoReservedNo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAnimalOverview
            // 
            this.lbAnimalOverview.FormattingEnabled = true;
            this.lbAnimalOverview.ItemHeight = 16;
            this.lbAnimalOverview.Location = new System.Drawing.Point(6, 115);
            this.lbAnimalOverview.Name = "lbAnimalOverview";
            this.lbAnimalOverview.Size = new System.Drawing.Size(148, 292);
            this.lbAnimalOverview.TabIndex = 0;
            this.lbAnimalOverview.SelectedIndexChanged += new System.EventHandler(this.lbAnimalOverview_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAnimalType);
            this.groupBox1.Controls.Add(this.cbAnimalSorts);
            this.groupBox1.Controls.Add(this.lbAnimalOverview);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 409);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overview";
            // 
            // lbAnimalType
            // 
            this.lbAnimalType.AutoSize = true;
            this.lbAnimalType.Location = new System.Drawing.Point(6, 37);
            this.lbAnimalType.Name = "lbAnimalType";
            this.lbAnimalType.Size = new System.Drawing.Size(133, 17);
            this.lbAnimalType.TabIndex = 2;
            this.lbAnimalType.Text = "Sort by animal type:";
            // 
            // cbAnimalSorts
            // 
            this.cbAnimalSorts.FormattingEnabled = true;
            this.cbAnimalSorts.Location = new System.Drawing.Point(6, 67);
            this.cbAnimalSorts.Name = "cbAnimalSorts";
            this.cbAnimalSorts.Size = new System.Drawing.Size(147, 24);
            this.cbAnimalSorts.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dtpInfoWalkDate);
            this.groupBox2.Controls.Add(this.dtpInfoDate);
            this.groupBox2.Controls.Add(this.cbInfoOwner);
            this.groupBox2.Controls.Add(this.btSaveAnimalInfo);
            this.groupBox2.Controls.Add(this.btEditAnimalInfo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbInfoHabit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbInfoPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbInfoName);
            this.groupBox2.Location = new System.Drawing.Point(331, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 407);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dtpInfoDate
            // 
            this.dtpInfoDate.Enabled = false;
            this.dtpInfoDate.Location = new System.Drawing.Point(97, 73);
            this.dtpInfoDate.Name = "dtpInfoDate";
            this.dtpInfoDate.Size = new System.Drawing.Size(172, 22);
            this.dtpInfoDate.TabIndex = 24;
            // 
            // cbInfoOwner
            // 
            this.cbInfoOwner.Enabled = false;
            this.cbInfoOwner.FormattingEnabled = true;
            this.cbInfoOwner.Location = new System.Drawing.Point(97, 112);
            this.cbInfoOwner.Name = "cbInfoOwner";
            this.cbInfoOwner.Size = new System.Drawing.Size(172, 24);
            this.cbInfoOwner.TabIndex = 23;
            // 
            // btSaveAnimalInfo
            // 
            this.btSaveAnimalInfo.Location = new System.Drawing.Point(194, 366);
            this.btSaveAnimalInfo.Name = "btSaveAnimalInfo";
            this.btSaveAnimalInfo.Size = new System.Drawing.Size(75, 23);
            this.btSaveAnimalInfo.TabIndex = 22;
            this.btSaveAnimalInfo.Text = "Save";
            this.btSaveAnimalInfo.UseVisualStyleBackColor = true;
            this.btSaveAnimalInfo.Click += new System.EventHandler(this.btSaveAnimalInfo_Click);
            // 
            // btEditAnimalInfo
            // 
            this.btEditAnimalInfo.Location = new System.Drawing.Point(73, 366);
            this.btEditAnimalInfo.Name = "btEditAnimalInfo";
            this.btEditAnimalInfo.Size = new System.Drawing.Size(99, 23);
            this.btEditAnimalInfo.TabIndex = 21;
            this.btEditAnimalInfo.Text = "Edit";
            this.btEditAnimalInfo.UseVisualStyleBackColor = true;
            this.btEditAnimalInfo.Click += new System.EventHandler(this.btEditAnimalInfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Habits:";
            // 
            // tbInfoHabit
            // 
            this.tbInfoHabit.Location = new System.Drawing.Point(97, 309);
            this.tbInfoHabit.Multiline = true;
            this.tbInfoHabit.Name = "tbInfoHabit";
            this.tbInfoHabit.ReadOnly = true;
            this.tbInfoHabit.Size = new System.Drawing.Size(172, 22);
            this.tbInfoHabit.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Walk date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reserved:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price:";
            // 
            // tbInfoPrice
            // 
            this.tbInfoPrice.Location = new System.Drawing.Point(97, 156);
            this.tbInfoPrice.Name = "tbInfoPrice";
            this.tbInfoPrice.ReadOnly = true;
            this.tbInfoPrice.Size = new System.Drawing.Size(172, 22);
            this.tbInfoPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Owner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birthdate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // tbInfoName
            // 
            this.tbInfoName.Location = new System.Drawing.Point(97, 34);
            this.tbInfoName.Name = "tbInfoName";
            this.tbInfoName.ReadOnly = true;
            this.tbInfoName.Size = new System.Drawing.Size(172, 22);
            this.tbInfoName.TabIndex = 1;
            // 
            // btAddAnimal
            // 
            this.btAddAnimal.Location = new System.Drawing.Point(693, 41);
            this.btAddAnimal.Name = "btAddAnimal";
            this.btAddAnimal.Size = new System.Drawing.Size(132, 50);
            this.btAddAnimal.TabIndex = 3;
            this.btAddAnimal.Text = "Add animal";
            this.btAddAnimal.UseVisualStyleBackColor = true;
            this.btAddAnimal.Click += new System.EventHandler(this.btAddAnimal_Click);
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(693, 99);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(132, 50);
            this.btnAddOwner.TabIndex = 4;
            this.btnAddOwner.Text = "Add owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // dtpInfoWalkDate
            // 
            this.dtpInfoWalkDate.Enabled = false;
            this.dtpInfoWalkDate.Location = new System.Drawing.Point(97, 270);
            this.dtpInfoWalkDate.Name = "dtpInfoWalkDate";
            this.dtpInfoWalkDate.Size = new System.Drawing.Size(172, 22);
            this.dtpInfoWalkDate.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbInfoReservedNo);
            this.groupBox3.Controls.Add(this.rbInfoReservedYes);
            this.groupBox3.Location = new System.Drawing.Point(97, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 61);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reserved";
            // 
            // rbInfoReservedYes
            // 
            this.rbInfoReservedYes.AutoSize = true;
            this.rbInfoReservedYes.Enabled = false;
            this.rbInfoReservedYes.Location = new System.Drawing.Point(6, 34);
            this.rbInfoReservedYes.Name = "rbInfoReservedYes";
            this.rbInfoReservedYes.Size = new System.Drawing.Size(53, 21);
            this.rbInfoReservedYes.TabIndex = 0;
            this.rbInfoReservedYes.TabStop = true;
            this.rbInfoReservedYes.Text = "Yes";
            this.rbInfoReservedYes.UseVisualStyleBackColor = true;
            // 
            // rbInfoReservedNo
            // 
            this.rbInfoReservedNo.AutoSize = true;
            this.rbInfoReservedNo.Enabled = false;
            this.rbInfoReservedNo.Location = new System.Drawing.Point(79, 34);
            this.rbInfoReservedNo.Name = "rbInfoReservedNo";
            this.rbInfoReservedNo.Size = new System.Drawing.Size(47, 21);
            this.rbInfoReservedNo.TabIndex = 1;
            this.rbInfoReservedNo.TabStop = true;
            this.rbInfoReservedNo.Text = "No";
            this.rbInfoReservedNo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(947, 442);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.btAddAnimal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAnimalOverview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAnimalType;
        private System.Windows.Forms.ComboBox cbAnimalSorts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInfoPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInfoName;
        private System.Windows.Forms.Button btEditAnimalInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbInfoHabit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSaveAnimalInfo;
        private System.Windows.Forms.Button btAddAnimal;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.ComboBox cbInfoOwner;
        private System.Windows.Forms.DateTimePicker dtpInfoDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbInfoReservedNo;
        private System.Windows.Forms.RadioButton rbInfoReservedYes;
        private System.Windows.Forms.DateTimePicker dtpInfoWalkDate;
    }
}


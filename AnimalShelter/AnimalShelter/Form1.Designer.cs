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
            this.cbAnimalSorts = new System.Windows.Forms.ComboBox();
            this.lbAnimalType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbInfoName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInfoBirthdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInfoOwner = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInfoPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInfoReserved = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInfoWalkDate = new System.Windows.Forms.TextBox();
            this.btEditAnimalInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbInfoHabit = new System.Windows.Forms.TextBox();
            this.btSaveAnimalInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // cbAnimalSorts
            // 
            this.cbAnimalSorts.FormattingEnabled = true;
            this.cbAnimalSorts.Location = new System.Drawing.Point(6, 67);
            this.cbAnimalSorts.Name = "cbAnimalSorts";
            this.cbAnimalSorts.Size = new System.Drawing.Size(147, 24);
            this.cbAnimalSorts.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSaveAnimalInfo);
            this.groupBox2.Controls.Add(this.btEditAnimalInfo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbInfoHabit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbInfoWalkDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbInfoReserved);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbInfoPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbInfoOwner);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbInfoBirthdate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbInfoName);
            this.groupBox2.Location = new System.Drawing.Point(331, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 407);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // tbInfoName
            // 
            this.tbInfoName.Location = new System.Drawing.Point(97, 67);
            this.tbInfoName.Name = "tbInfoName";
            this.tbInfoName.ReadOnly = true;
            this.tbInfoName.Size = new System.Drawing.Size(100, 22);
            this.tbInfoName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birthdate";
            // 
            // tbInfoBirthdate
            // 
            this.tbInfoBirthdate.Location = new System.Drawing.Point(97, 106);
            this.tbInfoBirthdate.Name = "tbInfoBirthdate";
            this.tbInfoBirthdate.ReadOnly = true;
            this.tbInfoBirthdate.Size = new System.Drawing.Size(100, 22);
            this.tbInfoBirthdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Owner";
            // 
            // tbInfoOwner
            // 
            this.tbInfoOwner.Location = new System.Drawing.Point(97, 149);
            this.tbInfoOwner.Name = "tbInfoOwner";
            this.tbInfoOwner.ReadOnly = true;
            this.tbInfoOwner.Size = new System.Drawing.Size(100, 22);
            this.tbInfoOwner.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price:";
            // 
            // tbInfoPrice
            // 
            this.tbInfoPrice.Location = new System.Drawing.Point(97, 189);
            this.tbInfoPrice.Name = "tbInfoPrice";
            this.tbInfoPrice.ReadOnly = true;
            this.tbInfoPrice.Size = new System.Drawing.Size(100, 22);
            this.tbInfoPrice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reserved:";
            // 
            // tbInfoReserved
            // 
            this.tbInfoReserved.Location = new System.Drawing.Point(97, 228);
            this.tbInfoReserved.Name = "tbInfoReserved";
            this.tbInfoReserved.ReadOnly = true;
            this.tbInfoReserved.Size = new System.Drawing.Size(100, 22);
            this.tbInfoReserved.TabIndex = 10;
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
            // tbInfoWalkDate
            // 
            this.tbInfoWalkDate.Location = new System.Drawing.Point(97, 267);
            this.tbInfoWalkDate.Name = "tbInfoWalkDate";
            this.tbInfoWalkDate.ReadOnly = true;
            this.tbInfoWalkDate.Size = new System.Drawing.Size(100, 22);
            this.tbInfoWalkDate.TabIndex = 16;
            // 
            // btEditAnimalInfo
            // 
            this.btEditAnimalInfo.Location = new System.Drawing.Point(97, 366);
            this.btEditAnimalInfo.Name = "btEditAnimalInfo";
            this.btEditAnimalInfo.Size = new System.Drawing.Size(75, 23);
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
            this.tbInfoHabit.Name = "tbInfoHabit";
            this.tbInfoHabit.ReadOnly = true;
            this.tbInfoHabit.Size = new System.Drawing.Size(100, 22);
            this.tbInfoHabit.TabIndex = 19;
            // 
            // btSaveAnimalInfo
            // 
            this.btSaveAnimalInfo.Location = new System.Drawing.Point(194, 366);
            this.btSaveAnimalInfo.Name = "btSaveAnimalInfo";
            this.btSaveAnimalInfo.Size = new System.Drawing.Size(75, 23);
            this.btSaveAnimalInfo.TabIndex = 22;
            this.btSaveAnimalInfo.Text = "Save";
            this.btSaveAnimalInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox tbInfoOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInfoBirthdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInfoName;
        private System.Windows.Forms.Button btEditAnimalInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbInfoHabit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbInfoWalkDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInfoReserved;
        private System.Windows.Forms.Button btSaveAnimalInfo;
    }
}


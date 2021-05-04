
namespace Genetic_Algorithm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.no1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.values1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtMrate = new System.Windows.Forms.TextBox();
            this.txtSrate = new System.Windows.Forms.TextBox();
            this.txtErate = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.domainUpDown5 = new System.Windows.Forms.DomainUpDown();
            this.domPopSize = new System.Windows.Forms.DomainUpDown();
            this.domMaxValue = new System.Windows.Forms.DomainUpDown();
            this.domMaxWeight = new System.Windows.Forms.DomainUpDown();
            this.domNumObj = new System.Windows.Forms.DomainUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCreatePop = new System.Windows.Forms.Button();
            this.btnCreateData = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.no2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gene2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.values2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.no3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gene3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.values3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fitness3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no1,
            this.values1,
            this.weight1});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(459, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(202, 777);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // no1
            // 
            this.no1.Text = "No.";
            this.no1.Width = 45;
            // 
            // values1
            // 
            this.values1.Text = "Values";
            this.values1.Width = 78;
            // 
            // weight1
            // 
            this.weight1.Text = "Weight";
            this.weight1.Width = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtMrate);
            this.panel1.Controls.Add(this.txtSrate);
            this.panel1.Controls.Add(this.txtErate);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.domainUpDown5);
            this.panel1.Controls.Add(this.domPopSize);
            this.panel1.Controls.Add(this.domMaxValue);
            this.panel1.Controls.Add(this.domMaxWeight);
            this.panel1.Controls.Add(this.domNumObj);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnCreatePop);
            this.panel1.Controls.Add(this.btnCreateData);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 777);
            this.panel1.TabIndex = 7;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(20, 631);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(229, 29);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "Base on Convergence";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(20, 547);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(207, 29);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Base on Generation";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtMrate
            // 
            this.txtMrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrate.Location = new System.Drawing.Point(272, 402);
            this.txtMrate.Multiline = true;
            this.txtMrate.Name = "txtMrate";
            this.txtMrate.Size = new System.Drawing.Size(148, 34);
            this.txtMrate.TabIndex = 26;
            this.txtMrate.Text = ".15";
            // 
            // txtSrate
            // 
            this.txtSrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrate.Location = new System.Drawing.Point(272, 495);
            this.txtSrate.Multiline = true;
            this.txtSrate.Name = "txtSrate";
            this.txtSrate.Size = new System.Drawing.Size(148, 34);
            this.txtSrate.TabIndex = 25;
            this.txtSrate.Text = ".75";
            // 
            // txtErate
            // 
            this.txtErate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErate.Location = new System.Drawing.Point(272, 364);
            this.txtErate.Multiline = true;
            this.txtErate.Name = "txtErate";
            this.txtErate.Size = new System.Drawing.Size(148, 34);
            this.txtErate.TabIndex = 24;
            this.txtErate.Text = ".35";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(20, 459);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(224, 29);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Steady state selection";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(20, 328);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(175, 29);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Elitism Selection";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // domainUpDown5
            // 
            this.domainUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDown5.Location = new System.Drawing.Point(272, 581);
            this.domainUpDown5.Name = "domainUpDown5";
            this.domainUpDown5.Size = new System.Drawing.Size(148, 30);
            this.domainUpDown5.TabIndex = 20;
            this.domainUpDown5.Text = "100";
            // 
            // domPopSize
            // 
            this.domPopSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domPopSize.Location = new System.Drawing.Point(272, 199);
            this.domPopSize.Name = "domPopSize";
            this.domPopSize.Size = new System.Drawing.Size(148, 30);
            this.domPopSize.TabIndex = 19;
            this.domPopSize.Text = "50";
            // 
            // domMaxValue
            // 
            this.domMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domMaxValue.Location = new System.Drawing.Point(272, 102);
            this.domMaxValue.Name = "domMaxValue";
            this.domMaxValue.Size = new System.Drawing.Size(148, 30);
            this.domMaxValue.TabIndex = 18;
            this.domMaxValue.Text = "100";
            // 
            // domMaxWeight
            // 
            this.domMaxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domMaxWeight.Location = new System.Drawing.Point(272, 59);
            this.domMaxWeight.Name = "domMaxWeight";
            this.domMaxWeight.Size = new System.Drawing.Size(148, 30);
            this.domMaxWeight.TabIndex = 21;
            this.domMaxWeight.Text = "100";
            // 
            // domNumObj
            // 
            this.domNumObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domNumObj.Location = new System.Drawing.Point(272, 15);
            this.domNumObj.Name = "domNumObj";
            this.domNumObj.Size = new System.Drawing.Size(148, 30);
            this.domNumObj.TabIndex = 17;
            this.domNumObj.Text = "10";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(233, 680);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 68);
            this.button3.TabIndex = 16;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCreatePop
            // 
            this.btnCreatePop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePop.Location = new System.Drawing.Point(20, 241);
            this.btnCreatePop.Name = "btnCreatePop";
            this.btnCreatePop.Size = new System.Drawing.Size(187, 79);
            this.btnCreatePop.TabIndex = 15;
            this.btnCreatePop.Text = "Create intial population";
            this.btnCreatePop.UseVisualStyleBackColor = true;
            this.btnCreatePop.Click += new System.EventHandler(this.btnCreatePop_Click);
            // 
            // btnCreateData
            // 
            this.btnCreateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateData.Location = new System.Drawing.Point(20, 152);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(187, 35);
            this.btnCreateData.TabIndex = 14;
            this.btnCreateData.Text = "Create data";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Max value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Population size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Max weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Max interaction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Steady rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mutation rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Elitism rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of objects";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no2,
            this.gene2,
            this.values2,
            this.weight2});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(667, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(345, 777);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // no2
            // 
            this.no2.Text = "No.";
            this.no2.Width = 45;
            // 
            // gene2
            // 
            this.gene2.Text = "Gene";
            this.gene2.Width = 143;
            // 
            // values2
            // 
            this.values2.Text = "Values";
            this.values2.Width = 74;
            // 
            // weight2
            // 
            this.weight2.Text = "Weight";
            this.weight2.Width = 78;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no3,
            this.gene3,
            this.values3,
            this.weight3,
            this.fitness3});
            this.listView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(1018, 2);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(418, 777);
            this.listView3.TabIndex = 6;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // no3
            // 
            this.no3.Text = "No.";
            this.no3.Width = 45;
            // 
            // gene3
            // 
            this.gene3.Text = "Gene";
            this.gene3.Width = 152;
            // 
            // values3
            // 
            this.values3.Text = "Values";
            this.values3.Width = 74;
            // 
            // weight3
            // 
            this.weight3.Text = "Weight";
            this.weight3.Width = 70;
            // 
            // fitness3
            // 
            this.fitness3.Text = "Fitness";
            this.fitness3.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 791);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Genetic Algorithm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtMrate;
        private System.Windows.Forms.TextBox txtSrate;
        private System.Windows.Forms.TextBox txtErate;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DomainUpDown domainUpDown5;
        private System.Windows.Forms.DomainUpDown domPopSize;
        private System.Windows.Forms.DomainUpDown domMaxValue;
        private System.Windows.Forms.DomainUpDown domMaxWeight;
        private System.Windows.Forms.DomainUpDown domNumObj;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCreatePop;
        private System.Windows.Forms.Button btnCreateData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader no1;
        private System.Windows.Forms.ColumnHeader values1;
        private System.Windows.Forms.ColumnHeader weight1;
        private System.Windows.Forms.ColumnHeader no2;
        private System.Windows.Forms.ColumnHeader gene2;
        private System.Windows.Forms.ColumnHeader values2;
        private System.Windows.Forms.ColumnHeader weight2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader no3;
        private System.Windows.Forms.ColumnHeader gene3;
        private System.Windows.Forms.ColumnHeader values3;
        private System.Windows.Forms.ColumnHeader weight3;
        private System.Windows.Forms.ColumnHeader fitness3;
    }
}


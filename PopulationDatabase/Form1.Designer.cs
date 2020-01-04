namespace PopulationDatabase
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTotalPopulation = new System.Windows.Forms.Button();
            this.btnAveragePopulation = new System.Windows.Forms.Button();
            this.btnHighestPopulation = new System.Windows.Forms.Button();
            this.btnLowestPopulation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLowestPopulation = new System.Windows.Forms.Label();
            this.lblHighestPopulation = new System.Windows.Forms.Label();
            this.lblAveragePopulation = new System.Windows.Forms.Label();
            this.lblTotalPopulation = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Population Information:";
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(224, 124);
            this.txtPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(174, 22);
            this.txtPopulation.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(224, 68);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(174, 22);
            this.txtCity.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnInsert);
            this.groupBox3.Location = new System.Drawing.Point(13, 172);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(447, 96);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(313, 30);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(19, 23);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 53);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Existing Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click_1);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(166, 30);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 39);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert Record";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(325, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit Population Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnTotalPopulation
            // 
            this.btnTotalPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPopulation.Location = new System.Drawing.Point(8, 36);
            this.btnTotalPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalPopulation.Name = "btnTotalPopulation";
            this.btnTotalPopulation.Size = new System.Drawing.Size(228, 41);
            this.btnTotalPopulation.TabIndex = 2;
            this.btnTotalPopulation.Text = "Show Total Population";
            this.btnTotalPopulation.UseVisualStyleBackColor = true;
            this.btnTotalPopulation.Click += new System.EventHandler(this.BtnTotalPopulation_Click_1);
            // 
            // btnAveragePopulation
            // 
            this.btnAveragePopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAveragePopulation.Location = new System.Drawing.Point(8, 84);
            this.btnAveragePopulation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAveragePopulation.Name = "btnAveragePopulation";
            this.btnAveragePopulation.Size = new System.Drawing.Size(228, 41);
            this.btnAveragePopulation.TabIndex = 3;
            this.btnAveragePopulation.Text = "Show Average Population";
            this.btnAveragePopulation.UseVisualStyleBackColor = true;
            this.btnAveragePopulation.Click += new System.EventHandler(this.BtnAveragePopulation_Click_1);
            // 
            // btnHighestPopulation
            // 
            this.btnHighestPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighestPopulation.Location = new System.Drawing.Point(8, 132);
            this.btnHighestPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.btnHighestPopulation.Name = "btnHighestPopulation";
            this.btnHighestPopulation.Size = new System.Drawing.Size(228, 41);
            this.btnHighestPopulation.TabIndex = 4;
            this.btnHighestPopulation.Text = "Show Highest Population";
            this.btnHighestPopulation.UseVisualStyleBackColor = true;
            this.btnHighestPopulation.Click += new System.EventHandler(this.BtnHighestPopulation_Click_1);
            // 
            // btnLowestPopulation
            // 
            this.btnLowestPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowestPopulation.Location = new System.Drawing.Point(8, 180);
            this.btnLowestPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.btnLowestPopulation.Name = "btnLowestPopulation";
            this.btnLowestPopulation.Size = new System.Drawing.Size(228, 41);
            this.btnLowestPopulation.TabIndex = 5;
            this.btnLowestPopulation.Text = "Show Lowest Population";
            this.btnLowestPopulation.UseVisualStyleBackColor = true;
            this.btnLowestPopulation.Click += new System.EventHandler(this.BtnLowestPopulation_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.btnLowestPopulation);
            this.groupBox2.Controls.Add(this.btnHighestPopulation);
            this.groupBox2.Controls.Add(this.btnAveragePopulation);
            this.groupBox2.Controls.Add(this.btnTotalPopulation);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(810, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(245, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Population Database:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lblLowestPopulation);
            this.groupBox1.Controls.Add(this.lblHighestPopulation);
            this.groupBox1.Controls.Add(this.lblAveragePopulation);
            this.groupBox1.Controls.Add(this.lblTotalPopulation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 304);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1012, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblLowestPopulation
            // 
            this.lblLowestPopulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLowestPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestPopulation.Location = new System.Drawing.Point(762, 27);
            this.lblLowestPopulation.Name = "lblLowestPopulation";
            this.lblLowestPopulation.Size = new System.Drawing.Size(138, 84);
            this.lblLowestPopulation.TabIndex = 3;
            // 
            // lblHighestPopulation
            // 
            this.lblHighestPopulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHighestPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestPopulation.Location = new System.Drawing.Point(538, 27);
            this.lblHighestPopulation.Name = "lblHighestPopulation";
            this.lblHighestPopulation.Size = new System.Drawing.Size(138, 84);
            this.lblHighestPopulation.TabIndex = 2;
            // 
            // lblAveragePopulation
            // 
            this.lblAveragePopulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAveragePopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAveragePopulation.Location = new System.Drawing.Point(279, 27);
            this.lblAveragePopulation.Name = "lblAveragePopulation";
            this.lblAveragePopulation.Size = new System.Drawing.Size(138, 84);
            this.lblAveragePopulation.TabIndex = 1;
            // 
            // lblTotalPopulation
            // 
            this.lblTotalPopulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPopulation.Location = new System.Drawing.Point(32, 27);
            this.lblTotalPopulation.Name = "lblTotalPopulation";
            this.lblTotalPopulation.Size = new System.Drawing.Size(138, 84);
            this.lblTotalPopulation.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPopulation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Population Database";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTotalPopulation;
        private System.Windows.Forms.Button btnAveragePopulation;
        private System.Windows.Forms.Button btnHighestPopulation;
        private System.Windows.Forms.Button btnLowestPopulation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLowestPopulation;
        private System.Windows.Forms.Label lblHighestPopulation;
        private System.Windows.Forms.Label lblAveragePopulation;
        private System.Windows.Forms.Label lblTotalPopulation;
    }
}

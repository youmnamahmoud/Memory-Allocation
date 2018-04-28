namespace MemoryAllocation
{
    partial class Simulation
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allocate = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.lableNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Allocation",
            "Deallocation"});
            this.comboBox1.Location = new System.Drawing.Point(65, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allocate);
            this.groupBox1.Controls.Add(this.size);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Controls.Add(this.labelSize);
            this.groupBox1.Controls.Add(this.lableNumber);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process";
            // 
            // allocate
            // 
            this.allocate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allocate.Location = new System.Drawing.Point(54, 87);
            this.allocate.Name = "allocate";
            this.allocate.Size = new System.Drawing.Size(78, 36);
            this.allocate.TabIndex = 2;
            this.allocate.Text = "Allocate";
            this.allocate.UseVisualStyleBackColor = true;
            this.allocate.Click += new System.EventHandler(this.allocate_Click);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(54, 59);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(78, 22);
            this.size.TabIndex = 3;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(54, 28);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(78, 22);
            this.number.TabIndex = 2;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(23, 66);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(34, 16);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Size";
            // 
            // lableNumber
            // 
            this.lableNumber.AutoSize = true;
            this.lableNumber.Location = new System.Drawing.Point(23, 31);
            this.lableNumber.Name = "lableNumber";
            this.lableNumber.Size = new System.Drawing.Size(30, 16);
            this.lableNumber.TabIndex = 0;
            this.lableNumber.Text = "PID";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back to Holes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.list.Location = new System.Drawing.Point(238, 73);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(133, 143);
            this.list.TabIndex = 2;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose allocate or de-allocate";
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(759, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Simulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Simulation_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button allocate;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label lableNumber;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
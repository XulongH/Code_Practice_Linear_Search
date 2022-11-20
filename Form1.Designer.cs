namespace Code_Practice_Linear_Search
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
            this.lbAll = new System.Windows.Forms.ListBox();
            this.lbFilterResult = new System.Windows.Forms.ListBox();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFilterRange = new System.Windows.Forms.Button();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCSI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAll
            // 
            this.lbAll.FormattingEnabled = true;
            this.lbAll.ItemHeight = 24;
            this.lbAll.Location = new System.Drawing.Point(35, 39);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(366, 532);
            this.lbAll.TabIndex = 0;
            // 
            // lbFilterResult
            // 
            this.lbFilterResult.FormattingEnabled = true;
            this.lbFilterResult.ItemHeight = 24;
            this.lbFilterResult.Location = new System.Drawing.Point(708, 39);
            this.lbFilterResult.Name = "lbFilterResult";
            this.lbFilterResult.Size = new System.Drawing.Size(337, 532);
            this.lbFilterResult.TabIndex = 1;
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(475, 108);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(139, 40);
            this.btnContains.TabIndex = 2;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(451, 249);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(185, 40);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Students Index";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFilterRange
            // 
            this.btnFilterRange.Location = new System.Drawing.Point(475, 507);
            this.btnFilterRange.Name = "btnFilterRange";
            this.btnFilterRange.Size = new System.Drawing.Size(139, 40);
            this.btnFilterRange.TabIndex = 5;
            this.btnFilterRange.Text = "Range";
            this.btnFilterRange.UseVisualStyleBackColor = true;
            this.btnFilterRange.Click += new System.EventHandler(this.btnFilterRange_Click);
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(492, 60);
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(100, 29);
            this.txtContains.TabIndex = 6;
            // 
            // txtFindName
            // 
            this.txtFindName.Location = new System.Drawing.Point(451, 204);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(183, 29);
            this.txtFindName.TabIndex = 7;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(453, 456);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(52, 29);
            this.txtMin.TabIndex = 8;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(582, 456);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(52, 29);
            this.txtMax.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Max";
            // 
            // btnCSI
            // 
            this.btnCSI.Location = new System.Drawing.Point(475, 343);
            this.btnCSI.Name = "btnCSI";
            this.btnCSI.Size = new System.Drawing.Size(139, 40);
            this.btnCSI.TabIndex = 12;
            this.btnCSI.Text = "Find CSI";
            this.btnCSI.UseVisualStyleBackColor = true;
            this.btnCSI.Click += new System.EventHandler(this.btnCSI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 619);
            this.Controls.Add(this.btnCSI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtFindName);
            this.Controls.Add(this.txtContains);
            this.Controls.Add(this.btnFilterRange);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.lbFilterResult);
            this.Controls.Add(this.lbAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAll;
        private System.Windows.Forms.ListBox lbFilterResult;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFilterRange;
        private System.Windows.Forms.TextBox txtContains;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCSI;
    }
}


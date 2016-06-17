namespace PrimePay_Database
{
    partial class frmPrimePay
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblLocale = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtLocale = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.grpMainInfo = new System.Windows.Forms.GroupBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpNewRec = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpUpdateRec = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpMainInfo.SuspendLayout();
            this.grpNewRec.SuspendLayout();
            this.grpUpdateRec.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(6, 31);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(60, 13);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(199, 31);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(61, 13);
            this.lblLast.TabIndex = 1;
            this.lblLast.Text = "Last Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(36, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(198, 57);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 3;
            this.lblDept.Text = "Department";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(72, 28);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 4;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(266, 28);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(100, 20);
            this.txtLast.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(72, 54);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(266, 54);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 7;
            // 
            // lblLocale
            // 
            this.lblLocale.AutoSize = true;
            this.lblLocale.Location = new System.Drawing.Point(15, 83);
            this.lblLocale.Name = "lblLocale";
            this.lblLocale.Size = new System.Drawing.Size(51, 13);
            this.lblLocale.TabIndex = 8;
            this.lblLocale.Text = "Location:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(189, 83);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(71, 13);
            this.lblSalary.TabIndex = 9;
            this.lblSalary.Text = "Yearly Salary:";
            // 
            // txtLocale
            // 
            this.txtLocale.Location = new System.Drawing.Point(72, 80);
            this.txtLocale.Name = "txtLocale";
            this.txtLocale.Size = new System.Drawing.Size(100, 20);
            this.txtLocale.TabIndex = 10;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(266, 80);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 11;
            // 
            // grpMainInfo
            // 
            this.grpMainInfo.Controls.Add(this.btnFirst);
            this.grpMainInfo.Controls.Add(this.btnLast);
            this.grpMainInfo.Controls.Add(this.btnPrev);
            this.grpMainInfo.Controls.Add(this.btnNext);
            this.grpMainInfo.Controls.Add(this.lblFirst);
            this.grpMainInfo.Controls.Add(this.lblSalary);
            this.grpMainInfo.Controls.Add(this.txtSalary);
            this.grpMainInfo.Controls.Add(this.txtFirst);
            this.grpMainInfo.Controls.Add(this.txtLocale);
            this.grpMainInfo.Controls.Add(this.lblLast);
            this.grpMainInfo.Controls.Add(this.txtLast);
            this.grpMainInfo.Controls.Add(this.lblLocale);
            this.grpMainInfo.Controls.Add(this.lblTitle);
            this.grpMainInfo.Controls.Add(this.txtDept);
            this.grpMainInfo.Controls.Add(this.txtTitle);
            this.grpMainInfo.Controls.Add(this.lblDept);
            this.grpMainInfo.Location = new System.Drawing.Point(12, 12);
            this.grpMainInfo.Name = "grpMainInfo";
            this.grpMainInfo.Size = new System.Drawing.Size(372, 135);
            this.grpMainInfo.TabIndex = 12;
            this.grpMainInfo.TabStop = false;
            this.grpMainInfo.Text = "Employee Info";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(6, 106);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 15;
            this.btnFirst.Text = "| | <";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(291, 106);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 14;
            this.btnLast.Text = "> | |";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(87, 106);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "< <";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(210, 106);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "> >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // grpNewRec
            // 
            this.grpNewRec.Controls.Add(this.btnAdd);
            this.grpNewRec.Controls.Add(this.btnSave);
            this.grpNewRec.Controls.Add(this.btnCancel);
            this.grpNewRec.Location = new System.Drawing.Point(12, 153);
            this.grpNewRec.Name = "grpNewRec";
            this.grpNewRec.Size = new System.Drawing.Size(372, 48);
            this.grpNewRec.TabIndex = 13;
            this.grpNewRec.TabStop = false;
            this.grpNewRec.Text = "Add New Record";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(149, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(292, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpUpdateRec
            // 
            this.grpUpdateRec.Controls.Add(this.btnUpdate);
            this.grpUpdateRec.Controls.Add(this.btnDelete);
            this.grpUpdateRec.Location = new System.Drawing.Point(12, 207);
            this.grpUpdateRec.Name = "grpUpdateRec";
            this.grpUpdateRec.Size = new System.Drawing.Size(372, 48);
            this.grpUpdateRec.TabIndex = 16;
            this.grpUpdateRec.TabStop = false;
            this.grpUpdateRec.Text = "Update Records";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(210, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmPrimePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 265);
            this.Controls.Add(this.grpUpdateRec);
            this.Controls.Add(this.grpNewRec);
            this.Controls.Add(this.grpMainInfo);
            this.Name = "frmPrimePay";
            this.Text = "PrimePay Database";
            this.Load += new System.EventHandler(this.frmPrimePay_Load);
            this.grpMainInfo.ResumeLayout(false);
            this.grpMainInfo.PerformLayout();
            this.grpNewRec.ResumeLayout(false);
            this.grpUpdateRec.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblLocale;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtLocale;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.GroupBox grpMainInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.GroupBox grpNewRec;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpUpdateRec;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}


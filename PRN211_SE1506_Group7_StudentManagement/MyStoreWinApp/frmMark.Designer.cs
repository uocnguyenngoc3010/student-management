﻿
namespace MyStoreWinApp
{
    partial class frmMark
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
            this.lbCourseID = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lbAssignment = new System.Windows.Forms.Label();
            this.lbPractical = new System.Windows.Forms.Label();
            this.lbFinal = new System.Windows.Forms.Label();
            this.lbGPA = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvMark = new System.Windows.Forms.DataGridView();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.txtPractical = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMark)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCourseID
            // 
            this.lbCourseID.AutoSize = true;
            this.lbCourseID.Location = new System.Drawing.Point(86, 72);
            this.lbCourseID.Name = "lbCourseID";
            this.lbCourseID.Size = new System.Drawing.Size(69, 20);
            this.lbCourseID.TabIndex = 0;
            this.lbCourseID.Text = "CourseID";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(86, 123);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(75, 20);
            this.lbStudentID.TabIndex = 1;
            this.lbStudentID.Text = "StudentID";
            // 
            // lbAssignment
            // 
            this.lbAssignment.AutoSize = true;
            this.lbAssignment.Location = new System.Drawing.Point(86, 178);
            this.lbAssignment.Name = "lbAssignment";
            this.lbAssignment.Size = new System.Drawing.Size(86, 20);
            this.lbAssignment.TabIndex = 2;
            this.lbAssignment.Text = "Assignment";
            // 
            // lbPractical
            // 
            this.lbPractical.AutoSize = true;
            this.lbPractical.Location = new System.Drawing.Point(446, 75);
            this.lbPractical.Name = "lbPractical";
            this.lbPractical.Size = new System.Drawing.Size(65, 20);
            this.lbPractical.TabIndex = 3;
            this.lbPractical.Text = "Practical";
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Location = new System.Drawing.Point(446, 126);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(40, 20);
            this.lbFinal.TabIndex = 4;
            this.lbFinal.Text = "Final";
            // 
            // lbGPA
            // 
            this.lbGPA.AutoSize = true;
            this.lbGPA.Location = new System.Drawing.Point(446, 175);
            this.lbGPA.Name = "lbGPA";
            this.lbGPA.Size = new System.Drawing.Size(36, 20);
            this.lbGPA.TabIndex = 5;
            this.lbGPA.Text = "GPA";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(105, 245);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(326, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(545, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvMark
            // 
            this.dgvMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMark.Location = new System.Drawing.Point(62, 296);
            this.dgvMark.Name = "dgvMark";
            this.dgvMark.RowHeadersWidth = 51;
            this.dgvMark.RowTemplate.Height = 29;
            this.dgvMark.Size = new System.Drawing.Size(668, 188);
            this.dgvMark.TabIndex = 9;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(181, 72);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(125, 27);
            this.txtCourseID.TabIndex = 10;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(181, 116);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(125, 27);
            this.txtStudentID.TabIndex = 11;
            // 
            // txtAssignment
            // 
            this.txtAssignment.Location = new System.Drawing.Point(181, 163);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(125, 27);
            this.txtAssignment.TabIndex = 12;
            // 
            // txtPractical
            // 
            this.txtPractical.Location = new System.Drawing.Point(529, 72);
            this.txtPractical.Name = "txtPractical";
            this.txtPractical.Size = new System.Drawing.Size(125, 27);
            this.txtPractical.TabIndex = 13;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(529, 123);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(125, 27);
            this.txtFinal.TabIndex = 14;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(529, 175);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(125, 27);
            this.txtGPA.TabIndex = 15;
            // 
            // frmMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtPractical);
            this.Controls.Add(this.txtAssignment);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.dgvMark);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbGPA);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.lbPractical);
            this.Controls.Add(this.lbAssignment);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.lbCourseID);
            this.Name = "frmMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark";
            this.Load += new System.EventHandler(this.frmMark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCourseID;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbAssignment;
        private System.Windows.Forms.Label lbPractical;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.Label lbGPA;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvMark;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.TextBox txtPractical;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtGPA;
    }
}
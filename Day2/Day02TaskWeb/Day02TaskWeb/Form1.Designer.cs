namespace Day02TaskWeb
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_Depts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Depts).BeginInit();
            SuspendLayout();
            // 
            // dgv_Depts
            // 
            dgv_Depts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Depts.Location = new Point(28, 215);
            dgv_Depts.Name = "dgv_Depts";
            dgv_Depts.Size = new Size(727, 208);
            dgv_Depts.TabIndex = 0;
            dgv_Depts.CellContentClick += dgv_Depts_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_Depts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Depts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Depts;
    }
}

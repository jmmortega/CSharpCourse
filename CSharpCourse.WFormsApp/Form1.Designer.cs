namespace CSharpCourse.WFormsApp
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
            this.buttonChangeTextBox = new System.Windows.Forms.Button();
            this.buttonFillGrid = new System.Windows.Forms.Button();
            this.labelChangeText = new System.Windows.Forms.Label();
            this.textBoxTextChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMedia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeTextBox
            // 
            this.buttonChangeTextBox.Location = new System.Drawing.Point(83, 116);
            this.buttonChangeTextBox.Name = "buttonChangeTextBox";
            this.buttonChangeTextBox.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeTextBox.TabIndex = 0;
            this.buttonChangeTextBox.Text = "Change text";
            this.buttonChangeTextBox.UseVisualStyleBackColor = true;
            this.buttonChangeTextBox.Click += new System.EventHandler(this.buttonChangeTextBox_Click);
            // 
            // buttonFillGrid
            // 
            this.buttonFillGrid.Location = new System.Drawing.Point(83, 145);
            this.buttonFillGrid.Name = "buttonFillGrid";
            this.buttonFillGrid.Size = new System.Drawing.Size(75, 23);
            this.buttonFillGrid.TabIndex = 1;
            this.buttonFillGrid.Text = "Fill grid";
            this.buttonFillGrid.UseVisualStyleBackColor = true;
            this.buttonFillGrid.Click += new System.EventHandler(this.buttonFillGrid_Click);
            // 
            // labelChangeText
            // 
            this.labelChangeText.AutoSize = true;
            this.labelChangeText.Location = new System.Drawing.Point(317, 116);
            this.labelChangeText.Name = "labelChangeText";
            this.labelChangeText.Size = new System.Drawing.Size(35, 13);
            this.labelChangeText.TabIndex = 2;
            this.labelChangeText.Text = "label1";
            // 
            // textBoxTextChange
            // 
            this.textBoxTextChange.Location = new System.Drawing.Point(193, 113);
            this.textBoxTextChange.Name = "textBoxTextChange";
            this.textBoxTextChange.Size = new System.Drawing.Size(100, 20);
            this.textBoxTextChange.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remember! All of controls that you may change by code, should change generic name" +
    " \"controlNameN\" for another name...";
            // 
            // dataGridViewMedia
            // 
            this.dataGridViewMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedia.Location = new System.Drawing.Point(193, 145);
            this.dataGridViewMedia.Name = "dataGridViewMedia";
            this.dataGridViewMedia.Size = new System.Drawing.Size(414, 202);
            this.dataGridViewMedia.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 359);
            this.Controls.Add(this.dataGridViewMedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTextChange);
            this.Controls.Add(this.labelChangeText);
            this.Controls.Add(this.buttonFillGrid);
            this.Controls.Add(this.buttonChangeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeTextBox;
        private System.Windows.Forms.Button buttonFillGrid;
        private System.Windows.Forms.Label labelChangeText;
        private System.Windows.Forms.TextBox textBoxTextChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMedia;
    }
}


namespace Tuan02
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
            this.upperTextbox1 = new Tuan02.UpperTextbox();
            this.stripedDatagridView1 = new Tuan02.StripedDatagridView();
            ((System.ComponentModel.ISupportInitialize)(this.stripedDatagridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // upperTextbox1
            // 
            this.upperTextbox1.Location = new System.Drawing.Point(64, 60);
            this.upperTextbox1.Name = "upperTextbox1";
            this.upperTextbox1.Size = new System.Drawing.Size(148, 22);
            this.upperTextbox1.TabIndex = 0;
            // 
            // stripedDatagridView1
            // 
            this.stripedDatagridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stripedDatagridView1.Location = new System.Drawing.Point(30, 126);
            this.stripedDatagridView1.Name = "stripedDatagridView1";
            this.stripedDatagridView1.RowTemplate.Height = 24;
            this.stripedDatagridView1.Size = new System.Drawing.Size(424, 196);
            this.stripedDatagridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 334);
            this.Controls.Add(this.stripedDatagridView1);
            this.Controls.Add(this.upperTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stripedDatagridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UpperTextbox upperTextbox1;
        private StripedDatagridView stripedDatagridView1;
    }
}


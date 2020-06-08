namespace QueuingSystem_1
{
    partial class Success
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Success));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.queuNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeOnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is your queu number, get a screenshot or a photo of this, and proceed to the" +
    " registration line. Thank you ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "NO.";
            // 
            // queuNumber
            // 
            this.queuNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queuNumber.Location = new System.Drawing.Point(247, 199);
            this.queuNumber.Name = "queuNumber";
            this.queuNumber.Size = new System.Drawing.Size(417, 122);
            this.queuNumber.TabIndex = 2;
            this.queuNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.queuNumber.Click += new System.EventHandler(this.queuNumber_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // closeOnDone
            // 
            this.closeOnDone.AutoSize = true;
            this.closeOnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeOnDone.Location = new System.Drawing.Point(348, 489);
            this.closeOnDone.Name = "closeOnDone";
            this.closeOnDone.Size = new System.Drawing.Size(95, 39);
            this.closeOnDone.TabIndex = 4;
            this.closeOnDone.Text = "DONE";
            this.closeOnDone.UseVisualStyleBackColor = true;
            this.closeOnDone.Click += new System.EventHandler(this.closeOnDone_Click);
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.closeOnDone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.queuNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Success";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Success";
            this.Load += new System.EventHandler(this.Success_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label queuNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeOnDone;
    }
}
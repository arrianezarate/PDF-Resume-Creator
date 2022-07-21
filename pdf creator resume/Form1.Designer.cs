namespace pdf_creator_resume
{
    partial class _frmPDFgenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmPDFgenerator));
            this._lblCreatePDF = new System.Windows.Forms.Label();
            this._btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblCreatePDF
            // 
            this._lblCreatePDF.AutoSize = true;
            this._lblCreatePDF.BackColor = System.Drawing.Color.Transparent;
            this._lblCreatePDF.Font = new System.Drawing.Font("HP Simplified Hans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCreatePDF.ForeColor = System.Drawing.Color.MistyRose;
            this._lblCreatePDF.Location = new System.Drawing.Point(12, 9);
            this._lblCreatePDF.Name = "_lblCreatePDF";
            this._lblCreatePDF.Size = new System.Drawing.Size(168, 36);
            this._lblCreatePDF.TabIndex = 0;
            this._lblCreatePDF.Text = "Create PDF";
            // 
            // _btnGenerate
            // 
            this._btnGenerate.BackColor = System.Drawing.Color.HotPink;
            this._btnGenerate.Font = new System.Drawing.Font("HP Simplified Hans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGenerate.ForeColor = System.Drawing.Color.LavenderBlush;
            this._btnGenerate.Location = new System.Drawing.Point(18, 48);
            this._btnGenerate.Name = "_btnGenerate";
            this._btnGenerate.Size = new System.Drawing.Size(162, 56);
            this._btnGenerate.TabIndex = 1;
            this._btnGenerate.Text = "GENERATE";
            this._btnGenerate.UseVisualStyleBackColor = false;
            // 
            // _frmPDFgenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(468, 395);
            this.Controls.Add(this._btnGenerate);
            this.Controls.Add(this._lblCreatePDF);
            this.Name = "_frmPDFgenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblCreatePDF;
        private System.Windows.Forms.Button _btnGenerate;
    }
}


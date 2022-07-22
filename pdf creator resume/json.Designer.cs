namespace pdf_creator_resume
{
    partial class _frmJSON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmJSON));
            this._tboxJSON = new System.Windows.Forms.TextBox();
            this._btnDisplay = new System.Windows.Forms.Button();
            this._lblJSON = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _tboxJSON
            // 
            this._tboxJSON.Location = new System.Drawing.Point(77, 68);
            this._tboxJSON.Multiline = true;
            this._tboxJSON.Name = "_tboxJSON";
            this._tboxJSON.Size = new System.Drawing.Size(279, 445);
            this._tboxJSON.TabIndex = 0;
            // 
            // _btnDisplay
            // 
            this._btnDisplay.BackColor = System.Drawing.Color.HotPink;
            this._btnDisplay.Font = new System.Drawing.Font("HP Simplified Hans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDisplay.ForeColor = System.Drawing.Color.LavenderBlush;
            this._btnDisplay.Location = new System.Drawing.Point(135, 519);
            this._btnDisplay.Name = "_btnDisplay";
            this._btnDisplay.Size = new System.Drawing.Size(162, 56);
            this._btnDisplay.TabIndex = 2;
            this._btnDisplay.Text = "VIEW";
            this._btnDisplay.UseVisualStyleBackColor = false;
            this._btnDisplay.Click += new System.EventHandler(this._btnDisplay_Click);
            // 
            // _lblJSON
            // 
            this._lblJSON.AutoSize = true;
            this._lblJSON.BackColor = System.Drawing.Color.Transparent;
            this._lblJSON.Font = new System.Drawing.Font("HP Simplified Hans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblJSON.ForeColor = System.Drawing.Color.MistyRose;
            this._lblJSON.Location = new System.Drawing.Point(170, 29);
            this._lblJSON.Name = "_lblJSON";
            this._lblJSON.Size = new System.Drawing.Size(85, 36);
            this._lblJSON.TabIndex = 3;
            this._lblJSON.Text = "JSON";
            // 
            // _frmJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 587);
            this.Controls.Add(this._lblJSON);
            this.Controls.Add(this._btnDisplay);
            this.Controls.Add(this._tboxJSON);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "_frmJSON";
            this.Text = "JSON ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tboxJSON;
        private System.Windows.Forms.Button _btnDisplay;
        private System.Windows.Forms.Label _lblJSON;
    }
}
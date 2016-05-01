namespace met2lua
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
            this.tbOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbOut
            // 
            this.tbOut.AllowDrop = true;
            this.tbOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOut.BackColor = System.Drawing.SystemColors.Window;
            this.tbOut.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOut.Location = new System.Drawing.Point(12, 12);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.ReadOnly = true;
            this.tbOut.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbOut.Size = new System.Drawing.Size(516, 301);
            this.tbOut.TabIndex = 0;
            this.tbOut.Text = "Drop a .met file here!";
            this.tbOut.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbOut_DragDrop);
            this.tbOut.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbOut_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 325);
            this.Controls.Add(this.tbOut);
            this.Name = "Form1";
            this.Text = "Metrics to Lua Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOut;
    }
}


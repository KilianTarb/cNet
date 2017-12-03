namespace NetComponents.src.components.traceroute
{
    partial class traceroute
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.outputArea = new System.Windows.Forms.ListBox();
            this.packetTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // outputArea
            // 
            this.outputArea.BackColor = System.Drawing.SystemColors.MenuText;
            this.outputArea.ForeColor = System.Drawing.Color.DarkOrange;
            this.outputArea.FormattingEnabled = true;
            this.outputArea.Location = new System.Drawing.Point(3, 3);
            this.outputArea.Name = "outputArea";
            this.outputArea.Size = new System.Drawing.Size(550, 459);
            this.outputArea.TabIndex = 0;
            // 
            // packetTick
            // 
            this.packetTick.Interval = 1000;
            this.packetTick.Tick += new System.EventHandler(this.packetTick_Tick);
            // 
            // traceroute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputArea);
            this.Name = "traceroute";
            this.Size = new System.Drawing.Size(556, 467);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputArea;
        private System.Windows.Forms.Timer packetTick;
    }
}

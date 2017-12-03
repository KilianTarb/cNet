namespace NetComponents.src.components
{
    partial class Ping
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
            this.pingBox = new System.Windows.Forms.ListBox();
            this.packetTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pingBox
            // 
            this.pingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pingBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pingBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.pingBox.FormattingEnabled = true;
            this.pingBox.ItemHeight = 14;
            this.pingBox.Location = new System.Drawing.Point(3, 3);
            this.pingBox.Name = "pingBox";
            this.pingBox.Size = new System.Drawing.Size(503, 410);
            this.pingBox.TabIndex = 0;
            // 
            // packetTick
            // 
            this.packetTick.Interval = 1000;
            this.packetTick.Tick += new System.EventHandler(this.packetTick_Tick);
            // 
            // Ping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pingBox);
            this.Name = "Ping";
            this.Size = new System.Drawing.Size(509, 410);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox pingBox;
        private System.Windows.Forms.Timer packetTick;
    }
}

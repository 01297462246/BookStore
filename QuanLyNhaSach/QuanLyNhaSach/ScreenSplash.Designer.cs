
namespace QuanLyNhaSach
{
    partial class ScreenSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSplash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressbarCircle = new CircularProgressBar.CircularProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.progressbarCircle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 425);
            this.panel1.TabIndex = 1;
            // 
            // progressbarCircle
            // 
            this.progressbarCircle.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("progressbarCircle.AnimationFunction")));
            this.progressbarCircle.AnimationSpeed = 500;
            this.progressbarCircle.BackColor = System.Drawing.Color.White;
            this.progressbarCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progressbarCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressbarCircle.InnerColor = System.Drawing.Color.White;
            this.progressbarCircle.InnerMargin = 2;
            this.progressbarCircle.InnerWidth = -1;
            this.progressbarCircle.Location = new System.Drawing.Point(245, 174);
            this.progressbarCircle.MarqueeAnimationSpeed = 2000;
            this.progressbarCircle.Name = "progressbarCircle";
            this.progressbarCircle.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.progressbarCircle.OuterMargin = -25;
            this.progressbarCircle.OuterWidth = 26;
            this.progressbarCircle.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressbarCircle.ProgressWidth = 6;
            this.progressbarCircle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressbarCircle.Size = new System.Drawing.Size(119, 111);
            this.progressbarCircle.StartAngle = 270;
            this.progressbarCircle.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressbarCircle.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressbarCircle.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressbarCircle.SubscriptText = "";
            this.progressbarCircle.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressbarCircle.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressbarCircle.SuperscriptText = "";
            this.progressbarCircle.TabIndex = 0;
            this.progressbarCircle.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressbarCircle.Value = 68;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuanLyNhaSach.Properties.Resources.logo_bookstore;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(202, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // ScreenSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "ScreenSplash";
            this.Size = new System.Drawing.Size(629, 425);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CircularProgressBar.CircularProgressBar progressbarCircle;
    }
}

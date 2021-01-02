
namespace QuanLyNhaSach
{
    partial class frmLoad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoad));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressbarCircle = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressbarCircle
            // 
            this.progressbarCircle.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("progressbarCircle.AnimationFunction")));
            this.progressbarCircle.AnimationSpeed = 100;
            this.progressbarCircle.BackColor = System.Drawing.Color.White;
            this.progressbarCircle.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progressbarCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressbarCircle.ForeColor = System.Drawing.Color.Black;
            this.progressbarCircle.InnerColor = System.Drawing.Color.White;
            this.progressbarCircle.InnerMargin = 2;
            this.progressbarCircle.InnerWidth = -1;
            this.progressbarCircle.Location = new System.Drawing.Point(220, 82);
            this.progressbarCircle.MarqueeAnimationSpeed = 1000;
            this.progressbarCircle.Name = "progressbarCircle";
            this.progressbarCircle.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.progressbarCircle.OuterMargin = -25;
            this.progressbarCircle.OuterWidth = 26;
            this.progressbarCircle.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressbarCircle.ProgressWidth = 6;
            this.progressbarCircle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressbarCircle.Size = new System.Drawing.Size(119, 119);
            this.progressbarCircle.StartAngle = 270;
            this.progressbarCircle.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressbarCircle.SubscriptColor = System.Drawing.Color.Black;
            this.progressbarCircle.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressbarCircle.SubscriptText = "";
            this.progressbarCircle.SuperscriptColor = System.Drawing.Color.Black;
            this.progressbarCircle.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressbarCircle.SuperscriptText = "";
            this.progressbarCircle.TabIndex = 2;
            this.progressbarCircle.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressbarCircle.Click += new System.EventHandler(this.progressbarCircle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Store";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loading...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Copyrights © storebook 2021";
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(577, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressbarCircle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoad";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar progressbarCircle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
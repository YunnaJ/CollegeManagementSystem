
namespace CollegeManagementSystem
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingpageprogressbartimer1 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this.loadingpageprogressbartimer1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(87, 520);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(649, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(317, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "COLLEGE MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loadingpageprogressbartimer1
            // 
            this.loadingpageprogressbartimer1.Enabled = true;
            this.loadingpageprogressbartimer1.Interval = 25D;
            this.loadingpageprogressbartimer1.SynchronizingObject = this;
            this.loadingpageprogressbartimer1.Elapsed += new System.Timers.ElapsedEventHandler(this.loadingpageprogressbartimer1_Elapsed);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CollegeManagementSystem.Properties.Resources.mainform1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Management System";
            ((System.ComponentModel.ISupportInitialize) (this.loadingpageprogressbartimer1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer loadingpageprogressbartimer1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ProgressBar progressBar1;

        #endregion
    }
}


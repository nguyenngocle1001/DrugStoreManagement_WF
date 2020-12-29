
namespace GUI
{
    partial class FormSplashScreen
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
            this.panelLoadParent = new System.Windows.Forms.Panel();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLoadParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoadParent
            // 
            this.panelLoadParent.BackColor = System.Drawing.Color.White;
            this.panelLoadParent.Controls.Add(this.panelLoad);
            this.panelLoadParent.Location = new System.Drawing.Point(157, 219);
            this.panelLoadParent.Name = "panelLoadParent";
            this.panelLoadParent.Size = new System.Drawing.Size(350, 10);
            this.panelLoadParent.TabIndex = 1;
            // 
            // panelLoad
            // 
            this.panelLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.panelLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoad.Location = new System.Drawing.Point(0, 0);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(20, 10);
            this.panelLoad.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ NHÀ THUỐC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 9);
            this.label2.TabIndex = 5;
            this.label2.Text = "Version 1.0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GUI.Properties.Resources.drugsplash;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(226, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 165);
            this.panel1.TabIndex = 0;
            // 
            // FormSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLoadParent);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplashScreen";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormSplashScreen_Load);
            this.panelLoadParent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLoadParent;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
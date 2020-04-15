namespace Proiect
{
    partial class HomeManagement
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
            this.Transport = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panelCazare = new System.Windows.Forms.Panel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Cazare = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1.SuspendLayout();
            this.Cazare.SuspendLayout();
            this.SuspendLayout();
            // 
            // Transport
            // 
            this.Transport.HorizontalScrollbarBarColor = true;
            this.Transport.HorizontalScrollbarHighlightOnWheel = false;
            this.Transport.HorizontalScrollbarSize = 10;
            this.Transport.Location = new System.Drawing.Point(4, 38);
            this.Transport.Name = "Transport";
            this.Transport.Size = new System.Drawing.Size(943, 606);
            this.Transport.TabIndex = 1;
            this.Transport.Text = "Transport";
            this.Transport.VerticalScrollbarBarColor = true;
            this.Transport.VerticalScrollbarHighlightOnWheel = false;
            this.Transport.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panelCazare);
            this.metroTabPage1.Controls.Add(this.metroButton4);
            this.metroTabPage1.Controls.Add(this.metroButton3);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.splitter1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(943, 606);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Cazare";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panelCazare
            // 
            this.panelCazare.Location = new System.Drawing.Point(182, 0);
            this.panelCazare.Name = "panelCazare";
            this.panelCazare.Size = new System.Drawing.Size(758, 606);
            this.panelCazare.TabIndex = 7;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(3, 432);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(176, 29);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = " Vizualizare";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(3, 322);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(176, 29);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = " Stergere";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(3, 197);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(176, 29);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Modificare";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(3, 64);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(176, 29);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = " Adaugare";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(179, 606);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // Cazare
            // 
            this.Cazare.Controls.Add(this.metroTabPage1);
            this.Cazare.Controls.Add(this.Transport);
            this.Cazare.Location = new System.Drawing.Point(-1, -1);
            this.Cazare.Name = "Cazare";
            this.Cazare.SelectedIndex = 0;
            this.Cazare.Size = new System.Drawing.Size(951, 648);
            this.Cazare.TabIndex = 0;
            this.Cazare.UseSelectable = true;
            // 
            // HomeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 647);
            this.Controls.Add(this.Cazare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeManagement";
            this.Text = "Management";
            this.metroTabPage1.ResumeLayout(false);
            this.Cazare.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage Transport;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panelCazare;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Splitter splitter1;
        private MetroFramework.Controls.MetroTabControl Cazare;
    }
}
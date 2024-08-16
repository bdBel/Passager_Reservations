namespace Passager_Reservations
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.listePassagers = new System.Windows.Forms.ListBox();
            this.DetailReservation = new System.Windows.Forms.ListBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQuestion3 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnNvReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(840, 354);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // listePassagers
            // 
            this.listePassagers.FormattingEnabled = true;
            this.listePassagers.Location = new System.Drawing.Point(0, 65);
            this.listePassagers.Name = "listePassagers";
            this.listePassagers.Size = new System.Drawing.Size(613, 121);
            this.listePassagers.TabIndex = 2;
            // 
            // DetailReservation
            // 
            this.DetailReservation.FormattingEnabled = true;
            this.DetailReservation.Location = new System.Drawing.Point(619, 65);
            this.DetailReservation.Name = "DetailReservation";
            this.DetailReservation.Size = new System.Drawing.Size(429, 121);
            this.DetailReservation.TabIndex = 4;
            this.DetailReservation.SelectedIndexChanged += new System.EventHandler(this.DetailReservation_SelectedIndexChanged);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(619, 21);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(141, 23);
            this.btnDetail.TabIndex = 5;
            this.btnDetail.Text = "Detail Reservation";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "btnQuestion1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "btnQuestion2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQuestion3
            // 
            this.btnQuestion3.Location = new System.Drawing.Point(42, 338);
            this.btnQuestion3.Name = "btnQuestion3";
            this.btnQuestion3.Size = new System.Drawing.Size(99, 23);
            this.btnQuestion3.TabIndex = 8;
            this.btnQuestion3.Text = "btnQuestion3";
            this.btnQuestion3.UseVisualStyleBackColor = true;
            this.btnQuestion3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(728, 354);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 21);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(254, 23);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter une reservation pour un passager";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnNvReservation
            // 
            this.btnNvReservation.Location = new System.Drawing.Point(324, 21);
            this.btnNvReservation.Name = "btnNvReservation";
            this.btnNvReservation.Size = new System.Drawing.Size(217, 23);
            this.btnNvReservation.TabIndex = 11;
            this.btnNvReservation.Text = "Nouveau Passager? Cliquer içi";
            this.btnNvReservation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 450);
            this.Controls.Add(this.btnNvReservation);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnQuestion3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.DetailReservation);
            this.Controls.Add(this.listePassagers);
            this.Controls.Add(this.btnRetour);
            this.Name = "Form1";
            this.Text = "Recherche";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListBox listePassagers;
        private System.Windows.Forms.ListBox DetailReservation;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQuestion3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnNvReservation;
    }
}


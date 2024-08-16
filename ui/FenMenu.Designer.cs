namespace Passager_Reservations.ui
{
    partial class FenMenu
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
            this.btnEdition = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCharger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEdition
            // 
            this.btnEdition.Location = new System.Drawing.Point(270, 238);
            this.btnEdition.Name = "btnEdition";
            this.btnEdition.Size = new System.Drawing.Size(107, 59);
            this.btnEdition.TabIndex = 0;
            this.btnEdition.Text = "Ajouter Passager";
            this.btnEdition.UseVisualStyleBackColor = true;
            this.btnEdition.Click += new System.EventHandler(this.btnEdition_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(441, 238);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(96, 59);
            this.btnRecherche.TabIndex = 1;
            this.btnRecherche.Text = "QuestionSelect";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(591, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 59);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(120, 238);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(90, 59);
            this.btnCharger.TabIndex = 6;
            this.btnCharger.Text = "Ajouter Reservation";
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // FenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.btnEdition);
            this.Name = "FenMenu";
            this.Text = "FenMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdition;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCharger;
    }
}
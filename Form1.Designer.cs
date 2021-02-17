namespace Sudoku
{
    partial class frmSudoku
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSudoku));
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.btnNettoyer = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnSolveSync = new System.Windows.Forms.Button();
            this.lblTemps = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(460, 103);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(238, 26);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Résoudre en temps réel";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(463, 18);
            this.btnGenerer.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(108, 26);
            this.btnGenerer.TabIndex = 2;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // btnNettoyer
            // 
            this.btnNettoyer.Location = new System.Drawing.Point(463, 205);
            this.btnNettoyer.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnNettoyer.Name = "btnNettoyer";
            this.btnNettoyer.Size = new System.Drawing.Size(238, 29);
            this.btnNettoyer.TabIndex = 3;
            this.btnNettoyer.Text = "Nettoyer";
            this.btnNettoyer.UseVisualStyleBackColor = true;
            this.btnNettoyer.Click += new System.EventHandler(this.btnNettoyer_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(650, 142);
            this.btnStop.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(48, 31);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Arrêter";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(460, 144);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(93, 13);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Nombre d\'essais : ";
            // 
            // btnSolveSync
            // 
            this.btnSolveSync.Location = new System.Drawing.Point(460, 62);
            this.btnSolveSync.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSolveSync.Name = "btnSolveSync";
            this.btnSolveSync.Size = new System.Drawing.Size(238, 23);
            this.btnSolveSync.TabIndex = 6;
            this.btnSolveSync.Text = "Résoudre";
            this.btnSolveSync.UseVisualStyleBackColor = true;
            this.btnSolveSync.Click += new System.EventHandler(this.btnSolveSync_Click);
            // 
            // lblTemps
            // 
            this.lblTemps.AutoSize = true;
            this.lblTemps.Location = new System.Drawing.Point(460, 166);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(48, 13);
            this.lblTemps.TabIndex = 7;
            this.lblTemps.Text = "Temps : ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(578, 23);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombres";
            // 
            // frmSudoku
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(720, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblTemps);
            this.Controls.Add(this.btnSolveSync);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnNettoyer);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.btnSolve);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "frmSudoku";
            this.Text = "Sudoku";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.Button btnNettoyer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnSolveSync;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}


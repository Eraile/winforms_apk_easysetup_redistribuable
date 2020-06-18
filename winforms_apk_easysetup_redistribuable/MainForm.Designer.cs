namespace winforms_apk_easysetup_redistribuable
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_uninstall = new System.Windows.Forms.Button();
            this.button_install = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_uninstall
            // 
            this.button_uninstall.Location = new System.Drawing.Point(12, 12);
            this.button_uninstall.Name = "button_uninstall";
            this.button_uninstall.Size = new System.Drawing.Size(177, 23);
            this.button_uninstall.TabIndex = 0;
            this.button_uninstall.Text = "Désinstaller version actuelle";
            this.button_uninstall.UseVisualStyleBackColor = true;
            this.button_uninstall.Click += new System.EventHandler(this.button_uninstall_Click);
            // 
            // button_install
            // 
            this.button_install.Location = new System.Drawing.Point(12, 41);
            this.button_install.Name = "button_install";
            this.button_install.Size = new System.Drawing.Size(84, 23);
            this.button_install.TabIndex = 1;
            this.button_install.Text = "Installer .apk";
            this.button_install.UseVisualStyleBackColor = true;
            this.button_install.Click += new System.EventHandler(this.button_install_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 76);
            this.Controls.Add(this.button_install);
            this.Controls.Add(this.button_uninstall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MyApp - Easy Setup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_uninstall;
        private System.Windows.Forms.Button button_install;
    }
}


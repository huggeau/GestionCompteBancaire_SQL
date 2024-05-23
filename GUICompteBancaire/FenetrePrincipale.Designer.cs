namespace GUICompteBancaire
{
    partial class FenetrePrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPrincipal = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            creerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            gestionBddToolStripMenuItem = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.ImageScalingSize = new Size(20, 20);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, gestionBddToolStripMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Padding = new Padding(5, 2, 0, 2);
            menuPrincipal.Size = new Size(880, 24);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ouvrirToolStripMenuItem, creerToolStripMenuItem, toolStripSeparator1, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(180, 22);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            ouvrirToolStripMenuItem.Click += ouvrirToolStripMenuItem_Click;
            // 
            // creerToolStripMenuItem
            // 
            creerToolStripMenuItem.Name = "creerToolStripMenuItem";
            creerToolStripMenuItem.Size = new Size(180, 22);
            creerToolStripMenuItem.Text = "Créer";
            creerToolStripMenuItem.Click += creerToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(180, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // gestionBddToolStripMenuItem
            // 
            gestionBddToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionToolStripMenuItem });
            gestionBddToolStripMenuItem.Name = "gestionBddToolStripMenuItem";
            gestionBddToolStripMenuItem.Size = new Size(80, 20);
            gestionBddToolStripMenuItem.Text = "GestionBdd";
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(180, 22);
            gestionToolStripMenuItem.Text = "gestion";
            gestionToolStripMenuItem.Click += gestionToolStripMenuItem_Click;
            // 
            // FenetrePrincipale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 482);
            Controls.Add(menuPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = menuPrincipal;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FenetrePrincipale";
            Text = "Gestion Compte Bancaire";
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem creerToolStripMenuItem;
        private ToolStripMenuItem gestionBddToolStripMenuItem;
        private ToolStripMenuItem gestionToolStripMenuItem;
    }
}

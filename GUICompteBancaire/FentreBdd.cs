using CompteBancaireEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICompteBancaire
{
    public partial class FentreBdd : Form
       
    { 
        ComptesBancaireContext fichierSQLite;

        public FentreBdd()
        {
            InitializeComponent();
        }

        private void FentreBdd_Load(object sender, EventArgs e)
        {
            fichierSQLite = new ComptesBancaireContext();
            fichierSQLite.Database.EnsureCreated();
            fichierSQLite.Comptes.Load();
            compteBindingSource.DataSource = fichierSQLite.Comptes.Local.ToBindingList();
        }

        private void FentreBdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            fichierSQLite.SaveChanges();
        }
    }
}

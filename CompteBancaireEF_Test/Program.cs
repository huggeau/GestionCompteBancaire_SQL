using CompteBancaireEF;
using Microsoft.EntityFrameworkCore;

namespace CompteBancaireEF_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComptesBancaireContext fichierSQLite = new ComptesBancaireContext();
            fichierSQLite.Database.EnsureCreated();
            fichierSQLite.Comptes.Load();
            fichierSQLite.Transactions.Load();
            //
            Compte cpte = new Compte();
            cpte.Proprietaire = "Hugo";
            cpte.Numero = 219682;
            fichierSQLite.Comptes.Add(cpte);
            fichierSQLite.SaveChanges();
            // 
            Console.WriteLine("le id est "+cpte.Id);
            //
            Transaction t = new Transaction();
            t.Date = DateTime.Today.ToString();
            t.Montant = 50.0; ;
            t.Notes = "Solde Initial";
            //
            //t.IdCompte = cpte.Id;
            t.IdCompteNavigation = cpte;
            fichierSQLite.Transactions.Add(t);
            fichierSQLite.SaveChanges();

        }
    }
}

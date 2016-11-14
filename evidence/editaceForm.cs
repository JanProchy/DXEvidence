using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace evidence
{
    public partial class editaceForm : DevExpress.XtraEditors.XtraForm
    {
        EvidenceLidiEntities DbLocal;
        int EditClovekId;

        public editaceForm(EvidenceLidiEntities db, Lide editClovek)
        {
            InitializeComponent();
            DbLocal = db;

            editControl ec = editControl1;
            ec.jmenoEdit.Text = editClovek.jmeno;
            ec.prijmeniEdit.Text = editClovek.prijmeni;
            ec.uliceEdit.Text = editClovek.ulice;
            ec.obecEdit.Text = editClovek.obec;
            ec.telEdit.Text = editClovek.telefon.ToString();
            ec.emailEdit.Text = editClovek.email;

            EditClovekId = DbLocal.Lide.Find(editClovek.id_osoba).id_osoba;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            editControl ec = editControl1;
            var novyClovek = DbLocal.Lide.Find(EditClovekId);
            novyClovek.jmeno = ec.jmenoEdit.Text;
            novyClovek.prijmeni = ec.prijmeniEdit.Text;
            novyClovek.ulice = ec.uliceEdit.Text;
            novyClovek.obec = ec.obecEdit.Text;
            novyClovek.telefon = Int32.Parse(ec.telEdit.Text);
            novyClovek.email = ec.emailEdit.Text;
            DbLocal.SaveChanges();
        }
    }
}
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
        }
    }
}
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
    public partial class pridaniForm : DevExpress.XtraEditors.XtraForm
    {
        EvidenceLidiEntities DbLocal;

        public pridaniForm(EvidenceLidiEntities db)
        {
            InitializeComponent();
            DbLocal = db;
        }

        private void pridatButton_Click(object sender, EventArgs e)
        {
            editControl ec = editControl2;
            

            Lide novyClovek = new Lide();
            novyClovek.jmeno = ec.jmenoEdit.Text;
            novyClovek.prijmeni = ec.prijmeniEdit.Text;
            novyClovek.ulice = ec.uliceEdit.Text;
            novyClovek.obec = ec.obecEdit.Text;
            novyClovek.telefon = Int32.Parse(ec.telEdit.Text);
            novyClovek.email = ec.emailEdit.Text;

            //EvidenceLidiEntities db = new EvidenceLidiEntities();
            DbLocal.Lide.Add(novyClovek);
            try
            {
                DbLocal.SaveChanges();
                MessageBox.Show("Hotovo!");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
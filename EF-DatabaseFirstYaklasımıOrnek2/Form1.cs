
using EF_DatabaseFirstYaklasımıOrnek2.Models;

namespace EF_DatabaseFirstYaklasımıOrnek2

{
    public partial class Form1 : Form
    {
        NorthwindContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new NorthwindContext();
            Goster();
        }

        private void Goster()
        {
            dgvMusteri.DataSource = null;
            dgvMusteri.DataSource = _db.Customers.OrderBy(x => x.CustomerId).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            EF_DatabaseFirstYaklasımıOrnek2.Models.Customer yenieklenecekmusteri = new EF_DatabaseFirstYaklasımıOrnek2.Models.Customer();

            yenieklenecekmusteri.CustomerId = txtId.Text;
            yenieklenecekmusteri.CompanyName = txtSirketAdi.Text;

            _db.Customers.Add(yenieklenecekmusteri);
            _db.SaveChanges();
            Goster();
            MessageBox.Show("Başarıyla eklenmiştir.");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EF_DatabaseFirstYaklasımıOrnek2.Models.Customer silinecekmusteri = _db.Customers.FirstOrDefault(c => c.CustomerId == ((txtId.Text)));

            _db.Customers.Remove(silinecekmusteri); 
            _db.SaveChanges();
            Goster();
            MessageBox.Show("Başarıyla silinmiştir.");


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EF_DatabaseFirstYaklasımıOrnek2.Models.Customer guncellenecekmusteri = _db.Customers.FirstOrDefault(b => b.CustomerId ==((txtId.Text)));

           
            guncellenecekmusteri.CompanyName = txtSirketAdi.Text;

            _db.SaveChanges();
            Goster();
        }
    }
}
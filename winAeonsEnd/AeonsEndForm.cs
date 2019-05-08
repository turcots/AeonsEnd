using AeonsEnd.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winAeonsEnd
{
    public partial class AeonsEndForm : Form
    {
        MarcheModel marche = null;

        static HttpClient client = new HttpClient();

        public AeonsEndForm()
        {
            InitializeComponent();
            InitializeClient();
        }

        private async Task ChargerMarche()
        {
            marche = (await new winAeonsEnd.Affaires.Marche().ObtenirMarcheAsync());

            LoadVersionsAsync(marche.ListeVersions);
            LoadNemesisAsync(marche.ListeNemesis);
            LoadMagesAsync(marche.ListeMages);
            LoadRelicsAsync(marche.ListeRelics);
            LoadGemsAsync(marche.ListeGems);
            LoadSortsAsync(marche.ListeSorts);
        }

        private void LoadSortsAsync(List<SortModel> listeSorts)
        {
            if (listeSorts != null)
            {
                var listSorts = listeSorts.OrderBy(s => s.Name).ToList();

                listSorts.Insert(0, new SortModel { Id = 0, Name = "" });
                cbSort1.DisplayMember = "Name";
                cbSort1.ValueMember = "Id";
                cbSort1.DataSource = listSorts;

                cbSort2.DisplayMember = "Name";
                cbSort2.ValueMember = "Id";
                cbSort2.DataSource = new List<SortModel>(listSorts);

                cbSort3.DisplayMember = "Name";
                cbSort3.ValueMember = "Id";
                cbSort3.DataSource = new List<SortModel>(listSorts);

                cbSort4.DisplayMember = "Name";
                cbSort4.ValueMember = "Id";
                cbSort4.DataSource = new List<SortModel>(listSorts);
            }
        }

        private void LoadGemsAsync(List<GemModel> listeGems)
        {
            if (listeGems != null)
            {
                var listGems = listeGems.OrderBy(s => s.Name).ToList();

                listGems.Insert(0, new GemModel { Id = 0, Name = "" });
                cbGem1.DisplayMember = "Name";
                cbGem1.ValueMember = "Id";
                cbGem1.DataSource = listGems;

                cbGem2.DisplayMember = "Name";
                cbGem2.ValueMember = "Id";
                cbGem2.DataSource = new List<GemModel>(listGems);

                cbGem3.DisplayMember = "Name";
                cbGem3.ValueMember = "Id";
                cbGem3.DataSource = new List<GemModel>(listGems);
            }
        }

        private void LoadRelicsAsync(List<RelicModel> listeRelics)
        {
            if (listeRelics != null)
            {
                var listRelics = listeRelics.OrderBy(s => s.Name).ToList();

                listRelics.Insert(0, new RelicModel { Id = 0, Name = "" });
                cbReplique1.DisplayMember = "Name";
                cbReplique1.ValueMember = "Id";
                cbReplique1.DataSource = listRelics;

                cbReplique2.DisplayMember = "Name";
                cbReplique2.ValueMember = "Id";
                cbReplique2.DataSource = new List<RelicModel>(listRelics);
            }
        }

        private void LoadMagesAsync(List<MageModel> listeMages)
        {
            if (listeMages != null)
            {
                var listMages = listeMages.OrderBy(s => s.Name).ToList();
 
                listMages.Insert(0, new MageModel { Id = 0, Name = "" });
                cbMage1.DisplayMember = "Name";
                cbMage1.ValueMember = "Id";
                cbMage1.DataSource = listMages;

                cbMage2.DisplayMember = "Name";
                cbMage2.ValueMember = "Id";
                cbMage2.DataSource = new List<MageModel>(listMages);

                cbMage3.DisplayMember = "Name";
                cbMage3.ValueMember = "Id";
                cbMage3.DataSource = new List<MageModel>(listMages);

                cbMage4.DisplayMember = "Name";
                cbMage4.ValueMember = "Id";
                cbMage4.DataSource = new List<MageModel>(listMages);
            }
        }

        private void LoadNemesisAsync(List<NemesisModel> listeNemesis)
        {
            if (listeNemesis != null)
            {
                var listNemesis = listeNemesis.OrderBy(s => s.Name).ToList();

                listNemesis.Insert(0, new NemesisModel { Id = 0, Name = "" });
                cbNemesis.DisplayMember = "Name";
                cbNemesis.ValueMember = "Id";
                cbNemesis.DataSource = listNemesis; ;
            }
        }

        private void LoadVersionsAsync(List<VersionModel> listeVersions)
        {
            if (listeVersions != null)
            {
                var listVersions = listeVersions.OrderBy(s => s.Id).ToList();
                var listVersionsPJ = listeVersions.OrderBy(s => s.Id).ToList();

                listVersions.Insert(0, new VersionModel { Id = 0, Nom = "All" });
                cbVersions.DisplayMember = "Nom";
                cbVersions.ValueMember = "Id";
                cbVersions.DataSource = listVersions;
                cbVersions.SelectedIndex = 0;
                cbNbJoueurs.SelectedIndex = 0;

                listVersionsPJ.Insert(0, new VersionModel { Id = 0, Nom = "" });
                cbVersionPJ.DisplayMember = "Nom";
                cbVersionPJ.ValueMember = "Id";
                cbVersionPJ.DataSource = listVersionsPJ; ;
            }
        }

        private void InitializeClient()
        {
            client.BaseAddress = new Uri("http://aeonsend.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ChargerMarche();
        }

        private void cbNemesis_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            NemesisModel selectedModel = (NemesisModel)combo.SelectedItem;

            if (selectedModel.Id == 0)
            {
                lblNiveauNemesis.Text = string.Empty;
                lblVieDepartNemesis.Text = string.Empty;
            } else {
                lblNiveauNemesis.Text = selectedModel.Level.ToString();
                lblVieDepartNemesis.Text = selectedModel.Life.ToString();
            }
        }

        private void cbReplique2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            RelicModel selectedModel = (RelicModel)combo.SelectedItem;

            if (selectedModel.Id == 0)
            {
                lblR2Cost.Text = string.Empty;
            }
            else
            {
                lblR2Cost.Text = selectedModel.Cost.ToString();
            }
        }

        private void cbReplique1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            RelicModel selectedModel = (RelicModel)combo.SelectedItem;

            if (selectedModel.Id == 0)
            {
                lblR1Cost.Text = string.Empty;
            }
            else
            {
                lblR1Cost.Text = selectedModel.Cost.ToString();
            }
        }

        private List<T> RandomList<T>(List<T> liste, int numberRandom)
        {
            List<T> listeRandom = new List<T>();
            var random = new Random();

            if (numberRandom >= liste.Count)
                return liste;
            while (listeRandom.Count < numberRandom)
            {
                int index = random.Next(liste.Count);

                if (!listeRandom.Contains(liste[index]))
                    listeRandom.Add(liste[index]);
            }
            return listeRandom;
        }

        private void LoadGems(int versionId)
        {
            var listeGemsVersion = marche.ListeGems.Where(pr => versionId == pr.VersionId || versionId == 0).ToList();
            listeGemsVersion = RandomList(listeGemsVersion, 3);

            if (listeGemsVersion.Any())
            {
                 var stores = (from x in listeGemsVersion select new { x.VersionName, x.Name, x.Cost }).ToList();
                dgGems.DataSource = stores;
                dgGems.ClearSelection();
            }
            else
            {
                var stores = (from x in new List<GemModel>() select new { x.VersionName, x.Name, x.Cost }).ToList();
                dgGems.DataSource = stores;
            }
        }

        private void LoadRelics(int versionId)
        {
            var listeRelicsVersion = marche.ListeRelics.Where(pr => versionId == pr.VersionId || versionId == 0).ToList();
            listeRelicsVersion = RandomList(listeRelicsVersion, 2);

            if (listeRelicsVersion.Any())
            {
                var stores = (from x in listeRelicsVersion select new { x.VersionName, x.Name, x.Cost }).ToList();
                dgRelics.DataSource = stores;
                dgRelics.ClearSelection();
            }
            else
            {
                var stores = (from x in new List<RelicModel>() select new { x.VersionName, x.Name, x.Cost }).ToList();
                dgRelics.DataSource = stores;
            }
        }

        private void LoadSorts(int versionId)
        {
            var listeSortsVersion = marche.ListeSorts.Where(pr => versionId == pr.VersionId || versionId == 0).ToList();
            listeSortsVersion = RandomList(listeSortsVersion, 4);

            if (listeSortsVersion.Any())
            {
                var stores = (from x in listeSortsVersion select new { x.VersionName, x.Name, x.Cost }).ToList();
                dgSorts.DataSource = stores;
                dgSorts.ClearSelection();
            }
            else
            {
                var stores = (from x in new List<SortModel>() select new { x.VersionName, x.Name, x.Cost }).ToList();
                dgSorts.DataSource = stores;
            }
        }

        private void LoadMages(int nbJoueur, int versionId)
        {
            var listeMagesVersion = marche.ListeMages.Where(pr => versionId == pr.VersionId || versionId == 0).ToList();
            listeMagesVersion = RandomList(listeMagesVersion, nbJoueur);

            if (listeMagesVersion.Any())
            {
                lstMages.DisplayMember = "Name";
                lstMages.ValueMember = "Id";
                lstMages.DataSource = listeMagesVersion;
                lstMages.SelectedIndex = -1;
            }
            else
                lstMages.DataSource = null;
        }

        private void LoadNemesis(int versionId)
        {
            var listeNemesisVersion = marche.ListeNemesis.Where(pr => versionId == pr.VersionId || versionId == 0).ToList();
            listeNemesisVersion = RandomList(listeNemesisVersion, 1);

            if (listeNemesisVersion.Any())
                txtNemesis.Text = listeNemesisVersion.FirstOrDefault().Name;
            else
                txtNemesis.Text = "";
        }

        private void LoadMarket(int nbJoueur, int versionId)
        {
            LoadGems(versionId);
            LoadRelics(versionId);
            LoadSorts(versionId);
            LoadMages(nbJoueur, versionId);
            LoadNemesis(versionId);
        }

        private void BtnMarket_Click(object sender, EventArgs e)
        {
            int nbVersion = 0;
            string valeur = Convert.ToString(cbVersions.SelectedValue);

            int.TryParse(valeur, out nbVersion);

            LoadMarket(int.Parse(cbNbJoueurs.Text), nbVersion);
        }

        private void bntChargerPartie_Click(object sender, EventArgs e)
        {

        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {

        }

        private void btnImporterMarket_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerPartie_Click(object sender, EventArgs e)
        {

        }

        private void btnSauverPartie_Click(object sender, EventArgs e)
        {

        }

    }
}

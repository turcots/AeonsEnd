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

                //listVersions.Insert(0, new VersionModel { Id = 0, Nom = "All" });
                //cbVersions.DisplayMember = "Nom";
                //cbVersions.ValueMember = "Id";
                //cbVersions.DataSource = listVersions;
                //cbVersions.SelectedIndex = 0;
                //cbNbJoueurs.SelectedIndex = 0;

                //listVersions.Insert(0, new VersionModel { Id = 0, Nom = "All" });
                //cbNbJoueursPartie.DisplayMember = "Nom";
                //cbNbJoueursPartie.ValueMember = "Id";
                //cbNbJoueursPartie.DataSource = listVersions;
                //cbNbJoueursPartie.SelectedIndex = 0;
                //cbNbJoueursPartie.SelectedIndex = 0;

                listVersions.Insert(0, new VersionModel { Id = 0, Nom = "All" });
                cbVersionPJ.DisplayMember = "Nom";
                cbVersionPJ.ValueMember = "Id";
                cbVersionPJ.DataSource = listVersions;
                cbVersionPJ.SelectedIndex = 0;

            }

            cbNbJoueursPartie.SelectedIndex = 0;
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
            }
            else
            {
                lblNiveauNemesis.Text = selectedModel.Level.ToString();
                lblVieDepartNemesis.Text = selectedModel.Life.ToString();
            }
        }

        private void cbReplique2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            RelicModel selectedModel = (RelicModel)combo.SelectedItem;

            //if (selectedModel.Id == 0)
            //{
            //    lblR2Cost.Text = string.Empty;
            //}
            //else
            //{
            //    lblR2Cost.Text = selectedModel.Cost.ToString();
            //}
        }

        private void cbReplique1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            RelicModel selectedModel = (RelicModel)combo.SelectedItem;

            //if (selectedModel.Id == 0 || )
            //{
            //    lblR1Cost.Text = string.Empty;
            //}
            //else
            //{
            //    lblR1Cost.Text = selectedModel.Cost.ToString();
            //}
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
                if (listeGemsVersion.Count == 1)
                {
                    cbGem1.SelectedIndex = cbGem1.FindStringExact(listeGemsVersion[0].Name);
                    cbGem2.SelectedIndex = -1;
                    cbGem3.SelectedIndex = -1;
                }
                else if (listeGemsVersion.Count == 2)
                {
                    cbGem1.SelectedIndex = cbGem1.FindStringExact(listeGemsVersion[0].Name);
                    cbGem2.SelectedIndex = cbGem2.FindStringExact(listeGemsVersion[1].Name);
                    cbGem3.SelectedIndex = -1;
                }
                else if (listeGemsVersion.Count == 3)
                {
                    cbGem1.SelectedIndex = cbGem1.FindStringExact(listeGemsVersion[0].Name);
                    cbGem2.SelectedIndex = cbGem2.FindStringExact(listeGemsVersion[1].Name);
                    cbGem3.SelectedIndex = cbGem3.FindStringExact(listeGemsVersion[2].Name);
                }
                // var stores = (from x in listeGemsVersion select new { x.VersionName, x.Name, x.Cost }).ToList();
                //dgGems.DataSource = stores;
                //dgGems.ClearSelection();
            }
            else
            {
                cbGem1.SelectedIndex = -1;
                cbGem2.SelectedIndex = -1;
                cbGem3.SelectedIndex = -1;
                //var stores = (from x in new List<GemModel>() select new { x.VersionName, x.Name, x.Cost }).ToList();
                //dgGems.DataSource = stores;
            }
        }

        private void LoadRelics(int versionId)
        {
            var listeRelicsVersion = marche.ListeRelics.Where(pr => versionId == pr.VersionId || versionId == 0).ToList();
            listeRelicsVersion = RandomList(listeRelicsVersion, 2);

            if (listeRelicsVersion.Any())
            {
                if (listeRelicsVersion.Count == 1)
                {
                    cbReplique1.SelectedIndex = cbReplique1.FindStringExact(listeRelicsVersion[0].Name);
                    cbReplique2.SelectedIndex = -1;
                }
                else if (listeRelicsVersion.Count == 2)
                {
                    cbReplique1.SelectedIndex = cbReplique1.FindStringExact(listeRelicsVersion[0].Name);
                    cbReplique2.SelectedIndex = cbReplique2.FindStringExact(listeRelicsVersion[1].Name);
                }

                //var stores = (from x in listeRelicsVersion select new { x.VersionName, x.Name, x.Cost }).ToList();
                //dgRelics.DataSource = stores;
                //dgRelics.ClearSelection();
            }
            else
            {
                cbReplique1.SelectedIndex = -1;
                cbReplique2.SelectedIndex = -1;
                //var stores = (from x in new List<RelicModel>() select new { x.VersionName, x.Name, x.Cost }).ToList();
                //dgRelics.DataSource = stores;
            }
        }

        private void LoadSorts(int versionId)
        {
            var listeSortsVersion = marche.ListeSorts.Where(pr => versionId == pr.VersionId || versionId == 0).ToList();
            listeSortsVersion = RandomList(listeSortsVersion, 4);

            if (listeSortsVersion.Any())
            {
                if (listeSortsVersion.Count == 1)
                {
                    cbSort1.SelectedIndex = cbSort1.FindStringExact(listeSortsVersion[0].Name);
                    cbSort2.SelectedIndex = -1;
                    cbSort3.SelectedIndex = -1;
                    cbSort4.SelectedIndex = -1;
                }
                else if (listeSortsVersion.Count == 2)
                {
                    cbSort1.SelectedIndex = cbSort1.FindStringExact(listeSortsVersion[0].Name);
                    cbSort2.SelectedIndex = cbSort2.FindStringExact(listeSortsVersion[1].Name);
                    cbSort3.SelectedIndex = -1;
                    cbSort4.SelectedIndex = -1;
                }
                else if (listeSortsVersion.Count == 3)
                {
                    cbSort1.SelectedIndex = cbSort1.FindStringExact(listeSortsVersion[0].Name);
                    cbSort2.SelectedIndex = cbSort3.FindStringExact(listeSortsVersion[1].Name);
                    cbSort3.SelectedIndex = cbSort3.FindStringExact(listeSortsVersion[2].Name);
                    cbSort4.SelectedIndex = -1;
                }
                else if (listeSortsVersion.Count == 4)
                {
                    cbSort1.SelectedIndex = cbSort1.FindStringExact(listeSortsVersion[0].Name);
                    cbSort2.SelectedIndex = cbSort3.FindStringExact(listeSortsVersion[1].Name);
                    cbSort3.SelectedIndex = cbSort3.FindStringExact(listeSortsVersion[2].Name);
                    cbSort4.SelectedIndex = cbSort4.FindStringExact(listeSortsVersion[3].Name);
                }
                //var stores = (from x in listeSortsVersion select new { x.VersionName, x.Name, x.Cost }).ToList();
                //dgSorts.DataSource = stores;
                //dgSorts.ClearSelection();
            }
            else
            {
                cbSort1.SelectedIndex = -1;
                cbSort2.SelectedIndex = -1;
                cbSort3.SelectedIndex = -1;
                cbSort4.SelectedIndex = -1;
                //var stores = (from x in new List<SortModel>() select new { x.VersionName, x.Name, x.Cost }).ToList();
                //dgSorts.DataSource = stores;
            }
        }

        private void LoadMages(int nbJoueur, int versionId)
        {
            var listeMagesVersion = marche.ListeMages.Where(pr => versionId == pr.VersionId || versionId == 0).ToList();
            listeMagesVersion = RandomList(listeMagesVersion, nbJoueur);

            if (listeMagesVersion.Any())
            {
                //lstMages.DisplayMember = "Name";
                //lstMages.ValueMember = "Id";
                //lstMages.DataSource = listeMagesVersion;
                //lstMages.SelectedIndex = -1;
                if (listeMagesVersion.Count == 1)
                {
                    cbMage1.SelectedIndex = cbMage1.FindStringExact(listeMagesVersion[0].Name);
                    cbMage2.SelectedIndex = -1;
                    cbMage3.SelectedIndex = -1;
                    cbMage4.SelectedIndex = -1;
                }
                else if (listeMagesVersion.Count == 2)
                {
                    cbMage1.SelectedIndex = cbMage1.FindStringExact(listeMagesVersion[0].Name);
                    cbMage2.SelectedIndex = cbMage2.FindStringExact(listeMagesVersion[1].Name);
                    cbMage3.SelectedIndex = -1;
                    cbMage4.SelectedIndex = -1;
                }
                else if (listeMagesVersion.Count == 3)
                {
                    cbMage1.SelectedIndex = cbMage1.FindStringExact(listeMagesVersion[0].Name);
                    cbMage2.SelectedIndex = cbMage2.FindStringExact(listeMagesVersion[1].Name);
                    cbMage3.SelectedIndex = cbMage3.FindStringExact(listeMagesVersion[2].Name);
                    cbMage4.SelectedIndex = -1;
                }
                else if (listeMagesVersion.Count == 4)
                {
                    cbMage1.SelectedIndex = cbMage1.FindStringExact(listeMagesVersion[0].Name);
                    cbMage2.SelectedIndex = cbMage2.FindStringExact(listeMagesVersion[1].Name);
                    cbMage3.SelectedIndex = cbMage3.FindStringExact(listeMagesVersion[2].Name);
                    cbMage4.SelectedIndex = cbMage4.FindStringExact(listeMagesVersion[3].Name);
                }
                //cbMage1
            }
            else
            {
                cbMage1.SelectedIndex = -1;
                cbMage2.SelectedIndex = -1;
                cbMage3.SelectedIndex = -1;
                cbMage4.SelectedIndex = -1;
                //lstMages.DataSource = null;
            }
        }

        private void LoadNemesis(int versionId)
        {
            var listeNemesisVersion = marche.ListeNemesis.Where(pr => versionId == pr.VersionId || versionId == 0).ToList();
            listeNemesisVersion = RandomList(listeNemesisVersion, 1);

            if (listeNemesisVersion.Any())
                cbNemesis.SelectedIndex = cbNemesis.FindStringExact(listeNemesisVersion[0].Name);
            else
                cbNemesis.SelectedIndex = -1;
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
            //int nbVersion = 0;
            //string valeur = Convert.ToString(cbVersions.SelectedValue);

            //int.TryParse(valeur, out nbVersion);

            //LoadMarket(int.Parse(cbNbJoueurs.Text), nbVersion);
        }

        private void bntChargerPartie_Click(object sender, EventArgs e)
        {

        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
            txtNemesisVie.Text = "";
            txtNbCycle.Text = "";
            txtGraveHoldVie.Text = "";
            txtVieMage1.Text = "";
            txtVieMage2.Text = "";
            txtVieMage3.Text = "";
            txtVieMage4.Text = "";
            txtCommentaire.Text = "";
            cbResultatPartie.SelectedIndex = -1;
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

        private void BtnImporterMarket_Click_1(object sender, EventArgs e)
        {
            //if (txtNemesis.Text != "")
            //    cbNemesis.SelectedIndex = cbNemesis.FindStringExact(txtNemesis.Text);

            //for (int i = 0; i < lstMages.Items.Count; i++)
            //{
            //    if (i == 0)
            //        cbMage1.SelectedIndex = cbMage1.FindStringExact(((MageModel)lstMages.Items[i]).Name);
            //    else if (i == 1)
            //        cbMage2.SelectedIndex = cbMage2.FindStringExact(((MageModel)lstMages.Items[i]).Name);
            //    else if (i == 2)
            //        cbMage3.SelectedIndex = cbMage3.FindStringExact(((MageModel)lstMages.Items[i]).Name);
            //    else if (i == 3)
            //        cbMage4.SelectedIndex = cbMage4.FindStringExact(((MageModel)lstMages.Items[i]).Name);
            //}

            //for (int i = 0; i < dgRelics.RowCount; i++)
            //{      
            //    if (i == 0)
            //        cbReplique1.SelectedIndex = cbReplique1.FindStringExact(dgRelics.Rows[i].Cells[1].Value.ToString());
            //    else if (i == 1)
            //        cbReplique2.SelectedIndex = cbReplique2.FindStringExact(dgRelics.Rows[i].Cells[1].Value.ToString());
            //}

            //for (int i = 0; i < dgGems.RowCount; i++)
            //{
            //    if (i == 0)
            //        cbGem1.SelectedIndex = cbGem1.FindStringExact(dgGems.Rows[i].Cells[1].Value.ToString());
            //    else if (i == 1)
            //        cbGem2.SelectedIndex = cbGem2.FindStringExact(dgGems.Rows[i].Cells[1].Value.ToString());
            //    else if (i == 2)
            //        cbGem3.SelectedIndex = cbGem3.FindStringExact(dgGems.Rows[i].Cells[1].Value.ToString());
            //}

            //for (int i = 0; i < dgSorts.RowCount; i++)
            //{
            //    if (i == 0)
            //        cbSort1.SelectedIndex = cbSort1.FindStringExact(dgSorts.Rows[i].Cells[1].Value.ToString());
            //    else if (i == 1)
            //        cbSort2.SelectedIndex = cbSort2.FindStringExact(dgSorts.Rows[i].Cells[1].Value.ToString());
            //    else if (i == 2)
            //        cbSort3.SelectedIndex = cbSort3.FindStringExact(dgSorts.Rows[i].Cells[1].Value.ToString());
            //    else if (i == 3)
            //        cbSort4.SelectedIndex = cbSort4.FindStringExact(dgSorts.Rows[i].Cells[1].Value.ToString());
            //}

        }

        private void BntHasard_Click(object sender, EventArgs e)
        {
            int nbVersion = 0;
            string valeur = Convert.ToString(cbVersionPJ.SelectedValue);

            int.TryParse(valeur, out nbVersion);

            if (cbNbJoueursPartie.Text != "")
                LoadMarket(int.Parse(cbNbJoueursPartie.Text), nbVersion);
        }


        private void CbMage1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                PopUpForm();
            }


        }

        private void CbMage1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbMage1_KeyDown(object sender, KeyEventArgs e)
        {
            PopUpForm();
            //if (e.KeyCode == Keys.Delete && CbMage1.DroppedDown)
            //{
            //    //Remove the listitem from the combobox list
            //    CbMage1.Items.RemoveAt(CbMage1.SelectedIndex);

            //    //Make sure no other processing happens, ex: deleting text from combobox
            //    e.Handled = true;
            //}
            //else if (e.KeyCode == Keys.Down && !CbMage1.DroppedDown)
            //{
            //    //If the down arrow is pressed show the dropdown list from the combobox
            //    CbMage1.DroppedDown = true;
            //}
        }

        private void PopUpForm()
        {
            PopupForm popup = new PopupForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PopUpForm();
        }
    }
}

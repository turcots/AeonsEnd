using AeonsEnd.Affaires;
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
            this.Enabled = false;
            marche = (await new winAeonsEnd.Affaires.Marche().ObtenirMarcheAsync());

            LoadVersionsAsync(marche.ListeVersions);
            LoadNemesisAsync(marche.ListeNemesis);
            LoadMagesAsync(marche.ListeMages);
            LoadRelicsAsync(marche.ListeRelics);
            LoadGemsAsync(marche.ListeGems);
            LoadSortsAsync(marche.ListeSorts);

            LoadParties();
            this.Enabled = true;
        }

        private void LoadParties()
        {
            cbPartie.DisplayMember = "partieName";
            cbPartie.ValueMember = "partieId";
            cbPartie.DataSource = ObtenirParties();

            cbPartie.SelectedIndex = cbPartie.FindStringExact(txtNomPartie.Text);
        }

        private List<PartieModel> ObtenirParties()
        {
            var parties = new Partie().ObtenirPartieTous();

            return parties;
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
            }
            else
            {
                cbGem1.SelectedIndex = -1;
                cbGem2.SelectedIndex = -1;
                cbGem3.SelectedIndex = -1;
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
            }
            else
            {
                cbReplique1.SelectedIndex = -1;
                cbReplique2.SelectedIndex = -1;
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
            }
            else
            {
                cbSort1.SelectedIndex = -1;
                cbSort2.SelectedIndex = -1;
                cbSort3.SelectedIndex = -1;
                cbSort4.SelectedIndex = -1;
            }
        }

        private void LoadMages(int nbJoueur, int versionId)
        {
            var listeMagesVersion = marche.ListeMages.Where(pr => versionId == pr.VersionId || versionId == 0).ToList();
            listeMagesVersion = RandomList(listeMagesVersion, nbJoueur);

            if (listeMagesVersion.Any())
            {
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
            }
            else
            {
                cbMage1.SelectedIndex = -1;
                cbMage2.SelectedIndex = -1;
                cbMage3.SelectedIndex = -1;
                cbMage4.SelectedIndex = -1;
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

        private void bntChargerPartie_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPartie.SelectedValue == null)
                    throw new Exception("Vous devez sélectionner une partie sauvegardée pour pouvoir la chargée");

                int partieId = int.Parse(cbPartie.SelectedValue.ToString());

                PartieModel partie = ObtenirParties().Where(x => x.partieId == partieId).FirstOrDefault();

                ChargerPartie(partie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
            InitialiserPartie();
        }
        private void InitialiserPartie()
        {
            txtNomPartie.Text = "";
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
            string messageErreur = "Partie supprimée";
            try
            {
                if (cbPartie.SelectedValue == null)
                    throw new Exception("Vous devez sélectionner une partie sauvegardée pour pouvoir la supprimer");

                new Partie().Delete(int.Parse(cbPartie.SelectedValue.ToString()));
                LoadParties();
                InitialiserPartie();
            }
            catch (Exception ex)
            {
                messageErreur = ex.Message;
            }
            MessageBox.Show(messageErreur, "Message");
        }

        private void btnSauverPartie_Click(object sender, EventArgs e)
        {
            string messageErreur = "Partie sauvegardée";
            try
            {
                var partie = RecupererPartie();
                new Partie().Insert(partie);
                LoadParties();
            }
            catch (Exception ex)
            {
                messageErreur = ex.Message;
            }

            MessageBox.Show(messageErreur, "Message");
        }

        private void ChargerPartie(PartieModel partie)
        {
            txtNomPartie.Text = partie.partieName;
            cbVersionPJ.SelectedValue = partie.versionId;
            cbNemesis.SelectedValue = partie.nemesisId;
            txtNemesisVie.Text = partie.nemesisVie.ToString();
            cbMage1.SelectedValue = partie.mageId1;
            txtVieMage1.Text = partie.mageVie1.ToString();
            cbMage2.SelectedValue = partie.mageId2;
            txtVieMage2.Text = partie.mageVie2.ToString();
            cbMage3.SelectedValue = partie.mageId3;
            txtVieMage3.Text = partie.mageVie3.ToString();
            cbMage4.SelectedValue = partie.mageId4;
            txtVieMage4.Text = partie.mageVie4.ToString();
            cbReplique1.SelectedValue = partie.repliqueId1;
            cbReplique2.SelectedValue = partie.repliqueId2;
            cbGem1.SelectedValue = partie.gemId1;
            cbGem2.SelectedValue = partie.gemId2;
            cbGem3.SelectedValue = partie.gemId3;
            cbSort1.SelectedValue = partie.sortId1;
            cbSort2.SelectedValue = partie.sortId2;
            cbSort3.SelectedValue = partie.sortId3;
            cbSort4.SelectedValue = partie.sortId4;
            cbResultatPartie.SelectedItem = (partie.partieGagne) ? "Gagné" : "Perdu";
            txtNbCycle.Text = partie.nbCycle.ToString();
            txtGraveHoldVie.Text = partie.graveholdVie.ToString();
            txtCommentaire.Text = partie.commentaire;

            var nbJoueurs = 0;
            if (partie.mageId1 > 0)
                nbJoueurs++;
            if (partie.mageId2 > 0)
                nbJoueurs++;
            if (partie.mageId3 > 0)
                nbJoueurs++;
            if (partie.mageId4 > 0)
                nbJoueurs++;

            cbNbJoueursPartie.SelectedItem = nbJoueurs.ToString();

        }

        private void ValidationChampsPartie()
        {
            var result = 0;

            if (txtNomPartie.Text == "")
                throw new Exception("Nom de partie invalide");
            if (!int.TryParse(cbVersionPJ.SelectedValue.ToString(), out result))
                throw new Exception("Nom de la version invalide");
            if (!int.TryParse(cbNemesis.SelectedValue.ToString(), out result) || cbNemesis.SelectedValue.ToString() == "0")
                throw new Exception("Nom du nemesis invalide");
            if (!int.TryParse(txtNemesisVie.Text, out result))
                throw new Exception("Vie du nemesis invalide");
            if (int.Parse(cbNbJoueursPartie.Text) == 1 && cbMage1.SelectedValue.ToString() == "0")
                throw new Exception("Mage 1 invalide");
            if (int.Parse(cbNbJoueursPartie.Text) == 2 && (cbMage1.SelectedValue.ToString() == "0" || cbMage2.SelectedValue.ToString() == "0"))
                throw new Exception("Mage 1 ou 2 invalide");
            if (int.Parse(cbNbJoueursPartie.Text) == 3 && (cbMage1.SelectedValue.ToString() == "0" || cbMage2.SelectedValue.ToString() == "0" || cbMage3.SelectedValue.ToString() == "0"))
                throw new Exception("Mage 1 ou 2 ou 3 invalide");
            if (int.Parse(cbNbJoueursPartie.Text) == 4 && (cbMage1.SelectedValue.ToString() == "0" || cbMage2.SelectedValue.ToString() == "0" || cbMage3.SelectedValue.ToString() == "0" || cbMage4.SelectedValue.ToString() == "0"))
                throw new Exception("Mage 1 ou 2 ou 3 ou 4 invalide");
            if (!int.TryParse(cbReplique1.SelectedValue.ToString(), out result) || cbReplique1.SelectedValue.ToString() == "0")
                throw new Exception("Replique 1 invalide");
            if (!int.TryParse(cbReplique2.SelectedValue.ToString(), out result) || cbReplique2.SelectedValue.ToString() == "0")
                throw new Exception("Replique 2 invalide");
            if (!int.TryParse(cbGem1.SelectedValue.ToString(), out result) || cbGem1.SelectedValue.ToString() == "0")
                throw new Exception("Gem 1 invalide");
            if (!int.TryParse(cbGem2.SelectedValue.ToString(), out result) || cbGem2.SelectedValue.ToString() == "0")
                throw new Exception("Gem 2 invalide");
            if (!int.TryParse(cbGem3.SelectedValue.ToString(), out result) || cbGem3.SelectedValue.ToString() == "0")
                throw new Exception("Gem 3 invalide");
            if (!int.TryParse(cbSort1.SelectedValue.ToString(), out result) || cbSort1.SelectedValue.ToString() == "0")
                throw new Exception("Sort 1 invalide");
            if (!int.TryParse(cbSort2.SelectedValue.ToString(), out result) || cbSort2.SelectedValue.ToString() == "0")
                throw new Exception("Sort 2 invalide");
            if (!int.TryParse(cbSort3.SelectedValue.ToString(), out result) || cbSort3.SelectedValue.ToString() == "0")
                throw new Exception("Sort 3 invalide");
            if (!int.TryParse(cbSort4.SelectedValue.ToString(), out result) || cbSort4.SelectedValue.ToString() == "0")
                throw new Exception("Sort 4 invalide");
            if (!int.TryParse(txtVieMage1.Text, out result))
                throw new Exception("Vie du mage 1 invalide");
            if (!int.TryParse(txtVieMage2.Text, out result))
                throw new Exception("Vie du mage 2 invalide");
            if (!int.TryParse(txtVieMage3.Text, out result))
                throw new Exception("Vie du mage 3 invalide");
            if (!int.TryParse(txtVieMage4.Text, out result))
                throw new Exception("Vie du mage 4 invalide");
            if (!int.TryParse(txtNbCycle.Text, out result))
                throw new Exception("Nombre de cycle invalide");
            if (!int.TryParse(txtGraveHoldVie.Text, out result))
                throw new Exception("Vie de gravehold invalide");
            if (cbResultatPartie.SelectedItem == null)
                throw new Exception("Résultat de la partie invalide");
            
        }
        private PartieModel RecupererPartie()
        {
            ValidationChampsPartie();

            var partieModel = new PartieModel();

            partieModel.partieName = txtNomPartie.Text;
            partieModel.versionId = int.Parse(cbVersionPJ.SelectedValue.ToString());
            partieModel.nemesisId = int.Parse(cbNemesis.SelectedValue.ToString());
            partieModel.nemesisVie = int.Parse(txtNemesisVie.Text);
            partieModel.mageId1 = cbMage1.SelectedValue == null ? 0 : int.Parse(cbMage1.SelectedValue.ToString());
            partieModel.mageVie1 = int.Parse(txtVieMage1.Text);
            partieModel.mageId2 = cbMage2.SelectedValue == null ? 0 : int.Parse(cbMage2.SelectedValue.ToString());
            partieModel.mageVie2 = int.Parse(txtVieMage2.Text);
            partieModel.mageId3 = cbMage3.SelectedValue == null ? 0 : int.Parse(cbMage3.SelectedValue.ToString());
            partieModel.mageVie3 = int.Parse(txtVieMage3.Text);
            partieModel.mageId4 = cbMage4.SelectedValue == null ? 0 : int.Parse(cbMage4.SelectedValue.ToString());
            partieModel.mageVie4 = int.Parse(txtVieMage4.Text);
            partieModel.repliqueId1 = int.Parse(cbReplique1.SelectedValue.ToString());
            partieModel.repliqueId2 = int.Parse(cbReplique2.SelectedValue.ToString());
            partieModel.gemId1 = int.Parse(cbGem1.SelectedValue.ToString());
            partieModel.gemId2 = int.Parse(cbGem2.SelectedValue.ToString());
            partieModel.gemId3 = int.Parse(cbGem3.SelectedValue.ToString());
            partieModel.sortId1 = int.Parse(cbSort1.SelectedValue.ToString());
            partieModel.sortId2 = int.Parse(cbSort2.SelectedValue.ToString());
            partieModel.sortId3 = int.Parse(cbSort3.SelectedValue.ToString());
            partieModel.sortId4 = int.Parse(cbSort4.SelectedValue.ToString());
            partieModel.partieGagne = (cbResultatPartie.SelectedItem.ToString() == cbResultatPartie.Items[0].ToString());
            partieModel.nbCycle = int.Parse(txtNbCycle.Text);
            partieModel.graveholdVie = int.Parse(txtGraveHoldVie.Text);
            partieModel.commentaire = txtCommentaire.Text;
            
            return partieModel;
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

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string messageErreur = "Partie mise à jour";
            try
            {
                if (cbPartie.SelectedValue == null || !int.TryParse(cbPartie.SelectedValue.ToString(), out int result) || cbPartie.SelectedValue.ToString() == "0")
                    throw new Exception("Vous devez sélectionner une partie sauvegardée");

                var partie = RecupererPartie();
 
                partie.partieId = int.Parse(cbPartie.SelectedValue.ToString());

                new Partie().Update(partie);
                LoadParties();
            }
            catch (Exception ex)
            {
                messageErreur = ex.Message;
            }

            MessageBox.Show(messageErreur, "Message");
        }

        private void CbNbJoueursPartie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

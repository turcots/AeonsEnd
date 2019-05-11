﻿using System;
using System.Windows.Forms;

namespace winAeonsEnd
{
    partial class AeonsEndForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPartiesJouees = new System.Windows.Forms.TabPage();
            this.grpResultatPartie = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomPartie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbResultatPartie = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cbPartie = new System.Windows.Forms.ComboBox();
            this.btnSupprimerPartie = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.txtNbCycle = new System.Windows.Forms.TextBox();
            this.btnNouvellePartie = new System.Windows.Forms.Button();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bntChargerPartie = new System.Windows.Forms.Button();
            this.txtGraveHoldVie = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNemesisVie = new System.Windows.Forms.TextBox();
            this.btnSauverPartie = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVieMage1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtVieMage2 = new System.Windows.Forms.TextBox();
            this.txtVieMage3 = new System.Windows.Forms.TextBox();
            this.txtVieMage4 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.cbNbJoueursPartie = new System.Windows.Forms.ComboBox();
            this.bntHasard = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblVieDepartNemesis = new System.Windows.Forms.Label();
            this.lblNiveauNemesis = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbNemesis = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbReplique1 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbSort4 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbSort3 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbSort2 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cbSort1 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cbGem3 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbGem2 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cbGem1 = new System.Windows.Forms.ComboBox();
            this.cbReplique2 = new System.Windows.Forms.ComboBox();
            this.Mages = new System.Windows.Forms.GroupBox();
            this.cbMage1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbMage2 = new System.Windows.Forms.ComboBox();
            this.cbMage3 = new System.Windows.Forms.ComboBox();
            this.cbMage4 = new System.Windows.Forms.ComboBox();
            this.cbVersionPJ = new System.Windows.Forms.ComboBox();
            this.lblNumeroPartie = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPartiesJouees.SuspendLayout();
            this.grpResultatPartie.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Mages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPartiesJouees);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1094, 453);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPartiesJouees
            // 
            this.tabPartiesJouees.BackColor = System.Drawing.Color.White;
            this.tabPartiesJouees.Controls.Add(this.grpResultatPartie);
            this.tabPartiesJouees.Controls.Add(this.label45);
            this.tabPartiesJouees.Controls.Add(this.cbNbJoueursPartie);
            this.tabPartiesJouees.Controls.Add(this.bntHasard);
            this.tabPartiesJouees.Controls.Add(this.groupBox3);
            this.tabPartiesJouees.Controls.Add(this.groupBox2);
            this.tabPartiesJouees.Controls.Add(this.Mages);
            this.tabPartiesJouees.Controls.Add(this.cbVersionPJ);
            this.tabPartiesJouees.Controls.Add(this.lblNumeroPartie);
            this.tabPartiesJouees.Controls.Add(this.label10);
            this.tabPartiesJouees.Location = new System.Drawing.Point(4, 25);
            this.tabPartiesJouees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPartiesJouees.Name = "tabPartiesJouees";
            this.tabPartiesJouees.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPartiesJouees.Size = new System.Drawing.Size(1086, 424);
            this.tabPartiesJouees.TabIndex = 1;
            this.tabPartiesJouees.Text = "Parties jouées";
            // 
            // grpResultatPartie
            // 
            this.grpResultatPartie.Controls.Add(this.button1);
            this.grpResultatPartie.Controls.Add(this.label2);
            this.grpResultatPartie.Controls.Add(this.txtNomPartie);
            this.grpResultatPartie.Controls.Add(this.label1);
            this.grpResultatPartie.Controls.Add(this.label12);
            this.grpResultatPartie.Controls.Add(this.cbResultatPartie);
            this.grpResultatPartie.Controls.Add(this.label31);
            this.grpResultatPartie.Controls.Add(this.cbPartie);
            this.grpResultatPartie.Controls.Add(this.btnSupprimerPartie);
            this.grpResultatPartie.Controls.Add(this.label33);
            this.grpResultatPartie.Controls.Add(this.txtNbCycle);
            this.grpResultatPartie.Controls.Add(this.btnNouvellePartie);
            this.grpResultatPartie.Controls.Add(this.txtCommentaire);
            this.grpResultatPartie.Controls.Add(this.label9);
            this.grpResultatPartie.Controls.Add(this.label17);
            this.grpResultatPartie.Controls.Add(this.bntChargerPartie);
            this.grpResultatPartie.Controls.Add(this.txtGraveHoldVie);
            this.grpResultatPartie.Controls.Add(this.label34);
            this.grpResultatPartie.Controls.Add(this.label18);
            this.grpResultatPartie.Controls.Add(this.txtNemesisVie);
            this.grpResultatPartie.Controls.Add(this.btnSauverPartie);
            this.grpResultatPartie.Controls.Add(this.label19);
            this.grpResultatPartie.Controls.Add(this.txtVieMage1);
            this.grpResultatPartie.Controls.Add(this.label20);
            this.grpResultatPartie.Controls.Add(this.txtVieMage2);
            this.grpResultatPartie.Controls.Add(this.txtVieMage3);
            this.grpResultatPartie.Controls.Add(this.txtVieMage4);
            this.grpResultatPartie.Location = new System.Drawing.Point(648, 59);
            this.grpResultatPartie.Name = "grpResultatPartie";
            this.grpResultatPartie.Size = new System.Drawing.Size(432, 345);
            this.grpResultatPartie.TabIndex = 82;
            this.grpResultatPartie.TabStop = false;
            this.grpResultatPartie.Text = "Partie jouée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Partie sauvegardée";
            // 
            // txtNomPartie
            // 
            this.txtNomPartie.Location = new System.Drawing.Point(155, 58);
            this.txtNomPartie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomPartie.MaxLength = 50;
            this.txtNomPartie.Name = "txtNomPartie";
            this.txtNomPartie.Size = new System.Drawing.Size(265, 22);
            this.txtNomPartie.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "Résultat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Nemesis (vie)";
            // 
            // cbResultatPartie
            // 
            this.cbResultatPartie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResultatPartie.FormattingEnabled = true;
            this.cbResultatPartie.Items.AddRange(new object[] {
            "Gagné",
            "Perdu"});
            this.cbResultatPartie.Location = new System.Drawing.Point(155, 85);
            this.cbResultatPartie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbResultatPartie.Name = "cbResultatPartie";
            this.cbResultatPartie.Size = new System.Drawing.Size(121, 24);
            this.cbResultatPartie.TabIndex = 81;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(19, 144);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(114, 17);
            this.label31.TabIndex = 34;
            this.label31.Text = "Nombre de cycle";
            // 
            // cbPartie
            // 
            this.cbPartie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartie.FormattingEnabled = true;
            this.cbPartie.Location = new System.Drawing.Point(155, 29);
            this.cbPartie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPartie.Name = "cbPartie";
            this.cbPartie.Size = new System.Drawing.Size(265, 24);
            this.cbPartie.TabIndex = 73;
            // 
            // btnSupprimerPartie
            // 
            this.btnSupprimerPartie.Location = new System.Drawing.Point(293, 184);
            this.btnSupprimerPartie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimerPartie.Name = "btnSupprimerPartie";
            this.btnSupprimerPartie.Size = new System.Drawing.Size(127, 30);
            this.btnSupprimerPartie.TabIndex = 75;
            this.btnSupprimerPartie.Text = "Supprimer partie";
            this.btnSupprimerPartie.UseVisualStyleBackColor = true;
            this.btnSupprimerPartie.Click += new System.EventHandler(this.btnSupprimerPartie_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(19, 171);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(112, 17);
            this.label33.TabIndex = 36;
            this.label33.Text = "Grave Hold (vie)";
            // 
            // txtNbCycle
            // 
            this.txtNbCycle.Location = new System.Drawing.Point(155, 141);
            this.txtNbCycle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNbCycle.Name = "txtNbCycle";
            this.txtNbCycle.Size = new System.Drawing.Size(121, 22);
            this.txtNbCycle.TabIndex = 43;
            // 
            // btnNouvellePartie
            // 
            this.btnNouvellePartie.Location = new System.Drawing.Point(293, 117);
            this.btnNouvellePartie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNouvellePartie.Name = "btnNouvellePartie";
            this.btnNouvellePartie.Size = new System.Drawing.Size(127, 28);
            this.btnNouvellePartie.TabIndex = 72;
            this.btnNouvellePartie.Text = "Nouvelle partie";
            this.btnNouvellePartie.UseVisualStyleBackColor = true;
            this.btnNouvellePartie.Click += new System.EventHandler(this.btnNouvellePartie_Click);
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(155, 304);
            this.txtCommentaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCommentaire.MaxLength = 50;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(265, 22);
            this.txtCommentaire.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nom de la partie";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Vie du Mage 1";
            // 
            // bntChargerPartie
            // 
            this.bntChargerPartie.Location = new System.Drawing.Point(293, 85);
            this.bntChargerPartie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntChargerPartie.Name = "bntChargerPartie";
            this.bntChargerPartie.Size = new System.Drawing.Size(127, 28);
            this.bntChargerPartie.TabIndex = 70;
            this.bntChargerPartie.Text = "Charger partie";
            this.bntChargerPartie.UseVisualStyleBackColor = true;
            this.bntChargerPartie.Click += new System.EventHandler(this.bntChargerPartie_Click);
            // 
            // txtGraveHoldVie
            // 
            this.txtGraveHoldVie.Location = new System.Drawing.Point(155, 168);
            this.txtGraveHoldVie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGraveHoldVie.Name = "txtGraveHoldVie";
            this.txtGraveHoldVie.Size = new System.Drawing.Size(121, 22);
            this.txtGraveHoldVie.TabIndex = 47;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(19, 307);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(91, 17);
            this.label34.TabIndex = 37;
            this.label34.Text = "Commentaire";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 225);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "Vie du Mage 2";
            // 
            // txtNemesisVie
            // 
            this.txtNemesisVie.Location = new System.Drawing.Point(155, 114);
            this.txtNemesisVie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNemesisVie.Name = "txtNemesisVie";
            this.txtNemesisVie.Size = new System.Drawing.Size(121, 22);
            this.txtNemesisVie.TabIndex = 46;
            // 
            // btnSauverPartie
            // 
            this.btnSauverPartie.Location = new System.Drawing.Point(293, 149);
            this.btnSauverPartie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSauverPartie.Name = "btnSauverPartie";
            this.btnSauverPartie.Size = new System.Drawing.Size(127, 30);
            this.btnSauverPartie.TabIndex = 66;
            this.btnSauverPartie.Text = "Sauver partie";
            this.btnSauverPartie.UseVisualStyleBackColor = true;
            this.btnSauverPartie.Click += new System.EventHandler(this.btnSauverPartie_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 252);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 17);
            this.label19.TabIndex = 22;
            this.label19.Text = "Vie du Mage 3";
            // 
            // txtVieMage1
            // 
            this.txtVieMage1.Location = new System.Drawing.Point(155, 195);
            this.txtVieMage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVieMage1.Name = "txtVieMage1";
            this.txtVieMage1.Size = new System.Drawing.Size(121, 22);
            this.txtVieMage1.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 279);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 17);
            this.label20.TabIndex = 23;
            this.label20.Text = "Vie du Mage 4";
            // 
            // txtVieMage2
            // 
            this.txtVieMage2.Location = new System.Drawing.Point(155, 222);
            this.txtVieMage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVieMage2.Name = "txtVieMage2";
            this.txtVieMage2.Size = new System.Drawing.Size(121, 22);
            this.txtVieMage2.TabIndex = 53;
            // 
            // txtVieMage3
            // 
            this.txtVieMage3.Location = new System.Drawing.Point(155, 249);
            this.txtVieMage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVieMage3.Name = "txtVieMage3";
            this.txtVieMage3.Size = new System.Drawing.Size(121, 22);
            this.txtVieMage3.TabIndex = 54;
            // 
            // txtVieMage4
            // 
            this.txtVieMage4.Location = new System.Drawing.Point(155, 276);
            this.txtVieMage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVieMage4.Name = "txtVieMage4";
            this.txtVieMage4.Size = new System.Drawing.Size(121, 22);
            this.txtVieMage4.TabIndex = 55;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(332, 26);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(129, 17);
            this.label45.TabIndex = 79;
            this.label45.Text = "Nombre de joueurs";
            // 
            // cbNbJoueursPartie
            // 
            this.cbNbJoueursPartie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNbJoueursPartie.FormattingEnabled = true;
            this.cbNbJoueursPartie.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbNbJoueursPartie.Location = new System.Drawing.Point(467, 23);
            this.cbNbJoueursPartie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNbJoueursPartie.Name = "cbNbJoueursPartie";
            this.cbNbJoueursPartie.Size = new System.Drawing.Size(121, 24);
            this.cbNbJoueursPartie.TabIndex = 78;
            this.cbNbJoueursPartie.SelectedIndexChanged += new System.EventHandler(this.CbNbJoueursPartie_SelectedIndexChanged);
            // 
            // bntHasard
            // 
            this.bntHasard.Location = new System.Drawing.Point(648, 20);
            this.bntHasard.Name = "bntHasard";
            this.bntHasard.Size = new System.Drawing.Size(127, 28);
            this.bntHasard.TabIndex = 77;
            this.bntHasard.Text = "Hasard";
            this.bntHasard.UseVisualStyleBackColor = true;
            this.bntHasard.Click += new System.EventHandler(this.BntHasard_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblVieDepartNemesis);
            this.groupBox3.Controls.Add(this.lblNiveauNemesis);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbNemesis);
            this.groupBox3.Location = new System.Drawing.Point(5, 59);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(627, 75);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nemesis";
            // 
            // lblVieDepartNemesis
            // 
            this.lblVieDepartNemesis.AutoSize = true;
            this.lblVieDepartNemesis.Location = new System.Drawing.Point(434, 51);
            this.lblVieDepartNemesis.Name = "lblVieDepartNemesis";
            this.lblVieDepartNemesis.Size = new System.Drawing.Size(26, 17);
            this.lblVieDepartNemesis.TabIndex = 51;
            this.lblVieDepartNemesis.Text = "vie";
            // 
            // lblNiveauNemesis
            // 
            this.lblNiveauNemesis.AutoSize = true;
            this.lblNiveauNemesis.Location = new System.Drawing.Point(471, 23);
            this.lblNiveauNemesis.Name = "lblNiveauNemesis";
            this.lblNiveauNemesis.Size = new System.Drawing.Size(50, 17);
            this.lblNiveauNemesis.TabIndex = 50;
            this.lblNiveauNemesis.Text = "niveau";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(327, 23);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(138, 17);
            this.label35.TabIndex = 49;
            this.label35.Text = "Niveau du Nemesis :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(327, 51);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(101, 17);
            this.label32.TabIndex = 47;
            this.label32.Text = "Vie de départ :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Nom du Nemesis";
            // 
            // cbNemesis
            // 
            this.cbNemesis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNemesis.FormattingEnabled = true;
            this.cbNemesis.Location = new System.Drawing.Point(135, 23);
            this.cbNemesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNemesis.Name = "cbNemesis";
            this.cbNemesis.Size = new System.Drawing.Size(176, 24);
            this.cbNemesis.TabIndex = 45;
            this.cbNemesis.SelectedIndexChanged += new System.EventHandler(this.cbNemesis_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbReplique1);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.cbSort4);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.cbSort3);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.cbSort2);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.cbSort1);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.cbGem3);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.cbGem2);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.cbGem1);
            this.groupBox2.Controls.Add(this.cbReplique2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 232);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(623, 172);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marché";
            // 
            // cbReplique1
            // 
            this.cbReplique1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReplique1.FormattingEnabled = true;
            this.cbReplique1.Location = new System.Drawing.Point(131, 24);
            this.cbReplique1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReplique1.Name = "cbReplique1";
            this.cbReplique1.Size = new System.Drawing.Size(176, 24);
            this.cbReplique1.TabIndex = 56;
            this.cbReplique1.SelectedIndexChanged += new System.EventHandler(this.cbReplique1_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 17);
            this.label21.TabIndex = 24;
            this.label21.Text = "Replique 1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 57);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 17);
            this.label22.TabIndex = 25;
            this.label22.Text = "Replique 2";
            // 
            // cbSort4
            // 
            this.cbSort4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort4.FormattingEnabled = true;
            this.cbSort4.Location = new System.Drawing.Point(386, 113);
            this.cbSort4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSort4.Name = "cbSort4";
            this.cbSort4.Size = new System.Drawing.Size(176, 24);
            this.cbSort4.TabIndex = 65;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 87);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 17);
            this.label23.TabIndex = 26;
            this.label23.Text = "Gem 1";
            // 
            // cbSort3
            // 
            this.cbSort3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort3.FormattingEnabled = true;
            this.cbSort3.Location = new System.Drawing.Point(386, 83);
            this.cbSort3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSort3.Name = "cbSort3";
            this.cbSort3.Size = new System.Drawing.Size(176, 24);
            this.cbSort3.TabIndex = 64;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 116);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 17);
            this.label24.TabIndex = 27;
            this.label24.Text = "Gem 2";
            // 
            // cbSort2
            // 
            this.cbSort2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort2.FormattingEnabled = true;
            this.cbSort2.Location = new System.Drawing.Point(386, 53);
            this.cbSort2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSort2.Name = "cbSort2";
            this.cbSort2.Size = new System.Drawing.Size(176, 24);
            this.cbSort2.TabIndex = 63;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 146);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 17);
            this.label25.TabIndex = 28;
            this.label25.Text = "Gem 3";
            // 
            // cbSort1
            // 
            this.cbSort1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort1.FormattingEnabled = true;
            this.cbSort1.Location = new System.Drawing.Point(386, 24);
            this.cbSort1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSort1.Name = "cbSort1";
            this.cbSort1.Size = new System.Drawing.Size(176, 24);
            this.cbSort1.TabIndex = 62;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(324, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 17);
            this.label26.TabIndex = 29;
            this.label26.Text = "Sort 1";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(324, 56);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 17);
            this.label27.TabIndex = 30;
            this.label27.Text = "Sort 2";
            // 
            // cbGem3
            // 
            this.cbGem3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGem3.FormattingEnabled = true;
            this.cbGem3.Location = new System.Drawing.Point(131, 143);
            this.cbGem3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGem3.Name = "cbGem3";
            this.cbGem3.Size = new System.Drawing.Size(176, 24);
            this.cbGem3.TabIndex = 60;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(324, 86);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 17);
            this.label28.TabIndex = 31;
            this.label28.Text = "Sort 3";
            // 
            // cbGem2
            // 
            this.cbGem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGem2.FormattingEnabled = true;
            this.cbGem2.Location = new System.Drawing.Point(131, 113);
            this.cbGem2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGem2.Name = "cbGem2";
            this.cbGem2.Size = new System.Drawing.Size(176, 24);
            this.cbGem2.TabIndex = 59;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(324, 116);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 17);
            this.label29.TabIndex = 32;
            this.label29.Text = "Sort 4";
            // 
            // cbGem1
            // 
            this.cbGem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGem1.FormattingEnabled = true;
            this.cbGem1.Location = new System.Drawing.Point(131, 83);
            this.cbGem1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGem1.Name = "cbGem1";
            this.cbGem1.Size = new System.Drawing.Size(176, 24);
            this.cbGem1.TabIndex = 58;
            // 
            // cbReplique2
            // 
            this.cbReplique2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReplique2.FormattingEnabled = true;
            this.cbReplique2.Location = new System.Drawing.Point(131, 53);
            this.cbReplique2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReplique2.Name = "cbReplique2";
            this.cbReplique2.Size = new System.Drawing.Size(176, 24);
            this.cbReplique2.TabIndex = 57;
            this.cbReplique2.SelectedIndexChanged += new System.EventHandler(this.cbReplique2_SelectedIndexChanged);
            // 
            // Mages
            // 
            this.Mages.Controls.Add(this.cbMage1);
            this.Mages.Controls.Add(this.label13);
            this.Mages.Controls.Add(this.label14);
            this.Mages.Controls.Add(this.label15);
            this.Mages.Controls.Add(this.label16);
            this.Mages.Controls.Add(this.cbMage2);
            this.Mages.Controls.Add(this.cbMage3);
            this.Mages.Controls.Add(this.cbMage4);
            this.Mages.Location = new System.Drawing.Point(5, 142);
            this.Mages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mages.Name = "Mages";
            this.Mages.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mages.Size = new System.Drawing.Size(627, 80);
            this.Mages.TabIndex = 67;
            this.Mages.TabStop = false;
            this.Mages.Text = "Mages";
            // 
            // cbMage1
            // 
            this.cbMage1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMage1.FormattingEnabled = true;
            this.cbMage1.Location = new System.Drawing.Point(135, 22);
            this.cbMage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMage1.Name = "cbMage1";
            this.cbMage1.Size = new System.Drawing.Size(176, 24);
            this.cbMage1.TabIndex = 48;
            this.cbMage1.SelectedIndexChanged += new System.EventHandler(this.CbMage1_SelectedIndexChanged);
            this.cbMage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CbMage1_MouseDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Nom du mage 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Nom du mage 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(327, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Nom du mage 3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(327, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Nom du mage 4";
            // 
            // cbMage2
            // 
            this.cbMage2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMage2.FormattingEnabled = true;
            this.cbMage2.Location = new System.Drawing.Point(135, 50);
            this.cbMage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMage2.Name = "cbMage2";
            this.cbMage2.Size = new System.Drawing.Size(176, 24);
            this.cbMage2.TabIndex = 49;
            // 
            // cbMage3
            // 
            this.cbMage3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMage3.FormattingEnabled = true;
            this.cbMage3.Location = new System.Drawing.Point(441, 22);
            this.cbMage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMage3.Name = "cbMage3";
            this.cbMage3.Size = new System.Drawing.Size(176, 24);
            this.cbMage3.TabIndex = 50;
            // 
            // cbMage4
            // 
            this.cbMage4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMage4.FormattingEnabled = true;
            this.cbMage4.Location = new System.Drawing.Point(441, 50);
            this.cbMage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMage4.Name = "cbMage4";
            this.cbMage4.Size = new System.Drawing.Size(176, 24);
            this.cbMage4.TabIndex = 51;
            // 
            // cbVersionPJ
            // 
            this.cbVersionPJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersionPJ.FormattingEnabled = true;
            this.cbVersionPJ.Location = new System.Drawing.Point(140, 23);
            this.cbVersionPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVersionPJ.Name = "cbVersionPJ";
            this.cbVersionPJ.Size = new System.Drawing.Size(176, 24);
            this.cbVersionPJ.TabIndex = 44;
            // 
            // lblNumeroPartie
            // 
            this.lblNumeroPartie.AutoSize = true;
            this.lblNumeroPartie.Location = new System.Drawing.Point(147, 23);
            this.lblNumeroPartie.Name = "lblNumeroPartie";
            this.lblNumeroPartie.Size = new System.Drawing.Size(0, 17);
            this.lblNumeroPartie.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nom de version";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 86;
            this.button1.Text = "Mettre à jour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // AeonsEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1118, 472);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AeonsEndForm";
            this.Text = "Aeons End";
            this.tabControl1.ResumeLayout(false);
            this.tabPartiesJouees.ResumeLayout(false);
            this.tabPartiesJouees.PerformLayout();
            this.grpResultatPartie.ResumeLayout(false);
            this.grpResultatPartie.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Mages.ResumeLayout(false);
            this.Mages.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPartiesJouees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblNumeroPartie;
        private System.Windows.Forms.TextBox txtNbCycle;
        private System.Windows.Forms.TextBox txtVieMage4;
        private System.Windows.Forms.TextBox txtVieMage3;
        private System.Windows.Forms.TextBox txtVieMage2;
        private System.Windows.Forms.TextBox txtVieMage1;
        private System.Windows.Forms.ComboBox cbMage4;
        private System.Windows.Forms.ComboBox cbMage3;
        private System.Windows.Forms.ComboBox cbMage2;
        private System.Windows.Forms.ComboBox cbMage1;
        private System.Windows.Forms.TextBox txtGraveHoldVie;
        private System.Windows.Forms.TextBox txtNemesisVie;
        private System.Windows.Forms.ComboBox cbNemesis;
        private System.Windows.Forms.ComboBox cbVersionPJ;
        private System.Windows.Forms.ComboBox cbGem3;
        private System.Windows.Forms.ComboBox cbGem2;
        private System.Windows.Forms.ComboBox cbGem1;
        private System.Windows.Forms.ComboBox cbReplique2;
        private System.Windows.Forms.ComboBox cbReplique1;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.ComboBox cbSort4;
        private System.Windows.Forms.ComboBox cbSort3;
        private System.Windows.Forms.ComboBox cbSort2;
        private System.Windows.Forms.ComboBox cbSort1;
        private System.Windows.Forms.Button btnSauverPartie;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Mages;
        private System.Windows.Forms.Button bntChargerPartie;
        private System.Windows.Forms.Button btnNouvellePartie;
        private System.Windows.Forms.Button btnSupprimerPartie;
        private System.Windows.Forms.Label lblVieDepartNemesis;
        private System.Windows.Forms.Label lblNiveauNemesis;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button bntHasard;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox cbNbJoueursPartie;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ComboBox cbResultatPartie;
        private GroupBox grpResultatPartie;
        private Label label1;
        private Label label2;
        private TextBox txtNomPartie;
        private ComboBox cbPartie;
        private Button button1;
    }
}
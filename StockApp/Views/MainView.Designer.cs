namespace StockApp.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            BT_AjouterFournisseur = new DevExpress.XtraBars.BarButtonItem();
            BT_AfficherFournisseurs = new DevExpress.XtraBars.BarButtonItem();
            BT_AjouterArticle = new DevExpress.XtraBars.BarButtonItem();
            BT_AjouterBonEntree = new DevExpress.XtraBars.BarButtonItem();
            BT_AfficherProduits = new DevExpress.XtraBars.BarButtonItem();
            BT_AfficherBons = new DevExpress.XtraBars.BarButtonItem();
            BT_AjouterClient = new DevExpress.XtraBars.BarButtonItem();
            BT_AjouterBonCommande = new DevExpress.XtraBars.BarButtonItem();
            BT_AjouterBonLivraison = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            BT_AfficherClients = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, BT_AjouterFournisseur, BT_AfficherFournisseurs, BT_AjouterArticle, BT_AjouterBonEntree, BT_AfficherProduits, BT_AfficherBons, BT_AjouterClient, BT_AjouterBonCommande, BT_AjouterBonLivraison, barButtonItem10, BT_AfficherClients });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 17;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2, ribbonPage3, ribbonPage4 });
            ribbon.Size = new System.Drawing.Size(891, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // BT_AjouterFournisseur
            // 
            BT_AjouterFournisseur.Caption = "Ajouter un fournisseur";
            BT_AjouterFournisseur.Id = 1;
            BT_AjouterFournisseur.ImageOptions.Image = Properties.Resources.ajouter_personne;
            BT_AjouterFournisseur.Name = "BT_AjouterFournisseur";
            BT_AjouterFournisseur.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            BT_AjouterFournisseur.ItemClick += BT_AjouterFournisseur_ItemClick;
            // 
            // BT_AfficherFournisseurs
            // 
            BT_AfficherFournisseurs.Caption = "Voir la liste de mes fournisseurs";
            BT_AfficherFournisseurs.Id = 4;
            BT_AfficherFournisseurs.ImageOptions.Image = Properties.Resources.mes_clients;
            BT_AfficherFournisseurs.Name = "BT_AfficherFournisseurs";
            BT_AfficherFournisseurs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            BT_AfficherFournisseurs.ItemClick += BT_AfficherFournisseurs_ItemClick;
            // 
            // BT_AjouterArticle
            // 
            BT_AjouterArticle.Caption = "Ajouter une fiche article";
            BT_AjouterArticle.Id = 5;
            BT_AjouterArticle.ImageOptions.Image = Properties.Resources.ajouter_produit;
            BT_AjouterArticle.Name = "BT_AjouterArticle";
            BT_AjouterArticle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            BT_AjouterArticle.ItemClick += BT_AjouterArticle_ItemClick;
            // 
            // BT_AjouterBonEntree
            // 
            BT_AjouterBonEntree.Caption = "Ajouter un bon d'entrée";
            BT_AjouterBonEntree.Id = 6;
            BT_AjouterBonEntree.ImageOptions.Image = Properties.Resources.ajouter_fichier;
            BT_AjouterBonEntree.Name = "BT_AjouterBonEntree";
            BT_AjouterBonEntree.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            BT_AjouterBonEntree.ItemClick += BT_AjouterBonEntree_ItemClick;
            // 
            // BT_AfficherProduits
            // 
            BT_AfficherProduits.Caption = "Afficher mes produits";
            BT_AfficherProduits.Id = 7;
            BT_AfficherProduits.ImageOptions.Image = Properties.Resources.mes_articles;
            BT_AfficherProduits.Name = "BT_AfficherProduits";
            BT_AfficherProduits.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            BT_AfficherProduits.ItemClick += BT_AfficherProduits_ItemClick;
            // 
            // BT_AfficherBons
            // 
            BT_AfficherBons.Caption = "Parcourir mes bons";
            BT_AfficherBons.Id = 9;
            BT_AfficherBons.ImageOptions.Image = Properties.Resources.mes_bons;
            BT_AfficherBons.Name = "BT_AfficherBons";
            BT_AfficherBons.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            BT_AfficherBons.ItemClick += BT_AfficherBons_ItemClick;
            // 
            // BT_AjouterClient
            // 
            BT_AjouterClient.Caption = "Ajouter une fiche client";
            BT_AjouterClient.Id = 11;
            BT_AjouterClient.ImageOptions.Image = Properties.Resources.ajouter_personne;
            BT_AjouterClient.Name = "BT_AjouterClient";
            BT_AjouterClient.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            BT_AjouterClient.ItemClick += BT_AjouterClient_ItemClick;
            // 
            // BT_AjouterBonCommande
            // 
            BT_AjouterBonCommande.Caption = "Ajouter un bon commande";
            BT_AjouterBonCommande.Id = 12;
            BT_AjouterBonCommande.ImageOptions.Image = Properties.Resources.ajouter_fichier;
            BT_AjouterBonCommande.Name = "BT_AjouterBonCommande";
            BT_AjouterBonCommande.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            BT_AjouterBonCommande.ItemClick += BT_AjouterBonCommande_ItemClick;
            // 
            // BT_AjouterBonLivraison
            // 
            BT_AjouterBonLivraison.Caption = "Ajouter un bon de livraison";
            BT_AjouterBonLivraison.Id = 13;
            BT_AjouterBonLivraison.ImageOptions.Image = Properties.Resources.ajouter_fichier;
            BT_AjouterBonLivraison.Name = "BT_AjouterBonLivraison";
            BT_AjouterBonLivraison.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            BT_AjouterBonLivraison.ItemClick += BT_AjouterBonLivraison_ItemClick;
            // 
            // barButtonItem10
            // 
            barButtonItem10.Caption = "Voir mes clients";
            barButtonItem10.Id = 14;
            barButtonItem10.Name = "barButtonItem10";
            // 
            // BT_AfficherClients
            // 
            BT_AfficherClients.Caption = "Voir mes clients";
            BT_AfficherClients.Id = 15;
            BT_AfficherClients.ImageOptions.Image = Properties.Resources.rechercher_client;
            BT_AfficherClients.Name = "BT_AfficherClients";
            BT_AfficherClients.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            BT_AfficherClients.ItemClick += BT_AfficherClients_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup5, ribbonPageGroup8, ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Gestion du Stock";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(BT_AjouterBonEntree);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup8
            // 
            ribbonPageGroup8.ItemLinks.Add(BT_AfficherProduits);
            ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(BT_AjouterArticle);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3, ribbonPageGroup7, ribbonPageGroup2, ribbonPageGroup9 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Ventes";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(BT_AjouterBonCommande);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup7
            // 
            ribbonPageGroup7.ItemLinks.Add(BT_AjouterBonLivraison);
            ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(BT_AjouterClient);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup9
            // 
            ribbonPageGroup9.ItemLinks.Add(BT_AfficherClients);
            ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPage3
            // 
            ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4, ribbonPageGroup6 });
            ribbonPage3.Name = "ribbonPage3";
            ribbonPage3.Text = "Achats";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(BT_AjouterFournisseur);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup6
            // 
            ribbonPageGroup6.ItemLinks.Add(BT_AfficherFournisseurs);
            ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage4
            // 
            ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup10 });
            ribbonPage4.Name = "ribbonPage4";
            ribbonPage4.Text = "Visualiser mes bons";
            // 
            // ribbonPageGroup10
            // 
            ribbonPageGroup10.ItemLinks.Add(BT_AfficherBons);
            ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new System.Drawing.Point(0, 595);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(891, 30);
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(panelControl1);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 193);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(891, 402);
            layoutControl1.TabIndex = 2;
            layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(layoutControl2);
            panelControl1.Location = new System.Drawing.Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(867, 378);
            panelControl1.TabIndex = 4;
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(pictureEdit1);
            layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl2.Location = new System.Drawing.Point(2, 2);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new System.Drawing.Size(863, 374);
            layoutControl2.TabIndex = 0;
            layoutControl2.Text = "layoutControl2";
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = Properties.Resources.Main_view_page;
            pictureEdit1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureEdit1.Location = new System.Drawing.Point(28, 12);
            pictureEdit1.MenuManager = ribbon;
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new System.Drawing.Size(823, 337);
            pictureEdit1.StyleController = layoutControl2;
            pictureEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.ContentImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, layoutControlItem2 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(863, 374);
            layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(0, 341);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(843, 13);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = pictureEdit1;
            layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            layoutControlItem2.MinSize = new System.Drawing.Size(144, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(843, 341);
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem2.Text = " ";
            layoutControlItem2.TextSize = new System.Drawing.Size(4, 16);
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(891, 402);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = panelControl1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(871, 382);
            layoutControlItem1.TextVisible = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(891, 625);
            Controls.Add(layoutControl1);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("MainView.IconOptions.SvgImage");
            IsMdiContainer = true;
            Name = "MainView";
            Ribbon = ribbon;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "Accueil MonStock";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem BT_AjouterFournisseur;
        private DevExpress.XtraBars.BarButtonItem BT_AfficherFournisseurs;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem BT_AjouterArticle;
        private DevExpress.XtraBars.BarButtonItem BT_AjouterBonEntree;
        private DevExpress.XtraBars.BarButtonItem BT_AfficherProduits;
        private DevExpress.XtraBars.BarButtonItem BT_AfficherBons;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem BT_AjouterClient;
        private DevExpress.XtraBars.BarButtonItem BT_AjouterBonCommande;
        private DevExpress.XtraBars.BarButtonItem BT_AjouterBonLivraison;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem BT_AfficherClients;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
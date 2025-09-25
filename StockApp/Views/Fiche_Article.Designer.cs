namespace StockApp.Views
{
    partial class Fiche_Article
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiche_Article));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            BT_AjouterFicheArticle = new DevExpress.XtraEditors.SimpleButton();
            TE_Quantite = new DevExpress.XtraEditors.TextEdit();
            TE_TVA = new DevExpress.XtraEditors.TextEdit();
            TE_PrixHT = new DevExpress.XtraEditors.TextEdit();
            TE_Designation = new DevExpress.XtraEditors.TextEdit();
            TE_CodeArticle = new DevExpress.XtraEditors.TextEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            Désignation = new DevExpress.XtraLayout.LayoutControlItem();
            Prix_unitaire_HT = new DevExpress.XtraLayout.LayoutControlItem();
            Taux_TVA = new DevExpress.XtraLayout.LayoutControlItem();
            Quantité = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TE_Quantite.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_TVA.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_PrixHT.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_Designation.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_CodeArticle.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Désignation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Prix_unitaire_HT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Taux_TVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Quantité).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(panelControl1);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(856, 245);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(layoutControl2);
            panelControl1.Location = new System.Drawing.Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(832, 221);
            panelControl1.TabIndex = 4;
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(BT_AjouterFicheArticle);
            layoutControl2.Controls.Add(TE_Quantite);
            layoutControl2.Controls.Add(TE_TVA);
            layoutControl2.Controls.Add(TE_PrixHT);
            layoutControl2.Controls.Add(TE_Designation);
            layoutControl2.Controls.Add(TE_CodeArticle);
            layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl2.Location = new System.Drawing.Point(2, 2);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 0, 812, 500);
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new System.Drawing.Size(828, 217);
            layoutControl2.TabIndex = 0;
            layoutControl2.Text = "layoutControl2";
            // 
            // BT_AjouterFicheArticle
            // 
            BT_AjouterFicheArticle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BT_AjouterFicheArticle.Appearance.Options.UseFont = true;
            BT_AjouterFicheArticle.Location = new System.Drawing.Point(12, 162);
            BT_AjouterFicheArticle.Name = "BT_AjouterFicheArticle";
            BT_AjouterFicheArticle.Size = new System.Drawing.Size(804, 27);
            BT_AjouterFicheArticle.StyleController = layoutControl2;
            BT_AjouterFicheArticle.TabIndex = 6;
            BT_AjouterFicheArticle.Text = "Ajouter";
            BT_AjouterFicheArticle.Click += BT_AjouterFicheArticle_Click;
            // 
            // TE_Quantite
            // 
            TE_Quantite.Location = new System.Drawing.Point(118, 132);
            TE_Quantite.Name = "TE_Quantite";
            TE_Quantite.Size = new System.Drawing.Size(698, 22);
            TE_Quantite.StyleController = layoutControl2;
            TE_Quantite.TabIndex = 5;
            // 
            // TE_TVA
            // 
            TE_TVA.Location = new System.Drawing.Point(118, 102);
            TE_TVA.Name = "TE_TVA";
            TE_TVA.Size = new System.Drawing.Size(698, 22);
            TE_TVA.StyleController = layoutControl2;
            TE_TVA.TabIndex = 4;
            // 
            // TE_PrixHT
            // 
            TE_PrixHT.Anchor = System.Windows.Forms.AnchorStyles.None;
            TE_PrixHT.Location = new System.Drawing.Point(118, 72);
            TE_PrixHT.Name = "TE_PrixHT";
            TE_PrixHT.Size = new System.Drawing.Size(698, 22);
            TE_PrixHT.StyleController = layoutControl2;
            TE_PrixHT.TabIndex = 3;
            // 
            // TE_Designation
            // 
            TE_Designation.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TE_Designation.Location = new System.Drawing.Point(118, 42);
            TE_Designation.Name = "TE_Designation";
            TE_Designation.Size = new System.Drawing.Size(698, 22);
            TE_Designation.StyleController = layoutControl2;
            TE_Designation.TabIndex = 2;
            // 
            // TE_CodeArticle
            // 
            TE_CodeArticle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TE_CodeArticle.Location = new System.Drawing.Point(118, 12);
            TE_CodeArticle.Name = "TE_CodeArticle";
            TE_CodeArticle.Size = new System.Drawing.Size(698, 22);
            TE_CodeArticle.StyleController = layoutControl2;
            TE_CodeArticle.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3, Désignation, Prix_unitaire_HT, Taux_TVA, Quantité, emptySpaceItem1, layoutControlItem2 });
            layoutControlGroup1.Name = "Root";
            layoutControlGroup1.Size = new System.Drawing.Size(828, 217);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = TE_CodeArticle;
            layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            layoutControlItem3.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem3.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(808, 30);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.Text = "Code Article";
            layoutControlItem3.TextSize = new System.Drawing.Size(94, 16);
            // 
            // Désignation
            // 
            Désignation.Control = TE_Designation;
            Désignation.Location = new System.Drawing.Point(0, 30);
            Désignation.MinSize = new System.Drawing.Size(200, 30);
            Désignation.Name = "Désignation";
            Désignation.Size = new System.Drawing.Size(808, 30);
            Désignation.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            Désignation.TextSize = new System.Drawing.Size(94, 16);
            // 
            // Prix_unitaire_HT
            // 
            Prix_unitaire_HT.Control = TE_PrixHT;
            Prix_unitaire_HT.Location = new System.Drawing.Point(0, 60);
            Prix_unitaire_HT.MaxSize = new System.Drawing.Size(0, 30);
            Prix_unitaire_HT.MinSize = new System.Drawing.Size(200, 30);
            Prix_unitaire_HT.Name = "Prix_unitaire_HT";
            Prix_unitaire_HT.Size = new System.Drawing.Size(808, 30);
            Prix_unitaire_HT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            Prix_unitaire_HT.TextSize = new System.Drawing.Size(94, 16);
            Prix_unitaire_HT.TextChanged += Prix_unitaire_HT_TextChanged;
            // 
            // Taux_TVA
            // 
            Taux_TVA.Control = TE_TVA;
            Taux_TVA.Location = new System.Drawing.Point(0, 90);
            Taux_TVA.MaxSize = new System.Drawing.Size(0, 30);
            Taux_TVA.MinSize = new System.Drawing.Size(200, 30);
            Taux_TVA.Name = "Taux_TVA";
            Taux_TVA.Size = new System.Drawing.Size(808, 30);
            Taux_TVA.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            Taux_TVA.Text = "Taux_TVA %";
            Taux_TVA.TextSize = new System.Drawing.Size(94, 16);
            // 
            // Quantité
            // 
            Quantité.Control = TE_Quantite;
            Quantité.Location = new System.Drawing.Point(0, 120);
            Quantité.MaxSize = new System.Drawing.Size(0, 30);
            Quantité.MinSize = new System.Drawing.Size(200, 30);
            Quantité.Name = "Quantité";
            Quantité.Size = new System.Drawing.Size(808, 30);
            Quantité.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            Quantité.TextSize = new System.Drawing.Size(94, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(0, 181);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(808, 16);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = BT_AjouterFicheArticle;
            layoutControlItem2.Location = new System.Drawing.Point(0, 150);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(808, 31);
            layoutControlItem2.TextVisible = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(856, 245);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = panelControl1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.MinSize = new System.Drawing.Size(5, 5);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(836, 225);
            layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem1.TextVisible = false;
            // 
            // Fiche_Article
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(856, 245);
            Controls.Add(layoutControl1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Fiche_Article.IconOptions.SvgImage");
            Name = "Fiche_Article";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Fiche Article";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TE_Quantite.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_TVA.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_PrixHT.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_Designation.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_CodeArticle.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Désignation).EndInit();
            ((System.ComponentModel.ISupportInitialize)Prix_unitaire_HT).EndInit();
            ((System.ComponentModel.ISupportInitialize)Taux_TVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)Quantité).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit TE_CodeArticle;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit TE_Designation;
        private DevExpress.XtraLayout.LayoutControlItem Désignation;
        private DevExpress.XtraEditors.TextEdit TE_TVA;
        private DevExpress.XtraEditors.TextEdit TE_PrixHT;
        private DevExpress.XtraLayout.LayoutControlItem Prix_unitaire_HT;
        private DevExpress.XtraLayout.LayoutControlItem Taux_TVA;
        private DevExpress.XtraEditors.TextEdit TE_Quantite;
        private DevExpress.XtraLayout.LayoutControlItem Quantité;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton BT_AjouterFicheArticle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
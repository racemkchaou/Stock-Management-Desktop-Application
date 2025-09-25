namespace StockApp.Views
{
    partial class Ajouter_Ligne_Bon_Commande_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_Ligne_Bon_Commande_View));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            BT_AjouterLigneBonCommande = new DevExpress.XtraEditors.SimpleButton();
            TE_PrixUnitaire = new DevExpress.XtraEditors.TextEdit();
            TE_Quantite = new DevExpress.XtraEditors.TextEdit();
            TE_Designation = new DevExpress.XtraEditors.TextEdit();
            LUE_CodeArticle = new DevExpress.XtraEditors.SearchLookUpEdit();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TE_PrixUnitaire.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_Quantite.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_Designation.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LUE_CodeArticle.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
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
            layoutControl1.Size = new System.Drawing.Size(640, 234);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(layoutControl2);
            panelControl1.Location = new System.Drawing.Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(616, 210);
            panelControl1.TabIndex = 4;
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(BT_AjouterLigneBonCommande);
            layoutControl2.Controls.Add(TE_PrixUnitaire);
            layoutControl2.Controls.Add(TE_Quantite);
            layoutControl2.Controls.Add(TE_Designation);
            layoutControl2.Controls.Add(LUE_CodeArticle);
            layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl2.Location = new System.Drawing.Point(2, 2);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new System.Drawing.Size(612, 206);
            layoutControl2.TabIndex = 0;
            layoutControl2.Text = "layoutControl2";
            // 
            // BT_AjouterLigneBonCommande
            // 
            BT_AjouterLigneBonCommande.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BT_AjouterLigneBonCommande.Appearance.Options.UseFont = true;
            BT_AjouterLigneBonCommande.Location = new System.Drawing.Point(307, 152);
            BT_AjouterLigneBonCommande.Name = "BT_AjouterLigneBonCommande";
            BT_AjouterLigneBonCommande.Size = new System.Drawing.Size(293, 27);
            BT_AjouterLigneBonCommande.StyleController = layoutControl2;
            BT_AjouterLigneBonCommande.TabIndex = 8;
            BT_AjouterLigneBonCommande.Text = "Ajouter";
            BT_AjouterLigneBonCommande.Click += BT_AjouterLigneBonCommande_Click;
            // 
            // TE_PrixUnitaire
            // 
            TE_PrixUnitaire.Location = new System.Drawing.Point(120, 117);
            TE_PrixUnitaire.Name = "TE_PrixUnitaire";
            TE_PrixUnitaire.Size = new System.Drawing.Size(480, 22);
            TE_PrixUnitaire.StyleController = layoutControl2;
            TE_PrixUnitaire.TabIndex = 7;
            // 
            // TE_Quantite
            // 
            TE_Quantite.Location = new System.Drawing.Point(120, 82);
            TE_Quantite.Name = "TE_Quantite";
            TE_Quantite.Size = new System.Drawing.Size(480, 22);
            TE_Quantite.StyleController = layoutControl2;
            TE_Quantite.TabIndex = 6;
            // 
            // TE_Designation
            // 
            TE_Designation.Location = new System.Drawing.Point(120, 47);
            TE_Designation.Name = "TE_Designation";
            TE_Designation.Size = new System.Drawing.Size(480, 22);
            TE_Designation.StyleController = layoutControl2;
            TE_Designation.TabIndex = 5;
            // 
            // LUE_CodeArticle
            // 
            LUE_CodeArticle.Location = new System.Drawing.Point(120, 12);
            LUE_CodeArticle.Name = "LUE_CodeArticle";
            LUE_CodeArticle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            LUE_CodeArticle.Properties.DisplayMember = "Designation";
            LUE_CodeArticle.Properties.NullText = "Sélectionner votre article ...";
            LUE_CodeArticle.Properties.PopupView = gridView1;
            LUE_CodeArticle.Properties.ValueMember = "CodeArticle";
            LUE_CodeArticle.Size = new System.Drawing.Size(480, 22);
            LUE_CodeArticle.StyleController = layoutControl2;
            LUE_CodeArticle.TabIndex = 4;
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4 });
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView1.Name = "gridView1";
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            gridColumn4.Name = "gridColumn4";
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, emptySpaceItem1, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(612, 206);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = LUE_CodeArticle;
            layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            layoutControlItem2.MaxSize = new System.Drawing.Size(0, 35);
            layoutControlItem2.MinSize = new System.Drawing.Size(146, 35);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(592, 35);
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem2.Text = "Code article";
            layoutControlItem2.TextSize = new System.Drawing.Size(96, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(0, 140);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(295, 46);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = TE_Designation;
            layoutControlItem3.Location = new System.Drawing.Point(0, 35);
            layoutControlItem3.MaxSize = new System.Drawing.Size(0, 35);
            layoutControlItem3.MinSize = new System.Drawing.Size(146, 35);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(592, 35);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.Text = "Désignation";
            layoutControlItem3.TextSize = new System.Drawing.Size(96, 16);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = TE_Quantite;
            layoutControlItem4.Location = new System.Drawing.Point(0, 70);
            layoutControlItem4.MaxSize = new System.Drawing.Size(0, 35);
            layoutControlItem4.MinSize = new System.Drawing.Size(146, 35);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(592, 35);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.Text = "Quantité";
            layoutControlItem4.TextSize = new System.Drawing.Size(96, 16);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = TE_PrixUnitaire;
            layoutControlItem5.Location = new System.Drawing.Point(0, 105);
            layoutControlItem5.MaxSize = new System.Drawing.Size(0, 35);
            layoutControlItem5.MinSize = new System.Drawing.Size(146, 35);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(592, 35);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.Text = "Prix unitaire TTC";
            layoutControlItem5.TextSize = new System.Drawing.Size(96, 16);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = BT_AjouterLigneBonCommande;
            layoutControlItem6.Location = new System.Drawing.Point(295, 140);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(297, 46);
            layoutControlItem6.TextVisible = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(640, 234);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = panelControl1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(620, 214);
            layoutControlItem1.TextVisible = false;
            // 
            // Ajouter_Ligne_Bon_Commande_View
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(640, 234);
            Controls.Add(layoutControl1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Ajouter_Ligne_Bon_Commande_View.IconOptions.SvgImage");
            Name = "Ajouter_Ligne_Bon_Commande_View";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ajouter Ligne Bon Commande";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TE_PrixUnitaire.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_Quantite.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_Designation.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LUE_CodeArticle.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit TE_PrixUnitaire;
        private DevExpress.XtraEditors.TextEdit TE_Quantite;
        private DevExpress.XtraEditors.TextEdit TE_Designation;
        private DevExpress.XtraEditors.SearchLookUpEdit LUE_CodeArticle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1; private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton BT_AjouterLigneBonCommande;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
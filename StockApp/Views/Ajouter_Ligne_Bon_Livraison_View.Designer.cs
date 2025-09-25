namespace StockApp.Views
{
    partial class Ajouter_Ligne_Bon_Livraison_View
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
            ((System.ComponentModel.ISupportInitialize)gridViewArticle).EndInit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_Ligne_Bon_Livraison_View));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            BT_AjouterLigneBonLivraison = new DevExpress.XtraEditors.SimpleButton();
            TE_Prix = new DevExpress.XtraEditors.TextEdit();
            TE_Quantite = new DevExpress.XtraEditors.TextEdit();
            TE_Designation = new DevExpress.XtraEditors.TextEdit();
            LUE_CodeArticle = new DevExpress.XtraEditors.SearchLookUpEdit();
            gridViewArticle = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl3).BeginInit();
            layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TE_Prix.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_Quantite.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_Designation.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LUE_CodeArticle.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewArticle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
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
            layoutControl1.Size = new System.Drawing.Size(652, 204);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(layoutControl3);
            panelControl1.Location = new System.Drawing.Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(628, 180);
            panelControl1.TabIndex = 4;
            // 
            // layoutControl3
            // 
            layoutControl3.Controls.Add(BT_AjouterLigneBonLivraison);
            layoutControl3.Controls.Add(TE_Prix);
            layoutControl3.Controls.Add(TE_Quantite);
            layoutControl3.Controls.Add(TE_Designation);
            layoutControl3.Controls.Add(LUE_CodeArticle);
            layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl3.Location = new System.Drawing.Point(2, 2);
            layoutControl3.Name = "layoutControl3";
            layoutControl3.Root = layoutControlGroup2;
            layoutControl3.Size = new System.Drawing.Size(624, 176);
            layoutControl3.TabIndex = 0;
            layoutControl3.Text = "layoutControl3";
            // 
            // BT_AjouterLigneBonLivraison
            // 
            BT_AjouterLigneBonLivraison.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BT_AjouterLigneBonLivraison.Appearance.Options.UseFont = true;
            BT_AjouterLigneBonLivraison.Location = new System.Drawing.Point(314, 132);
            BT_AjouterLigneBonLivraison.Name = "BT_AjouterLigneBonLivraison";
            BT_AjouterLigneBonLivraison.Size = new System.Drawing.Size(298, 27);
            BT_AjouterLigneBonLivraison.StyleController = layoutControl3;
            BT_AjouterLigneBonLivraison.TabIndex = 8;
            BT_AjouterLigneBonLivraison.Text = "Ajouter";
            BT_AjouterLigneBonLivraison.Click += BT_AjouterLigneBonLivraison_Click;
            // 
            // TE_Prix
            // 
            TE_Prix.Location = new System.Drawing.Point(92, 102);
            TE_Prix.Name = "TE_Prix";
            TE_Prix.Size = new System.Drawing.Size(520, 22);
            TE_Prix.StyleController = layoutControl3;
            TE_Prix.TabIndex = 7;
            // 
            // TE_Quantite
            // 
            TE_Quantite.Location = new System.Drawing.Point(92, 72);
            TE_Quantite.Name = "TE_Quantite";
            TE_Quantite.Size = new System.Drawing.Size(520, 22);
            TE_Quantite.StyleController = layoutControl3;
            TE_Quantite.TabIndex = 6;
            // 
            // TE_Designation
            // 
            TE_Designation.Location = new System.Drawing.Point(92, 42);
            TE_Designation.Name = "TE_Designation";
            TE_Designation.Size = new System.Drawing.Size(520, 22);
            TE_Designation.StyleController = layoutControl3;
            TE_Designation.TabIndex = 5;
            // 
            // LUE_CodeArticle
            // 
            LUE_CodeArticle.Location = new System.Drawing.Point(92, 12);
            LUE_CodeArticle.Name = "LUE_CodeArticle";
            LUE_CodeArticle.Properties.DisplayMember = "CodeArticle";
            LUE_CodeArticle.Properties.NullText = "Sélectionner un article ...";
            LUE_CodeArticle.Properties.PopupView = gridViewArticle;
            LUE_CodeArticle.Properties.ValueMember = "CodeArticle";
            LUE_CodeArticle.Size = new System.Drawing.Size(520, 22);
            LUE_CodeArticle.StyleController = layoutControl3;
            LUE_CodeArticle.TabIndex = 4;
            // 
            // gridViewArticle
            // 
            gridViewArticle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4 });
            gridViewArticle.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridViewArticle.Name = "gridViewArticle";
            gridViewArticle.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewArticle.OptionsView.ShowAutoFilterRow = true;
            gridViewArticle.OptionsView.ShowGroupPanel = false;
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
            // layoutControlGroup2
            // 
            layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup2.GroupBordersVisible = false;
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3, emptySpaceItem1, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7 });
            layoutControlGroup2.Name = "layoutControlGroup2";
            layoutControlGroup2.Size = new System.Drawing.Size(624, 176);
            layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = LUE_CodeArticle;
            layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            layoutControlItem3.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem3.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(604, 30);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.Text = "Code article";
            layoutControlItem3.TextSize = new System.Drawing.Size(68, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(302, 36);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = TE_Designation;
            layoutControlItem4.Location = new System.Drawing.Point(0, 30);
            layoutControlItem4.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem4.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(604, 30);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.Text = "Désignation";
            layoutControlItem4.TextSize = new System.Drawing.Size(68, 16);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = TE_Quantite;
            layoutControlItem5.Location = new System.Drawing.Point(0, 60);
            layoutControlItem5.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem5.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(604, 30);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.Text = "Quantité";
            layoutControlItem5.TextSize = new System.Drawing.Size(68, 16);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = TE_Prix;
            layoutControlItem6.Location = new System.Drawing.Point(0, 90);
            layoutControlItem6.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem6.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(604, 30);
            layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem6.Text = "Prix";
            layoutControlItem6.TextSize = new System.Drawing.Size(68, 16);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = BT_AjouterLigneBonLivraison;
            layoutControlItem7.Location = new System.Drawing.Point(302, 120);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new System.Drawing.Size(302, 36);
            layoutControlItem7.TextVisible = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(652, 204);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = panelControl1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.MinSize = new System.Drawing.Size(5, 5);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(632, 184);
            layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem1.TextVisible = false;
            // 
            // Ajouter_Ligne_Bon_Livraison_View
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(652, 204);
            Controls.Add(layoutControl1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Ajouter_Ligne_Bon_Livraison_View.IconOptions.SvgImage");
            Name = "Ajouter_Ligne_Bon_Livraison_View";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ajouter ligne bon de livraison";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl3).EndInit();
            layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TE_Prix.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_Quantite.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_Designation.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LUE_CodeArticle.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewArticle).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit LUE_CodeArticle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewArticle; 
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit TE_Prix;
        private DevExpress.XtraEditors.TextEdit TE_Quantite;
        private DevExpress.XtraEditors.TextEdit TE_Designation;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton BT_AjouterLigneBonLivraison;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
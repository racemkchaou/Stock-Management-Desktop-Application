namespace StockApp.Views
{
    partial class Fiche_Fournisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiche_Fournisseur));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            BT_AjouterFicheFournisseur = new DevExpress.XtraEditors.SimpleButton();
            TE_Tel = new DevExpress.XtraEditors.TextEdit();
            TE_Adresse = new DevExpress.XtraEditors.TextEdit();
            TE_NomFournisseur = new DevExpress.XtraEditors.TextEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TE_Tel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_Adresse.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_NomFournisseur.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
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
            layoutControl1.Size = new System.Drawing.Size(674, 225);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(layoutControl2);
            panelControl1.Location = new System.Drawing.Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(650, 201);
            panelControl1.TabIndex = 4;
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(BT_AjouterFicheFournisseur);
            layoutControl2.Controls.Add(TE_Tel);
            layoutControl2.Controls.Add(TE_Adresse);
            layoutControl2.Controls.Add(TE_NomFournisseur);
            layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl2.Location = new System.Drawing.Point(2, 2);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new System.Drawing.Size(646, 197);
            layoutControl2.TabIndex = 0;
            layoutControl2.Text = "layoutControl2";
            // 
            // BT_AjouterFicheFournisseur
            // 
            BT_AjouterFicheFournisseur.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BT_AjouterFicheFournisseur.Appearance.Options.UseFont = true;
            BT_AjouterFicheFournisseur.Location = new System.Drawing.Point(325, 102);
            BT_AjouterFicheFournisseur.Name = "BT_AjouterFicheFournisseur";
            BT_AjouterFicheFournisseur.Size = new System.Drawing.Size(309, 27);
            BT_AjouterFicheFournisseur.StyleController = layoutControl2;
            BT_AjouterFicheFournisseur.TabIndex = 5;
            BT_AjouterFicheFournisseur.Text = "Ajouter";
            BT_AjouterFicheFournisseur.Click += BT_AjouterFicheFournisseur_Click;
            // 
            // TE_Tel
            // 
            TE_Tel.Location = new System.Drawing.Point(113, 72);
            TE_Tel.Name = "TE_Tel";
            TE_Tel.Size = new System.Drawing.Size(521, 22);
            TE_Tel.StyleController = layoutControl2;
            TE_Tel.TabIndex = 4;
            // 
            // TE_Adresse
            // 
            TE_Adresse.Location = new System.Drawing.Point(113, 42);
            TE_Adresse.Name = "TE_Adresse";
            TE_Adresse.Size = new System.Drawing.Size(521, 22);
            TE_Adresse.StyleController = layoutControl2;
            TE_Adresse.TabIndex = 3;
            // 
            // TE_NomFournisseur
            // 
            TE_NomFournisseur.Location = new System.Drawing.Point(113, 12);
            TE_NomFournisseur.Name = "TE_NomFournisseur";
            TE_NomFournisseur.Size = new System.Drawing.Size(521, 22);
            TE_NomFournisseur.StyleController = layoutControl2;
            TE_NomFournisseur.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, layoutControlItem3, layoutControlItem4, emptySpaceItem1, layoutControlItem5 });
            layoutControlGroup1.Name = "Root";
            layoutControlGroup1.Size = new System.Drawing.Size(646, 197);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = TE_NomFournisseur;
            layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            layoutControlItem2.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem2.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(626, 30);
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem2.Text = "Nom et prénom";
            layoutControlItem2.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = TE_Adresse;
            layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            layoutControlItem3.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem3.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(626, 30);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.Text = "Adresse";
            layoutControlItem3.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = TE_Tel;
            layoutControlItem4.Location = new System.Drawing.Point(0, 60);
            layoutControlItem4.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem4.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(626, 30);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.Text = "TEL";
            layoutControlItem4.TextSize = new System.Drawing.Size(89, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(0, 90);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(313, 87);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = BT_AjouterFicheFournisseur;
            layoutControlItem5.Location = new System.Drawing.Point(313, 90);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(313, 87);
            layoutControlItem5.TextVisible = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(674, 225);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = panelControl1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.MinSize = new System.Drawing.Size(5, 5);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(654, 205);
            layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem1.TextVisible = false;
            // 
            // Fiche_Fournisseur
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(674, 225);
            Controls.Add(layoutControl1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Fiche_Fournisseur.IconOptions.SvgImage");
            Name = "Fiche_Fournisseur";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Fiche Fournisseur";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TE_Tel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_Adresse.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_NomFournisseur.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit TE_Tel;
        private DevExpress.XtraEditors.TextEdit TE_Adresse;
        private DevExpress.XtraEditors.TextEdit TE_NomFournisseur;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton BT_AjouterFicheFournisseur;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
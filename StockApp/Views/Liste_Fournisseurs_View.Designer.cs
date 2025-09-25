namespace StockApp.Views
{
    partial class Liste_Fournisseurs_View
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liste_Fournisseurs_View));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            ficheFournisseurBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCodeFournisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomFournisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            colAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalDesAchats = new DevExpress.XtraGrid.Columns.GridColumn();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ficheFournisseurBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
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
            layoutControl1.Size = new System.Drawing.Size(918, 543);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(layoutControl2);
            panelControl1.Location = new System.Drawing.Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(894, 519);
            panelControl1.TabIndex = 4;
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(gridControl1);
            layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl2.Location = new System.Drawing.Point(2, 2);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new System.Drawing.Size(890, 515);
            layoutControl2.TabIndex = 0;
            layoutControl2.Text = "layoutControl2";
            // 
            // gridControl1
            // 
            gridControl1.DataSource = ficheFournisseurBindingSource;
            gridControl1.Location = new System.Drawing.Point(12, 12);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(866, 397);
            gridControl1.TabIndex = 5;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // ficheFournisseurBindingSource
            // 
            ficheFournisseurBindingSource.DataSource = typeof(Models.FicheFournisseur);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCodeFournisseur, colNomFournisseur, colAdresse, colTel, colTotalDesAchats });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // colCodeFournisseur
            // 
            colCodeFournisseur.FieldName = "CodeFournisseur";
            colCodeFournisseur.MinWidth = 25;
            colCodeFournisseur.Name = "colCodeFournisseur";
            colCodeFournisseur.Visible = true;
            colCodeFournisseur.VisibleIndex = 0;
            colCodeFournisseur.Width = 94;
            // 
            // colNomFournisseur
            // 
            colNomFournisseur.FieldName = "NomFournisseur";
            colNomFournisseur.MinWidth = 25;
            colNomFournisseur.Name = "colNomFournisseur";
            colNomFournisseur.Visible = true;
            colNomFournisseur.VisibleIndex = 1;
            colNomFournisseur.Width = 94;
            // 
            // colAdresse
            // 
            colAdresse.FieldName = "Adresse";
            colAdresse.MinWidth = 25;
            colAdresse.Name = "colAdresse";
            colAdresse.Visible = true;
            colAdresse.VisibleIndex = 2;
            colAdresse.Width = 94;
            // 
            // colTel
            // 
            colTel.FieldName = "Tel";
            colTel.MinWidth = 25;
            colTel.Name = "colTel";
            colTel.Visible = true;
            colTel.VisibleIndex = 3;
            colTel.Width = 94;
            // 
            // colTotalDesAchats
            // 
            colTotalDesAchats.FieldName = "TotalDesAchats";
            colTotalDesAchats.MinWidth = 25;
            colTotalDesAchats.Name = "colTotalDesAchats";
            colTotalDesAchats.Visible = true;
            colTotalDesAchats.VisibleIndex = 4;
            colTotalDesAchats.Width = 94;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, layoutControlItem3 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(890, 515);
            layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(0, 401);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(870, 94);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = gridControl1;
            layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(870, 401);
            layoutControlItem3.TextVisible = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(918, 543);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = panelControl1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(898, 523);
            layoutControlItem1.TextVisible = false;
            // 
            // Liste_Fournisseurs_View
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(918, 543);
            Controls.Add(layoutControl1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Liste_Fournisseurs_View.IconOptions.SvgImage");
            Name = "Liste_Fournisseurs_View";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Mes Fournisseurs";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ficheFournisseurBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource ficheFournisseurBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeFournisseur;
        private DevExpress.XtraGrid.Columns.GridColumn colNomFournisseur;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresse;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDesAchats;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
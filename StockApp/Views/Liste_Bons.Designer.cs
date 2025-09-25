namespace StockApp.Views
{
    partial class Liste_Bons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liste_Bons));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            TE_NomPrenom = new DevExpress.XtraEditors.TextEdit();
            TE_NumeroBon = new DevExpress.XtraEditors.TextEdit();
            DE_DateFin = new DevExpress.XtraEditors.DateEdit();
            DE_DateDebut = new DevExpress.XtraEditors.DateEdit();
            CBE_NatureBon = new DevExpress.XtraEditors.ComboBoxEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_NomPrenom.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_NumeroBon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DE_DateFin.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DE_DateFin.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DE_DateDebut.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DE_DateDebut.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CBE_NatureBon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
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
            layoutControl1.Size = new System.Drawing.Size(1066, 608);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(layoutControl2);
            panelControl1.Location = new System.Drawing.Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1042, 584);
            panelControl1.TabIndex = 4;
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(gridControl1);
            layoutControl2.Controls.Add(TE_NomPrenom);
            layoutControl2.Controls.Add(TE_NumeroBon);
            layoutControl2.Controls.Add(DE_DateFin);
            layoutControl2.Controls.Add(DE_DateDebut);
            layoutControl2.Controls.Add(CBE_NatureBon);
            layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl2.Location = new System.Drawing.Point(2, 2);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new System.Drawing.Size(1038, 580);
            layoutControl2.TabIndex = 0;
            layoutControl2.Text = "layoutControl2";
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(12, 64);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1014, 494);
            gridControl1.TabIndex = 9;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            // 
            // gridView1
            // 
            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSkyBlue;
            gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn5, gridColumn1, gridColumn2, gridColumn3, gridColumn4 });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Nature du bon";
            gridColumn5.MinWidth = 25;
            gridColumn5.Name = "gridColumn5";
            gridColumn5.OptionsColumn.AllowEdit = false;
            gridColumn5.OptionsColumn.ReadOnly = true;
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 0;
            gridColumn5.Width = 94;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Numéro Bon";
            gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn1.MinWidth = 25;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.OptionsColumn.AllowEdit = false;
            gridColumn1.OptionsColumn.ReadOnly = true;
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 1;
            gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Date Bon";
            gridColumn2.DisplayFormat.FormatString = "d";
            gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridColumn2.MinWidth = 25;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.OptionsColumn.AllowEdit = false;
            gridColumn2.OptionsColumn.ReadOnly = true;
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 3;
            gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Nom et prénom";
            gridColumn3.MinWidth = 25;
            gridColumn3.Name = "gridColumn3";
            gridColumn3.OptionsColumn.AllowEdit = false;
            gridColumn3.OptionsColumn.ReadOnly = true;
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Montant Total";
            gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn4.MinWidth = 25;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.OptionsColumn.AllowEdit = false;
            gridColumn4.OptionsColumn.ReadOnly = true;
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 4;
            gridColumn4.Width = 94;
            // 
            // TE_NomPrenom
            // 
            TE_NomPrenom.Location = new System.Drawing.Point(622, 38);
            TE_NomPrenom.Name = "TE_NomPrenom";
            TE_NomPrenom.Properties.NullText = "Tapez le nom et prénom ...";
            TE_NomPrenom.Size = new System.Drawing.Size(404, 22);
            TE_NomPrenom.StyleController = layoutControl2;
            TE_NomPrenom.TabIndex = 8;
            // 
            // TE_NumeroBon
            // 
            TE_NumeroBon.Location = new System.Drawing.Point(113, 38);
            TE_NumeroBon.Name = "TE_NumeroBon";
            TE_NumeroBon.Properties.NullText = "Tapez un numéro de bon ...";
            TE_NumeroBon.Size = new System.Drawing.Size(404, 22);
            TE_NumeroBon.StyleController = layoutControl2;
            TE_NumeroBon.TabIndex = 7;
            // 
            // DE_DateFin
            // 
            DE_DateFin.EditValue = null;
            DE_DateFin.Location = new System.Drawing.Point(876, 12);
            DE_DateFin.Name = "DE_DateFin";
            DE_DateFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DE_DateFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DE_DateFin.Size = new System.Drawing.Size(150, 22);
            DE_DateFin.StyleController = layoutControl2;
            DE_DateFin.TabIndex = 6;
            // 
            // DE_DateDebut
            // 
            DE_DateDebut.EditValue = null;
            DE_DateDebut.Location = new System.Drawing.Point(622, 12);
            DE_DateDebut.Name = "DE_DateDebut";
            DE_DateDebut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DE_DateDebut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DE_DateDebut.Size = new System.Drawing.Size(149, 22);
            DE_DateDebut.StyleController = layoutControl2;
            DE_DateDebut.TabIndex = 5;
            // 
            // CBE_NatureBon
            // 
            CBE_NatureBon.Location = new System.Drawing.Point(113, 12);
            CBE_NatureBon.Name = "CBE_NatureBon";
            CBE_NatureBon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CBE_NatureBon.Size = new System.Drawing.Size(404, 22);
            CBE_NatureBon.StyleController = layoutControl2;
            CBE_NatureBon.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, emptySpaceItem1, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(1038, 580);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = CBE_NatureBon;
            layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(509, 26);
            layoutControlItem2.Text = "Nature du bon";
            layoutControlItem2.TextSize = new System.Drawing.Size(89, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(0, 550);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(1018, 10);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = DE_DateDebut;
            layoutControlItem3.Location = new System.Drawing.Point(509, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(254, 26);
            layoutControlItem3.Text = "Date début";
            layoutControlItem3.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = DE_DateFin;
            layoutControlItem4.Location = new System.Drawing.Point(763, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(255, 26);
            layoutControlItem4.Text = "Date fin";
            layoutControlItem4.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = TE_NumeroBon;
            layoutControlItem5.Location = new System.Drawing.Point(0, 26);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(509, 26);
            layoutControlItem5.Text = "Numéro bon";
            layoutControlItem5.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = TE_NomPrenom;
            layoutControlItem6.Location = new System.Drawing.Point(509, 26);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(509, 26);
            layoutControlItem6.Text = "Nom et prénom";
            layoutControlItem6.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = gridControl1;
            layoutControlItem7.Location = new System.Drawing.Point(0, 52);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new System.Drawing.Size(1018, 498);
            layoutControlItem7.TextVisible = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1066, 608);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = panelControl1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(1046, 588);
            layoutControlItem1.TextVisible = false;
            // 
            // Liste_Bons
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1066, 608);
            Controls.Add(layoutControl1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Liste_Bons.IconOptions.SvgImage");
            Name = "Liste_Bons";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Liste bons";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_NomPrenom.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_NumeroBon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DE_DateFin.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DE_DateFin.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DE_DateDebut.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DE_DateDebut.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CBE_NatureBon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.TextEdit TE_NomPrenom;
        private DevExpress.XtraEditors.TextEdit TE_NumeroBon;
        private DevExpress.XtraEditors.DateEdit DE_DateFin;
        private DevExpress.XtraEditors.DateEdit DE_DateDebut;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_NatureBon;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
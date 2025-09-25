namespace StockApp.Views
{
    partial class Fiche_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiche_Client));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            BT_AjouterFicheClient = new DevExpress.XtraEditors.SimpleButton();
            TE_Tel = new DevExpress.XtraEditors.TextEdit();
            TE_Adresse = new DevExpress.XtraEditors.TextEdit();
            TE_NomClient = new DevExpress.XtraEditors.TextEdit();
            TE_CodeClient = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)TE_Tel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_Adresse.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_NomClient.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TE_CodeClient.Properties).BeginInit();
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
            layoutControl1.Size = new System.Drawing.Size(735, 221);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(layoutControl2);
            panelControl1.Location = new System.Drawing.Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(711, 197);
            panelControl1.TabIndex = 4;
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(BT_AjouterFicheClient);
            layoutControl2.Controls.Add(TE_Tel);
            layoutControl2.Controls.Add(TE_Adresse);
            layoutControl2.Controls.Add(TE_NomClient);
            layoutControl2.Controls.Add(TE_CodeClient);
            layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl2.Location = new System.Drawing.Point(2, 2);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new System.Drawing.Size(707, 193);
            layoutControl2.TabIndex = 0;
            layoutControl2.Text = "layoutControl2";
            // 
            // BT_AjouterFicheClient
            // 
            BT_AjouterFicheClient.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BT_AjouterFicheClient.Appearance.Options.UseFont = true;
            BT_AjouterFicheClient.Location = new System.Drawing.Point(12, 132);
            BT_AjouterFicheClient.Name = "BT_AjouterFicheClient";
            BT_AjouterFicheClient.Size = new System.Drawing.Size(683, 27);
            BT_AjouterFicheClient.StyleController = layoutControl2;
            BT_AjouterFicheClient.TabIndex = 8;
            BT_AjouterFicheClient.Text = "Ajouter";
            BT_AjouterFicheClient.Click += BT_AjouterFicheClient_Click;
            // 
            // TE_Tel
            // 
            TE_Tel.Location = new System.Drawing.Point(113, 102);
            TE_Tel.Name = "TE_Tel";
            TE_Tel.Size = new System.Drawing.Size(582, 22);
            TE_Tel.StyleController = layoutControl2;
            TE_Tel.TabIndex = 7;
            // 
            // TE_Adresse
            // 
            TE_Adresse.Location = new System.Drawing.Point(113, 72);
            TE_Adresse.Name = "TE_Adresse";
            TE_Adresse.Size = new System.Drawing.Size(582, 22);
            TE_Adresse.StyleController = layoutControl2;
            TE_Adresse.TabIndex = 6;
            // 
            // TE_NomClient
            // 
            TE_NomClient.Location = new System.Drawing.Point(113, 42);
            TE_NomClient.Name = "TE_NomClient";
            TE_NomClient.Size = new System.Drawing.Size(582, 22);
            TE_NomClient.StyleController = layoutControl2;
            TE_NomClient.TabIndex = 5;
            // 
            // TE_CodeClient
            // 
            TE_CodeClient.Location = new System.Drawing.Point(113, 12);
            TE_CodeClient.Name = "TE_CodeClient";
            TE_CodeClient.Size = new System.Drawing.Size(582, 22);
            TE_CodeClient.StyleController = layoutControl2;
            TE_CodeClient.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, emptySpaceItem1, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(707, 193);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = TE_CodeClient;
            layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            layoutControlItem2.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem2.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(687, 30);
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem2.Text = "Code client";
            layoutControlItem2.TextSize = new System.Drawing.Size(89, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(0, 151);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(687, 22);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = TE_NomClient;
            layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            layoutControlItem3.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem3.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(687, 30);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.Text = "Nom et prénom";
            layoutControlItem3.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = TE_Adresse;
            layoutControlItem4.Location = new System.Drawing.Point(0, 60);
            layoutControlItem4.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem4.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(687, 30);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.Text = "Adresse";
            layoutControlItem4.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = TE_Tel;
            layoutControlItem5.Location = new System.Drawing.Point(0, 90);
            layoutControlItem5.MaxSize = new System.Drawing.Size(0, 30);
            layoutControlItem5.MinSize = new System.Drawing.Size(200, 30);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(687, 30);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.Text = "TEL";
            layoutControlItem5.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = BT_AjouterFicheClient;
            layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(687, 31);
            layoutControlItem6.TextVisible = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(735, 221);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = panelControl1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(715, 201);
            layoutControlItem1.TextVisible = false;
            // 
            // Fiche_Client
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(735, 221);
            Controls.Add(layoutControl1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Fiche_Client.IconOptions.SvgImage");
            Name = "Fiche_Client";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Fiche Client";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TE_Tel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_Adresse.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_NomClient.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TE_CodeClient.Properties).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit TE_Tel;
        private DevExpress.XtraEditors.TextEdit TE_Adresse;
        private DevExpress.XtraEditors.TextEdit TE_NomClient;
        private DevExpress.XtraEditors.TextEdit TE_CodeClient;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton BT_AjouterFicheClient;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
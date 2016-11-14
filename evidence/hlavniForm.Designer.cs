namespace evidence
{
    partial class hlavniForm
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.smazatButton = new DevExpress.XtraEditors.SimpleButton();
            this.editovatButton = new DevExpress.XtraEditors.SimpleButton();
            this.pridatButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.jmenoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prijmeniColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uliceColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.obecColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.telefonColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.emailColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.smazatButton);
            this.layoutControl1.Controls.Add(this.editovatButton);
            this.layoutControl1.Controls.Add(this.pridatButton);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(918, 131, 705, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(758, 217);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // smazatButton
            // 
            this.smazatButton.Location = new System.Drawing.Point(670, 183);
            this.smazatButton.Name = "smazatButton";
            this.smazatButton.Size = new System.Drawing.Size(76, 22);
            this.smazatButton.StyleController = this.layoutControl1;
            this.smazatButton.TabIndex = 7;
            this.smazatButton.Text = "Smazat";
            // 
            // editovatButton
            // 
            this.editovatButton.Location = new System.Drawing.Point(617, 183);
            this.editovatButton.Name = "editovatButton";
            this.editovatButton.Size = new System.Drawing.Size(49, 22);
            this.editovatButton.StyleController = this.layoutControl1;
            this.editovatButton.TabIndex = 6;
            this.editovatButton.Text = "Editovat";
            this.editovatButton.Click += new System.EventHandler(this.editovatButton_Click);
            // 
            // pridatButton
            // 
            this.pridatButton.Location = new System.Drawing.Point(12, 183);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.Size = new System.Drawing.Size(601, 22);
            this.pridatButton.StyleController = this.layoutControl1;
            this.pridatButton.TabIndex = 5;
            this.pridatButton.Text = "Přidat";
            this.pridatButton.Click += new System.EventHandler(this.pridatButton_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(734, 167);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.jmenoColumn,
            this.prijmeniColumn,
            this.uliceColumn,
            this.obecColumn,
            this.telefonColumn,
            this.emailColumn,
            this.idColumn});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // jmenoColumn
            // 
            this.jmenoColumn.Caption = "Jméno";
            this.jmenoColumn.FieldName = "jmeno";
            this.jmenoColumn.Name = "jmenoColumn";
            this.jmenoColumn.Visible = true;
            this.jmenoColumn.VisibleIndex = 0;
            // 
            // prijmeniColumn
            // 
            this.prijmeniColumn.Caption = "Příjmení";
            this.prijmeniColumn.FieldName = "prijmeni";
            this.prijmeniColumn.Name = "prijmeniColumn";
            this.prijmeniColumn.Visible = true;
            this.prijmeniColumn.VisibleIndex = 1;
            // 
            // uliceColumn
            // 
            this.uliceColumn.Caption = "Ulice";
            this.uliceColumn.FieldName = "ulice";
            this.uliceColumn.Name = "uliceColumn";
            this.uliceColumn.Visible = true;
            this.uliceColumn.VisibleIndex = 2;
            // 
            // obecColumn
            // 
            this.obecColumn.Caption = "Obec";
            this.obecColumn.FieldName = "obec";
            this.obecColumn.Name = "obecColumn";
            this.obecColumn.Visible = true;
            this.obecColumn.VisibleIndex = 3;
            // 
            // telefonColumn
            // 
            this.telefonColumn.Caption = "Telefon";
            this.telefonColumn.FieldName = "telefon";
            this.telefonColumn.Name = "telefonColumn";
            this.telefonColumn.Visible = true;
            this.telefonColumn.VisibleIndex = 4;
            // 
            // emailColumn
            // 
            this.emailColumn.Caption = "E-mail";
            this.emailColumn.FieldName = "email";
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.Visible = true;
            this.emailColumn.VisibleIndex = 5;
            // 
            // idColumn
            // 
            this.idColumn.FieldName = "id_osoba";
            this.idColumn.Name = "idColumn";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(758, 217);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(738, 171);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pridatButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 171);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(605, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.editovatButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(605, 171);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(53, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.smazatButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(658, 171);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // hlavniForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "hlavniForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton smazatButton;
        private DevExpress.XtraEditors.SimpleButton editovatButton;
        private DevExpress.XtraEditors.SimpleButton pridatButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn jmenoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn prijmeniColumn;
        private DevExpress.XtraGrid.Columns.GridColumn uliceColumn;
        private DevExpress.XtraGrid.Columns.GridColumn obecColumn;
        private DevExpress.XtraGrid.Columns.GridColumn telefonColumn;
        private DevExpress.XtraGrid.Columns.GridColumn emailColumn;
        private DevExpress.XtraGrid.Columns.GridColumn idColumn;
    }
}


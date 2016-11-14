namespace evidence
{
    partial class pridaniForm
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
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.zavritButton = new DevExpress.XtraEditors.SimpleButton();
            this.pridatButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.editControl2 = new evidence.editControl();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.zavritButton);
            this.layoutControl2.Controls.Add(this.pridatButton);
            this.layoutControl2.Controls.Add(this.editControl2);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(405, 376);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // zavritButton
            // 
            this.zavritButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.zavritButton.Location = new System.Drawing.Point(211, 342);
            this.zavritButton.Name = "zavritButton";
            this.zavritButton.Size = new System.Drawing.Size(182, 22);
            this.zavritButton.StyleController = this.layoutControl2;
            this.zavritButton.TabIndex = 6;
            this.zavritButton.Text = "Zavřít";
            // 
            // pridatButton
            // 
            this.pridatButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pridatButton.Location = new System.Drawing.Point(12, 342);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.Size = new System.Drawing.Size(195, 22);
            this.pridatButton.StyleController = this.layoutControl2;
            this.pridatButton.TabIndex = 5;
            this.pridatButton.Text = "Přidat";
            this.pridatButton.Click += new System.EventHandler(this.pridatButton_Click);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(405, 376);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.pridatButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 330);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(199, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.zavritButton;
            this.layoutControlItem6.Location = new System.Drawing.Point(199, 330);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(186, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // editControl2
            // 
            this.editControl2.Location = new System.Drawing.Point(12, 12);
            this.editControl2.Name = "editControl2";
            this.editControl2.Size = new System.Drawing.Size(381, 326);
            this.editControl2.TabIndex = 4;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.editControl2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(385, 330);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // pridaniForm
            // 
            this.ClientSize = new System.Drawing.Size(405, 376);
            this.Controls.Add(this.layoutControl2);
            this.Name = "pridaniForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přidání osoby";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private DevExpress.XtraLayout.LayoutControl layoutControl1;
        //private DevExpress.XtraEditors.SimpleButton simpleButton2;
        //private DevExpress.XtraEditors.SimpleButton simpleButton1;
        //private editControl editControl1;
        //private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        //private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        //private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        //private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3; zbytyk z předchozích pokusů
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SimpleButton zavritButton;
        private DevExpress.XtraEditors.SimpleButton pridatButton;
        private editControl editControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
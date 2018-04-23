namespace Sample___Toolbar {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.commandBar = new DevExpress.XtraBars.Bar();
			this.barButtonCategorized = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonAlphabetical = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.propertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager
			// 
			this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.commandBar});
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonCategorized,
            this.barButtonAlphabetical});
			this.barManager.MaxItemId = 2;
			// 
			// commandBar
			// 
			this.commandBar.BarName = "Tools";
			this.commandBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
			this.commandBar.DockCol = 0;
			this.commandBar.DockRow = 0;
			this.commandBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.commandBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonCategorized),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAlphabetical)});
			this.commandBar.OptionsBar.AllowQuickCustomization = false;
			this.commandBar.OptionsBar.DisableCustomization = true;
			this.commandBar.OptionsBar.DrawDragBorder = false;
			this.commandBar.OptionsBar.UseWholeRow = true;
			this.commandBar.Text = "Tools";
			// 
			// barButtonCategorized
			// 
			this.barButtonCategorized.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.barButtonCategorized.Caption = "Categorized";
			this.barButtonCategorized.Id = 0;
			this.barButtonCategorized.Name = "barButtonCategorized";
			// 
			// barButtonAlphabetical
			// 
			this.barButtonAlphabetical.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.barButtonAlphabetical.Caption = "Alphabetical";
			this.barButtonAlphabetical.Id = 1;
			this.barButtonAlphabetical.Name = "barButtonAlphabetical";
			// 
			// propertyGridControl
			// 
			this.propertyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGridControl.Location = new System.Drawing.Point(0, 24);
			this.propertyGridControl.Name = "propertyGridControl";
			this.propertyGridControl.ServiceProvider = null;
			this.propertyGridControl.Size = new System.Drawing.Size(492, 242);
			this.propertyGridControl.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 266);
			this.Controls.Add(this.propertyGridControl);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.Bar commandBar;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem barButtonCategorized;
		private DevExpress.XtraBars.BarButtonItem barButtonAlphabetical;
		private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl;
	}
}


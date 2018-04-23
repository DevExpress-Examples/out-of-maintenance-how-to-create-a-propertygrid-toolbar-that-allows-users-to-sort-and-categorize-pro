using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid;
using DevExpress.Utils;
using DevExpress.XtraBars;
using System.Reflection;

namespace Sample___Toolbar {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			this.barButtonCategorized.DownChanged += this.barButton_DownChanged;
			this.barButtonAlphabetical.DownChanged += this.barButton_DownChanged;
			SetBarButtonToolTip(this.barButtonAlphabetical, "Alphabetical");
			SetBarButtonToolTip(this.barButtonCategorized, "Categorized");
			this.barButtonCategorized.Glyph = ResourceImageHelper.CreateImageFromResources("Sample___Toolbar.Categorized.png", Assembly.GetExecutingAssembly());
            this.barButtonAlphabetical.Glyph = ResourceImageHelper.CreateImageFromResources("Sample___Toolbar.Alphabetical.png", Assembly.GetExecutingAssembly());
			this.ShowCategories = true;
			PropertyGridControl.SelectedObject = PropertyGridControl;
		}
		public bool ShowCategories {
            get { return this.barButtonCategorized.Down; }
            set { this.barButtonCategorized.Down = value; }
        }
        public PropertyGridControl PropertyGridControl {
            get { return propertyGridControl; }
        }
        private void barButton_DownChanged(object sender, ItemClickEventArgs e) {
			if(e.Item.Equals(this.barButtonCategorized)) {
				SetBarButtonDown(this.barButtonAlphabetical, !this.barButtonCategorized.Down);
			} else {
				SetBarButtonDown(this.barButtonCategorized, !this.barButtonAlphabetical.Down);
			}
            UpdatePropertyGrid();
        }
        static void SetBarButtonToolTip(DevExpress.XtraBars.BarButtonItem barButton, string value) {
            SuperToolTip superToolTip = new SuperToolTip();
            ToolTipTitleItem toolTipTitleItem = new ToolTipTitleItem();
            toolTipTitleItem.Text = value;
            superToolTip.Items.Add(toolTipTitleItem);
            barButton.SuperTip = superToolTip;
        }
        void SetBarButtonDown(BarButtonItem barButton, bool value) {
            barButton.DownChanged -= new ItemClickEventHandler(this.barButton_DownChanged);
            barButton.Down = value;
            barButton.DownChanged += new ItemClickEventHandler(this.barButton_DownChanged);
        }
        void UpdatePropertyGrid() {
            this.propertyGridControl.OptionsView.ShowRootCategories = this.barButtonCategorized.Down;
        }
	}
}
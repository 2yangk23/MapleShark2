﻿using System.Windows.Forms;
using MapleShark2.Theme;
using MapleShark2.Tools;
using WeifenLuo.WinFormsUI.Docking;

namespace MapleShark2.UI {
    public partial class PropertyForm : DockContent {
        public MainForm MainForm => ParentForm as MainForm;
        public PropertyGrid Properties => mProperties;

        public PropertyForm() {
            InitializeComponent();
        }

        public new void Show(DockPanel panel) {
            base.Show(panel);
            BackColor = Config.Instance.Theme.DockSuiteTheme.ColorPalette.MainWindowActive.Background;
            ThemeApplier.ApplyTheme(Config.Instance.Theme, Controls);
        }
    }
}
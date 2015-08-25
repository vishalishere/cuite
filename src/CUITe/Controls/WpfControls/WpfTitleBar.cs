﻿using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTitleBar
    /// </summary>
    public class WpfTitleBar : WpfControl<CUITControls.WpfTitleBar>
    {
        public WpfTitleBar()
        {
        }

        public WpfTitleBar(string searchParameters)
            : base(searchParameters)
        {
        }

        public string DisplayText
        {
            get { return UnWrap().DisplayText; }
        }
    }
}
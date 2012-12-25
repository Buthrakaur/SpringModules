using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleModule.Time;
using Page = Spring.Web.UI.Page;

namespace SampleWebFormsApp.Pages
{
	public partial class SamplePage : Page
	{
		public ISystemTime SystemTime { get; set; }

		public string InjectedText { get; set; }

		public string CurrentTime { get { return SystemTime.GetCurrentTime().ToString(); } }

		public SamplePage()
		{
			InjectedText = "not injected yet";
		}

		protected override void OnLoad(EventArgs e)
		{
			lblInjectedText.Text = InjectedText;
			lblCurrentTime.Text = CurrentTime;

			base.OnLoad(e);
		}
	}
}
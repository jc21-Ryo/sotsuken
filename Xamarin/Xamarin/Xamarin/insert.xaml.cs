using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class insert : CarouselPage
	{
		public insert (List<DateTime> dt)
		{
			InitializeComponent ();

            Calendar.Text = dt[0].ToString("yyyy年MM月dd日");
		}



    }

}
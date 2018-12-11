using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class fixed_cost : ContentPage
    {
        public fixed_cost()
        {
            InitializeComponent();

            var komokuList = new List<string>
        {
            "食費",
            "日用品",
            "交通費",
            "医療費",
            "光熱費",
            "美容衣服",
            "趣味",
            "酒タバコ",
            "その他",
        };

            foreach (var item in komokuList)
            {
                this.komoku.Items.Add(item);
            }

        }

	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DetailPage
{
	public partial class MainPage : MasterDetailPage
	{
		
		public MainPage()
		{
			InitializeComponent();
			profImg = new Button { ImageSource = "solaren.jpg", HeightRequest = 700 };//Make clickable
			abtList.ItemsSource = GetMenuList();
			var homePage = typeof(Views.HomePagge);
			Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
			IsPresented = false;
		}
		//https://byjus.com/physics/energy/
		public List<MasterMenuItems> GetMenuList()
		{
			var list = new List<MasterMenuItems>();
			list.Add(new MasterMenuItems()
			{
				Text = "Biomass Energy",
				Detail = "Some info about biomass energy",
				ImagePath = "biomass.png",
				TargetPage = typeof(Views.BiomEn)
			});
			list.Add(new MasterMenuItems()
			{
				Text = "Coal Energy",
				Detail = "Some info about coal energy",
				ImagePath = "coalen.png",
				TargetPage = typeof(Views.CoalEn)
			});
			
			list.Add(new MasterMenuItems()
			{
				Text = "Gas Energy",
				Detail = "Some info about gas energy",
				ImagePath = "gasen.jpg",
				TargetPage = typeof(Views.GasEn)
			});
			list.Add(new MasterMenuItems()
			{
				Text = "Heat Energy",
				Detail = "Some info about heat energy",
				ImagePath = "heaten.png",
				TargetPage = typeof(Views.HeatEn)
			});
			list.Add(new MasterMenuItems()
			{
				Text = "Kinetic Energy",
				Detail = "Some info about kinetic energy",
				ImagePath = "kinet.png",
				TargetPage = typeof(Views.KineticEn)
			});
			list.Add(new MasterMenuItems()
			{
				Text = "Nuclear Energy",
				Detail = "Some info about nuclear energy",
				ImagePath = "nuc.jpg",
				TargetPage = typeof(Views.NuclearEn)
			});
			list.Add(new MasterMenuItems()
			{
				Text = "Solar Energy",
				Detail = "Some info about solar energy",
				TargetPage = typeof(Views.SolarEn),
				ImagePath = "solar.png"
			});
			list.Add(new MasterMenuItems()
			{
				Text = "Tidal Energy",
				Detail = "Some info about tidal energy",
				TargetPage = typeof(Views.TideEn),
				ImagePath = "tidal.png"
			});
			list.Add(new MasterMenuItems()
			{
				Text="Water Energy",
				Detail = "Some info about water energy",
				TargetPage = typeof(Views.WaterEn),
				ImagePath = "wateren.png"
			});
			list.Add(new MasterMenuItems()
			{
				Text = "Wind Energy",
				Detail = "Some info about wind energy",
				ImagePath = "winden.png",
				TargetPage = typeof(Views.WindEn)
			});
			
			
			
			return list;
		}

		private void abtList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var selMenuItem = (MasterMenuItems)e.SelectedItem;
			Type selPage = selMenuItem.TargetPage;
			Detail = new NavigationPage((Page)Activator.CreateInstance(selPage));
			IsPresented = false;
		}
	}
}

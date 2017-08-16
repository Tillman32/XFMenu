using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XFMenu.Models;

namespace XFMenu.Pages
{
    public partial class MainMenu : MasterDetailPage
    {
        public List<MainMenuItem> MainMenuItems { get; set; }

        public MainMenu()
        {
            // Set the binding context to this code behind.
            BindingContext = this;

    		// Build the Menu
    		MainMenuItems = new List<MainMenuItem>()
    		{
    			new MainMenuItem() { Title = "Page One", Icon = "menu_inbox.png", TargetType = typeof(PageOne) },
    			new MainMenuItem() { Title = "Page Two", Icon = "menu_stock.png", TargetType = typeof(PageTwo) }
    		};

            // Set the default page, this is the "home" page.
            Detail = new NavigationPage(new PageOne());

    		InitializeComponent();
        }

    	// When a MenuItem is selected.
    	public void MainMenuItem_Selected(object sender, SelectedItemChangedEventArgs e)
    	{
    		var item = e.SelectedItem as MainMenuItem;
    		if (item != null)
    		{
    			if (item.Title.Equals("Page One"))
    			{
    				Detail = new NavigationPage(new PageOne());
    			}
    			else if (item.Title.Equals("Page Two"))
    			{
    				Detail = new NavigationPage(new PageTwo());
    			}

    			MenuListView.SelectedItem = null;
    			IsPresented = false;
    		}
    	}
    }
}

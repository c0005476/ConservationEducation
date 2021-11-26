using System;
using System.Collections.Generic;
using ConservationEducation.ViewModels;
using ConservationEducation.Views;
using Xamarin.Forms;

namespace ConservationEducation
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

using System.ComponentModel;
using Xamarin.Forms;
using ConservationEducation.ViewModels;

namespace ConservationEducation.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ButtonDemo());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ButtonCode());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DatepickerDemo());
            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EditorDemo());
            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync (new EditorDemo());
            };
            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LabelDemo());
            };
            Item7.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EntryCode());
            };
            Item8.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LabelDemo());
            };
            Item9.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LabelCode());
            };
            Item10.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LocalImage());
            };
            Item11.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EmbeddedImage());
            };
        }
    }
}
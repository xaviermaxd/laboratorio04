using System;
using System.ComponentModel.Design;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace laboratorio04 
{     
    public partial class App : Application 
    {
        public App() 
        { 
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
        }
    }
        
}

    
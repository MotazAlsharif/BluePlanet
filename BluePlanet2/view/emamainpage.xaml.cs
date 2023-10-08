using BluePlanet2.view;
using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace BluePlanet2.view;

public partial class emamainpage : ContentPage
{
    
    public emamainpage()
    {
        InitializeComponent();
    }

    private async void OnHawksbillSeaTurtleButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new hawksbillseaturtle());
    }

    private async void OnLeatherbackSeaTurtleButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new leatherbackseaturtle());
    }

    private async void OnDugongButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new dugong());
    }

    private async void OnNapoleonWrasseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Napoleon());
    }

    private async void OnGiantMantaRayButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new giantmantaray());
    }

    private async void OnWhaleSharkButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new whaleshark());
    }

    private async void OnElkhornCoralButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new elkhorncoral());
    }

    private async void OnStaghornCoralButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new staghorncora());
    }

    private async void OnBrainCoralButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new braincoral());
    }

    private async void OnFireCoralButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new fire());
    }

    private async void OnGiantClamButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new giantclam());
    }



}
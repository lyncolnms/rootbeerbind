using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.Scottyab.Rootbeer;

namespace RootBeerBindTest.MAUI;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity {
    protected override void OnCreate(Bundle savedInstanceState) {
        RootBeer rootBeer = new RootBeer(this);



        base.OnCreate(savedInstanceState);
    }
}
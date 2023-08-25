using Com.Scottyab.Rootbeer;

namespace RootBeerBindTest.Android;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity {
    protected override void OnCreate(Bundle? savedInstanceState) {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        RootBeer rootBeer = new RootBeer(this);

        bool isRooted = rootBeer.IsRooted;
    }
}
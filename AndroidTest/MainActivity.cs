using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Com.Esri.Android.Map;
using Com.Esri.Android.Map.Osm;

namespace AndroidTest {

	[Activity(Label = "AndroidTest", MainLauncher = true)]
	public class MainActivity : Activity {

		protected override void OnCreate(Bundle bundle) {
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_main);

			var layout = FindViewById<LinearLayout> (Resource.Id.activity_main_linear_layout);
			MapView mapView = new MapView (this);
			mapView.EnableWrapAround (true);
			mapView.SetEsriLogoVisible (true);
			mapView.LayoutParameters = new ViewGroup.LayoutParams (ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.FillParent);
			layout.AddView (mapView);
			var baseLayer = new OpenStreetMapLayer ();
			baseLayer.Name = "Basemap";
			mapView.AddLayer (baseLayer);
		}
	}
}



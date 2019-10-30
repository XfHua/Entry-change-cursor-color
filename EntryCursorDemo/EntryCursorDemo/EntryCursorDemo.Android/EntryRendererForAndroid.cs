using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EntryCursorDemo;
using EntryCursorDemo.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(EntryRendererForAndroid), new[] { typeof(VisualMarker.MaterialVisual) })]
namespace EntryCursorDemo.Droid
{
    public class EntryRendererForAndroid : MaterialEntryRenderer
    {
        public EntryRendererForAndroid(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {

            base.OnElementChanged(e);
            Control.EditText.SetTextCursorDrawable(Resource.Drawable.my_cursor);

        }
    }
}
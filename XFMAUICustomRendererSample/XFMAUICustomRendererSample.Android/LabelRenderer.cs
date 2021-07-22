using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFMAUICustomRendererSample.Droid;
using LabelRenderer = Xamarin.Forms.Platform.Android.FastRenderers.LabelRenderer;

[assembly: ExportRenderer(typeof(Label), typeof(MyLabelRenderer))]
namespace XFMAUICustomRendererSample.Droid
{

    public class MyLabelRenderer : LabelRenderer
    {
        public MyLabelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}
package md51558244f76c53b6aeda52c8a337f2c37;


public class TimePickerRenderer_TimePickerListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.views.View_IOnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.TimePickerRenderer+TimePickerListener, Xamarin.Forms.Platform.Android", TimePickerRenderer_TimePickerListener.class, __md_methods);
	}


	public TimePickerRenderer_TimePickerListener ()
	{
		super ();
		if (getClass () == TimePickerRenderer_TimePickerListener.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.TimePickerRenderer+TimePickerListener, Xamarin.Forms.Platform.Android", "", this, new java.lang.Object[] {  });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

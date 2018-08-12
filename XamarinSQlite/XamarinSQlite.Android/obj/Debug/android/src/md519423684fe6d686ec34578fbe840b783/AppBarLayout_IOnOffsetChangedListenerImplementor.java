package md519423684fe6d686ec34578fbe840b783;


public class AppBarLayout_IOnOffsetChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		md519423684fe6d686ec34578fbe840b783.AppBarLayout_IOnOffsetChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onOffsetChanged:(Landroid/support/design/widget/AppBarLayout;I)V:GetOnOffsetChanged_Landroid_support_design_widget_AppBarLayout_IHandler:Android.Support.Design.Widget.AppBarLayout/IOnOffsetChangedListenerInvoker, Xamarin.Android.Support.Design\n" +
			"";
		mono.android.Runtime.register ("Android.Support.Design.Widget.AppBarLayout+IOnOffsetChangedListenerImplementor, Xamarin.Android.Support.Design", AppBarLayout_IOnOffsetChangedListenerImplementor.class, __md_methods);
	}


	public AppBarLayout_IOnOffsetChangedListenerImplementor ()
	{
		super ();
		if (getClass () == AppBarLayout_IOnOffsetChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.Design.Widget.AppBarLayout+IOnOffsetChangedListenerImplementor, Xamarin.Android.Support.Design", "", this, new java.lang.Object[] {  });
	}


	public void onOffsetChanged (android.support.design.widget.AppBarLayout p0, int p1)
	{
		n_onOffsetChanged (p0, p1);
	}

	private native void n_onOffsetChanged (android.support.design.widget.AppBarLayout p0, int p1);

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

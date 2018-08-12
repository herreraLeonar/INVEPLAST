package md5241842994fc3d20a4a1b139db0e6010a;


public class IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		md5241842994fc3d20a4a1b139db0e6010a.IFitWindowsViewGroupOnFitSystemWindowsListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFitSystemWindows:(Landroid/graphics/Rect;)V:GetOnFitSystemWindows_Landroid_graphics_Rect_Handler:Android.Support.V7.Widget.IFitWindowsViewGroupOnFitSystemWindowsListenerInvoker, Xamarin.Android.Support.v7.AppCompat\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V7.Widget.IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor, Xamarin.Android.Support.v7.AppCompat", IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor.class, __md_methods);
	}


	public IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor ()
	{
		super ();
		if (getClass () == IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V7.Widget.IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor, Xamarin.Android.Support.v7.AppCompat", "", this, new java.lang.Object[] {  });
	}


	public void onFitSystemWindows (android.graphics.Rect p0)
	{
		n_onFitSystemWindows (p0);
	}

	private native void n_onFitSystemWindows (android.graphics.Rect p0);

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

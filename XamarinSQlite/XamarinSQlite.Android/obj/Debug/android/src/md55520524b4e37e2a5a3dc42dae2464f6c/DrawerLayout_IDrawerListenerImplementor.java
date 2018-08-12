package md55520524b4e37e2a5a3dc42dae2464f6c;


public class DrawerLayout_IDrawerListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		md55520524b4e37e2a5a3dc42dae2464f6c.DrawerLayout_IDrawerListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDrawerClosed:(Landroid/view/View;)V:GetOnDrawerClosed_Landroid_view_View_Handler:Android.Support.V4.Widget.DrawerLayout/IDrawerListenerInvoker, Xamarin.Android.Support.v4\n" +
			"n_onDrawerOpened:(Landroid/view/View;)V:GetOnDrawerOpened_Landroid_view_View_Handler:Android.Support.V4.Widget.DrawerLayout/IDrawerListenerInvoker, Xamarin.Android.Support.v4\n" +
			"n_onDrawerSlide:(Landroid/view/View;F)V:GetOnDrawerSlide_Landroid_view_View_FHandler:Android.Support.V4.Widget.DrawerLayout/IDrawerListenerInvoker, Xamarin.Android.Support.v4\n" +
			"n_onDrawerStateChanged:(I)V:GetOnDrawerStateChanged_IHandler:Android.Support.V4.Widget.DrawerLayout/IDrawerListenerInvoker, Xamarin.Android.Support.v4\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V4.Widget.DrawerLayout+IDrawerListenerImplementor, Xamarin.Android.Support.v4", DrawerLayout_IDrawerListenerImplementor.class, __md_methods);
	}


	public DrawerLayout_IDrawerListenerImplementor ()
	{
		super ();
		if (getClass () == DrawerLayout_IDrawerListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V4.Widget.DrawerLayout+IDrawerListenerImplementor, Xamarin.Android.Support.v4", "", this, new java.lang.Object[] {  });
	}


	public void onDrawerClosed (android.view.View p0)
	{
		n_onDrawerClosed (p0);
	}

	private native void n_onDrawerClosed (android.view.View p0);


	public void onDrawerOpened (android.view.View p0)
	{
		n_onDrawerOpened (p0);
	}

	private native void n_onDrawerOpened (android.view.View p0);


	public void onDrawerSlide (android.view.View p0, float p1)
	{
		n_onDrawerSlide (p0, p1);
	}

	private native void n_onDrawerSlide (android.view.View p0, float p1);


	public void onDrawerStateChanged (int p0)
	{
		n_onDrawerStateChanged (p0);
	}

	private native void n_onDrawerStateChanged (int p0);

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

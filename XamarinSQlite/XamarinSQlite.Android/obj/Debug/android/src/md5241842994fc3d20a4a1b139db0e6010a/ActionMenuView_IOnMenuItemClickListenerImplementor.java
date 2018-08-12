package md5241842994fc3d20a4a1b139db0e6010a;


public class ActionMenuView_IOnMenuItemClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		md5241842994fc3d20a4a1b139db0e6010a.ActionMenuView_IOnMenuItemClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMenuItemClick:(Landroid/view/MenuItem;)Z:GetOnMenuItemClick_Landroid_view_MenuItem_Handler:Android.Support.V7.Widget.ActionMenuView/IOnMenuItemClickListenerInvoker, Xamarin.Android.Support.v7.AppCompat\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V7.Widget.ActionMenuView+IOnMenuItemClickListenerImplementor, Xamarin.Android.Support.v7.AppCompat", ActionMenuView_IOnMenuItemClickListenerImplementor.class, __md_methods);
	}


	public ActionMenuView_IOnMenuItemClickListenerImplementor ()
	{
		super ();
		if (getClass () == ActionMenuView_IOnMenuItemClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V7.Widget.ActionMenuView+IOnMenuItemClickListenerImplementor, Xamarin.Android.Support.v7.AppCompat", "", this, new java.lang.Object[] {  });
	}


	public boolean onMenuItemClick (android.view.MenuItem p0)
	{
		return n_onMenuItemClick (p0);
	}

	private native boolean n_onMenuItemClick (android.view.MenuItem p0);

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

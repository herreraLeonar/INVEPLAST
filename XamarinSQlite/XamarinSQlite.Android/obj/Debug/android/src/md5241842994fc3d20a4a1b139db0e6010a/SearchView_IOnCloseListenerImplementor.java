package md5241842994fc3d20a4a1b139db0e6010a;


public class SearchView_IOnCloseListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		md5241842994fc3d20a4a1b139db0e6010a.SearchView_IOnCloseListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClose:()Z:GetOnCloseHandler:Android.Support.V7.Widget.SearchView/IOnCloseListenerInvoker, Xamarin.Android.Support.v7.AppCompat\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V7.Widget.SearchView+IOnCloseListenerImplementor, Xamarin.Android.Support.v7.AppCompat", SearchView_IOnCloseListenerImplementor.class, __md_methods);
	}


	public SearchView_IOnCloseListenerImplementor ()
	{
		super ();
		if (getClass () == SearchView_IOnCloseListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V7.Widget.SearchView+IOnCloseListenerImplementor, Xamarin.Android.Support.v7.AppCompat", "", this, new java.lang.Object[] {  });
	}


	public boolean onClose ()
	{
		return n_onClose ();
	}

	private native boolean n_onClose ();

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

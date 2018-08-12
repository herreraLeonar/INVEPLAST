package md55520524b4e37e2a5a3dc42dae2464f6c;


public class SwipeRefreshLayout_IOnRefreshListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		md55520524b4e37e2a5a3dc42dae2464f6c.SwipeRefreshLayout_IOnRefreshListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRefresh:()V:GetOnRefreshHandler:Android.Support.V4.Widget.SwipeRefreshLayout/IOnRefreshListenerInvoker, Xamarin.Android.Support.v4\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V4.Widget.SwipeRefreshLayout+IOnRefreshListenerImplementor, Xamarin.Android.Support.v4", SwipeRefreshLayout_IOnRefreshListenerImplementor.class, __md_methods);
	}


	public SwipeRefreshLayout_IOnRefreshListenerImplementor ()
	{
		super ();
		if (getClass () == SwipeRefreshLayout_IOnRefreshListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V4.Widget.SwipeRefreshLayout+IOnRefreshListenerImplementor, Xamarin.Android.Support.v4", "", this, new java.lang.Object[] {  });
	}


	public void onRefresh ()
	{
		n_onRefresh ();
	}

	private native void n_onRefresh ();

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

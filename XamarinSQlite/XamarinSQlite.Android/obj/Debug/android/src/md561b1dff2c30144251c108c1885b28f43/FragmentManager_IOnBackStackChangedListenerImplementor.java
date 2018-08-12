package md561b1dff2c30144251c108c1885b28f43;


public class FragmentManager_IOnBackStackChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		md561b1dff2c30144251c108c1885b28f43.FragmentManager_IOnBackStackChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBackStackChanged:()V:GetOnBackStackChangedHandler:Android.Support.V4.App.FragmentManager/IOnBackStackChangedListenerInvoker, Xamarin.Android.Support.v4\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V4.App.FragmentManager+IOnBackStackChangedListenerImplementor, Xamarin.Android.Support.v4", FragmentManager_IOnBackStackChangedListenerImplementor.class, __md_methods);
	}


	public FragmentManager_IOnBackStackChangedListenerImplementor ()
	{
		super ();
		if (getClass () == FragmentManager_IOnBackStackChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V4.App.FragmentManager+IOnBackStackChangedListenerImplementor, Xamarin.Android.Support.v4", "", this, new java.lang.Object[] {  });
	}


	public void onBackStackChanged ()
	{
		n_onBackStackChanged ();
	}

	private native void n_onBackStackChanged ();

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

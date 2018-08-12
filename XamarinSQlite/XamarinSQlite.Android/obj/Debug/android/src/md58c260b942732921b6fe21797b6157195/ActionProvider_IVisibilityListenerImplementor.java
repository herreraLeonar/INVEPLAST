package md58c260b942732921b6fe21797b6157195;


public class ActionProvider_IVisibilityListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		md58c260b942732921b6fe21797b6157195.ActionProvider_IVisibilityListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onActionProviderVisibilityChanged:(Z)V:GetOnActionProviderVisibilityChanged_ZHandler:Android.Support.V4.View.ActionProvider/IVisibilityListenerInvoker, Xamarin.Android.Support.v4\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V4.View.ActionProvider+IVisibilityListenerImplementor, Xamarin.Android.Support.v4", ActionProvider_IVisibilityListenerImplementor.class, __md_methods);
	}


	public ActionProvider_IVisibilityListenerImplementor ()
	{
		super ();
		if (getClass () == ActionProvider_IVisibilityListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V4.View.ActionProvider+IVisibilityListenerImplementor, Xamarin.Android.Support.v4", "", this, new java.lang.Object[] {  });
	}


	public void onActionProviderVisibilityChanged (boolean p0)
	{
		n_onActionProviderVisibilityChanged (p0);
	}

	private native void n_onActionProviderVisibilityChanged (boolean p0);

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

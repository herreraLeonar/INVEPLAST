package md5241842994fc3d20a4a1b139db0e6010a;


public class SearchView_IOnSuggestionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		md5241842994fc3d20a4a1b139db0e6010a.SearchView_IOnSuggestionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSuggestionClick:(I)Z:GetOnSuggestionClick_IHandler:Android.Support.V7.Widget.SearchView/IOnSuggestionListenerInvoker, Xamarin.Android.Support.v7.AppCompat\n" +
			"n_onSuggestionSelect:(I)Z:GetOnSuggestionSelect_IHandler:Android.Support.V7.Widget.SearchView/IOnSuggestionListenerInvoker, Xamarin.Android.Support.v7.AppCompat\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V7.Widget.SearchView+IOnSuggestionListenerImplementor, Xamarin.Android.Support.v7.AppCompat", SearchView_IOnSuggestionListenerImplementor.class, __md_methods);
	}


	public SearchView_IOnSuggestionListenerImplementor ()
	{
		super ();
		if (getClass () == SearchView_IOnSuggestionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V7.Widget.SearchView+IOnSuggestionListenerImplementor, Xamarin.Android.Support.v7.AppCompat", "", this, new java.lang.Object[] {  });
	}


	public boolean onSuggestionClick (int p0)
	{
		return n_onSuggestionClick (p0);
	}

	private native boolean n_onSuggestionClick (int p0);


	public boolean onSuggestionSelect (int p0)
	{
		return n_onSuggestionSelect (p0);
	}

	private native boolean n_onSuggestionSelect (int p0);

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

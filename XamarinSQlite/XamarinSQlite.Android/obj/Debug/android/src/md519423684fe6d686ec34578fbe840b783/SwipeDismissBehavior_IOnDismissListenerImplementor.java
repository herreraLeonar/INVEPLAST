package md519423684fe6d686ec34578fbe840b783;


public class SwipeDismissBehavior_IOnDismissListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		md519423684fe6d686ec34578fbe840b783.SwipeDismissBehavior_IOnDismissListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDismiss:(Landroid/view/View;)V:GetOnDismiss_Landroid_view_View_Handler:Android.Support.Design.Widget.SwipeDismissBehavior/IOnDismissListenerInvoker, Xamarin.Android.Support.Design\n" +
			"n_onDragStateChanged:(I)V:GetOnDragStateChanged_IHandler:Android.Support.Design.Widget.SwipeDismissBehavior/IOnDismissListenerInvoker, Xamarin.Android.Support.Design\n" +
			"";
		mono.android.Runtime.register ("Android.Support.Design.Widget.SwipeDismissBehavior+IOnDismissListenerImplementor, Xamarin.Android.Support.Design", SwipeDismissBehavior_IOnDismissListenerImplementor.class, __md_methods);
	}


	public SwipeDismissBehavior_IOnDismissListenerImplementor ()
	{
		super ();
		if (getClass () == SwipeDismissBehavior_IOnDismissListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.Design.Widget.SwipeDismissBehavior+IOnDismissListenerImplementor, Xamarin.Android.Support.Design", "", this, new java.lang.Object[] {  });
	}


	public void onDismiss (android.view.View p0)
	{
		n_onDismiss (p0);
	}

	private native void n_onDismiss (android.view.View p0);


	public void onDragStateChanged (int p0)
	{
		n_onDragStateChanged (p0);
	}

	private native void n_onDragStateChanged (int p0);

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

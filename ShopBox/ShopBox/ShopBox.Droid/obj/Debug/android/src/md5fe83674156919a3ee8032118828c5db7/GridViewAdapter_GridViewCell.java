package md5fe83674156919a3ee8032118828c5db7;


public class GridViewAdapter_GridViewCell
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ShopBox.Droid.Renderers.GridViewAdapter+GridViewCell, ShopBox.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GridViewAdapter_GridViewCell.class, __md_methods);
	}


	public GridViewAdapter_GridViewCell (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == GridViewAdapter_GridViewCell.class)
			mono.android.TypeManager.Activate ("ShopBox.Droid.Renderers.GridViewAdapter+GridViewCell, ShopBox.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

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

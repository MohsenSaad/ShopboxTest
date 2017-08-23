package md5fe83674156919a3ee8032118828c5db7;


public class GroupedGridSpanSizeLookup
	extends android.support.v7.widget.GridLayoutManager.SpanSizeLookup
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getSpanSize:(I)I:GetGetSpanSize_IHandler\n" +
			"";
		mono.android.Runtime.register ("ShopBox.Droid.Renderers.GroupedGridSpanSizeLookup, ShopBox.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GroupedGridSpanSizeLookup.class, __md_methods);
	}


	public GroupedGridSpanSizeLookup () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GroupedGridSpanSizeLookup.class)
			mono.android.TypeManager.Activate ("ShopBox.Droid.Renderers.GroupedGridSpanSizeLookup, ShopBox.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public GroupedGridSpanSizeLookup (md5fe83674156919a3ee8032118828c5db7.GridViewAdapter p0, int p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == GroupedGridSpanSizeLookup.class)
			mono.android.TypeManager.Activate ("ShopBox.Droid.Renderers.GroupedGridSpanSizeLookup, ShopBox.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "ShopBox.Droid.Renderers.GridViewAdapter, ShopBox.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public int getSpanSize (int p0)
	{
		return n_getSpanSize (p0);
	}

	private native int n_getSpanSize (int p0);

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

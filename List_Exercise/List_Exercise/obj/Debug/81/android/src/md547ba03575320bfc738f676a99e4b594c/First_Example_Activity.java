package md547ba03575320bfc738f676a99e4b594c;


public class First_Example_Activity
	extends android.app.ListActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("List_Exercise.First_Example_Activity, List_Exercise", First_Example_Activity.class, __md_methods);
	}


	public First_Example_Activity ()
	{
		super ();
		if (getClass () == First_Example_Activity.class)
			mono.android.TypeManager.Activate ("List_Exercise.First_Example_Activity, List_Exercise", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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

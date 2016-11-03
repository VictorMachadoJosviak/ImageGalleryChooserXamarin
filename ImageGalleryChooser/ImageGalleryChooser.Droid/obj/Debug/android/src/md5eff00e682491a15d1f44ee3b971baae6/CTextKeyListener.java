package md5eff00e682491a15d1f44ee3b971baae6;


public class CTextKeyListener
	extends android.text.method.BaseKeyListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getInputType:()I:GetGetInputTypeHandler\n" +
			"n_onKeyDown:(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z:GetOnKeyDown_Landroid_view_View_Landroid_text_Editable_ILandroid_view_KeyEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("CTextKeyListener, Naylah.Xamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CTextKeyListener.class, __md_methods);
	}


	public CTextKeyListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CTextKeyListener.class)
			mono.android.TypeManager.Activate ("CTextKeyListener, Naylah.Xamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public int getInputType ()
	{
		return n_getInputType ();
	}

	private native int n_getInputType ();


	public boolean onKeyDown (android.view.View p0, android.text.Editable p1, int p2, android.view.KeyEvent p3)
	{
		return n_onKeyDown (p0, p1, p2, p3);
	}

	private native boolean n_onKeyDown (android.view.View p0, android.text.Editable p1, int p2, android.view.KeyEvent p3);

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

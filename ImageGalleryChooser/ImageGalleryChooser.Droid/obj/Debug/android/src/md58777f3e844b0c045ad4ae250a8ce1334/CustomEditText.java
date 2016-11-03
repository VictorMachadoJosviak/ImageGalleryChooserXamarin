package md58777f3e844b0c045ad4ae250a8ce1334;


public class CustomEditText
	extends android.widget.EditText
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateInputConnection:(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;:GetOnCreateInputConnection_Landroid_view_inputmethod_EditorInfo_Handler\n" +
			"n_onKeyDown:(ILandroid/view/KeyEvent;)Z:GetOnKeyDown_ILandroid_view_KeyEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Naylah.Xamarin.Android.Extras.CustomEditText, Naylah.Xamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CustomEditText.class, __md_methods);
	}


	public CustomEditText (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == CustomEditText.class)
			mono.android.TypeManager.Activate ("Naylah.Xamarin.Android.Extras.CustomEditText, Naylah.Xamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public CustomEditText (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == CustomEditText.class)
			mono.android.TypeManager.Activate ("Naylah.Xamarin.Android.Extras.CustomEditText, Naylah.Xamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomEditText (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == CustomEditText.class)
			mono.android.TypeManager.Activate ("Naylah.Xamarin.Android.Extras.CustomEditText, Naylah.Xamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomEditText (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3) throws java.lang.Throwable
	{
		super (p0, p1, p2, p3);
		if (getClass () == CustomEditText.class)
			mono.android.TypeManager.Activate ("Naylah.Xamarin.Android.Extras.CustomEditText, Naylah.Xamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public android.view.inputmethod.InputConnection onCreateInputConnection (android.view.inputmethod.EditorInfo p0)
	{
		return n_onCreateInputConnection (p0);
	}

	private native android.view.inputmethod.InputConnection n_onCreateInputConnection (android.view.inputmethod.EditorInfo p0);


	public boolean onKeyDown (int p0, android.view.KeyEvent p1)
	{
		return n_onKeyDown (p0, p1);
	}

	private native boolean n_onKeyDown (int p0, android.view.KeyEvent p1);

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

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Support.V4.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v4.view']/class[@name='ViewTreeObserverCompat']"
	[global::Android.Runtime.Register ("android/support/v4/view/ViewTreeObserverCompat", DoNotGenerateAcw=true)]
	public sealed partial class ViewTreeObserverCompat : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("android/support/v4/view/ViewTreeObserverCompat", typeof (ViewTreeObserverCompat));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal ViewTreeObserverCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.view']/class[@name='ViewTreeObserverCompat']/method[@name='removeOnGlobalLayoutListener' and count(parameter)=2 and parameter[1][@type='android.view.ViewTreeObserver'] and parameter[2][@type='android.view.ViewTreeObserver.OnGlobalLayoutListener']]"
		[Register ("removeOnGlobalLayoutListener", "(Landroid/view/ViewTreeObserver;Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V", "")]
		public static unsafe void RemoveOnGlobalLayoutListener (global::Android.Views.ViewTreeObserver? viewTreeObserver, global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener? victim)
		{
			const string __id = "removeOnGlobalLayoutListener.(Landroid/view/ViewTreeObserver;Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((viewTreeObserver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewTreeObserver).Handle);
				__args [1] = new JniArgumentValue ((victim == null) ? IntPtr.Zero : ((global::Java.Lang.Object) victim).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (viewTreeObserver);
				global::System.GC.KeepAlive (victim);
			}
		}

	}
}

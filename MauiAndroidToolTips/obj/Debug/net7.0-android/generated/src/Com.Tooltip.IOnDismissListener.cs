using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tooltip {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tooltip']/interface[@name='OnDismissListener']"
	[Register ("com/tooltip/OnDismissListener", "", "Com.Tooltip.IOnDismissListenerInvoker")]
	public partial interface IOnDismissListener : global::Android.Widget.PopupWindow.IOnDismissListener {
	}

	[global::Android.Runtime.Register ("com/tooltip/OnDismissListener", DoNotGenerateAcw=true)]
	internal partial class IOnDismissListenerInvoker : global::Java.Lang.Object, IOnDismissListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/tooltip/OnDismissListener", typeof (IOnDismissListenerInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOnDismissListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnDismissListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.tooltip.OnDismissListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnDismissListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onDismiss;
#pragma warning disable 0169
		static Delegate GetOnDismissHandler ()
		{
			if (cb_onDismiss == null)
				cb_onDismiss = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDismiss);
			return cb_onDismiss;
		}

		static void n_OnDismiss (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Tooltip.IOnDismissListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnDismiss ();
		}
#pragma warning restore 0169

		IntPtr id_onDismiss;
		public unsafe void OnDismiss ()
		{
			if (id_onDismiss == IntPtr.Zero)
				id_onDismiss = JNIEnv.GetMethodID (class_ref, "onDismiss", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDismiss);
		}

	}
}

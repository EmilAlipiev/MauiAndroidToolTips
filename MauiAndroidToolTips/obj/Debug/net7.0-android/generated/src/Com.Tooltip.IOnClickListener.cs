using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tooltip {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tooltip']/interface[@name='OnClickListener']"
	[Register ("com/tooltip/OnClickListener", "", "Com.Tooltip.IOnClickListenerInvoker")]
	public partial interface IOnClickListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/interface[@name='OnClickListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='com.tooltip.Tooltip']]"
		[Register ("onClick", "(Lcom/tooltip/Tooltip;)V", "GetOnClick_Lcom_tooltip_Tooltip_Handler:Com.Tooltip.IOnClickListenerInvoker, MauiAndroidToolTips")]
		void OnClick (global::Com.Tooltip.Tooltip p0);

	}

	[global::Android.Runtime.Register ("com/tooltip/OnClickListener", DoNotGenerateAcw=true)]
	internal partial class IOnClickListenerInvoker : global::Java.Lang.Object, IOnClickListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/tooltip/OnClickListener", typeof (IOnClickListenerInvoker));

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

		public static IOnClickListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.tooltip.OnClickListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onClick_Lcom_tooltip_Tooltip_;
#pragma warning disable 0169
		static Delegate GetOnClick_Lcom_tooltip_Tooltip_Handler ()
		{
			if (cb_onClick_Lcom_tooltip_Tooltip_ == null)
				cb_onClick_Lcom_tooltip_Tooltip_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnClick_Lcom_tooltip_Tooltip_);
			return cb_onClick_Lcom_tooltip_Tooltip_;
		}

		static void n_OnClick_Lcom_tooltip_Tooltip_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Tooltip.IOnClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0!);
		}
#pragma warning restore 0169

		IntPtr id_onClick_Lcom_tooltip_Tooltip_;
		public unsafe void OnClick (global::Com.Tooltip.Tooltip p0)
		{
			if (id_onClick_Lcom_tooltip_Tooltip_ == IntPtr.Zero)
				id_onClick_Lcom_tooltip_Tooltip_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Lcom/tooltip/Tooltip;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Lcom_tooltip_Tooltip_, __args);
		}

	}

	// event args for com.tooltip.OnClickListener.onClick
	public partial class ClickEventArgs : global::System.EventArgs {
		public ClickEventArgs (global::Com.Tooltip.Tooltip p0)
		{
			this.p0 = p0;
		}

		global::Com.Tooltip.Tooltip p0;

		public global::Com.Tooltip.Tooltip P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/tooltip/OnClickListenerImplementor")]
	internal sealed partial class IOnClickListenerImplementor : global::Java.Lang.Object, IOnClickListener {

		object sender;

		public IOnClickListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tooltip/OnClickListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<ClickEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnClick (global::Com.Tooltip.Tooltip p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ClickEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnClickListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}

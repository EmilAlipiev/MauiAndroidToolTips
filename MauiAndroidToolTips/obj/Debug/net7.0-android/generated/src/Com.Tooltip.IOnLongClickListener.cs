using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tooltip {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tooltip']/interface[@name='OnLongClickListener']"
	[Register ("com/tooltip/OnLongClickListener", "", "Com.Tooltip.IOnLongClickListenerInvoker")]
	public partial interface IOnLongClickListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/interface[@name='OnLongClickListener']/method[@name='onLongClick' and count(parameter)=1 and parameter[1][@type='com.tooltip.Tooltip']]"
		[Register ("onLongClick", "(Lcom/tooltip/Tooltip;)Z", "GetOnLongClick_Lcom_tooltip_Tooltip_Handler:Com.Tooltip.IOnLongClickListenerInvoker, MauiAndroidToolTips")]
		bool OnLongClick (global::Com.Tooltip.Tooltip p0);

	}

	[global::Android.Runtime.Register ("com/tooltip/OnLongClickListener", DoNotGenerateAcw=true)]
	internal partial class IOnLongClickListenerInvoker : global::Java.Lang.Object, IOnLongClickListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/tooltip/OnLongClickListener", typeof (IOnLongClickListenerInvoker));

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

		public static IOnLongClickListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnLongClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.tooltip.OnLongClickListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onLongClick_Lcom_tooltip_Tooltip_;
#pragma warning disable 0169
		static Delegate GetOnLongClick_Lcom_tooltip_Tooltip_Handler ()
		{
			if (cb_onLongClick_Lcom_tooltip_Tooltip_ == null)
				cb_onLongClick_Lcom_tooltip_Tooltip_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_OnLongClick_Lcom_tooltip_Tooltip_);
			return cb_onLongClick_Lcom_tooltip_Tooltip_;
		}

		static bool n_OnLongClick_Lcom_tooltip_Tooltip_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Tooltip.IOnLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnLongClick (p0!);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onLongClick_Lcom_tooltip_Tooltip_;
		public unsafe bool OnLongClick (global::Com.Tooltip.Tooltip p0)
		{
			if (id_onLongClick_Lcom_tooltip_Tooltip_ == IntPtr.Zero)
				id_onLongClick_Lcom_tooltip_Tooltip_ = JNIEnv.GetMethodID (class_ref, "onLongClick", "(Lcom/tooltip/Tooltip;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onLongClick_Lcom_tooltip_Tooltip_, __args);
			return __ret;
		}

	}

	// event args for com.tooltip.OnLongClickListener.onLongClick
	public partial class LongClickEventArgs : global::System.EventArgs {
		bool handled;

		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		public LongClickEventArgs (bool handled, global::Com.Tooltip.Tooltip p0)
		{
			this.handled = handled;
			this.p0 = p0;
		}

		global::Com.Tooltip.Tooltip p0;

		public global::Com.Tooltip.Tooltip P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/tooltip/OnLongClickListenerImplementor")]
	internal sealed partial class IOnLongClickListenerImplementor : global::Java.Lang.Object, IOnLongClickListener {

		object sender;

		public IOnLongClickListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tooltip/OnLongClickListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<LongClickEventArgs>? Handler;
		#pragma warning restore 0649

		public bool OnLongClick (global::Com.Tooltip.Tooltip p0)
		{
			var __h = Handler;
			if (__h == null)
				return false;
			var __e = new LongClickEventArgs (true, p0);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IOnLongClickListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}

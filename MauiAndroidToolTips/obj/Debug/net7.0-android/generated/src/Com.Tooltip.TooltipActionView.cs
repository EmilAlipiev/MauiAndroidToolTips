using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tooltip {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tooltip']/class[@name='TooltipActionView']"
	[global::Android.Runtime.Register ("com/tooltip/TooltipActionView", DoNotGenerateAcw=true)]
	public partial class TooltipActionView : global::Android.Widget.FrameLayout {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/tooltip/TooltipActionView", typeof (TooltipActionView));

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

		protected TooltipActionView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tooltip']/class[@name='TooltipActionView']/constructor[@name='TooltipActionView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TooltipActionView (global::Android.Content.Context? context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tooltip']/class[@name='TooltipActionView']/constructor[@name='TooltipActionView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe TooltipActionView (global::Android.Content.Context? context, global::Android.Util.IAttributeSet? attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tooltip']/class[@name='TooltipActionView']/constructor[@name='TooltipActionView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe TooltipActionView (global::Android.Content.Context? context, global::Android.Util.IAttributeSet? attrs, int defStyleAttr) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate? cb_getMenuItem;
#pragma warning disable 0169
		static Delegate GetGetMenuItemHandler ()
		{
			if (cb_getMenuItem == null)
				cb_getMenuItem = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMenuItem);
			return cb_getMenuItem;
		}

		static IntPtr n_GetMenuItem (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Tooltip.TooltipActionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.MenuItem);
		}
#pragma warning restore 0169

		static Delegate? cb_setMenuItem_Landroid_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetSetMenuItem_Landroid_view_MenuItem_Handler ()
		{
			if (cb_setMenuItem_Landroid_view_MenuItem_ == null)
				cb_setMenuItem_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMenuItem_Landroid_view_MenuItem_);
			return cb_setMenuItem_Landroid_view_MenuItem_;
		}

		static void n_SetMenuItem_Landroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_menuItem)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Tooltip.TooltipActionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var menuItem = (global::Android.Views.IMenuItem?)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_menuItem, JniHandleOwnership.DoNotTransfer);
			__this.MenuItem = menuItem!;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.IMenuItem? MenuItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='TooltipActionView']/method[@name='getMenuItem' and count(parameter)=0]"
			[Register ("getMenuItem", "()Landroid/view/MenuItem;", "GetGetMenuItemHandler")]
			get {
				const string __id = "getMenuItem.()Landroid/view/MenuItem;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='TooltipActionView']/method[@name='setMenuItem' and count(parameter)=1 and parameter[1][@type='android.view.MenuItem']]"
			[Register ("setMenuItem", "(Landroid/view/MenuItem;)V", "GetSetMenuItem_Landroid_view_MenuItem_Handler")]
			set {
				const string __id = "setMenuItem.(Landroid/view/MenuItem;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_setOnMenuItemClick_Landroid_view_MenuItem_OnMenuItemClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMenuItemClick_Landroid_view_MenuItem_OnMenuItemClickListener_Handler ()
		{
			if (cb_setOnMenuItemClick_Landroid_view_MenuItem_OnMenuItemClickListener_ == null)
				cb_setOnMenuItemClick_Landroid_view_MenuItem_OnMenuItemClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnMenuItemClick_Landroid_view_MenuItem_OnMenuItemClickListener_);
			return cb_setOnMenuItemClick_Landroid_view_MenuItem_OnMenuItemClickListener_;
		}

		static void n_SetOnMenuItemClick_Landroid_view_MenuItem_OnMenuItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Tooltip.TooltipActionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var l = (global::Android.Views.IMenuItemOnMenuItemClickListener?)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItemOnMenuItemClickListener> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMenuItemClick (l);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='TooltipActionView']/method[@name='setOnMenuItemClick' and count(parameter)=1 and parameter[1][@type='android.view.MenuItem.OnMenuItemClickListener']]"
		[Register ("setOnMenuItemClick", "(Landroid/view/MenuItem$OnMenuItemClickListener;)V", "GetSetOnMenuItemClick_Landroid_view_MenuItem_OnMenuItemClickListener_Handler")]
		public virtual unsafe void SetOnMenuItemClick (global::Android.Views.IMenuItemOnMenuItemClickListener? l)
		{
			const string __id = "setOnMenuItemClick.(Landroid/view/MenuItem$OnMenuItemClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((l == null) ? IntPtr.Zero : ((global::Java.Lang.Object) l).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (l);
			}
		}

		static Delegate? cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool visible)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Tooltip.TooltipActionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetVisible (visible);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='TooltipActionView']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
		public virtual unsafe void SetVisible (bool visible)
		{
			const string __id = "setVisible.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (visible);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}

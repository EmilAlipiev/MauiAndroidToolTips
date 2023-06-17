using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tooltip {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip']"
	[global::Android.Runtime.Register ("com/tooltip/Tooltip", DoNotGenerateAcw=true)]
	public sealed partial class Tooltip : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']"
		[global::Android.Runtime.Register ("com/tooltip/Tooltip$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/tooltip/Tooltip$Builder", typeof (Builder));

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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/constructor[@name='Tooltip.Builder' and count(parameter)=1 and parameter[1][@type='android.view.MenuItem']]"
			[Register (".ctor", "(Landroid/view/MenuItem;)V", "")]
			public unsafe Builder (global::Android.Views.IMenuItem anchorMenuItem) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/MenuItem;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((anchorMenuItem == null) ? IntPtr.Zero : ((global::Java.Lang.Object) anchorMenuItem).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (anchorMenuItem);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/constructor[@name='Tooltip.Builder' and count(parameter)=2 and parameter[1][@type='android.view.MenuItem'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Landroid/view/MenuItem;I)V", "")]
			public unsafe Builder (global::Android.Views.IMenuItem anchorMenuItem, int resId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/MenuItem;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((anchorMenuItem == null) ? IntPtr.Zero : ((global::Java.Lang.Object) anchorMenuItem).Handle);
					__args [1] = new JniArgumentValue (resId);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (anchorMenuItem);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/constructor[@name='Tooltip.Builder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register (".ctor", "(Landroid/view/View;)V", "")]
			public unsafe Builder (global::Android.Views.View anchorView) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/View;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((anchorView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) anchorView).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (anchorView);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/constructor[@name='Tooltip.Builder' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Landroid/view/View;I)V", "")]
			public unsafe Builder (global::Android.Views.View anchorView, int resId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/View;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((anchorView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) anchorView).Handle);
					__args [1] = new JniArgumentValue (resId);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (anchorView);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/tooltip/Tooltip;", "")]
			public unsafe global::Com.Tooltip.Tooltip? Build ()
			{
				const string __id = "build.()Lcom/tooltip/Tooltip;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setArrow' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setArrow", "(Landroid/graphics/drawable/Drawable;)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetArrow (global::Android.Graphics.Drawables.Drawable? arrowDrawable)
			{
				const string __id = "setArrow.(Landroid/graphics/drawable/Drawable;)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((arrowDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arrowDrawable).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (arrowDrawable);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setArrow' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setArrow", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetArrow (int resId)
			{
				const string __id = "setArrow.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setArrowEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setArrowEnabled", "(Z)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetArrowEnabled (bool isArrowEnabled)
			{
				const string __id = "setArrowEnabled.(Z)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isArrowEnabled);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setArrowHeight' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setArrowHeight", "(F)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetArrowHeight (float height)
			{
				const string __id = "setArrowHeight.(F)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (height);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setArrowHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setArrowHeight", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetArrowHeight (int resId)
			{
				const string __id = "setArrowHeight.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setArrowWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setArrowWidth", "(F)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetArrowWidth (float width)
			{
				const string __id = "setArrowWidth.(F)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (width);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setArrowWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setArrowWidth", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetArrowWidth (int resId)
			{
				const string __id = "setArrowWidth.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBackgroundColor", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetBackgroundColor (int color)
			{
				const string __id = "setBackgroundColor.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (color);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setCancelable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCancelable", "(Z)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetCancelable (bool cancelable)
			{
				const string __id = "setCancelable.(Z)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (cancelable);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setCornerRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setCornerRadius", "(F)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetCornerRadius (float radius)
			{
				const string __id = "setCornerRadius.(F)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (radius);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setCornerRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCornerRadius", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetCornerRadius (int resId)
			{
				const string __id = "setCornerRadius.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setDismissOnClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDismissOnClick", "(Z)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetDismissOnClick (bool isDismissOnClick)
			{
				const string __id = "setDismissOnClick.(Z)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isDismissOnClick);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setDrawableBottom' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setDrawableBottom", "(Landroid/graphics/drawable/Drawable;)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetDrawableBottom (global::Android.Graphics.Drawables.Drawable? drawable)
			{
				const string __id = "setDrawableBottom.(Landroid/graphics/drawable/Drawable;)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (drawable);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setDrawableBottom' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDrawableBottom", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetDrawableBottom (int resId)
			{
				const string __id = "setDrawableBottom.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setDrawableEnd' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setDrawableEnd", "(Landroid/graphics/drawable/Drawable;)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetDrawableEnd (global::Android.Graphics.Drawables.Drawable? drawable)
			{
				const string __id = "setDrawableEnd.(Landroid/graphics/drawable/Drawable;)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (drawable);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setDrawableEnd' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDrawableEnd", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetDrawableEnd (int resId)
			{
				const string __id = "setDrawableEnd.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setDrawablePadding' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDrawablePadding", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetDrawablePadding (int padding)
			{
				const string __id = "setDrawablePadding.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (padding);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setDrawableStart' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setDrawableStart", "(Landroid/graphics/drawable/Drawable;)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetDrawableStart (global::Android.Graphics.Drawables.Drawable? drawable)
			{
				const string __id = "setDrawableStart.(Landroid/graphics/drawable/Drawable;)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (drawable);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setDrawableStart' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDrawableStart", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetDrawableStart (int resId)
			{
				const string __id = "setDrawableStart.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setDrawableTop' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setDrawableTop", "(Landroid/graphics/drawable/Drawable;)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetDrawableTop (global::Android.Graphics.Drawables.Drawable? drawable)
			{
				const string __id = "setDrawableTop.(Landroid/graphics/drawable/Drawable;)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (drawable);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setDrawableTop' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDrawableTop", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetDrawableTop (int resId)
			{
				const string __id = "setDrawableTop.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setGravity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setGravity", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetGravity (int gravity)
			{
				const string __id = "setGravity.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (gravity);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setLineSpacing' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
			[Register ("setLineSpacing", "(FF)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetLineSpacing (float add, float mult)
			{
				const string __id = "setLineSpacing.(FF)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (add);
					__args [1] = new JniArgumentValue (mult);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setLineSpacing' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
			[Register ("setLineSpacing", "(IF)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetLineSpacing (int addResId, float mult)
			{
				const string __id = "setLineSpacing.(IF)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (addResId);
					__args [1] = new JniArgumentValue (mult);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMargin", "(F)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetMargin (float margin)
			{
				const string __id = "setMargin.(F)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (margin);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setMargin' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMargin", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetMargin (int resId)
			{
				const string __id = "setMargin.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setMaxWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxWidth", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetMaxWidth (int maxWidth)
			{
				const string __id = "setMaxWidth.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (maxWidth);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setOnClickListener' and count(parameter)=1 and parameter[1][@type='com.tooltip.OnClickListener']]"
			[Register ("setOnClickListener", "(Lcom/tooltip/OnClickListener;)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetOnClickListener (global::Com.Tooltip.IOnClickListener? listener)
			{
				const string __id = "setOnClickListener.(Lcom/tooltip/OnClickListener;)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setOnDismissListener' and count(parameter)=1 and parameter[1][@type='com.tooltip.OnDismissListener']]"
			[Register ("setOnDismissListener", "(Lcom/tooltip/OnDismissListener;)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetOnDismissListener (global::Com.Tooltip.IOnDismissListener? listener)
			{
				const string __id = "setOnDismissListener.(Lcom/tooltip/OnDismissListener;)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setOnLongClickListener' and count(parameter)=1 and parameter[1][@type='com.tooltip.OnLongClickListener']]"
			[Register ("setOnLongClickListener", "(Lcom/tooltip/OnLongClickListener;)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetOnLongClickListener (global::Com.Tooltip.IOnLongClickListener? listener)
			{
				const string __id = "setOnLongClickListener.(Lcom/tooltip/OnLongClickListener;)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[global::System.Obsolete (@"deprecated")]
			[Register ("setPadding", "(F)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetPadding (float padding)
			{
				const string __id = "setPadding.(F)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (padding);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPadding", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetPadding (int padding)
			{
				const string __id = "setPadding.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (padding);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setText", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetText (int resId)
			{
				const string __id = "setText.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setText", "(Ljava/lang/CharSequence;)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetText (global::Java.Lang.ICharSequence? text)
			{
				const string __id = "setText.(Ljava/lang/CharSequence;)Lcom/tooltip/Tooltip$Builder;";
				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_text);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (text);
				}
			}

			public global::Com.Tooltip.Tooltip.Builder? SetText (string? text)
			{
				var jls_text = text == null ? null : new global::Java.Lang.String (text);
				global::Com.Tooltip.Tooltip.Builder? __result = SetText (jls_text);
				var __rsval = __result;
				jls_text?.Dispose ();
				return __rsval;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setTextAppearance' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextAppearance", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetTextAppearance (int resId)
			{
				const string __id = "setTextAppearance.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextColor", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetTextColor (int color)
			{
				const string __id = "setTextColor.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (color);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTextSize", "(F)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetTextSize (float size)
			{
				const string __id = "setTextSize.(F)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (size);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextSize", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetTextSize (int resId)
			{
				const string __id = "setTextSize.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setTextStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextStyle", "(I)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetTextStyle (int style)
			{
				const string __id = "setTextStyle.(I)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (style);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='setTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setTypeface", "(Landroid/graphics/Typeface;)Lcom/tooltip/Tooltip$Builder;", "")]
			public unsafe global::Com.Tooltip.Tooltip.Builder? SetTypeface (global::Android.Graphics.Typeface? typeface)
			{
				const string __id = "setTypeface.(Landroid/graphics/Typeface;)Lcom/tooltip/Tooltip$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (typeface);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip.Builder']/method[@name='show' and count(parameter)=0]"
			[Register ("show", "()Lcom/tooltip/Tooltip;", "")]
			public unsafe global::Com.Tooltip.Tooltip? Show ()
			{
				const string __id = "show.()Lcom/tooltip/Tooltip;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tooltip.Tooltip> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/tooltip/Tooltip", typeof (Tooltip));

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

		internal Tooltip (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe bool IsShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip']/method[@name='isShowing' and count(parameter)=0]"
			[Register ("isShowing", "()Z", "")]
			get {
				const string __id = "isShowing.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip']/method[@name='dismiss' and count(parameter)=0]"
		[Register ("dismiss", "()V", "")]
		public unsafe void Dismiss ()
		{
			const string __id = "dismiss.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip']/method[@name='setOnClickListener' and count(parameter)=1 and parameter[1][@type='com.tooltip.OnClickListener']]"
		[Register ("setOnClickListener", "(Lcom/tooltip/OnClickListener;)V", "")]
		public unsafe void SetOnClickListener (global::Com.Tooltip.IOnClickListener? listener)
		{
			const string __id = "setOnClickListener.(Lcom/tooltip/OnClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip']/method[@name='setOnDismissListener' and count(parameter)=1 and parameter[1][@type='com.tooltip.OnDismissListener']]"
		[Register ("setOnDismissListener", "(Lcom/tooltip/OnDismissListener;)V", "")]
		public unsafe void SetOnDismissListener (global::Com.Tooltip.IOnDismissListener? listener)
		{
			const string __id = "setOnDismissListener.(Lcom/tooltip/OnDismissListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip']/method[@name='setOnLongClickListener' and count(parameter)=1 and parameter[1][@type='com.tooltip.OnLongClickListener']]"
		[Register ("setOnLongClickListener", "(Lcom/tooltip/OnLongClickListener;)V", "")]
		public unsafe void SetOnLongClickListener (global::Com.Tooltip.IOnLongClickListener? listener)
		{
			const string __id = "setOnLongClickListener.(Lcom/tooltip/OnLongClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tooltip']/class[@name='Tooltip']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "")]
		public unsafe void Show ()
		{
			const string __id = "show.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		#region "Event implementation for Com.Tooltip.IOnClickListener"

		public event EventHandler<global::Com.Tooltip.ClickEventArgs> Click {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tooltip.IOnClickListener, global::Com.Tooltip.IOnClickListenerImplementor>(
				ref weak_implementor_SetOnClickListener,
				__CreateIOnClickListenerImplementor,
				SetOnClickListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tooltip.IOnClickListener, global::Com.Tooltip.IOnClickListenerImplementor>(
				ref weak_implementor_SetOnClickListener,
				global::Com.Tooltip.IOnClickListenerImplementor.__IsEmpty,
				__v => SetOnClickListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnClickListener;

		global::Com.Tooltip.IOnClickListenerImplementor __CreateIOnClickListenerImplementor ()
		{
			return new global::Com.Tooltip.IOnClickListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Tooltip.IOnLongClickListener"

		public event EventHandler<global::Com.Tooltip.LongClickEventArgs> LongClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tooltip.IOnLongClickListener, global::Com.Tooltip.IOnLongClickListenerImplementor>(
				ref weak_implementor_SetOnLongClickListener,
				__CreateIOnLongClickListenerImplementor,
				SetOnLongClickListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tooltip.IOnLongClickListener, global::Com.Tooltip.IOnLongClickListenerImplementor>(
				ref weak_implementor_SetOnLongClickListener,
				global::Com.Tooltip.IOnLongClickListenerImplementor.__IsEmpty,
				__v => SetOnLongClickListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnLongClickListener;

		global::Com.Tooltip.IOnLongClickListenerImplementor __CreateIOnLongClickListenerImplementor ()
		{
			return new global::Com.Tooltip.IOnLongClickListenerImplementor (this);
		}

		#endregion

	}
}

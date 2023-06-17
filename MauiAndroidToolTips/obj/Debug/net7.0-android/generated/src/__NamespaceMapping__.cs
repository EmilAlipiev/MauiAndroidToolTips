using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "android.support.v4.view", Managed="Android.Support.V4.View")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.tooltip", Managed="Com.Tooltip")]

delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif


using System;

namespace UnrealEngine{
    public partial class UClass
    {
        public static implicit operator UClass(IntPtr p)
        {
            if (p == IntPtr.Zero)
                return null;
            return new UClass() { _this = p };
        }
    }
}
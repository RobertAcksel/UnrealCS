using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FString
    {
        public FScriptArray Data;

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private static extern string ToString(ref FString str);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern FString FromString(string ret);

        public override string ToString()
        {
            return FString.ToString(ref this);
        }

        public static implicit operator FString(string str)
        {
            return FString.FromString(str);
        }

        public static implicit operator string(FString str)
        {
            return str.ToString();
        }
    }
}

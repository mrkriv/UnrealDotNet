using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public class PropertyConvert
    {
        public static bool CanEditPropertyInEditor(PropertyInfo p)
        {
            return p.CanWrite;
        }

        public static bool FilterPropertyForEditor(PropertyInfo p)
        {
            var attribute1 = p.GetCustomAttribute<EditAnywhereAttribute>();
            var attribute2 = p.GetCustomAttribute<EditDefaultsOnlyAttribute>();

            var isBlueprint = attribute1 != null || attribute2 != null;
            var isPrimitive = Type.GetTypeCode(p.PropertyType) != TypeCode.Object;

            return isPrimitive && isBlueprint;
        }

        public static object ParceObjectFromByteStream(Type type, BinaryReader br)
        {
            if (type.IsEnum)
            {
                type = type.GetEnumUnderlyingType();
            }

            if (type == typeof(IntPtr))
            {
                return Marshal.SizeOf<IntPtr>() == Marshal.SizeOf<Int32>()
                    ? (IntPtr)br.ReadInt32()
                    : (IntPtr)br.ReadInt64();
            }
            if (type.IsPrimitive)
            {
                return ParcePrimitiveObject(type, br);
            }
            if (type.IsValueType)
            {
                var data = br.ReadBytes(Marshal.SizeOf(type));
                return ByteArrayToStructure(data, type);
            }

            return null;
        }

        private static object ByteArrayToStructure(IEnumerable bytes, Type type)
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return Marshal.PtrToStructure(handle.AddrOfPinnedObject(), type);
            }
            finally
            {
                handle.Free();
            }
        }

        private static object ParcePrimitiveObject(Type type, BinaryReader br)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.String:
                    return br.ReadString();

                case TypeCode.Boolean:
                    return br.ReadBoolean();

                case TypeCode.Single:
                    return br.ReadSingle();

                case TypeCode.Byte:
                    return br.ReadByte();

                case TypeCode.Char:
                    return br.ReadChar();

                case TypeCode.Int16:
                    return br.ReadInt16();

                case TypeCode.Int32:
                    return br.ReadInt32();

                case TypeCode.Int64:
                    return br.ReadInt64();

                case TypeCode.Double:
                    return br.ReadDouble();

                default:
                    return null;
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    internal class TArrayExtern
    {
        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr E_TArray_Create();

        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int E_TArray_Num(IntPtr arrayPtr);

        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr E_TArray_Get(IntPtr arrayPtr, int index);

        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr E_TArray_Set(IntPtr arrayPtr, int index, IntPtr value);

        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr E_TArray_Remove(IntPtr arrayPtr, int index);

        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr E_TArray_Add(IntPtr arrayPtr, IntPtr value);

        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void E_TArray_Reset(IntPtr arrayPtr);

    }

    public class TArray<T> : NativeWrapper, IList<T>
    {

        public TArray(IntPtr adress) : base(adress)
        {
        }

        public T this[int index] 
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int Count => TArrayExtern.E_TArray_Num(NativePointer);
        public bool IsReadOnly => false;

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            TArrayExtern.E_TArray_Reset(NativePointer);
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            TArrayExtern.E_TArray_Remove(NativePointer, index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static implicit operator IntPtr(TArray<T> self)
        {
            return self.NativePointer;
        }

        public static implicit operator TArray<T>(TemplatePointerDescription desc)
        {
            return desc.Pointer == IntPtr.Zero ? null : new TArray<T>(desc.Pointer);
        }
    }
}
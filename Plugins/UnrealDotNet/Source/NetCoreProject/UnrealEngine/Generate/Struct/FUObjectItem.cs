using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Single item in the UObject array.
	/// </summary>
	public partial class FUObjectItem
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FUObjectItem()
		{
			NativePointer = E_CreateStruct_FUObjectItem();
			IsRef = false;
		}

		internal FUObjectItem(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FUObjectItem();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern UObjectBase E_PROP_FUObjectItem_Object_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FUObjectItem_Object_SET(IntPtr Ptr, UObjectBase Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FUObjectItem_Flags_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FUObjectItem_Flags_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FUObjectItem_ClusterRootIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FUObjectItem_ClusterRootIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FUObjectItem_SerialNumber_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FUObjectItem_SerialNumber_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FUObjectItem_SetOwnerIndex(FUObjectItem Self, int OwnerIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_FUObjectItem_GetOwnerIndex(FUObjectItem Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FUObjectItem_SetUnreachable(FUObjectItem Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FUObjectItem_IsUnreachable(FUObjectItem Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FUObjectItem_ThisThreadAtomicallyClearedRFUnreachable(FUObjectItem Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Single item in the UObject array.
		/// </summary>
		public UObjectBase Object
		{
			get => E_PROP_FUObjectItem_Object_GET(NativePointer);
			set => E_PROP_FUObjectItem_Object_SET(NativePointer, value);
		}

		public int Flags
		{
			get => E_PROP_FUObjectItem_Flags_GET(NativePointer);
			set => E_PROP_FUObjectItem_Flags_SET(NativePointer, value);
		}

		public int ClusterRootIndex
		{
			get => E_PROP_FUObjectItem_ClusterRootIndex_GET(NativePointer);
			set => E_PROP_FUObjectItem_ClusterRootIndex_SET(NativePointer, value);
		}

		public int SerialNumber
		{
			get => E_PROP_FUObjectItem_SerialNumber_GET(NativePointer);
			set => E_PROP_FUObjectItem_SerialNumber_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void SetOwnerIndex(int OwnerIndex)
			=> E_FUObjectItem_SetOwnerIndex(this, OwnerIndex);
		
		public int GetOwnerIndex()
			=> E_FUObjectItem_GetOwnerIndex(this);
		
		public void SetUnreachable()
			=> E_FUObjectItem_SetUnreachable(this);
		
		public bool IsUnreachable()
			=> E_FUObjectItem_IsUnreachable(this);
		
		public bool ThisThreadAtomicallyClearedRFUnreachable()
			=> E_FUObjectItem_ThisThreadAtomicallyClearedRFUnreachable(this);
		
		#endregion
		
		public static implicit operator IntPtr(FUObjectItem Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FUObjectItem(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FUObjectItem(Adress, false);
		}}}

using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Serialized ULevel information about dynamic texture instances
	/// </summary>
	public partial class FDynamicTextureInstance : FStreamableTextureInstance
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FDynamicTextureInstance()
		{
			NativePointer = E_CreateStruct_FDynamicTextureInstance();
			IsRef = false;
		}

		internal FDynamicTextureInstance(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FDynamicTextureInstance();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FDynamicTextureInstance_bAttached_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FDynamicTextureInstance_bAttached_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FDynamicTextureInstance_OriginalRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FDynamicTextureInstance_OriginalRadius_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public bool bAttached
		{
			get => E_PROP_FDynamicTextureInstance_bAttached_GET(NativePointer);
			set => E_PROP_FDynamicTextureInstance_bAttached_SET(NativePointer, value);
		}

		public float OriginalRadius
		{
			get => E_PROP_FDynamicTextureInstance_OriginalRadius_GET(NativePointer);
			set => E_PROP_FDynamicTextureInstance_OriginalRadius_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDynamicTextureInstance Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDynamicTextureInstance(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDynamicTextureInstance(Adress, false);
		}}}

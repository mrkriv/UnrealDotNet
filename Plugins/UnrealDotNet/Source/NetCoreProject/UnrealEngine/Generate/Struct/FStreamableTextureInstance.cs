using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Structure containing all information needed for determining the screen space
	/// size of an object/ texture instance.
	/// </summary>
	public partial class FStreamableTextureInstance
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FStreamableTextureInstance()
		{
			NativePointer = E_CreateStruct_FStreamableTextureInstance();
			IsRef = false;
		}

		internal FStreamableTextureInstance(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FStreamableTextureInstance();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FStreamableTextureInstance_MinDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FStreamableTextureInstance_MinDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FStreamableTextureInstance_MaxDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FStreamableTextureInstance_MaxDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FStreamableTextureInstance_TexelFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FStreamableTextureInstance_TexelFactor_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Min distance from view where this instance is usable
		/// </summary>
		public float MinDistance
		{
			get => E_PROP_FStreamableTextureInstance_MinDistance_GET(NativePointer);
			set => E_PROP_FStreamableTextureInstance_MinDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance from view where this instance is usable
		/// </summary>
		public float MaxDistance
		{
			get => E_PROP_FStreamableTextureInstance_MaxDistance_GET(NativePointer);
			set => E_PROP_FStreamableTextureInstance_MaxDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Object (and bounding sphere) specific texel scale factor
		/// </summary>
		public float TexelFactor
		{
			get => E_PROP_FStreamableTextureInstance_TexelFactor_GET(NativePointer);
			set => E_PROP_FStreamableTextureInstance_TexelFactor_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FStreamableTextureInstance Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FStreamableTextureInstance(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStreamableTextureInstance(Adress, false);
		}}}

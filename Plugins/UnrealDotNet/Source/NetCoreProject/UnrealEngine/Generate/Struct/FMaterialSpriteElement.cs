using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FMaterialSpriteElement
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FMaterialSpriteElement()
		{
			NativePointer = E_CreateStruct_FMaterialSpriteElement();
			IsRef = false;
		}

		internal FMaterialSpriteElement(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FMaterialSpriteElement();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FMaterialSpriteElement_BaseSizeX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FMaterialSpriteElement_BaseSizeX_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FMaterialSpriteElement_BaseSizeY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FMaterialSpriteElement_BaseSizeY_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The base width of the sprite, multiplied with the DistanceToSizeCurve.
		/// </summary>
		public float BaseSizeX
		{
			get => E_PROP_FMaterialSpriteElement_BaseSizeX_GET(NativePointer);
			set => E_PROP_FMaterialSpriteElement_BaseSizeX_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The base height of the sprite, multiplied with the DistanceToSizeCurve.
		/// </summary>
		public float BaseSizeY
		{
			get => E_PROP_FMaterialSpriteElement_BaseSizeY_GET(NativePointer);
			set => E_PROP_FMaterialSpriteElement_BaseSizeY_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FMaterialSpriteElement Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FMaterialSpriteElement(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FMaterialSpriteElement(Adress, false);
		}}}

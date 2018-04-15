using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:70

namespace UnrealEngine
{
	public  partial class FSpriteCategoryInfo : NativeStructWrapper
	{
		internal FSpriteCategoryInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSpriteCategoryInfo() :
			base(E_CreateStruct_FSpriteCategoryInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSpriteCategoryInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FSpriteCategoryInfo_Category_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSpriteCategoryInfo_Category_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FSpriteCategoryInfo_Description_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSpriteCategoryInfo_Description_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FSpriteCategoryInfo_DisplayName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSpriteCategoryInfo_DisplayName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string Category
		{
			get => E_PROP_FSpriteCategoryInfo_Category_GET(NativePointer);
			set => E_PROP_FSpriteCategoryInfo_Category_SET(NativePointer, value);
		}

		public string Description
		{
			get => E_PROP_FSpriteCategoryInfo_Description_GET(NativePointer);
			set => E_PROP_FSpriteCategoryInfo_Description_SET(NativePointer, value);
		}

		public string DisplayName
		{
			get => E_PROP_FSpriteCategoryInfo_DisplayName_GET(NativePointer);
			set => E_PROP_FSpriteCategoryInfo_DisplayName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSpriteCategoryInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSpriteCategoryInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSpriteCategoryInfo(Adress, false);
		}}}

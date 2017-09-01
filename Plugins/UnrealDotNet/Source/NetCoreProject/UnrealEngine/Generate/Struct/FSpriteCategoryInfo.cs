using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Information about the sprite category
	/// </summary>
	public partial class FSpriteCategoryInfo
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FSpriteCategoryInfo()
		{
			NativePointer = E_CreateStruct_FSpriteCategoryInfo();
			IsRef = false;
		}

		internal FSpriteCategoryInfo(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FSpriteCategoryInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FSpriteCategoryInfo_Category_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSpriteCategoryInfo_Category_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FSpriteCategoryInfo_DisplayName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSpriteCategoryInfo_DisplayName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FSpriteCategoryInfo_Description_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSpriteCategoryInfo_Description_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string Category
		{
			get => E_PROP_FSpriteCategoryInfo_Category_GET(NativePointer);
			set => E_PROP_FSpriteCategoryInfo_Category_SET(NativePointer, value);
		}

		public string DisplayName
		{
			get => E_PROP_FSpriteCategoryInfo_DisplayName_GET(NativePointer);
			set => E_PROP_FSpriteCategoryInfo_DisplayName_SET(NativePointer, value);
		}

		public string Description
		{
			get => E_PROP_FSpriteCategoryInfo_Description_GET(NativePointer);
			set => E_PROP_FSpriteCategoryInfo_Description_SET(NativePointer, value);
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

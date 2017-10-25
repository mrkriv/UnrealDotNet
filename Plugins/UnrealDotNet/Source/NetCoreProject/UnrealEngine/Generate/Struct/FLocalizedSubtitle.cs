using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1486

namespace UnrealEngine
{
	public  partial class FLocalizedSubtitle : NativeStructWrapper
	{
		internal FLocalizedSubtitle(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLocalizedSubtitle() :
			base(E_CreateStruct_FLocalizedSubtitle(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLocalizedSubtitle();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FLocalizedSubtitle_LanguageExt_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLocalizedSubtitle_LanguageExt_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string LanguageExt
		{
			get => E_PROP_FLocalizedSubtitle_LanguageExt_GET(NativePointer);
			set => E_PROP_FLocalizedSubtitle_LanguageExt_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLocalizedSubtitle Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLocalizedSubtitle(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLocalizedSubtitle(Adress, false);
		}}}

using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3460

namespace UnrealEngine
{
	public  partial class FComponentSocketDescription : NativeStructWrapper
	{
		internal FComponentSocketDescription(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FComponentSocketDescription() :
			base(E_CreateStruct_FComponentSocketDescription(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FComponentSocketDescription();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FComponentSocketDescription_Name_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FComponentSocketDescription_Name_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Name of the socket </para>
		/// </summary>
		public string Name
		{
			get => E_PROP_FComponentSocketDescription_Name_GET(NativePointer);
			set => E_PROP_FComponentSocketDescription_Name_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FComponentSocketDescription Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FComponentSocketDescription(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FComponentSocketDescription(Adress, false);
		}}}

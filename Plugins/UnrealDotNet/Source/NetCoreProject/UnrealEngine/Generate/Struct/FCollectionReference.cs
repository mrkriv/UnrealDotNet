using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3554

namespace UnrealEngine
{
	public  partial class FCollectionReference : NativeStructWrapper
	{
		internal FCollectionReference(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FCollectionReference() :
			base(E_CreateStruct_FCollectionReference(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollectionReference();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FCollectionReference_CollectionName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollectionReference_CollectionName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Name of the collection </para>
		/// </summary>
		public string CollectionName
		{
			get => E_PROP_FCollectionReference_CollectionName_GET(NativePointer);
			set => E_PROP_FCollectionReference_CollectionName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCollectionReference Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FCollectionReference(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCollectionReference(Adress, false);
		}}}

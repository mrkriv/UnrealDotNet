using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FComponentReference : NativeStructWrapper
	{
		internal FComponentReference(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FComponentReference() :
			base(E_CreateStruct_FComponentReference(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FComponentReference();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FComponentReference_ComponentProperty_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FComponentReference_ComponentProperty_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Name of component property to use </para>
		/// </summary>
		public string ComponentProperty
		{
			get => E_PROP_FComponentReference_ComponentProperty_GET(NativePointer);
			set => E_PROP_FComponentReference_ComponentProperty_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FComponentReference Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FComponentReference(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FComponentReference(Adress, false);
		}}}

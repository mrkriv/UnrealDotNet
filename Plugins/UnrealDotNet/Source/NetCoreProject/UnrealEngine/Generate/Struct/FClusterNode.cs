using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FClusterNode : NativeStructWrapper
	{
		internal FClusterNode(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FClusterNode() :
			base(E_CreateStruct_FClusterNode(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FClusterNode();
		
		#endregion
		
		public static implicit operator IntPtr(FClusterNode Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FClusterNode(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FClusterNode(Adress, false);
		}}}

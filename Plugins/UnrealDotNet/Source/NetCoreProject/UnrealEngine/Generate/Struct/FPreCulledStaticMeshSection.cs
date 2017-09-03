using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FPreCulledStaticMeshSection : NativeStructWrapper
	{
		public FPreCulledStaticMeshSection() : base(E_CreateStruct_FPreCulledStaticMeshSection(), false)
		{
		}

		internal FPreCulledStaticMeshSection(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FPreCulledStaticMeshSection();
		
		#endregion
		
		public static implicit operator IntPtr(FPreCulledStaticMeshSection Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPreCulledStaticMeshSection(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPreCulledStaticMeshSection(Adress, false);
		}}}

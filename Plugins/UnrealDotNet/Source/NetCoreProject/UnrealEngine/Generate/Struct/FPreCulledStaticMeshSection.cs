using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FPreCulledStaticMeshSection
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FPreCulledStaticMeshSection()
		{
			NativePointer = E_CreateStruct_FPreCulledStaticMeshSection();
			IsRef = false;
		}

		internal FPreCulledStaticMeshSection(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FPreCulledStaticMeshSection();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#endregion
		
		public static implicit operator IntPtr(FPreCulledStaticMeshSection Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPreCulledStaticMeshSection(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPreCulledStaticMeshSection(Adress, false);
		}}}

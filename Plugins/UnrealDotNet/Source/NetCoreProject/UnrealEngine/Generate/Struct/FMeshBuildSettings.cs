using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FMeshBuildSettings : NativeStructWrapper
	{
		internal FMeshBuildSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default settings. </para>
		/// </summary>
		public FMeshBuildSettings() :
			base(E_CreateStruct_FMeshBuildSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMeshBuildSettings();
		
		#endregion
		
		public static implicit operator IntPtr(FMeshBuildSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FMeshBuildSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FMeshBuildSettings(Adress, false);
		}}}

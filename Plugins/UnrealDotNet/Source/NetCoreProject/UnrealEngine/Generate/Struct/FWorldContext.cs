using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FWorldContext : NativeStructWrapper
	{
		internal FWorldContext(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FWorldContext() :
			base(E_CreateStruct_FWorldContext(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWorldContext();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FWorldContext_SetCurrentWorld(IntPtr Self, IntPtr World);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FWorldContext_World(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Set CurrentWorld and update external reference pointers to reflect this </para>
		/// </summary>
		public void SetCurrentWorld(UWorld World)
			=> E_FWorldContext_SetCurrentWorld(this, World);
		
		public UWorld World()
			=> E_FWorldContext_World(this);
		
		#endregion
		
		public static implicit operator IntPtr(FWorldContext Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FWorldContext(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FWorldContext(Adress, false);
		}}}

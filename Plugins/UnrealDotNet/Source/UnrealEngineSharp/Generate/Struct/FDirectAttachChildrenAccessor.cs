using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:1311

namespace UnrealEngine
{
	public  partial class FDirectAttachChildrenAccessor : NativeStructWrapper
	{
		internal FDirectAttachChildrenAccessor(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDirectAttachChildrenAccessor() :
			base(E_CreateStruct_FDirectAttachChildrenAccessor(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDirectAttachChildrenAccessor();
		
		#endregion
		
		public static implicit operator IntPtr(FDirectAttachChildrenAccessor Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDirectAttachChildrenAccessor(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDirectAttachChildrenAccessor(Adress, false);
		}}}

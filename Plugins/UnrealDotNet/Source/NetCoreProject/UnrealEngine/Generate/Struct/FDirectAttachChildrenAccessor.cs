using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageDirectAttachChildrenAccessor
	/// <para>Struct to allow direct access to the AttachChildren array for a handful of cases that will require more work than can be done </para>
	/// <para>immediately to fix up in light of the privatization steps </para>
	/// </summary>
	public  partial class FDirectAttachChildrenAccessor : NativeStructWrapper
	{
		public FDirectAttachChildrenAccessor() : base(E_CreateStruct_FDirectAttachChildrenAccessor(), false)
		{
		}

		internal FDirectAttachChildrenAccessor(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
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

using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Struct to allow direct access to the AttachChildren array for a handful of cases that will require more work than can be done
	/// immediately to fix up in light of the privatization steps
	/// </summary>
	public partial class FDirectAttachChildrenAccessor
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FDirectAttachChildrenAccessor()
		{
			NativePointer = E_CreateStruct_FDirectAttachChildrenAccessor();
			IsRef = false;
		}

		internal FDirectAttachChildrenAccessor(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FDirectAttachChildrenAccessor();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#endregion
		
		public static implicit operator IntPtr(FDirectAttachChildrenAccessor Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDirectAttachChildrenAccessor(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDirectAttachChildrenAccessor(Adress, false);
		}}}

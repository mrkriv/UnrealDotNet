using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class TInputUnifiedDelegate : NativeStructWrapper
	{
		internal TInputUnifiedDelegate(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public TInputUnifiedDelegate() :
			base(E_CreateStruct_TInputUnifiedDelegate(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_TInputUnifiedDelegate();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TInputUnifiedDelegate_IsBound(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Returns if either the native or dynamic delegate is bound </para>
		/// </summary>
		public bool IsBound()
			=> E_TInputUnifiedDelegate_IsBound(this);
		
		#endregion
		
		public static implicit operator IntPtr(TInputUnifiedDelegate Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator TInputUnifiedDelegate(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new TInputUnifiedDelegate(Adress, false);
		}}}

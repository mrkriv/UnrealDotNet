using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FDamageEvent : NativeStructWrapper
	{
		internal FDamageEvent(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FDamageEvent() :
			base(E_CreateStruct_FDamageEvent(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDamageEvent();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FDamageEvent_GetTypeID(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FDamageEvent_IsOfType(IntPtr Self, int InID);
		
		#endregion
		
		#region ExternMethods
		public virtual int GetTypeID()
			=> E_FDamageEvent_GetTypeID(this);
		
		public virtual bool IsOfType(int InID)
			=> E_FDamageEvent_IsOfType(this, InID);
		
		#endregion
		
		public static implicit operator IntPtr(FDamageEvent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDamageEvent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDamageEvent(Adress, false);
		}}}

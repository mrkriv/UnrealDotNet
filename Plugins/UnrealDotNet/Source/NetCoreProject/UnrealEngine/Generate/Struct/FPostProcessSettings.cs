using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FPostProcessSettings : NativeStructWrapper
	{
		internal FPostProcessSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPostProcessSettings() :
			base(E_CreateStruct_FPostProcessSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPostProcessSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPostProcessSettings_OnAfterLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPostProcessSettings_SetBaseValues(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		public void OnAfterLoad()
			=> E_FPostProcessSettings_OnAfterLoad(this);
		
		
		/// <summary>
		/// <para>Used to define the values before any override happens. </para>
		/// <para>Should be as neutral as possible. </para>
		/// </summary>
		public void SetBaseValues()
			=> E_FPostProcessSettings_SetBaseValues(this);
		
		#endregion
		
		public static implicit operator IntPtr(FPostProcessSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPostProcessSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPostProcessSettings(Adress, false);
		}}}

using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageTickPrerequisite
	/// <para>This is small structure to hold prerequisite tick functions </para>
	/// </summary>
	public  partial class FTickPrerequisite : NativeStructWrapper
	{
		public FTickPrerequisite() : base(E_CreateStruct_FTickPrerequisite(), false)
		{
		}

		internal FTickPrerequisite(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FTickPrerequisite();
		
		#endregion
		
		public static implicit operator IntPtr(FTickPrerequisite Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTickPrerequisite(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTickPrerequisite(Adress, false);
		}}}

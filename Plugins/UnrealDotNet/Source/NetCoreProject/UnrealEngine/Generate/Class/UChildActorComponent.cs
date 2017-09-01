using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A component that spawns an Actor when registered, and destroys it when unregistered.
	/// </summary>
	public partial class UChildActorComponent : USceneComponent
	{
		public UChildActorComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UChildActorComponent_GetChildActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UChildActorComponent_GetChildActorName(IntPtr Self, out int ResultStringLen);
		
		#endregion
		
		#region ExternMethods
		public AActor GetChildActor()
			=> E_UChildActorComponent_GetChildActor(NativePointer);
		
		public string GetChildActorName()
			=> Marshal.PtrToStringUTF8(E_UChildActorComponent_GetChildActorName(NativePointer, out int ResultStringLen), ResultStringLen);
		
		#endregion
		
		public static implicit operator IntPtr(UChildActorComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UChildActorComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UChildActorComponent(Adress);
		}}}

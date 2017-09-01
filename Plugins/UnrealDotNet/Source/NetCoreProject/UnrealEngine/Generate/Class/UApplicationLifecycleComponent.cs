using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Component to handle receiving notifications from the OS about application state (activated, suspended, termination, etc).
	/// </summary>
	public partial class UApplicationLifecycleComponent : UActorComponent
	{
		public UApplicationLifecycleComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UApplicationLifecycleComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UApplicationLifecycleComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UApplicationLifecycleComponent(Adress);
		}}}

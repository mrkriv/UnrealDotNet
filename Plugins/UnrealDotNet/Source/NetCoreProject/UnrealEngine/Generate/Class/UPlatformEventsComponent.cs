using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Component to handle receiving notifications from the OS about platform events.
	/// </summary>
	public partial class UPlatformEventsComponent : UActorComponent
	{
		public UPlatformEventsComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UPlatformEventsComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPlatformEventsComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UPlatformEventsComponent(Adress);
		}}}

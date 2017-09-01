using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Component that provides a directional wind source. Only affects SpeedTree assets.
	/// </summary>
	public partial class UWindDirectionalSourceComponent : USceneComponent
	{
		public UWindDirectionalSourceComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UWindDirectionalSourceComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UWindDirectionalSourceComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UWindDirectionalSourceComponent(Adress);
		}}}

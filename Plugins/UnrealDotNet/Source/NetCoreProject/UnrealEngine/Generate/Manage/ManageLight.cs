using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManageLight : ALight
	{
		public ManageLight(IntPtr Adress)
			: base(Adress)
		{
		}

		public override void OnRep_bEnabled() { }
		
		public static implicit operator IntPtr(ManageLight Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageLight(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ManageLight ?? new ManageLight(Adress);
		}}}

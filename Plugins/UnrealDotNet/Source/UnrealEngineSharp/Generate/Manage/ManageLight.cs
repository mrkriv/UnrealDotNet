using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Light.h:13

namespace UnrealEngine
{
	[ManageType("ManageLight")]
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

		public static implicit operator ManageLight(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLight>(PtrDesc);
		}}}

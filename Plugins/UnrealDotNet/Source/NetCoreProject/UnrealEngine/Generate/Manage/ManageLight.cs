using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Light.h:13

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

		public static implicit operator ManageLight(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLight>(PtrDesc);
		}}}

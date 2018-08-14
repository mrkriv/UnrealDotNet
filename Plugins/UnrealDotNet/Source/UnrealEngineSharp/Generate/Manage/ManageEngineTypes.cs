using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3473

namespace UnrealEngine
{
	[ManageType("ManageEngineTypes")]
	public partial class ManageEngineTypes : UEngineTypes
	{
		public ManageEngineTypes(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageEngineTypes Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageEngineTypes(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageEngineTypes>(PtrDesc);
		}}}

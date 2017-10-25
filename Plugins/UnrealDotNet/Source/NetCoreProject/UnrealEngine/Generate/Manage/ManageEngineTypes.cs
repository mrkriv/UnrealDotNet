using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3422

namespace UnrealEngine
{
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

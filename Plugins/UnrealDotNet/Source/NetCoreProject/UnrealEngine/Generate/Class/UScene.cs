using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:1687

namespace UnrealEngine
{
	public  partial class UScene : UObject
	{
		public UScene(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(UScene Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UScene(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UScene>(PtrDesc);
		}}}

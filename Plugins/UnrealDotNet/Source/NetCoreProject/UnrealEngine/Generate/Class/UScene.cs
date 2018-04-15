using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:1741

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

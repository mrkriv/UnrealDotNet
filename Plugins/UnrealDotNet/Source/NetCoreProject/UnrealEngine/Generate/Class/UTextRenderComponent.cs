using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UTextRenderComponent : UPrimitiveComponent
	{
		public UTextRenderComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UTextRenderComponent(UObject Parent = null, string Name = "TextRenderComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UTextRenderComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UTextRenderComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UTextRenderComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UTextRenderComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UTextRenderComponent>(PtrDesc);
		}}}

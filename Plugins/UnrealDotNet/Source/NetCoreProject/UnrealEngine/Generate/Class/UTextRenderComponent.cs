using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Renders text in the world with given font. Contains usual font related attributes such as Scale, Alignment, Color etc.
	/// </summary>
	public partial class UTextRenderComponent : UPrimitiveComponent
	{
		public UTextRenderComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UTextRenderComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UTextRenderComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UTextRenderComponent(Adress);
		}}}

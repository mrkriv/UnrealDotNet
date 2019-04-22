// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

namespace UnrealEngine
{
	[ManageType("ManageDecalComponent")]
	public partial class ManageDecalComponent : UDecalComponent
	{
		public ManageDecalComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Called when the life span of the decal has been exceeded </para>
		/// </summary>
		protected override void LifeSpanCallback() { }
		
		public static implicit operator IntPtr(ManageDecalComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageDecalComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageDecalComponent>(PtrDesc);
		}}}

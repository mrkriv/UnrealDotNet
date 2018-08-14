using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

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
		
		public static implicit operator IntPtr(ManageDecalComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageDecalComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageDecalComponent>(PtrDesc);
		}}}

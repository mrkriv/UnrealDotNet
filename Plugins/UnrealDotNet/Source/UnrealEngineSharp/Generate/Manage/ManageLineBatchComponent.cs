// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:120

namespace UnrealEngine
{
	[ManageType("ManageLineBatchComponent")]
	public partial class ManageLineBatchComponent : ULineBatchComponent
	{
		public ManageLineBatchComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public override void DrawLine(FVector start, FVector end, FLinearColor color, byte depthPriority, float thickness, float lifeTime) { }
		
		public override void DrawPoint(FVector position, FLinearColor color, float pointSize, byte depthPriority, float lifeTime) { }
		
		public static implicit operator IntPtr(ManageLineBatchComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageLineBatchComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLineBatchComponent>(PtrDesc);
		}}}

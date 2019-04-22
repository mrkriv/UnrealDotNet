// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LightComponentBase.h:14

namespace UnrealEngine
{
	[ManageType("ManageLightComponentBase")]
	public partial class ManageLightComponentBase : ULightComponentBase
	{
		public ManageLightComponentBase(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageLightComponentBase self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageLightComponentBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLightComponentBase>(PtrDesc);
		}}}

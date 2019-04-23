// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ForceFeedbackAttenuation.h:20

namespace UnrealEngine
{
	[ManageType("ManageForceFeedbackAttenuation")]
	public partial class ManageForceFeedbackAttenuation : UForceFeedbackAttenuation
	{
		public ManageForceFeedbackAttenuation(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageForceFeedbackAttenuation self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageForceFeedbackAttenuation(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageForceFeedbackAttenuation>(PtrDesc);
		}}}

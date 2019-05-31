// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:106

namespace UnrealEngine
{
	[ManageType("ManageSceneComponent")]
	public partial class ManageSceneComponent : USceneComponent
	{
		public ManageSceneComponent(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageSceneComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageSceneComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSceneComponent>(PtrDesc);
		}}}

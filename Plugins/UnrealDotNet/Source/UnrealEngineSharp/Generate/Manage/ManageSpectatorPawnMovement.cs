// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawnMovement.h:15

namespace UnrealEngine
{
	[ManageType("ManageSpectatorPawnMovement")]
	public partial class ManageSpectatorPawnMovement : USpectatorPawnMovement
	{
		public ManageSpectatorPawnMovement(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageSpectatorPawnMovement self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageSpectatorPawnMovement(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSpectatorPawnMovement>(PtrDesc);
		}}}

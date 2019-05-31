// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameNetworkManager.h:27

namespace UnrealEngine
{
	[ManageType("ManageGameNetworkManager")]
	public partial class ManageGameNetworkManager : AGameNetworkManager
	{
		public ManageGameNetworkManager(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageGameNetworkManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameNetworkManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameNetworkManager>(PtrDesc);
		}}}

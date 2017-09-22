using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManageSpectatorPawn : ASpectatorPawn
	{
		public ManageSpectatorPawn(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSpectatorPawn Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageSpectatorPawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSpectatorPawn>(PtrDesc);
		}}}

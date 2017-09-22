using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManagePlayer : UPlayer
	{
		public ManagePlayer(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManagePlayer Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManagePlayer(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePlayer>(PtrDesc);
		}}}

using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USaveGame : UObject
	{
		public USaveGame(IntPtr Adress)
			: base(Adress)
		{
		}

		public USaveGame(UObject Parent = null, string Name = "SaveGame")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USaveGame(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USaveGame(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USaveGame Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USaveGame(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USaveGame>(PtrDesc);
		}}}

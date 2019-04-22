// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Player.h:17

namespace UnrealEngine
{
	public  partial class UPlayer : UObject
	{
		public UPlayer(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPlayer(UObject Parent = null, string Name = "Player")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPlayer(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPlayer(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UPlayer_ConsoleCommand(IntPtr self, string cmd, bool bWriteToLog);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Executes the Exec() command </para>
		/// <param name="Command">command to execute (string of commands optionally separated by a | (pipe)) </param>
		/// <param name="bWriteToLog">write out to the log </param>
		/// </summary>
		public string ConsoleCommand(string cmd, bool bWriteToLog = true)
			=> E_UPlayer_ConsoleCommand(this, cmd, bWriteToLog);
		
		#endregion
		
		public static implicit operator IntPtr(UPlayer self)
		{
			return self.NativePointer;
		}

		public static implicit operator UPlayer(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPlayer>(PtrDesc);
		}}}

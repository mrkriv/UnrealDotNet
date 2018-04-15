using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Player.h:17

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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPlayer(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UPlayer_ConsoleCommand(IntPtr Self, string Cmd, bool bWriteToLog);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Executes the Exec() command </para>
		/// <param name="Command">command to execute (string of commands optionally separated by a | (pipe)) </param>
		/// <param name="bWriteToLog">write out to the log </param>
		/// </summary>
		public string ConsoleCommand(string Cmd, bool bWriteToLog = true)
			=> E_UPlayer_ConsoleCommand(this, Cmd, bWriteToLog);
		
		#endregion
		
		public static implicit operator IntPtr(UPlayer Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPlayer(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPlayer>(PtrDesc);
		}}}

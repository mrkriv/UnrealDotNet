using System;
using System.Runtime.InteropServices;

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
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UPlayer(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UPlayer_ConsoleCommand(IntPtr Self, string Cmd, bool bWriteToLog, out int ResultStringLen);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Executes the Exec() command </para>
		/// <param name="Command">command to execute (string of commands optionally separated by a | (pipe)) </param>
		/// <param name="bWriteToLog">write out to the log </param>
		/// </summary>
		public string ConsoleCommand(string Cmd, bool bWriteToLog = true)
			=> Marshal.PtrToStringUTF8(E_UPlayer_ConsoleCommand(this, Cmd, bWriteToLog, out int ResultStringLen), ResultStringLen);
		
		#endregion
		
		public static implicit operator IntPtr(UPlayer Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPlayer(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UPlayer ?? new UPlayer(Adress);
		}}}

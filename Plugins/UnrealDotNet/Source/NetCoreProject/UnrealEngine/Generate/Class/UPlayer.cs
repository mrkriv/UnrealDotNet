using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Player: Corresponds to a real player (a local camera or remote net player).
	/// </summary>
	public partial class UPlayer : UObject
	{
		public UPlayer(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UPlayer_ConsoleCommand(IntPtr Self, string Cmd, bool bWriteToLog, out int ResultStringLen);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Executes the Exec() command
		/// @param Command command to execute (string of commands optionally separated by a | (pipe))
		/// @param bWriteToLog write out to the log
		/// </summary>
		public string ConsoleCommand(string Cmd, bool bWriteToLog = true)
			=> Marshal.PtrToStringUTF8(E_UPlayer_ConsoleCommand(NativePointer, Cmd, bWriteToLog, out int ResultStringLen), ResultStringLen);
		
		#endregion
		
		public static implicit operator IntPtr(UPlayer Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPlayer(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UPlayer(Adress);
		}}}

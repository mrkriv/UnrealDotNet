using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// World delegates
	/// </summary>
	public partial class FWorldDelegates
	{
		protected readonly IntPtr NativePointer;
		
		public FWorldDelegates(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		public static implicit operator IntPtr(FWorldDelegates Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FWorldDelegates(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FWorldDelegates(Adress);
		}}}

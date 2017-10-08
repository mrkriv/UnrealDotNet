using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FUserActivity : NativeStructWrapper
	{
		internal FUserActivity(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor. </para>
		/// </summary>
		public FUserActivity() :
			base(E_CreateStruct_FUserActivity(), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new instance. </para>
		/// </summary>
		public FUserActivity(string InActionName) :
			base(E_CreateStruct_FUserActivity_FString(InActionName), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new instance with a context other than the default "Game". </para>
		/// </summary>
		public FUserActivity(string InActionName, EUserActivityContext InContext) :
			base(E_CreateStruct_FUserActivity_FString_EUserActivityContext(InActionName, (byte)InContext), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FUserActivity();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FUserActivity_FString(string InActionName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FUserActivity_FString_EUserActivityContext(string InActionName, byte InContext);
		
		#endregion
		
		public static implicit operator IntPtr(FUserActivity Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FUserActivity(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FUserActivity(Adress, false);
		}}}

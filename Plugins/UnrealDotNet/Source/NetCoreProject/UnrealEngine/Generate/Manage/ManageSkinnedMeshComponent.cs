using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManageSkinnedMeshComponent : USkinnedMeshComponent
	{
		public ManageSkinnedMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Clear any applied ref pose override </para>
		/// </summary>
		public override void ClearRefPoseOverride() { }
		
		public static implicit operator IntPtr(ManageSkinnedMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageSkinnedMeshComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ManageSkinnedMeshComponent ?? new ManageSkinnedMeshComponent(Adress);
		}}}

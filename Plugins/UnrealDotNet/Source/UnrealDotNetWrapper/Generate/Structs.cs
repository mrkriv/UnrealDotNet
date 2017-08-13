using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	/// <summary>
	/// A point or direction FVector in 3d space.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Vector.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	public struct FVector
	{
		/// <summary>
		/// X
		/// </summary>
		[FieldOffset(4)]
		public float X;
		
		/// <summary>
		/// Y
		/// </summary>
		[FieldOffset(4)]
		public float Y;
		
		/// <summary>
		/// Z
		/// </summary>
		[FieldOffset(4)]
		public float Z;
		
		
	}
	/// <summary>
	/// An orthogonal rotation in 3d space.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Rotator.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	public struct FRotator
	{
		/// <summary>
		/// Pitch (degrees) around Y axis
		/// </summary>
		[FieldOffset(4)]
		public float Pitch;
		
		/// <summary>
		/// Yaw (degrees) around Z axis
		/// </summary>
		[FieldOffset(4)]
		public float Yaw;
		
		/// <summary>
		/// Roll (degrees) around X axis
		/// </summary>
		[FieldOffset(4)]
		public float Roll;
		
		
	}
	/// <summary>
	/// Key
	/// </summary>
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	public struct FKey
	{
		/// <summary>
		/// Key Name
		/// </summary>
		[FieldOffset(12)]
		public string KeyName;
		
		
	}
	/// <summary>
	/// Quaternion.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Quat.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	public struct FQuat
	{
		/// <summary>
		/// X
		/// </summary>
		[FieldOffset(4)]
		public float X;
		
		/// <summary>
		/// Y
		/// </summary>
		[FieldOffset(4)]
		public float Y;
		
		/// <summary>
		/// Z
		/// </summary>
		[FieldOffset(4)]
		public float Z;
		
		/// <summary>
		/// W
		/// </summary>
		[FieldOffset(4)]
		public float W;
		
		
	}
	/// <summary>
	/// Transform composed of Quat/Translation/Scale.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Transform.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	public struct FTransform
	{
		/// <summary>
		/// Rotation
		/// </summary>
		[FieldOffset(16)]
		public FQuat Rotation;
		
		/// <summary>
		/// Translation
		/// </summary>
		[FieldOffset(12)]
		public FVector Translation;
		
		/// <summary>
		/// Scale 3D
		/// </summary>
		[FieldOffset(12)]
		public FVector Scale3D;
		
		
	}
	
}
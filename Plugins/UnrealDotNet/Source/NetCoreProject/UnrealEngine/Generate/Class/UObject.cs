using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class UObject : UObjectBaseUtility
	{
		public UObject(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UObject_GetDetailedInfoInternal(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_CanModify(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_CanCreateInCurrentContext(IntPtr Self, IntPtr Template);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UObject_GetDesc(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UObject_GetWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UObject_GetWorldChecked(IntPtr Self, bool bSupported);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_ExecuteUbergraph(IntPtr Self, int EntryPoint);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UCapsuleComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UBrushComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_USplineComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UBillboardComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UArrowComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UModelComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UMaterialBillboardComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UShapeComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UDrawSphereComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UDrawFrustumComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UTextRenderComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UMeshComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UVectorFieldComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UInstancedStaticMeshComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UBoxComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_USplineMeshComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UStaticMeshComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_ULineBatchComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_USphereComponent(IntPtr Self, string Name);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// This function actually does the work for the GetDetailInfo and is virtual.
		/// It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers
		/// </summary>
		protected string GetDetailedInfoInternal()
			=> Marshal.PtrToStringUTF8(E_UObject_GetDetailedInfoInternal(NativePointer, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// Called after the C++ constructor and after the properties have been initialized, including those loaded from config.
		/// mainly this is to emulate some behavior of when the constructor was called after the properties were initialized.
		/// </summary>
		public void PostInitProperties()
			=> E_UObject_PostInitProperties(NativePointer);
		
		
		/// <summary>
		/// Called from within SavePackage on the passed in base/ root. This function is being called after the package
		/// has been saved and can perform cleanup.
		/// @param	bCleanupIsRequired	Whether PreSaveRoot dirtied state that needs to be cleaned up
		/// </summary>
		public void PostSaveRoot(bool bCleanupIsRequired)
			=> E_UObject_PostSaveRoot(NativePointer, bCleanupIsRequired);
		
		
		/// <summary>
		/// Note that the object will be modified.  If we are currently recording into the
		/// transaction buffer (undo/redo), save a copy of this object into the buffer and
		/// marks the package as needing to be saved.
		/// @param	bAlwaysMarkDirty	if true, marks the package dirty even if we aren't
		/// currently recording an active undo/redo transaction
		/// @return true if the object was saved to the transaction buffer
		/// </summary>
		public bool Modify(bool bAlwaysMarkDirty = true)
			=> E_UObject_Modify(NativePointer, bAlwaysMarkDirty);
		
		
		/// <summary>
		/// Utility to allow overrides of Modify to avoid doing work if the base class is not going modify anyways.
		/// </summary>
		public bool CanModify()
			=> E_UObject_CanModify(NativePointer);
		
		
		/// <summary>
		/// Called to check if the object is ready for FinishDestroy.  This is called after BeginDestroy to check the completion of the
		/// potentially asynchronous object cleanup.
		/// @return True if the object's asynchronous cleanup has completed and it is ready for FinishDestroy to be called.
		/// </summary>
		public bool IsReadyForFinishDestroy()
			=> E_UObject_IsReadyForFinishDestroy(NativePointer);
		
		
		/// <summary>
		/// Test the selection state of a UObject
		/// @return		true if the object is selected, false otherwise.
		/// @todo UE4 this doesn't belong here, but it doesn't belong anywhere else any better
		/// </summary>
		public void PostRename(UObject OldOuter, string OldName)
			=> E_UObject_PostRename(NativePointer, OldOuter, OldName);
		
		
		/// <summary>
		/// Determines if you can create an object from the supplied template in the current context (editor, client only, dedicated server, game/listen)
		/// This calls NeedsLoadForClient & NeedsLoadForServer
		/// </summary>
		public bool CanCreateInCurrentContext(UObject Template)
			=> E_UObject_CanCreateInCurrentContext(NativePointer, Template);
		
		
		/// <summary>
		/// @return a one line description of an object for viewing in the thumbnail view of the generic browser
		/// </summary>
		public string GetDesc()
			=> Marshal.PtrToStringUTF8(E_UObject_GetDesc(NativePointer, out int ResultStringLen), ResultStringLen);
		
		public UWorld GetWorld()
			=> E_UObject_GetWorld(NativePointer);
		
		public UWorld GetWorldChecked(bool bSupported)
			=> E_UObject_GetWorldChecked(NativePointer, bSupported);
		
		
		/// <summary>
		/// Returns whether native properties are identical to the one of the passed in component.
		/// @param	Other	Other component to compare against
		/// @return true if native properties are identical, false otherwise
		/// </summary>
		public bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_UObject_AreNativePropertiesIdenticalTo(NativePointer, Other);
		
		public void ExecuteUbergraph(int EntryPoint)
			=> E_UObject_ExecuteUbergraph(NativePointer, EntryPoint);
		
		public UCapsuleComponent CreateOptionalDefaultSubobject_UCapsuleComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UCapsuleComponent(NativePointer, Name);
		
		public UBrushComponent CreateOptionalDefaultSubobject_UBrushComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UBrushComponent(NativePointer, Name);
		
		public USplineComponent CreateOptionalDefaultSubobject_USplineComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_USplineComponent(NativePointer, Name);
		
		public UBillboardComponent CreateOptionalDefaultSubobject_UBillboardComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UBillboardComponent(NativePointer, Name);
		
		public UArrowComponent CreateOptionalDefaultSubobject_UArrowComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UArrowComponent(NativePointer, Name);
		
		public UModelComponent CreateOptionalDefaultSubobject_UModelComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UModelComponent(NativePointer, Name);
		
		public UMaterialBillboardComponent CreateOptionalDefaultSubobject_UMaterialBillboardComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UMaterialBillboardComponent(NativePointer, Name);
		
		public UShapeComponent CreateOptionalDefaultSubobject_UShapeComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UShapeComponent(NativePointer, Name);
		
		public UDrawSphereComponent CreateOptionalDefaultSubobject_UDrawSphereComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UDrawSphereComponent(NativePointer, Name);
		
		public UDrawFrustumComponent CreateOptionalDefaultSubobject_UDrawFrustumComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UDrawFrustumComponent(NativePointer, Name);
		
		public UTextRenderComponent CreateOptionalDefaultSubobject_UTextRenderComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UTextRenderComponent(NativePointer, Name);
		
		public UMeshComponent CreateOptionalDefaultSubobject_UMeshComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UMeshComponent(NativePointer, Name);
		
		public UVectorFieldComponent CreateOptionalDefaultSubobject_UVectorFieldComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UVectorFieldComponent(NativePointer, Name);
		
		public UInstancedStaticMeshComponent CreateOptionalDefaultSubobject_UInstancedStaticMeshComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UInstancedStaticMeshComponent(NativePointer, Name);
		
		public UBoxComponent CreateOptionalDefaultSubobject_UBoxComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UBoxComponent(NativePointer, Name);
		
		public USplineMeshComponent CreateOptionalDefaultSubobject_USplineMeshComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_USplineMeshComponent(NativePointer, Name);
		
		public UStaticMeshComponent CreateOptionalDefaultSubobject_UStaticMeshComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UStaticMeshComponent(NativePointer, Name);
		
		public ULineBatchComponent CreateOptionalDefaultSubobject_ULineBatchComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_ULineBatchComponent(NativePointer, Name);
		
		public USphereComponent CreateOptionalDefaultSubobject_USphereComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_USphereComponent(NativePointer, Name);
		
		#endregion
		
		public static implicit operator IntPtr(UObject Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UObject(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UObject(Adress);
		}}}

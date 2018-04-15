namespace UnrealEngine
{
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:45
	
	public delegate void FActorBeginCursorOverSignature(AActor TouchedActor);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:41
	
	public delegate void FActorBeginOverlapSignature(AActor OverlappedActor, AActor OtherActor);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ActorComponent.h:76
	
	public delegate void FActorComponentActivatedSignature(UActorComponent Component, bool bReset);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ActorComponent.h:77
	
	public delegate void FActorComponentDeactivateSignature(UActorComponent Component);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:54
	
	public delegate void FActorDestroyedSignature(AActor DestroyedActor);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:46
	
	public delegate void FActorEndCursorOverSignature(AActor TouchedActor);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:42
	
	public delegate void FActorEndOverlapSignature(AActor OverlappedActor, AActor OtherActor);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:43
	
	public delegate void FActorHitSignature(AActor SelfActor, AActor OtherActor, FVector NormalImpulse, FHitResult Hit);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:31
	
	public delegate void FCharacterMovementUpdatedSignature(float DeltaSeconds, FVector OldLocation, FVector OldVelocity);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:32
	
	public delegate void FCharacterReachedApexSignature();
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:155
	
	public delegate void FComponentBeginCursorOverSignature(UPrimitiveComponent TouchedComponent);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:145
	
	public delegate void FComponentBeginOverlapSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:153
	
	public delegate void FComponentCollisionSettingsChangedSignature(UPrimitiveComponent ChangedComponent);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:156
	
	public delegate void FComponentEndCursorOverSignature(UPrimitiveComponent TouchedComponent);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:147
	
	public delegate void FComponentEndOverlapSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:143
	
	public delegate void FComponentHitSignature(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, FHitResult Hit);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:151
	
	public delegate void FComponentSleepSignature(UPrimitiveComponent SleepingComponent, string BoneName);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:149
	
	public delegate void FComponentWakeSignature(UPrimitiveComponent WakingComponent, string BoneName);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3490
	
	public delegate void FConstraintBrokenSignature(int ConstraintIndex);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:33
	
	public delegate void FLandedSignature(FHitResult Hit);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:30
	
	public delegate void FMovementModeChangedSignature(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode);
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:46
	
	public delegate void FOnAnimInitialized();
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:19
	
	public delegate void FOnAudioFinished();
	// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:49
	
	public delegate void FOnAudioMultiEnvelopeValue(float AverageEnvelopeValue, float MaxEnvelope, int NumWaveInstances);
}

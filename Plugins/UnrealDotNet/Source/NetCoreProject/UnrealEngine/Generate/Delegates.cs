namespace UnrealEngine
{
	public delegate void FActorBeginCursorOverSignature(AActor TouchedActor);
	public delegate void FActorBeginOverlapSignature(AActor OverlappedActor, AActor OtherActor);
	public delegate void FActorComponentActivatedSignature(UActorComponent Component, bool bReset);
	public delegate void FActorComponentDeactivateSignature(UActorComponent Component);
	public delegate void FActorDestroyedSignature(AActor DestroyedActor);
	public delegate void FActorEndCursorOverSignature(AActor TouchedActor);
	public delegate void FActorEndOverlapSignature(AActor OverlappedActor, AActor OtherActor);
	public delegate void FCharacterMovementUpdatedSignature(float DeltaSeconds, FVector OldLocation, FVector OldVelocity);
	public delegate void FCharacterReachedApexSignature();
	public delegate void FComponentBeginCursorOverSignature(UPrimitiveComponent TouchedComponent);
	public delegate void FComponentCollisionSettingsChangedSignature(UPrimitiveComponent ChangedComponent);
	public delegate void FComponentEndCursorOverSignature(UPrimitiveComponent TouchedComponent);
	public delegate void FComponentEndOverlapSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex);
	public delegate void FComponentFractureSignature(FVector HitPoint, FVector HitDirection);
	public delegate void FComponentSleepSignature(UPrimitiveComponent SleepingComponent, string BoneName);
	public delegate void FComponentWakeSignature(UPrimitiveComponent WakingComponent, string BoneName);
	public delegate void FMovementModeChangedSignature(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode);
	public delegate void FOnAnimInitialized();
	public delegate void FOnAudioFinished();
}

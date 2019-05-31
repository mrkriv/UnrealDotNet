using System;
using System.ComponentModel;
using Newtonsoft.Json;
using UnrealEngine;

namespace GameLogic
{
    public class PlayerController : ManagePlayerController
    {
        private AActor _pickUpObject;
        private float _dragDistance;

        [EditAnywhere] public float DragDropDistance { get; set; } = 800.0f;

        public PlayerController(IntPtr adress) : base(adress)
        {
            PrimaryActorTick.bCanEverTick = 1;
        }

        protected override void BeginPlayingState()
        {
            InputComponent.BindAction("Fire", EInputEvent.IE_Pressed, OnFirePressed);
            InputComponent.BindAction("Fire", EInputEvent.IE_Released, OnFireReleased);

            InputComponent.BindAction("Jump", EInputEvent.IE_Pressed, () => GetCharacter()?.Jump());
            InputComponent.BindAction("Jump", EInputEvent.IE_Released, () => GetCharacter()?.StopJumping());

            InputComponent.BindAxis("Turn", v => GetCharacter()?.AddControllerYawInput(v));
            InputComponent.BindAxis("LookUp", v => GetCharacter()?.AddControllerPitchInput(v));
            InputComponent.BindAxis("MoveForward", OnMoveForward);
            InputComponent.BindAxis("MoveRight", MoveRight);
        }

        private void OnMoveForward(float value)
        {
            var forvard = new FRotator(0, GetControlRotation().Yaw, 0).Vector();
            GetCharacter()?.AddMovementInput(forvard, value, false);
        }

        private void MoveRight(float value)
        {
            var right = new FRotator(0, GetControlRotation().Yaw + 90, 0).Vector();
            GetCharacter()?.AddMovementInput(right, value, false);
        }

        private void OnFirePressed()
        {
            var character = GetCharacter();
            var result = new FHitResult();

            GetWorld().DebugDrawTraceTag = "drag&drop";

            GetWorld().LineTraceSingleByChannel(
                result,
                character.GetCapsuleComponent().GetWorldLocation(),
                character.GetCapsuleComponent().GetWorldLocation() + GetControlRotation().Vector() * DragDropDistance,
                ECollisionChannel.ECC_Visibility,
                new FCollisionQueryParams(GetWorld().DebugDrawTraceTag, true, null),
                new FCollisionResponseParams(ECollisionResponse.ECR_Block)
            );

            _pickUpObject = result.GetActor();
            _dragDistance = result.Distance;

            if (_pickUpObject?.IsRootComponentMovable() == false)
            {
                _pickUpObject = null;
            }

            Ue.ScreenDebugMessage(result.GetActor()?.GetName());
        }

        private void OnFireReleased()
        {
            _pickUpObject = null;
        }

        public override void Tick(float deltaSeconds)
        {
            if (_pickUpObject != null)
                TickDragDrop();
        }

        private void TickDragDrop()
        {
            _pickUpObject.SetActorLocation(
                GetCharacter().GetCapsuleComponent().GetWorldLocation() +
                GetControlRotation().Vector() * (DragDropDistance * _dragDistance),
                false,
                new FHitResult(),
                ETeleportType.TeleportPhysics);
        }
    }
}
#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "ManageObject.h"
#include "TypeConvertor.h"
#include "Runtime/Engine/Classes/Engine/GameViewportClient.h"
#include "ManageGameViewportClient.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\GameViewportClient.h:55

UCLASS()
class UNREALDOTNETRUNTIME_API UManageGameViewportClient : public UGameViewportClient, public IManageObject
{
	GENERATED_BODY()
	
public:
	bool bIsManageAttach = false;
	bool AddWrapperIfNotAttach() override;
	void SetManageType(const FDotnetTypeName& ManageType) override;
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void DetachViewportClient() override;
	virtual void LayoutPlayers() override;
	virtual void SetConsoleTarget(int32 PlayerIndex) override;
	virtual void SetDropDetail(float DeltaSeconds) override;
	virtual void ShowTitleSafeArea() override;
	virtual void SSSwapControllers() override;
	virtual void Tick(float DeltaTime) override;
	virtual void UpdateActiveSplitscreenType() override;
	virtual void VerifyPathRenderingComponents() override;
	virtual void BeginDestroy() override;
	virtual void FinishDestroy() override;
	virtual void MarkAsEditorOnlySubobject() override;
	virtual void PostCDOContruct() override;
	virtual void PostEditImport() override;
	virtual void PostInitProperties() override;
	virtual void PostLoad() override;
	virtual void PostNetReceive() override;
	virtual void PostRepNotifies() override;
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	virtual void PreDestroyFromReplication() override;
	virtual void PreNetReceive() override;
	virtual void ShutdownAfterError() override;
	virtual void CreateCluster() override;
	virtual void OnClusterMarkedAsPendingKill() override;
	
	void _Supper__DetachViewportClient();
	void _Supper__LayoutPlayers();
	void _Supper__SetConsoleTarget(int32 PlayerIndex);
	void _Supper__SetDropDetail(float DeltaSeconds);
	void _Supper__ShowTitleSafeArea();
	void _Supper__SSSwapControllers();
	void _Supper__Tick(float DeltaTime);
	void _Supper__UpdateActiveSplitscreenType();
	void _Supper__VerifyPathRenderingComponents();
	void _Supper__BeginDestroy();
	void _Supper__FinishDestroy();
	void _Supper__MarkAsEditorOnlySubobject();
	void _Supper__PostCDOContruct();
	void _Supper__PostEditImport();
	void _Supper__PostInitProperties();
	void _Supper__PostLoad();
	void _Supper__PostNetReceive();
	void _Supper__PostRepNotifies();
	void _Supper__PostSaveRoot(bool bCleanupIsRequired);
	void _Supper__PreDestroyFromReplication();
	void _Supper__PreNetReceive();
	void _Supper__ShutdownAfterError();
	void _Supper__CreateCluster();
	void _Supper__OnClusterMarkedAsPendingKill();
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS

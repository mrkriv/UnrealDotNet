#include "UDNStyle.h"
#include "UnrealDotNetEditorPCH.h"
#include "Framework/Application/SlateApplication.h"
#include "Styling/SlateStyleRegistry.h"
#include "Slate/SlateGameResources.h"

TSharedPtr<FSlateStyleSet> FUDNStyle::StyleInstance = NULL;

void FUDNStyle::Initialize()
{
	if (!StyleInstance.IsValid())
	{
		StyleInstance = Create();
		FSlateStyleRegistry::RegisterSlateStyle(*StyleInstance);
	}
}

void FUDNStyle::Shutdown()
{
	FSlateStyleRegistry::UnRegisterSlateStyle(*StyleInstance);
	ensure(StyleInstance.IsUnique());
	StyleInstance.Reset();
}

FName FUDNStyle::GetStyleSetName()
{
	static FName StyleSetName(TEXT("UnrealDotNetEditorStyle"));
	return StyleSetName;
}


#define IMAGE_BRUSH( RelativePath, ... ) FSlateImageBrush( Style->RootToContentDir( RelativePath, TEXT(".png") ), __VA_ARGS__ )

const FVector2D Icon40x40(40.0f, 40.0f);

TSharedRef<FSlateStyleSet> FUDNStyle::Create()
{
	TSharedRef<FSlateStyleSet> Style = MakeShareable(new FSlateStyleSet("UnrealDotNetEditorStyle"));

	Style->SetContentRoot(FPaths::ProjectPluginsDir() / "UnrealDotNet" / "Resources");
	Style->Set("UnrealDotNet.PluginAction", new IMAGE_BRUSH(TEXT("Compile_ButtonIcon_40x"), Icon40x40));

	return Style;
}

#undef IMAGE_BRUSH

void FUDNStyle::ReloadTextures()
{
	if (FSlateApplication::IsInitialized())
	{
		FSlateApplication::Get().GetRenderer()->ReloadTextureResources();
	}
}

const ISlateStyle& FUDNStyle::Get()
{
	return *StyleInstance;
}

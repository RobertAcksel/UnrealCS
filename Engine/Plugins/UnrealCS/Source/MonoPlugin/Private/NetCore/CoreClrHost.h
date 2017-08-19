#pragma once

#include <mono/metadata/object.h>
#include "Tickable.h"
#include <memory>
#include "mscoree.h"

class FCoreClrHost final : public FTickableGameObject {
public:
    static wchar_t const * const UnrealCSContentFolderName;

    FCoreClrHost();
    virtual ~FCoreClrHost();

    virtual void Tick(float DeltaTime) override{};
    virtual bool IsTickable() const override { return false; };
    virtual TStatId GetStatId() const override { return {}; };
    virtual bool IsTickableWhenPaused() const override { return true; }
    virtual bool IsTickableInEditor() const override { return true; }
    virtual UWorld * GetTickableGameObjectWorld() const override { return nullptr; }

private:
    bool Init();
    bool Start();
    bool Shutdown();

    bool run();

    std::unique_ptr<class FCoreClrHostPImpl> pImpl;
};

DECLARE_LOG_CATEGORY_EXTERN(LogClr, Log, All);

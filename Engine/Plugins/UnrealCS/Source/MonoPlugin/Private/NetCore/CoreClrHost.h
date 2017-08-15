#pragma once

#include <mono/metadata/object.h>
#include "Tickable.h"

class FCoreClrHost final : public FTickableGameObject {
public:
    FCoreClrHost();
    virtual ~FCoreClrHost();

    bool Init();
    bool Start();
    bool Shutdown() { return false; }

    virtual void Tick(float DeltaTime) override{};
    virtual bool IsTickable() const override { return false; };
    virtual TStatId GetStatId() const override { return {}; };
    virtual bool IsTickableWhenPaused() const override { return true; }
    virtual bool IsTickableInEditor() const override { return true; }
    virtual UWorld * GetTickableGameObjectWorld() const override { return nullptr; }
};


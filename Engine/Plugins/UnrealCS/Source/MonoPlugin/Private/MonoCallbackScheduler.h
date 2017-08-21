#pragma once

#include <mono/metadata/object.h>
#include "Array.h"

struct MonoCallbackScheduler {
public:
    bool AddTickableObject(MonoObject * obj);
    bool RemoveTickableObject(MonoObject * obj);
    void Tick(float DeltaTime);
    void HotReload();

private:
    //C# Object Tickable Support
    struct TickObject
    {
        //C# Object Pointer
        MonoObject* Obj;
        //C# Object Handle
        uint32 gc_handle;
        //C# Object Tick Method
        MonoMethod* TickMethod;
        //If Marked As Removed
        bool removed;
    };

    //Tick Object Array
    TArray<struct TickObject> TickObjects;
};

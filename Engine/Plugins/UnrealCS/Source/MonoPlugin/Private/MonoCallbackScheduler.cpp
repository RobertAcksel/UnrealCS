
#include "MonoCallbackScheduler.h"

#include "MonoPluginPrivatePCH.h"

bool MonoCallbackScheduler::AddTickableObject(MonoObject * obj) {
    if(obj == nullptr)
        return false;
    MonoClass * ObjectClass = mono_object_get_class(obj);

    TickObject Data;
    Data.removed = false;
    Data.Obj = obj;
    Data.TickMethod = mono_class_get_method_from_name(ObjectClass, "Tick", 1);
    if(Data.TickMethod == nullptr)
        return false;

    //attrs.name

    Data.gc_handle = mono_gchandle_new(obj, 1);

    for(int32 i = 0; i < TickObjects.Num(); i++) {
        if(TickObjects[i].removed) {
            TickObjects[i] = Data;
            return true;
        }
    }
    TickObjects.Add(Data);
    return true;
}

bool MonoCallbackScheduler::RemoveTickableObject(MonoObject * obj) {
    for(int32 i = 0; i < TickObjects.Num(); i++) {
        if(TickObjects[i].Obj == obj && !TickObjects[i].removed) {
            TickObjects[i].Obj = nullptr;
            mono_gchandle_free(TickObjects[i].gc_handle);
            TickObjects[i].removed = true;
            return true;
        }
    }
    return false;
}

void MonoCallbackScheduler::Tick(float DeltaTime) {
    for(int32 i = 0; i < TickObjects.Num(); i++) {
        if(!TickObjects[i].removed) {
            void * args[]{
                &DeltaTime
            };
            MonoObject * exception = nullptr;
            MonoObject * ret = mono_runtime_invoke(TickObjects[i].TickMethod, TickObjects[i].Obj, args, &exception);
            if(exception) {
                mono_print_unhandled_exception(exception);
            }
        }
    }
}

void MonoCallbackScheduler::HotReload() {
    //Remove all tickable objects
    for(int32 i = 0; i < TickObjects.Num(); i++) {
        if(!TickObjects[i].removed) {
            mono_gchandle_free(TickObjects[i].gc_handle);
        }
    }
    TickObjects.Empty();
}

using System;
using Zenject;

namespace _WavesCounter.Scripts.ScenesHandle.Base
{
    public abstract class SceneHandle : IInitializable, IDisposable
    {
        public abstract void Initialize();

        public abstract void Dispose();
    }
}
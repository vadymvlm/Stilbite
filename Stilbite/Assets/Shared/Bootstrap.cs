namespace Stilbite.Shared
{
    using UnityEngine;

    public static class Bootstrap
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void Apply() => Application.targetFrameRate = Ranges.MID_FRAME_RATE;
    }
}
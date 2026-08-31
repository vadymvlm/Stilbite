namespace Stilbite.Editor.Wizards
{
    using UnityEditor;
    using UnityEngine;
    using static Shared.Ranges;

    public sealed class FrameRateWizard : BaseWizard
    {
        [SerializeField]
        [Range(MIN_FRAME_RATE, MAX_FRAME_RATE)]
        private int _frameRate = MID_FRAME_RATE;

        [MenuItem("STILBITE/Frame Rate Wizard")]
        private static void Display() => Display<FrameRateWizard>("Frame Rate Wizard", height: 300, width: 150);

        private void OnWizardCreate() => Application.targetFrameRate = _frameRate;
        private void OnWizardOtherButton() => Application.targetFrameRate = _frameRate;
    }
}
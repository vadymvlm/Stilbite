namespace Stilbite.Editor.Wizards
{
    public abstract class BaseWizard : UnityEditor.ScriptableWizard
    {
        private static BaseWizard _singleton;

        protected virtual void OnDestroy()
        {
            _singleton = null;
        }

        protected static void Display<T>(string title, float height, float width, bool useSingleton = true, string createButtonName = "Apply & Close", string otherButtonName = "Apply")
        where T : BaseWizard
        {
            if (useSingleton && _singleton is not null)
                _singleton.Focus();
            else
            {
                _singleton = DisplayWizard<T>(title, createButtonName, otherButtonName);
                _singleton.maxSize = new(height, width);
            }
        }
    }
}
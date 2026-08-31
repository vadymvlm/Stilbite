namespace Stilbite.Editor
{
    using UnityEditor;
    using UnityEngine;

    public abstract class BaseEditor<T> : Editor
    where T : Object
    {
        public new T target => (T)base.target;
    }
}
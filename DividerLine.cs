using UnityEngine;
using UnityEditor;



[CustomPropertyDrawer(typeof(DividerLine))]
public class DividerLineDrawer : DecoratorDrawer
{
    DividerLine divider
    {
        get { return ((DividerLine)attribute); }
    }

    public override void OnGUI(Rect position)
    {
        position.width += position.x - 6;
        position.x = 6;
        EditorGUI.LabelField(position, "DividerLineWasHere", GUI.skin.horizontalSlider);
    }
}

public class DividerLine : PropertyAttribute
{
    public DividerLine()
    {
        
    }
}

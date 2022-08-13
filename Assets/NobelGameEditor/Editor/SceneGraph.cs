/// <summary>
/// ScebeNode ;メインのノード
/// </summary>
using UnityEditor;
using UnityEditor.Experimental.GraphView;

public class SceneGraph : GraphView
{
    public SceneGraph() : base()
    {
        AddElement(new SceneNode());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;
public class EditorSceneGraphView : GraphView
{
    public new class UxmlFactory : UxmlFactory<EditorSceneGraphView, GraphView.UxmlTraits> { }
   public EditorSceneGraphView()
    {
        Insert(0, new GridBackground());

        this.AddManipulator(new ContentDragger());
        this.AddManipulator(new ContentZoomer());
        this.AddManipulator(new SelectionDragger());
        this.AddManipulator(new RectangleSelector());


        var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/NobelGameEditor/Editor/EditorSceneView.uss");
        styleSheets.Add(styleSheet);
    }
}

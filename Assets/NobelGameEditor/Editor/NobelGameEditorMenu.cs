/// <summary>
/// NobelGameEditorのメニュー作成
/// </summary>

using UnityEditor;
using UnityEngine;
using System.Linq;
public class NobelGameEditorMenu : EditorWindow
{
    

    [MenuItem("NobelGameEditor/MainMenu")]
    public static void OpenSceneNode()
    {

        GetWindow<NobelGameEditorMenu>("NobelGameEditor");
        /*NobelGameEditorMenu nobelgameeditorMenu = CreateInstance<NobelGameEditorMenu>();
        nobelgameeditorMenu.Show();
        nobelgameeditorMenu.titleContent = new UnityEngine.GUIContent("SceneNode");*/
    }

    
    private void OnEnable()
    {

        NobelGameEditorTab tabmenu = new NobelGameEditorTab();
        
        rootVisualElement.Add(tabmenu);


        SceneGraph graphView = new SceneGraph()
        {
            style = {
                flexGrow = 1,
                backgroundColor = new Color(0.1f,0.1f,0.1f)
            }
        };
        rootVisualElement.Add(graphView);

        
    }
    
}




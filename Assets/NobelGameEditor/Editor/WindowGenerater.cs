using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
public class WindowGenerater : EditorWindow
{
    private Button projectSetting;
    private Button sceneView;
    private VisualElement project_Content;
    private VisualElement scene_Content;
    [MenuItem("NobelGameEditor/MainWindow")]
    public static void ShowWindow() => GetWindow<WindowGenerater>("WindowGenerater");

    private void OnEnable()
    {
        var window = Resources.Load<VisualTreeAsset>("WindowTemplate");
        window.CloneTree(rootVisualElement);

        

        projectSetting = rootVisualElement.Q<Button>("Tab_Button_Project_Settings");
        sceneView = rootVisualElement.Q<Button>("Tab_Button_Scene");
        project_Content = rootVisualElement.Q<VisualElement>("Editor_ProjectSettings");
        scene_Content = rootVisualElement.Q<VisualElement>("Editor_Scene");

        project_Content.style.display = DisplayStyle.None;//projectSetting‚ð”ñ•\Ž¦‚É‚·‚é
        projectSetting.SetEnabled(true);
        scene_Content.style.display = DisplayStyle.Flex;
        sceneView.SetEnabled(false);
        

        projectSetting.clicked += () =>
        {
            project_Content.style.display = DisplayStyle.Flex;
            projectSetting.SetEnabled(false);
            scene_Content.style.display = DisplayStyle.None;
            sceneView.SetEnabled(true);
        };

        sceneView.clicked += () =>
        {
            project_Content.style.display = DisplayStyle.None;
            projectSetting.SetEnabled(true);
            scene_Content.style.display = DisplayStyle.Flex;
            sceneView.SetEnabled(false);
        };




    }
}

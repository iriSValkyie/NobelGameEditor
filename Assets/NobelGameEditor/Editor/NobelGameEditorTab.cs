/// <summary>
/// NobelGameEditorのタブ
/// </summary>
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Linq;
using UnityEngine.UIElements;
public class NobelGameEditorTab : VisualElement
{

    private Dictionary<EditorTab, VisualElement> TabDic;

    private List<Button> _buttons = new List<Button>();


    private void OnEnable()
    {
        foreach (string _tmp in System.Enum.GetNames(typeof(EditorTab)))
        {
            Button _button = new Button();
            _button.text = _tmp.ToString();
            
            _buttons.Add(_button);
            SetMargin(_button, 0); // 子要素のMarginはUSSで変更されないようにスクリプトで定義
            SetPadding(_button, 0); // 子要素のPaddingはUSSで変更されないようにスクリプトで定義
            Add(_button);
        }
    }

    private static void SetMargin(VisualElement element, float px)
    {
        element.style.marginLeft = px;
        element.style.marginTop = px;
        element.style.marginRight = px;
        element.style.marginBottom = px;
    }

    private static void SetPadding(VisualElement element, float px)
    {
        element.style.paddingLeft = px;
        element.style.paddingTop = px;
        element.style.paddingRight = px;
        element.style.paddingBottom = px;
    }
}



public enum EditorTab
{
    ProjectSetting,
    SceneMap,
}
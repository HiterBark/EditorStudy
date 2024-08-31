
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public enum E_Text
{
    one=1,
    two=2,
    five=4,
    one_two=1|2
}

public class Lesson2 : EditorWindow
{
    [MenuItem("unity编辑器扩展/Lesson2/显示自定义面板")]
    private static void ShowWindow()
    {
        Lesson2 win = EditorWindow.GetWindow<Lesson2>(false,"测试",false);
        win.titleContent = new GUIContent("测试55");
        win.Show();
    }
    private void CreateGUI()
    {
        //// Each editor window contains a root VisualElement object
        //VisualElement root = rootVisualElement;

        //// VisualElements objects can contain other VisualElement following a tree hierarchy
        //Label label = new Label("Hello World!");
        //root.Add(label);

        //// Create button
        //Button button = new Button();
        //button.name = "button";
        //button.text = "Button";
        //root.Add(button);

        //// Create toggle
        //Toggle toggle = new Toggle();
        //toggle.name = "toggle";
        //toggle.label = "Toggle";
        //root.Add(toggle);
    }
    int layle;
    string tag;
    Color color;
    E_Text e_Text;
    E_Text e_Text2;


    string[] strs = new string[] { "123", "456", "789" };
    int[] ints = new int[] { 123, 456, 789 };
    int laint;
    Sprite obj;
    int ifield;
    Vector2 vector2;
    Vector3 vector3;
    int ifield2;
    bool isHide;
    bool isHideGroup;
    bool isTagle;
    AnimationCurve animationCurve = new AnimationCurve();
    private void OnGUI()
    {

        EditorGUILayout.LabelField("dasdada", "cacasaa");
        layle = EditorGUILayout.LayerField("层级选择",layle);
        tag = EditorGUILayout.TagField("标签选择", tag);
        color = EditorGUILayout.ColorField(new GUIContent("颜色选择"), color, true, true, true);
        e_Text = (E_Text)EditorGUILayout.EnumPopup("枚举选择", e_Text);
        e_Text2 = (E_Text)EditorGUILayout.EnumFlagsField("枚举多选", e_Text2);
        EditorGUILayout.LabelField("ccccc", "cxcccc", "xxxxx");

        isTagle = EditorGUILayout.BeginToggleGroup("99999", isTagle);

        laint = EditorGUILayout.IntPopup("", laint, strs, ints);
        isHideGroup = EditorGUILayout.BeginFoldoutHeaderGroup(isHideGroup, "zzz");
        if (isHideGroup)
        {
            EditorGUILayout.LabelField(laint.ToString());
            if (EditorGUILayout.DropdownButton(new GUIContent("899966"), FocusType.Keyboard))
            {
                Debug.Log(4556666);
            }
        }
        isHide = EditorGUILayout.Foldout(isHide, "折叠", true);
        
        if (isHide)
        {
            obj = EditorGUILayout.ObjectField(obj, typeof(Sprite), false) as Sprite;

            ifield = EditorGUILayout.IntField(ifield);
            vector2 = EditorGUILayout.Vector2Field("666", vector2);
            vector3 = EditorGUILayout.Vector3Field("666", vector3);

            ifield2 = EditorGUILayout.DelayedIntField(ifield2);
            EditorGUILayout.LabelField(ifield2.ToString());

        }

        EditorGUILayout.HelpBox("fafasfa", MessageType.None,false);
        EditorGUILayout.HelpBox("fafasfa", MessageType.Info,false);
        EditorGUILayout.HelpBox("fafasfa", MessageType.Warning, false);
        EditorGUILayout.HelpBox("fafasfa", MessageType.Error, false);

        EditorGUILayout.EndToggleGroup();
        animationCurve = EditorGUILayout.CurveField("动画", animationCurve);

        if(Event.current.commandName=="85555")
        {
            Debug.Log("Test");
        }
        //GUILayout.Label("测试文本");
        //if (GUILayout.Button("测试按钮", GUILayout.Width(200), GUILayout.Height(500)))
        //{
        //    Debug.Log("Test");
        //}
    }
    private void OnHierarchyChange()
    {
        Debug.Log("变化OnHierarchyChange");
    }
    private void OnFocus()
    {
       // Debug.Log("获取焦点");
    }
    private void OnLostFocus()
    {
       // Debug.Log("失去焦点");
    }
    private void OnProjectChange()
    {
       // Debug.Log("当Project窗口发生变化时");
    }
    private void OnInspectorUpdate()
    {
        //Debug.Log("当Inspector窗口发生变化时");
    }
    private void OnSelectionChange()
    {
       // Debug.Log("选中对象发生变化时");
    }
}

public class Lesson7 : EditorWindow
{
    [MenuItem("Tools/Lesson7")]
    public static void ShowWindow7()
    {
        EditorWindow window = EditorWindow.CreateWindow<Lesson7>("88");
        window.titleContent = new GUIContent("Lesson7");
    }
    private int cenLa;
    private string tag;
    private Color color;
    private E_Text E_Text;
    private E_Text E_Textss;
    private Texture img;
    private void OnGUI()
    {
        if(GUILayout.Button("开打"))
        {
            EditorGUIUtility.ShowObjectPicker<Texture>(null, true, "Editors", 0);
        }

        if(Event.current.commandName=="ObjectSelectorUpdated")
        {
            img = EditorGUIUtility.GetObjectPickerObject() as Texture;
            if (img!=null)
            {
                Debug.Log(img.name);
            }
        }
        if(Event.current.commandName=="ObjectSelectorClosed")
        {
            img = EditorGUIUtility.GetObjectPickerObject() as Texture;
            if (img != null)
            {
                Debug.Log("光比"+img.name);
            }
        }
        if(GUILayout.Button("8888"))
        {
            if (img != null)
            {
                EditorGUIUtility.PingObject(img);
            }
        }
        if(GUILayout.Button("打开"))
        {
            Event t = EditorGUIUtility.CommandEvent("85555");
            Lesson2 lesson2 = EditorWindow.GetWindow<Lesson2>();
            lesson2.SendEvent(t);
        }

        EditorGUI.DrawRect(new Rect(100, 200, 100, 100),Color.yellow);
        EditorGUIUtility.AddCursorRect(new Rect(100, 200, 100, 100), MouseCursor.Text);
    }
}
public class Lesson9 : EditorWindow
{
    [MenuItem("Tools/Lesson9")]
    public static void ShowWindow9()
    {
        EditorWindow window = EditorWindow.CreateWindow<Lesson9>("99");
        window.titleContent = new GUIContent("Lesson7");
        //window.Show();
    }

    private void OnGUI()
    {
 
    }
}

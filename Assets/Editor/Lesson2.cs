
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
    [MenuItem("unity�༭����չ/Lesson2/��ʾ�Զ������")]
    private static void ShowWindow()
    {
        Lesson2 win = EditorWindow.GetWindow<Lesson2>(false,"����",false);
        win.titleContent = new GUIContent("����55");
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
        layle = EditorGUILayout.LayerField("�㼶ѡ��",layle);
        tag = EditorGUILayout.TagField("��ǩѡ��", tag);
        color = EditorGUILayout.ColorField(new GUIContent("��ɫѡ��"), color, true, true, true);
        e_Text = (E_Text)EditorGUILayout.EnumPopup("ö��ѡ��", e_Text);
        e_Text2 = (E_Text)EditorGUILayout.EnumFlagsField("ö�ٶ�ѡ", e_Text2);
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
        isHide = EditorGUILayout.Foldout(isHide, "�۵�", true);
        
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
        animationCurve = EditorGUILayout.CurveField("����", animationCurve);

        if(Event.current.commandName=="85555")
        {
            Debug.Log("Test");
        }
        //GUILayout.Label("�����ı�");
        //if (GUILayout.Button("���԰�ť", GUILayout.Width(200), GUILayout.Height(500)))
        //{
        //    Debug.Log("Test");
        //}
    }
    private void OnHierarchyChange()
    {
        Debug.Log("�仯OnHierarchyChange");
    }
    private void OnFocus()
    {
       // Debug.Log("��ȡ����");
    }
    private void OnLostFocus()
    {
       // Debug.Log("ʧȥ����");
    }
    private void OnProjectChange()
    {
       // Debug.Log("��Project���ڷ����仯ʱ");
    }
    private void OnInspectorUpdate()
    {
        //Debug.Log("��Inspector���ڷ����仯ʱ");
    }
    private void OnSelectionChange()
    {
       // Debug.Log("ѡ�ж������仯ʱ");
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
        if(GUILayout.Button("����"))
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
                Debug.Log("���"+img.name);
            }
        }
        if(GUILayout.Button("8888"))
        {
            if (img != null)
            {
                EditorGUIUtility.PingObject(img);
            }
        }
        if(GUILayout.Button("��"))
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

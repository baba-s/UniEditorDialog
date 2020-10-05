# UniEditorDialog

EditorUtility.DisplayDialog に関する記述を短く書けるようにするクラス

## 使用例

```cs
using Kogane;
using UnityEditor;

public class Example
{
    private static EditorDialog m_editorDialog = new EditorDialog( "【ここにタイトル】" );

    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        // OK ダイアログを開く
        m_editorDialog.OpenOk( "【ここにメッセージ】" );

        // はい・いいえダイアログを開く
        var isYes = m_editorDialog.OpenYesNo( "【ここにメッセージ】" );
    }
}
```

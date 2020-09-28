using UnityEditor;

namespace Kogane
{
	public sealed class EditorDialog
	{
		private readonly string m_title;

		public EditorDialog( string title )
		{
			m_title = title;
		}

		public void OpenOk( string message )
		{
			EditorUtility.DisplayDialog
			(
				title: m_title,
				message: message,
				ok: "OK"
			);
		}

		public bool OpenYesNo( string message )
		{
			return EditorUtility.DisplayDialog
			(
				title: m_title,
				message: message,
				ok: "はい",
				cancel: "いいえ"
			);
		}
	}
}
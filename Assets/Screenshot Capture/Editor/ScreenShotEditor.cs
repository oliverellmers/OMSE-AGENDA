

using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Turzo
{

	[CustomEditor(typeof(Capture))]

		public class ScreenShotEditor : Editor {

			public Texture banner = Resources.Load("banner") as Texture;

			// Use this for initialization
			void Start () {

			}

			// Update is called once per frame
			void Update () {

			}

			// Use this for initialization
			public override void OnInspectorGUI () {

				GUILayout.Box (banner, GUILayout.ExpandWidth(true));
				DrawDefaultInspector();
			}
		}
}



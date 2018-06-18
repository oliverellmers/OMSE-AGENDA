using UnityEngine;
using System.Collections;
using System.IO;

namespace Turzo
{

	public class Capture : MonoBehaviour 
	{
		
		[Header("➨ Select OS & path")]
		[Space(10)]

		[Tooltip("Status bar to show after capture & saving image")]
		public GameObject SavedTag;
		public enum SelectOS { Android, iOS};
		public SelectOS OS_Option;
		[Tooltip("Location to save the Screenshot into device")]
		public string LocationToSave =  "/mnt/sdcard/CaputreSave/";
		[Space(10)]

		// Check the Shot Taken/Not.
		private bool Shot_Taken = false;
		// Name of the File.
		private string Screen_Shot_File_Name;
		// Screenshot name after capturing
		private string fileName;


		void Start()
		{
			
			//------------------
			if (OS_Option == SelectOS.Android) {

				LocationToSave = "/mnt/sdcard/CaputreSave/";
			}

			else if (OS_Option == SelectOS.iOS) {

				LocationToSave = "/Documents/CaputreSave/";
			}


			//---------------------


			if (Directory.Exists (LocationToSave) == false) {
				Directory.CreateDirectory(LocationToSave);
			} 

			if (PlayerPrefs.GetInt ("ImageID") == 0) {
				PlayerPrefs.SetInt ("ImageID",0); 
			}
		}


		void Update(){



			if(Shot_Taken == true)
			{
				string Origin_Path = System.IO.Path.Combine(Application.persistentDataPath, Screen_Shot_File_Name);
				// This is the path of my folder.
				string Path = LocationToSave + Screen_Shot_File_Name;
				//string Path = "/mnt/sdcard/DCIM/Camera/" + Screen_Shot_File_Name;
				if(System.IO.File.Exists(Origin_Path))
				{
					System.IO.File.Move(Origin_Path, Path);

					//----------------
					GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true; // Show UI after we're done

					StartCoroutine("showMSG"); // Show save status bar after capturing
					Application.OpenURL(Path); // Instantly open the captured image 

					//----------------
					Shot_Taken = false;
				}
			}
		}



		public void captureScreenshot(){

			PlayerPrefs.SetInt ("ImageID",PlayerPrefs.GetInt ("ImageID")+1); // Increasing this value to seperate to avaoid replacing. Reinstalling app will make this value to 0 again.
			StartCoroutine(CaptureScreen());
		}

		public IEnumerator CaptureScreen()
		{

			GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;
			// Wait for screen rendering to complete
			yield return new WaitForEndOfFrame();
			//Screen_Shot_File_Name = "Screenshot__" + PlayerPrefs.GetInt ("ImageID")+ System.DateTime.Now.ToString("__yyyy-MM-dd") + ".png";
			Screen_Shot_File_Name = "Screenshot__" + PlayerPrefs.GetInt ("ImageID")+ ".png";
			ScreenCapture.CaptureScreenshot(Screen_Shot_File_Name);
			//Application.OpenURL(Screen_Shot_File_Name);
			Shot_Taken = true;


		}

		IEnumerator showMSG(){

			SavedTag.SetActive (true);
			yield return new WaitForSeconds (2.0f);
			SavedTag.SetActive (false); // Hide the save status bar after 2 seconds
		}
	}
}
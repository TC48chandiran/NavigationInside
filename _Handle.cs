using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using UnityEngine.SceneManagement;

//Custom 8
public partial class Wit3D : MonoBehaviour {

	public Text myHandleTextBox;
	private bool actionFound = false;

	void Handle (string jsonString) {
		
		if (jsonString != null) {

			RootObject theAction = new RootObject ();
			Newtonsoft.Json.JsonConvert.PopulateObject (jsonString, theAction);

			if (theAction.entities.find != null) {
				foreach (Find aPart in theAction.entities.find) {
					Debug.Log (aPart.value);
                   if(aPart.value=="food")
                        SceneManager.LoadScene("food");
                    if (aPart.value == "clothes")
                        SceneManager.LoadScene("clotheslist");
                    if(aPart.value == "footwear")
                        SceneManager.LoadScene("footwear");
                     if (aPart.value == "grocery")
                        SceneManager.LoadScene("grocary");
                     if (aPart.value == "mobile")
                        SceneManager.LoadScene("mobile");
                    if(aPart.value == "cinema")
                        SceneManager.LoadScene("cinema");
                    if(aPart.value == "fashion")
                        SceneManager.LoadScene("style");
                    if(aPart.value == "basics")
                        SceneManager.LoadScene("nagiv2");

                    //SceneManager.LoadScene("desert");
                   // myHandleTextBox.text = aPart.value;
                    actionFound = true;
				}
			}
			if (theAction.entities.navigate!= null) {
				foreach (Nagivate aPart in theAction.entities.navigate) {
					Debug.Log (aPart.value);
                    if (aPart.value == "basics")
                        SceneManager.LoadScene("nagiv2");
                    //wmyHandleTextBox.text = aPart.value;

                    actionFound = true;
				}
			}

			if (!actionFound) {
				myHandleTextBox.text = "Request unknown, please ask a different way.";
			} else {
				actionFound = false;
			}

 		}//END OF IF

 	}//END OF HANDLE VOID

}//END OF CLASS
	

//Custom 9
public class Find {
	public bool suggested { get; set; }
	public double confidence { get; set; }
	public string value { get; set; }
	public string type { get; set; }
}
public class Nagivate {
	public bool suggested { get; set; }
	public double confidence { get; set; }
	public string value { get; set; }
	public string type { get; set; }
}

public class Entities {
	public List<Find> find { get; set; }
	public List<Nagivate> navigate { get; set; }
}

public class RootObject {
	public string _text { get; set; }
	public Entities entities { get; set; }
	public string msg_id { get; set; }
}
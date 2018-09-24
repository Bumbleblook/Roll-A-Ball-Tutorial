using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

	// Send what scene index you want to go to
	public void LoadByIndex (int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);
	}
}

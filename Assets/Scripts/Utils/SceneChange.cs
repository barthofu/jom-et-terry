using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{

    public void GoToGame () {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}

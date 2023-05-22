using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void StartGame()
 {
 SceneManager.LoadScene("Work Scene");
 }
 public void QuitGame()
 {
 Application.Quit();
 }

}

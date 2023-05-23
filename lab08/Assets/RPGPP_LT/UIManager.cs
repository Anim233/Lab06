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
 public void BackGame()
 {
 SceneManager.LoadScene("Start Scene");
 }
 public void QuitGame()
 {
 Application.Quit();
 }

}

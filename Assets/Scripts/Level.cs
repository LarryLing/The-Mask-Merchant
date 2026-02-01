using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
  public void ReturnToMainMenu()
  {
    SceneManager.LoadScene(0);
  }
}

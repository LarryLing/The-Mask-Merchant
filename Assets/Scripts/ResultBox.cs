using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class ResultBox : MonoBehaviour
{
    public TextMeshProUGUI resultText;

    private float typingSpeed = 0.01f;

    IEnumerator TypeLine(string description)
    {
        resultText.text = string.Empty;
        foreach (char letter in description.ToCharArray())
        {
            resultText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void ShowResult(string resultMessage)
    {
        StartCoroutine(TypeLine(resultMessage));
    }

    public void ContinueToNextLevel()
    {
        int nextSceneIndex;
        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
        {
            nextSceneIndex = 0;
        }
        else
        {
            nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        }

        SceneManager.LoadScene(nextSceneIndex);
    }
}

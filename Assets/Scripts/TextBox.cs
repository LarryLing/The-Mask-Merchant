using System.Collections;
using UnityEngine;
using TMPro;

public class TextBox : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public GameObject characterTextBox;
    public GameObject playerTextBox;
    public GameObject nextButton;
    public GameObject prevButton;
    public string[] dialogueLines;
    public bool isCharacterSpeakingFirst;

    private int currentLineIndex = 0;
    private float typingSpeed = 0.01f;

    void Start()
    {
        dialogueText.text = string.Empty;

        prevButton.SetActive(false);

        characterTextBox.SetActive(isCharacterSpeakingFirst);
        playerTextBox.SetActive(!isCharacterSpeakingFirst);

        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        dialogueText.text = string.Empty;
        foreach (char letter in dialogueLines[currentLineIndex].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    void SwapTextBox()
    {
        characterTextBox.SetActive(!characterTextBox.activeSelf);
        playerTextBox.SetActive(!playerTextBox.activeSelf);
    }

    public void HandleNextButton()
    {
        StopAllCoroutines();

        if (currentLineIndex < dialogueLines.Length - 1)
        {
            currentLineIndex++;
            StartCoroutine(TypeLine());

            if (currentLineIndex == dialogueLines.Length - 1)
            {
                nextButton.SetActive(false);
            }

            if (prevButton.activeSelf == false)
            {
                prevButton.SetActive(true);
            }

            SwapTextBox();
        }
    }

    public void HandlePrevButton()
    {
        StopAllCoroutines();

        if (currentLineIndex > 0)
        {
            currentLineIndex--;
            StartCoroutine(TypeLine());

            if (currentLineIndex == 0)
            {
                prevButton.SetActive(false);
            }

            if (nextButton.activeSelf == false)
            {
                nextButton.SetActive(true);
            }

            SwapTextBox();
        }
    }
}

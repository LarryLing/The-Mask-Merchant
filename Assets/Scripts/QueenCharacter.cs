using UnityEngine;

public class QueenCharacter : MonoBehaviour
{
    public GameObject masked;
    public GameObject unmasking;
    public GameObject unmasked;
    public GameObject remasked;

    public TextBox textBox;

    public string successMessage;
    public string failureMessage;

    void Start()
    {
        masked.SetActive(true);
        unmasking.SetActive(false);
        unmasked.SetActive(false);
        remasked.SetActive(false);
    }

    void Update()
    {
        if (textBox.currentLineIndex == 0)
        {
            masked.SetActive(true);
            unmasking.SetActive(false);
            unmasked.SetActive(false);
            remasked.SetActive(false);
        }
        else if (textBox.currentLineIndex == 2)
        {
            masked.SetActive(false);
            unmasking.SetActive(true);
            unmasked.SetActive(false);
            remasked.SetActive(false);
        }
        else if (textBox.currentLineIndex == 4)
        {
            masked.SetActive(false);
            unmasking.SetActive(false);
            unmasked.SetActive(true);
            remasked.SetActive(false);
        }
    }

    public void SwitchToMasked()
    {
        masked.SetActive(false);
        unmasking.SetActive(false);
        unmasked.SetActive(false);
        remasked.SetActive(true);
    }
}

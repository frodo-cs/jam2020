using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogStory : MonoBehaviour
{
    public Dialog dialog;

    Queue<string> sentences;

    public GameObject dialogPanel;
    public TextMeshProUGUI displayText;

    string activeSentence;
    public float typingSpeed;

    AudioSource myAudio;
    public AudioClip speakSound;
    private bool verificar = false;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        myAudio = GetComponent<AudioSource>();
        dialogPanel.SetActive(true);
        StartDialogue();

    }

    void StartDialogue()
    {
        sentences.Clear();
        foreach (string sentence in dialog.sentencesList)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    void DisplayNextSentence()
    {
        if (sentences.Count <= 0)
        {
            displayText.text = activeSentence;
            return;
        }
        activeSentence = sentences.Dequeue();
        displayText.text = activeSentence;

        StopAllCoroutines();
        StartCoroutine(TypeTheSentence(activeSentence));
    }

    IEnumerator TypeTheSentence(string sentence)
    {
        displayText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            displayText.text += letter;
            //myAudio.PlayOneShot(speakSound);
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Return) && displayText.text == activeSentence)
            {
                DisplayNextSentence();
            }

    }

}

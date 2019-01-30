using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnimatedText : MonoBehaviour
{
    //The time for each letter to appear - The lower it is, the faster letters appear
    public float letterPauseRate = 0.5f;
    //Message that will be displayed
    public string messageText;
    //Text for the message to display
    public Text assignedText;    

    void Start()
    {
        //Get text component
        assignedText = GetComponent<Text>();
        //messageText will display assignedText
        messageText = assignedText.text;
        //Sets the assignedText to be blank
        assignedText.text = "";
        //Calls the function
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        //Split each char into a char array
        foreach (char letter in messageText.ToCharArray())
        {
            //Add 1 letter each time
            assignedText.text += letter;
            yield return 0;
            // Waits for seconds assigned in letterPauseRate (eg. 0.5f)
            yield return new WaitForSeconds(letterPauseRate);
        }
    }
}
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

// SO is working but can't acces the buttons TMP

public class SceneC2 : MonoBehaviour {

    [SerializeField] public DialogueControl dial;
    private string myString;
    private TextMeshPro curDialogue;  // TextMeshProUGUI
    private Button myButton;
    [SerializeField] public Button button;

    public void Start() {
        myButton = button.GetComponent<Button>();
        myString = dial.dialogue[0];
        curDialogue = myButton.GetComponent<TextMeshPro>(); // textmeshpro is always null //  TextMeshProUGUI
        curDialogue.text= myString; ///not working  
        Debug.Log(myString);
        Debug.Log(curDialogue);

        
    }
    public void OnDialogue(){
        curDialogue.SetText(myString);
    }

    
}

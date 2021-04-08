using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // Implement this namespace if you are using interfaces to handle events
using TMPro; // Don't forget to import this

// We can detect button presses using an interface
// Add the IPointerClickHandler
public class Activities5 : MonoBehaviour
{

    //////////////////////////////////////////////////////
    // Session 18 Activities 5

    // Goal: Change the text on a string and debug to the console when the button is pressed
    // Change the text when the button is pressed

    public TextMeshProUGUI textObject;


    //  This way is the simplest way!
    // So the way buttons work is that they will run a certain method or function when an event is ran

    public void ChangeText() {
        textObject.text = "Anything we want.";
    }

    // This is the more complex way
    // Uses IPointerClickHandler
    public void OnPointerClick(PointerEventData eventData) {
        ChangeText();
    }

}

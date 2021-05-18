using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour, IPointerEnterHandler {

    public AudioSource buttonNoise;

    // Play the button hover noise when the pointer is over
    public void OnPointerEnter(PointerEventData eventData) {
        buttonNoise.Play();
    }

    // Play the game (load the game scene) when button is pressed
    public void PlayGame() {
        SceneManager.LoadScene("Game");
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SliderScript : MonoBehaviour
{
    public Slider beagleSlider;
    public TextMeshProUGUI beagleSliderText;
    private int menu = 0;

    private void Awake()
    {
        beagleSlider.value = PlayerPrefs.GetFloat("speed");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        beagleSliderText.text = "Selected: " + beagleSlider.value;
    }

    public void Back()
    {
        PlayerPrefs.SetFloat("speed", beagleSlider.value);
        SceneManager.LoadScene(menu);
    }
}

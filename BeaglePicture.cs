using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeaglePicture : MonoBehaviour
{
    public GameObject beagleOne;
    public GameObject beagleTwo;
    public GameObject beagleThree;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Menu.gameIsOver == true)
        {
            ChooseBeagle();
        }
    }

    public void ChooseBeagle()
    {
        if (Menu.gameIsOver == true)
        {
            if (beagleOne.activeInHierarchy == false && beagleTwo.activeInHierarchy == false && beagleThree.activeInHierarchy == false)
            {
                int chosen = Random.Range(0, 2);

                if (chosen == 0)
                {
                    beagleOne.SetActive(true);
                    beagleTwo.SetActive(false);
                    beagleThree.SetActive(false);
                }
                else if (chosen == 1)
                {
                    beagleOne.SetActive(false);
                    beagleTwo.SetActive(true);
                    beagleThree.SetActive(false);
                }
                else if (chosen == 2)
                {
                    beagleOne.SetActive(false);
                    beagleTwo.SetActive(false);
                    beagleThree.SetActive(true);
                }
            }
        }
    }
}

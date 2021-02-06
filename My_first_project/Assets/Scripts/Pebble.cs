using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Pebble : MonoBehaviour
{
    
    public GameObject bird;
    private Control birdControl;
    // Start is called before the first frame update
    void Start()
    {
        birdControl = bird.GetComponent<Control>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {

            gameObject.SetActive(false);
            if (birdControl)
            {
                birdControl.scoreCount++;
                birdControl.score.text = "Score : " + birdControl.scoreCount;
                birdControl.CreateSegment();
            }
        }
}

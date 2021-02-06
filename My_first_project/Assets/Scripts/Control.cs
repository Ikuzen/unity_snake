using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Control : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int scoreCount = 0;
    public GameObject prefabBirdSegment;
    private GameObject tmpGO;
    private Segment lastSegment = null;
    private Segment tmpSegment;
    public static Control instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = new Vector3(
            transform.position.x, 
            transform.position.y, 
            Camera.main.transform.position.z
           );
        if (Input.GetKey(KeyCode.Z))
            transform.position += new Vector3(0, 0.01f, 0);
        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0, - 0.01f, 0);
        if (Input.GetKey(KeyCode.Q))
            transform.position += new Vector3(-0.01f, 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(0.01f, 0, 0);

    }

    public void CreateSegment()
    {
        tmpGO = GameObject.Instantiate(prefabBirdSegment);
        tmpSegment = tmpGO.GetComponent<Segment>();
        if (lastSegment)
        {
        tmpGO.transform.position = lastSegment.transform.position;
        tmpSegment.previous = lastSegment;
        lastSegment.next = tmpSegment;
        }
        else
        {
            tmpGO.transform.position = transform.position;
        }
        lastSegment = tmpSegment;
        
    }


}

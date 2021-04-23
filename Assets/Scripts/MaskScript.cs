using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskScript : MonoBehaviour
{
    Transform parent;
    public GameObject parentCanvas;

    float yStart;
    [Range(0, 70)]
    public float xVal;

    public float xDist;
    public float yDist;

    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RectTransform objectRectTransform = parentCanvas.GetComponent<RectTransform>();

        if (xVal > 70)
            xVal = 70;
        else if (xVal < 0)
            xVal = 0;

        float x = xVal - 300;
        
        transform.position = new Vector3(objectRectTransform.rect.width - xDist, yDist + (-130), 0);
        parent.transform.position = new Vector3(objectRectTransform.rect.width - xDist, yDist + (x + 100), 0);
    }
}

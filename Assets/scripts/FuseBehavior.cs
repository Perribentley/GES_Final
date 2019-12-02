using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuseBehavior : MonoBehaviour
{

    private int FuseCount;
    [SerializeField] Text Fuses;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "Fuse")
        {
            FuseCount += 1;
            Debug.Log(FuseCount);
            SetFuseText();
            gameObject.SetActive(false);
        }
    }

    void SetFuseText()
    {
        Fuses.text = "Fuses: " + FuseCount.ToString();
    }
}

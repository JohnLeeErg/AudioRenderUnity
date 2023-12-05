using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLayer : MonoBehaviour
{
    [SerializeField] GameObject[] layers;
    [SerializeField] float layerDelay, layerTimer;
    int index = 0;
    // Start is called before the first frame update
    void Awake()
    {
        foreach( GameObject each in layers)
        {
            each.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (index < layers.Length)
        {
            layerTimer += Time.deltaTime;
            if (layerTimer > layerDelay)
            {
                layers[index].SetActive(true);
                index++;
                layerTimer = 0;

            }
        }
    }
}

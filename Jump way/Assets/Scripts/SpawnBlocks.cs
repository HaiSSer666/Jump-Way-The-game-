﻿using UnityEngine;
using System.Collections;

public class SpawnBlocks : MonoBehaviour {

    public GameObject block;
    private GameObject blockInstantiate;
    private Vector3 targetPosition;
    private float speed = 3.0f;

    void Start ()
    {
        targetPosition = new Vector3(Random.Range(2.7f, 3.7f), Random.Range(-3.0f, 0.0f), 1.7f);
        blockInstantiate = Instantiate(block, new Vector3(7.0f, -7.0f, 0.0f), Quaternion.identity) as GameObject;
        blockInstantiate.transform.localScale = new Vector3(RandomizeScale(), blockInstantiate.transform.localScale.y, blockInstantiate.transform.localScale.z);
	}

    private void Update()
    {
        if(blockInstantiate.transform.position != targetPosition)
        {
            blockInstantiate.transform.position = Vector3.MoveTowards(blockInstantiate.transform.position, targetPosition, Time.deltaTime * speed);
        }
    }

    float RandomizeScale ()
    {
        float rand;
        if (Random.Range (0, 100) > 80)
        {
            rand = Random.Range(1.2f, 2.0f);
        }
        else
        {
            rand = Random.Range(1.2f, 1.5f);
        }
        return rand;
    }
}

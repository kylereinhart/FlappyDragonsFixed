using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpandDown : MonoBehaviour
{
    [SerializeField] private float m_heightVariance;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * m_heightVariance;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiDenChet : MonoBehaviour
{
    [SerializeField] private GameObject playerTransform;
    [SerializeField] private float speed;
    private Transform enemyTransform;

    private void DidenChet()
    {
          transform.position = Vector2.MoveTowards(transform.position,enemyTransform.transform.position,speed*Time.deltaTime);
    }
    private void Start()
    {
        enemyTransform = playerTransform.transform;
    }
    private void Update()
    {
        DidenChet();
    }
}

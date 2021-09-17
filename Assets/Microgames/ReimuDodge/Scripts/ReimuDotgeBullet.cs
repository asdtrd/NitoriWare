using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReimuDotgeBullet : MonoBehaviour
{
    [Header ("target")]
    [SerializeField]
    private GameObject target;
    private Vector2 targetVec;
    // Start is called before the first frame update
    void Start()
    {
        targetVec = (target.transform.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if (targetVec != null)
        {
            transform.position = (Vector2)transform.position + (targetVec * Time.deltaTime);
        }
    }
}

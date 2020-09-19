using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField] private GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        var destroyer = collision.gameObject.GetComponent<Destroyer>();

        

        if (destroyer != null)
        {
                Destroy(obj, 3.0f);
        }
    }
}

using UnityEngine;
using System.Collections;

namespace HP
{
    public class Shoot : MonoBehaviour
    {
        private float fireRate = 0.3f;
        private float nextFire;
        private RaycastHit hit;
        private float range = 300;
        private Transform MyTransform;

        // Use this for initialization
        void Start()
        {
            setInitialReferences();
        }

        // Update is called once per frame
        void Update()
        {
            Fire();
        }

        void setInitialReferences()
        {
            MyTransform = transform;
        }

        void Fire()
        {
            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                FindingObject();
            }
        }

        void FindingObject()
        {
            Debug.DrawRay(MyTransform.TransformPoint(0, 0, 0.5f), MyTransform.forward, Color.green,3f);
            if(Physics.Raycast(MyTransform.TransformPoint(0,0,0.5f),MyTransform.forward,out hit,range))
            {
                Debug.Log(hit.transform.name);
            }
        }
    }
}

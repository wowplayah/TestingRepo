using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

namespace HP
{
    public class Swimming : MonoBehaviour
    {

        RigidbodyFirstPersonController.MovementSettings MS;
        float thrust = 3f;
        Rigidbody rb;
        // Use this for initialization
        void Start()
        {
            RenderSettings.fog = false;
            RenderSettings.fogColor = new Color(0.2f, 0.4f, 0.8f, 0.5f);
            RenderSettings.fogDensity = 0.04f;
            rb = GameObject.Find("FPSController").GetComponent<Rigidbody>();
            MS = GameObject.Find("FPSController").GetComponent<RigidbodyFirstPersonController.MovementSettings>();
        }

        bool isUnderWater()
        {
            return gameObject.transform.position.y < 0.1051623;
        }

        // Update is called once per frame
        void Update()
        {
            RenderSettings.fog = isUnderWater();
            if (isUnderWater())
            {
                MS.CurrentTargetSpeed = 2f;
                MS.JumpForce = 0f;
                if (Input.GetKey(KeyCode.R))
                {
                    rb.AddForce(new Vector3(rb.velocity.x, thrust, rb.velocity.z));
                }
            }
            else
            {
                MS.CurrentTargetSpeed = 8f;
                MS.JumpForce = 30f;
            }
        }
    }

}

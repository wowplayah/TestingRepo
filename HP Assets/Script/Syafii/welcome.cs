using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace HP
{
    public class welcome : MonoBehaviour
    {
        private Text textWelcome;
        private string Welcome = "Welcome!";
        private Canvas canvas;

        // Use this for initialization
        void Start()
        {
            setInitialReference();
        }

        void setInitialReference()
        {
            textWelcome = GameObject.Find("textWelcome").GetComponent<Text>();
            textWelcome.text = Welcome;
            canvas = GameObject.Find("CanvasWelcome").GetComponent<Canvas>();
            StartCoroutine(destroyWelcome());
        }

        IEnumerator destroyWelcome()
        {
            yield return new WaitForSeconds(3f);
            canvas.enabled = false;
        }
    }

}

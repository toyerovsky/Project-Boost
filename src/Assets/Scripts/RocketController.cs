using UnityEngine;

namespace Assets.Scripts
{
    public class RocketController : MonoBehaviour
    {
        private Rigidbody rigidbody;

        // Use this for initialization
        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            ProcessInput();
        }

        private void ProcessInput()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rigidbody.AddRelativeForce(Vector3.up);
            }

            if (Input.GetKey(KeyCode.A))
            {

            }
            else if (Input.GetKey(KeyCode.D))
            {

            }
        }
    }
}

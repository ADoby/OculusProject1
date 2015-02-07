using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;

namespace UnitySampleAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController car; // the car controller we want to use

        public float horizontal = 0f;
        public float vertical = 0f;

        private void Awake()
        {
            // get the car controller
            car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            //horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
            //vertical = CrossPlatformInputManager.GetAxis("Vertical");
            vertical = 0.1f;
            car.Move(horizontal, vertical);
        }
    }
}
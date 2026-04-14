using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class spin : MonoBehaviour
{

    public float angle1 = 30;
    public float angle2 = -30;

    private float targetAngle;

    public float swingspeed = 30;

    private void Start()
    {
        targetAngle = angle1;
    }

    private void Update()
    {
        float currentAngle = transform.eulerAngles.z;



        if (currentAngle > 180)
        {
            currentAngle = currentAngle - 360;
        }


        float angleProgression = Mathf.MoveTowards(currentAngle, targetAngle, swingspeed * Time.deltaTime);


        transform.rotation = Quaternion.Euler(0, 0, angleProgression);

        if (angleProgression == targetAngle)
        {
            if (targetAngle == angle1)
            {
                targetAngle = angle2;
            }

            else
            {
                targetAngle = angle1;
            }
        }
    }
    /* public float rotationspeed = 50f;





     private void Update()
     {
         transform.Rotate(Vector3.up * 0f 0f, 180f);


       }
     */




}

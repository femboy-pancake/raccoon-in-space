using UnityEngine;

public class spin2 : MonoBehaviour
{
   

    public float angle1 = 30;
    public float angle2 = -30;

    private float targetAngle;

    public float swingspeed = 30;

    private void Start()
    {
        targetAngle = angle2;
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
            if (targetAngle == angle2)
            {
                targetAngle = angle1;
            }

            else
            {
                targetAngle = angle2;
            }
        }
    }
}

using UnityEngine;

public class Shotgun : Gun
{
    public int bulletPerShot = 8;
    [Range(0f, 180f)] public float spread = 0.0f;

    protected override void Shoot()
    {
        //If the timer has finished counting down
        if (timer.IsFinished())
        {
            //Reset the timer
            timer.StartTimer(timeBetweenShots);

            for (int i = 0; i < bulletPerShot; i++)
            {
                //The angle within the shotgun's spread cone
                float randomSpread = Random.Range(-spread/2, spread/2);
                //Angle to create the bullet cone
                float coneSpread = Random.Range(0f, 360f);

                //The original direction the gun will shoot in
                Vector3 originalDir = transform.parent.forward;
                //Find the axis of rotation for applying spread
                Vector3 axis = Vector3.Cross(originalDir, Vector3.up);
                //Rotate the originalDir around the axis by randomSpread degrees
                Vector3 spreadDir = Quaternion.AngleAxis(randomSpread, axis) * originalDir;
                //Rotate the spreadDir around the originalDir by coneSpread degrees
                Vector3 finalDir = Quaternion.AngleAxis(coneSpread, originalDir) * spreadDir;

                //Do the raycast and store the info from it in hit
                RaycastHit hit;
                if (Physics.Raycast(transform.parent.position, finalDir * range, out hit))
                {
                    GameObject newMarker = Instantiate(hitMarker, hit.point, Quaternion.identity);
                }
            }
        }
    }
}

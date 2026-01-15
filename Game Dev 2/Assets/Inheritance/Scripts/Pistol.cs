using UnityEngine;
using UnityEngine.Timeline;

public class Pistol : Gun
{
    protected override void Shoot()
    {
        //If the timer has finished counting down
        if (timer.IsFinished())
        {
            //Reset the timer
            timer.StartTimer(timeBetweenShots);

            //Do the raycast and store the info from it in hit
            RaycastHit hit;
            if (Physics.Raycast(transform.parent.position, transform.parent.forward * range, out hit))
            {
                GameObject newMarker = Instantiate(hitMarker, hit.point, Quaternion.identity);
            }
        }
    }
}

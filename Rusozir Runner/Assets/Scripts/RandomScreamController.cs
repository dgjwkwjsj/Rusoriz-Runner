using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScreamController : MonoBehaviour
{
    [SerializeField] private List<AudioClip> screamClips;

    private void Start()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(Random.Range(1f, 5f));

            int randomIndex = Random.Range(0, screamClips.Count);
            Audio.instance.PlayScream(screamClips[randomIndex]);
            
        }
    }
}

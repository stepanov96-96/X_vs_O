using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class InternetCheck : MonoBehaviour
{
    [SerializeField] private string[] uris;
    public IEnumerator TestConection(Action<bool> callback) 
    {
        foreach (string uri in uris) 
        {
            UnityWebRequest request = UnityWebRequest.Get(uri);

            yield return request.SendWebRequest();

            if (request.isNetworkError == false) 
            {
                callback(true);
                yield break;
            
            }
        }

        callback(false);
    
    }
   
}

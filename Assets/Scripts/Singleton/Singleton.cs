using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T Instance;

    public virtual void Awake ()
	{
		Initialize();
	}

    public static T GetInstance()
    {
        return Instance;
    }

    public static void SetInstance(T newInstance)
    {
        Instance = newInstance;
    }

    void Initialize()
    {
        if (Instance == null) {
			Instance = this as T;
			DontDestroyOnLoad (this);
		} else {
			Destroy (gameObject);
		}
    }
}

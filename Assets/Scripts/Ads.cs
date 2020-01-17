using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{
	static int loadCount = 0;

	void Start()
	{
		if (loadCount % 1 == 0)  // only show ad every third time
		{
//			ShowAd ();
		}
		loadCount++;
	}

//	public void ShowAd()
//	{
//		if (Advertisement.IsReady())
//		{
//			Advertisement.Show();
//		}
//	}
}
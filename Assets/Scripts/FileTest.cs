using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileTest : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start ()
    {
        // テストデータの文字列
        string test_data_str = string.Empty;

        // TestData読み込み(ロード)
        yield return FIleManager.ReadFileText(r => test_data_str = r, "/Data/TestData.txt");

        // 読み込んだテストデータの文字列を表示
        Debug.Log(test_data_str);

        // TestData書き込み(セーブ)
        FIleManager.WriteText("/Data", "/TestData.txt", "テストデータに書き込みました！");

        // 書き込んだTestDataを読み込み(ロード)
        yield return FIleManager.ReadFileText(r => test_data_str = r, "/Data/TestData.txt");

        // 読み込んだテストデータの文字列を表示
        Debug.Log(test_data_str);
    }
}

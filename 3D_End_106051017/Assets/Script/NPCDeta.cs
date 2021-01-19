
using UnityEngine;
[CreateAssetMenu(fileName ="NPC 資料", menuName ="Elaine/NPC 資料")]
public class NPCDeta : ScriptableObject
{
    [Header("第一段對話")]
    public string dialougA;
    [Header("第二段對話")]
    public string dialougB;
}

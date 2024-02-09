using Unity.Netcode;
using UnityEngine;

namespace Phyw.Networking
{

  public class JoinSession : MonoBehaviour
  {


    #region CustomMethods
    public void CreateHost()
    {
      NetworkManager.Singleton.StartHost();
    }

    public void CreateClient()
    {
      NetworkManager.Singleton.StartClient();
    }
    #endregion

  }
}
using Unity.Netcode.Components;

namespace Phyw.Networking
{

  public class ClientNetworkTransform : NetworkTransform
  {
    protected override bool OnIsServerAuthoritative()
    {
      return false;
    }
  }
}
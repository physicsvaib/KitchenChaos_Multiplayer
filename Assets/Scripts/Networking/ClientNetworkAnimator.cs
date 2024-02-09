using Unity.Netcode.Components;

namespace Phyw.Networking
{

  public class ClientNetworkAnimator : NetworkAnimator
  {

    protected override bool OnIsServerAuthoritative()
    {
      return false;
    }

  }
}
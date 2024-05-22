using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexterOpcUaTestServer.States
{
  public interface IState
  {
    string StateName { get; }
    void StartServer();
    void StopServer();
    void StartStopMeasuring();
    void ChangeProduct(string product);
    void ChangeRecipe(string recipe);
    void OpenSettings();
  }
}

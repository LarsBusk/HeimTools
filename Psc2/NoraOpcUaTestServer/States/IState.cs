using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoraOpcUaTestServer.States
{
  public interface IState
  {
    string StateName { get; }
    bool ForceMeasure { get; set; }
    void StartServer();
    void StopServer();
    void StartStopMeasuring(string product);
    void ChangeProduct(string product);
    void EnqueueZero();
    void EnqueueRinse();
    void OpenSettings();
    void SetCip();
  }
}

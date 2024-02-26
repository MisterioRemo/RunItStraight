using System.Collections;
using UnityEngine;
using Zenject;
using static UnityEngine.InputSystem.InputAction;

namespace ris.polyomino
{
  public class PolyominoMovement : MonoBehaviour
  {
    #region PARAMETERS
    [Inject] private RISInputActions inputActions;
    #endregion

    #region LIFECYCLE
    private void Start()
    {
      inputActions.Player.Movement.started += MovementStarted;
    }

    private void OnDestroy()
    {
      inputActions.Player.Movement.started -= MovementStarted;
    }
    #endregion

    #region INPUT ACTIONS CALLBACKS
    private void MovementStarted(CallbackContext _context)
    {
    }
    #endregion
  }
}

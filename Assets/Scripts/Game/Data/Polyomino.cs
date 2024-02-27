using UnityEngine;

namespace ris.polyomino
{
  public class Polyomino : MonoBehaviour
  {
    #region PROPERTIES
    [field: SerializeField]
    public Vector3 Direction { get; private set; } = Vector3.forward;
    #endregion

    #region INTERFACE
    public void Move(Vector3 _direction)
    {
      transform.position += _direction;
    }
    public void Move(Vector2 _direction)
    {
      Move(new Vector3(_direction.x, 0, _direction.y));
    }
    #endregion
  }
}

using UnityEngine;

namespace ris
{
  public class GridPlacementSystem : MonoBehaviour
  {
    #region CONSTANTS
    private const int SCALE_TO_POS = 10;
    #endregion

    #region PARAMETERS
    [SerializeField] private Renderer gridRenderer;
    #endregion

    #region PROPERTIES
    [field: SerializeField]
    public float CellSize { get; private set; } = 1.0f;

    [field: SerializeField]
    public Vector2 GridSize { get; private set; } = Vector2.one;
    #endregion

#if UNITY_EDITOR
    private void OnValidate()
    {
      UpdateGrid();
    }
#endif

    #region LIFECYCLE
    void Start()
    {

    }

    void Update()
    {

    }
    #endregion

    #region METHODS
    private void EnableGridVisualization(bool _value)
    {
      if (gridRenderer == null) return;
      gridRenderer.gameObject.SetActive(_value);
    }

    private void UpdateGrid()
    {
      if (gridRenderer == null) return;

      gridRenderer.sharedMaterial.SetVector("_Cell_Size", new Vector4(CellSize, CellSize, 0.0f, 0.0f));
      gridRenderer.gameObject.transform.SetGlobalScale(new Vector3(GridSize.x, 0.0f, GridSize.y));
      gridRenderer.gameObject.transform.position = new Vector3(SCALE_TO_POS * GridSize.x / 2 , 0.0f, SCALE_TO_POS * GridSize.y / 2);
    }
    #endregion
  }
}

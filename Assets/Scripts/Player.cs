using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        // Start with the number of seeds assigned in the Inspector
        _numSeedsLeft = _numSeeds;

        // Update UI at the beginning
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);


    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, 0f) * _speed * Time.deltaTime;
        _playerTransform.position += movement;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }

    }

    public void PlantSeed ()
    {
        if(_numSeedsLeft <= 0)
            return;

       
        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);

       
        _numSeedsLeft--;

     
        _numSeedsPlanted++;


        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);


    }
}

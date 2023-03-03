using UnityEngine;
using Asteroids.Model;

public class SpawnExample : MonoBehaviour
{
    [SerializeField] private PresentersFactory _factory;
    [SerializeField] private Root _init;

    private int _index;
    private float _secondsPerIndex = 1f;

    private void Update()
    {
        int newIndex = (int)(Time.time / _secondsPerIndex);

        if(newIndex > _index)
        {
            _index = newIndex;
            OnTick();
        }
    }

    private void OnTick()
    {
        float chance = Random.Range(0, 100);

        if (chance < 40)
        {
            NloArmy nloGreen = new NloArmy(GetRandomPositionOutsideScreen(), Config.NloSpeed);
            NloArmy nloRed = new NloArmy(GetRandomPositionOutsideScreen(), Config.NloSpeed);

            nloGreen.SetTarget(nloRed);
            nloRed.SetTarget(nloGreen);

            _factory.CreateNlo(nloRed, "red");
            _factory.CreateNlo(nloGreen, "green");

        }
        else
        {
            //Vector2 position = GetRandomPositionOutsideScreen();
            //Vector2 direction = GetDirectionThroughtScreen(position);

            //_factory.CreateAsteroid(new Asteroid(position, direction, Config.AsteroidSpeed));
        }
    }

    private Vector2 GetRandomPositionOutsideScreen()
    {
        return Random.insideUnitCircle.normalized + new Vector2(0.5F, 0.5F);
    }

    private static Vector2 GetDirectionThroughtScreen(Vector2 postion)
    {
        return (new Vector2(Random.value, Random.value) - postion).normalized;
    }
}

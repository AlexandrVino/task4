using UnityEngine;
using Asteroids.Model;


struct NloPosition
{
    public Vector2 first;
    public Vector2 second;
}

public class SpawnExample : MonoBehaviour
{
    [SerializeField] private PresentersFactory _factory;
    [SerializeField] private Root _init;

    private int _index;
    private float _secondsPerIndex = 1f;

    private void Update()
    {
        int newIndex = (int)(Time.time / _secondsPerIndex);

        if (newIndex > _index)
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
            NloPosition nloPositions = GetRandomPositionNloOutsideScreen();

            NloArmy nloGreen = new NloArmy(nloPositions.first, Config.NloSpeed);
            NloArmy nloRed = new NloArmy(nloPositions.second, Config.NloSpeed);

            nloGreen.SetTarget(nloRed);
            nloRed.SetTarget(nloGreen);

            _factory.CreateNlo(nloRed, Color.red);
            _factory.CreateNlo(nloGreen, Color.green);

        }
        else
        {
            Vector2 position = GetRandomPositionOutsideScreen();
            Vector2 direction = GetDirectionThroughtScreen(position);

            _factory.CreateAsteroid(new Asteroid(position, direction, Config.AsteroidSpeed));
        }
    }

    private NloPosition GetRandomPositionNloOutsideScreen()
    {
        Vector2 vector = Random.insideUnitCircle.normalized;

        NloPosition data;

        data.first = vector;
        data.second = data.first * -1 + new Vector2(Random.Range(0.5f, 1.5f), Random.Range(0.5f, 1.5f));


        return data;
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

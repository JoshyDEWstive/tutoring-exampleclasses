using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example24_1 : MonoBehaviour
{


    /////////////////////////////////////////////////
    // Perlin Noise

    // Main Modifiers that we are going to focus on right now
    // Scale
    // Zooming in/out of the perlin map so that will give you extra or less detail
    // Offset
    // Changing where we are looking on the perlin map

    
    public float PerlinNoiseExample()
    {

        // The main function we will be using for perlin noise is
        // Mathf.Perlin(float x,float y);

        // IMPORTANT
        // The values for X and Y MUST be either in between 0 and 1 OR they MUST have a decimal in them.
        // You can values like 0.5, 0.75, 1.1 etc
        // But you CANNOT have values like 1,2,3,4 etc

        // Order of operations for perlin noise

        // 1. Find our offsets
        // 2. Find our x and y coordinate
        // 3. Generate the perlin noise
        // 4. Apply our scale

        // Offsets

        // We need to decide our offsets
        // So you can do this randomly or you can give them an offset manually
        // So for example
        // You can use a seed to determine the offsets (like you have seeds in Minecraft)

        // Manual way

        // This can be your world seed for example.
        int seed = 32362632;

        // Ensure that offsets are floats
        float offsetX = (float) seed;
        float offsetY = (float) seed;

        // You do not need to cast for int -> float because unity does it
        // Casting is converting from one type to another
        // Casting can be done by putting the type in brackets

        // Random way
        
        // Initialise the random number generator with our seed
        // NOTE:
        // You do not always have to do this, but it is good practice to
        Random.InitState(seed);

        // Ensure that you are  using 'f's when wrting your numbers in the random range function
        float offsetXRandom = Random.Range(0f, 1000f);
        float offsetYRandom = Random.Range(0, 1000f);

        // Determining our X and Y coordinates

        // Remember that our Mathf.PerlinNoise(float x,float y) function needs and X and a Y
        // We need to calculate what these should be

        // To calculate our X and Y values we need to know
        // 1. The offset
        // 2. How big our world is
        // 3. World position (x,y before calculating) for example if I want value at point (3,2) that point
        // needs to be converted into something the function can read


        // Note: It is important you always write world sizes in intergers
        int worldSizeX = 50;
        int worldSizeY = 50;

        // World position
        Vector2 worldPosition = new Vector2(3f, 2f);
        // You can also use a Vector2 for world size

        // X = World Position X / World Size X + Offset X
        // Y = World Position Y / World Size Y + Offset Y

        // Vectors:
        // position = worldPostion / worldSize + offset

        float xValue = worldPosition.x / worldSizeX + offsetXRandom;
        float yValue = worldPosition.y / worldSizeY + offsetYRandom;

        // Actually finding our perlin noise

        // Probably the most simplest part!
        float perlin = Mathf.PerlinNoise(xValue, yValue);

        // The last thing is SCALE

        // Simply times the perlin noise by your desired scale
        // Smaller numbers = more zoomed in (less detail)
        // Larger numbers = more zoomed out (more detail)
        // Zoom = less or more detail

        float scale = 1f;
        perlin = perlin * scale;

        // We are done!
        // That is how we can work out our perlin values!


        // An important thing to note, is that you should ALWAYS ensure to put an 'f' next to the constants
        // when you write them because perlin noise does NOT like it when you accidentally have an integer there

        return perlin;
    }

    public void UsingPerlinNoise()
    {
        // Using perlin noise is actually quite simple
        // All you need to do is either:
        // 1. Compare the perlin noise value (using ifs)
        // 2. Multiplying it by a number

        // If statements

        // Remember that our perlin noise values will always be in between 0 and 1
        // When we are doing IF statements make sure you start from the LOWEST value and move your way to the HIGHEST
        
        // For example:
        // Biomes
        // Ores
        // Difficulty
        // etc (you want to specify something)

        float perlin = PerlinNoiseExample();

        if (perlin <= 0.25f)
        {
            // Make water 
        }
        else if (perlin <= 0.5f)
        {
            // Make sand
        }
        else if (perlin <= 0.75f)
        {
            // Make grass
        }// etc

        // Multiplying 

        // For example:
        // Determining heights
        // Deciding temperature
        // etc (for if you actually want a value)

        // For multiplying you need to know the largest value that you want

        // If you use ints for height it will be blocky, if you use floats for height it will be smoother
        int largestHeight = 5;

        // Remember! We are looking for a height value in INTEGERS! So we can round to an interger
        int height = Mathf.RoundToInt(perlin * largestHeight);
        
        // Rounding types
        // Normal (Round) = If x < 0.5 then go to the number below, if x >= 0.5 then go to the number above
        // Flooring (Floor) = It's always going to go the number below
        // Ceiling (Ceil) = It's always going to go to the number above

        // Mathf.Round
        // Mathf.Floor
        // Mathf.Ceil
        
        // There are 'ToInt' variations that you can use to convert a float to an interger while it rounds as well

        // All the values will be between 0 and 5 because the largest height value is 5 and the perlin noise between 0 and 1

       
    }

}

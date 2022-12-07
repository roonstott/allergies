using System;
using System.Collections.Generic;

namespace Allergies.Models
{
  public class Allergens
  {

    private int _score;
    // properties, constructors, methods, etc. go here
    public Allergens(int score)
    {
      _score = score;
    }

    public int getScore()
    {
      return _score;
    }

    public string getAllergies()
    {
      Dictionary<int, string> allergies = new Dictionary<int, string>() {
        { 1, "eggs" },
        { 2, "peanuts"},
        { 4, "shellfish" },
        { 8, "strawberries"},
        { 16, "tomatoes" },
        { 32, "chocolate" },
        { 64, "pollen" },
        { 128, "cats" }
      };

      int scoreCounter = _score;
      while (scoreCounter > 0)
      {
        scoreCounter = Highest(scoreCounter);
      }
      return String.Join(" ", allergens);
    }

    List<int> allScores = new List<int> {1,2,4,8,16,32,64,128};
    List<int> highFirst = new List<int> {128, 64, 32, 16, 8, 4, 2, 1};
    List<string> allAllergens = new List<string> { "eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats" };

    List<string> allergens = new List<string> { };

    public int Highest(int scoreCtr)
    {

      int scoreCounter = scoreCtr;
      for (int index = 0; index < allScores.Count; index++)
      {
        if (allScores[index] == scoreCounter)
        {
          allergens.Add(allergies[index]);
          scoreCounter = scoreCounter - allScores[index];
          allScores.Remove(allScores[index]);
          break;
        }
        else if (allScores[index] > scoreCounter)
        {
          allergens.Add(allAllergens[index - 1]);
          scoreCounter = scoreCounter - allScores[index - 1];
          allAllergens.Remove(allAllergens[index - 1]);
          allScores.Remove(allScores[index - 1]);
          break;
        }
        else if (scoreCounter >= 128)
        {
          allergens.Add(allAllergens[index]);
          scoreCounter = scoreCounter - allScores[index];
          allAllergens.Remove(allAllergens[index]);
          allScores.Remove(allScores[index]);
          break;
        }
      }
      return scoreCounter;
    }
  }
}
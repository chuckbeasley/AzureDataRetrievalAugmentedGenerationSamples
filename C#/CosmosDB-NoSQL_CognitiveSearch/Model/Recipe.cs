﻿namespace CosmosRecipeGuide
{
    public class Recipe
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<float> embedding { get; set; }
        public string cuisine { get; set; }
        public string difficulty { get; set; }
        public string prepTime { get; set; }
        public string cookTime { get; set; }
        public string totalTime { get; set; }
        public int servings { get; set; }
        public List<string> ingredients { get; set; }
        public List<string> instructions { get; set; }
    }     
}
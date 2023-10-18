namespace CosmosRecipeGuide
{

    public class CogSearchDoc
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<float> embedding { get; set; }        
    }     
}
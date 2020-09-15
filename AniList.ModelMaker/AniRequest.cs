namespace AniList.ModelMaker
{
    public class AniRequest
    {
        public string Query { get; set; }
        public string OperationName { get; set; }
        public object Variables { get; set; }

        public AniRequest(string query, string operationName, object variables)
        {
            Query = query;
            OperationName = operationName;
            Variables = variables;
        }
    }
}

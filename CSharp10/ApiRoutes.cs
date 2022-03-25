namespace CSharp10Net6;

public static class ApiRoutes
{
    private const string ApiBase = "/api";

    public static class Library
    {
        //public const string Base = ApiBase + "/library";

        //constant interpolated strings
        public const string Base = $"{ApiBase}/library";

        public const string GetById = $"{Base}/{{id:guid}}";
    }
}

